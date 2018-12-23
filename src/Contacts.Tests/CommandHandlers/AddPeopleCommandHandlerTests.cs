using Contacts.Domain.Commands;
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

        public AddPeopleCommandHandlerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private AddPeopleCommandHandler CreateAddPeopleCommandHandler()
        {
            return new AddPeopleCommandHandler();
        }

        [Fact]
        public async Task Handle_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateAddPeopleCommandHandler();
            AddPeopleCommand request = new AddPeopleCommand
            {
                Names = new string[] { "Afandy", "Lamusu" },
                ContactID = Guid.NewGuid()
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