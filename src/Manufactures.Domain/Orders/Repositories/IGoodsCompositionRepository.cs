﻿using Infrastructure.Domain.Repositories;
using Manufactures.Domain.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Manufactures.Domain.Orders.Repositories
{
    public interface IGoodsCompositionRepository : IEntityRepository<GoodsComposition>
    {
        List<GoodsComposition> Find(Expression<Func<GoodsComposition, bool>> condition);

        IQueryable<GoodsComposition> Query { get; }
    }
}