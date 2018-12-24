using Contacts.Domain.Commands;
using ExtCore.Data.Abstractions;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Contacts.Tests.CommandHandlers
{
    public class AddPeopleCommandHandlerTests : IDisposable
    {
        private readonly MockRepository mockRepository;
        private readonly Mock<IStorage> mockStorage;

        public AddPeopleCommandHandlerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockStorage = this.mockRepository.Create<IStorage>();

        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private AddPeopleCommandHandler CreateAddPeopleCommandHandler()
        {
            return new AddPeopleCommandHandler(mockStorage.Object);
        }

        [Fact]
        public async Task Handle_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateAddPeopleCommandHandler();
            AddPeopleCommand request = new AddPeopleCommand
            {
                Names = new string[] { "Afandy", "Lamusu" },
                ContactId = Guid.NewGuid()
            };
            CancellationToken cancellationToken = CancellationToken.None;

            // Act
            var result = await unitUnderTest.Handle(
                request,
                cancellationToken);

            // Assert
            Assert.True(false);
        }
    }
}