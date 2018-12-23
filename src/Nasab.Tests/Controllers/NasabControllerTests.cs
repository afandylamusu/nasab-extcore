using Moq;
using Nasab.Controllers;
using Nasab.ViewModels.Nasab;
using System;
using Xunit;

namespace Nasab.Tests.Controllers
{
    public class NasabControllerTests : IDisposable
    {
        private readonly MockRepository mockRepository;

        private readonly Mock<IServiceProvider> mockServiceProvider;

        public NasabControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockServiceProvider = this.mockRepository.Create<IServiceProvider>();
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private NasabController CreateNasabController()
        {
            return new NasabController(
                this.mockServiceProvider.Object);
        }

        [Fact]
        public void Index_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateNasabController();

            // Act
            var result = unitUnderTest.Index();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Create_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateNasabController();

            // Act
            var result = unitUnderTest.Create();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Create_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateNasabController();
            CreateViewModel model = new CreateViewModel { };

            // Act
            var result = unitUnderTest.Create(
                model);

            // Assert
            Assert.True(false);
        }
    }
}
