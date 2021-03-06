﻿using ExtCore.Data.Abstractions;
using Infrastructure.Domain.Commands;
using Manufactures.Domain.Orders.Repositories;
using Moonlay;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Manufactures.Domain.Orders.Commands
{
    public class RemoveOrderCommandHandler : ICommandHandler<RemoveOrderCommand, ManufactureOrder>
    {
        private readonly IManufactureOrderRepository _manufactureOrderRepo;

        public RemoveOrderCommandHandler(IStorage storage)
        {
            Storage = storage;
            _manufactureOrderRepo = Storage.GetRepository<IManufactureOrderRepository>();
        }

        private IStorage Storage { get; }

        public async Task<ManufactureOrder> Handle(RemoveOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _manufactureOrderRepo.Find(o => o.Identity == request.Id).FirstOrDefault();

            if (order == null)
                throw Validator.ErrorValidation(("Id", "Invalid Order: " + request.Id));

            order.Remove();

            await _manufactureOrderRepo.Update(order);

            Storage.Save();

            return order;
        }
    }
}
