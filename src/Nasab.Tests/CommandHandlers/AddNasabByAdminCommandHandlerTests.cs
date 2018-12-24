using Contacts.Domain;
using Contacts.Domain.Commands;
using ExtCore.Data.Abstractions;
using FluentAssertions;
using MediatR;
using Moq;
using Nasab.Domain;
using Nasab.Domain.Commands;
using Nasab.Domain.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Nasab.Tests.CommandHandlers
{
    public class AddNasabByAdminCommandHandlerTests : IDisposable
    {
        private readonly MockRepository mockRepository;
        private readonly Mock<IMediator> mockMediator;
        private readonly Mock<IStorage> mockStorage;
        private readonly Mock<IPeopleNasabRepository> mockNasabRepository;

        public AddNasabByAdminCommandHandlerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockMediator = this.mockRepository.Create<IMediator>();

            this.mockStorage = this.mockRepository.Create<IStorage>();

            this.mockNasabRepository = this.mockRepository.Create<IPeopleNasabRepository>();

            this.mockStorage.Setup(x => x.GetRepository<IPeopleNasabRepository>()).Returns(mockNasabRepository.Object);

            this.mockStorage.Setup(x => x.Save());
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private AddNasabByAdminCommandHandler CreateAddNasabByAdminCommandHandler()
        {
            return new AddNasabByAdminCommandHandler(this.mockMediator.Object, this.mockStorage.Object);
        }

        [Fact(DisplayName = "Add Nasab ByAdmin Command Handler")]
        public async Task Handle_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateAddNasabByAdminCommandHandler();

            AddNasabByAdminCommand request = new AddNasabByAdminCommand() {
                PersonNames = new string[] { "Afandy", "Lamusu" },
                FatherId = Guid.NewGuid().ToString()
            };

            CancellationToken cancellationToken = CancellationToken.None;


            var contact = new Contact(Guid.Parse(request.PersonId), request.PersonNames);

            this.mockMediator.Setup(x => x.Send(It.IsAny<IRequest<Contact>>(), cancellationToken)).Returns(Task.FromResult(contact));

            this.mockNasabRepository.Setup(x => x.Update(It.IsAny<PeopleNasab>())).Returns(Task.CompletedTask);

            // Act
            var result = await unitUnderTest.Handle(
                request,
                cancellationToken);

            // Assert
            result.Should().NotBeNull();
        }
    }
}