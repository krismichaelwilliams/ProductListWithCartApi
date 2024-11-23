using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductListWithCart.Api.Controllers.Desserts;
using ProductListWithCart.Application.Interfaces;
using ProductListWithCart.Application.Models;
using ProductListWithCart.Application.Queries.Desserts;
using ProductListWithCart.DataAccess.Repositories;

namespace ProductListWithCart.Tests.Behavioral.DessertsControllerTests
{
    public class GetDessertsShould
    {
        private const string Desserts = "Desserts";
        private readonly IFixture _fixture;
        private readonly Mock<IMenuContext> _mockContext;
        private readonly DessertsRepository _dessertsRepository;
        private readonly GetDesserts _getDesserts;
        private readonly DessertsController _sut;

        public GetDessertsShould()
        {
            _fixture = new Fixture();
            _mockContext = new Mock<IMenuContext>();
            _dessertsRepository = new DessertsRepository(_mockContext.Object);
            _getDesserts = new GetDesserts(_dessertsRepository);
            _sut = new DessertsController(_getDesserts);
        }

        [Fact]
        public async Task Return200_WithListOfDessertData()
        {
            // Arrange
            var getDessertsResponse = _fixture.Create<List<DessertItem>>();
            var expectedResult = new DessertItemSuccessResponse()
            {
                Status = "success",
                Data = getDessertsResponse
            };

            _mockContext.Setup(x => x.GetDesserts<DessertItem>(Desserts)).ReturnsAsync(getDessertsResponse);

            // Act
            var result = await _sut.GetDesserts() as OkObjectResult;

            // Assert
            result.Value.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public async Task Return500_WhenUnableToRetrieveDessertData()
        {
            // Arrange
            _mockContext.Setup(x => x.GetDesserts<DessertItem>(Desserts)).ThrowsAsync(new Exception());

            // Act
            var result = await _sut.GetDesserts() as StatusCodeResult;

            // Assert
            result.StatusCode.Should().Be(500);
        }
    }
}
