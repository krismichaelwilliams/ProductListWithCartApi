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

        public GetDessertsShould()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public async Task ReturnListOfDessertData()
        {
            // Arrange
            var mockContext = new Mock<IMenuContext>();
            var dessertsRepository = new DessertsRepository(mockContext.Object);
            var getDesserts = new GetDesserts(dessertsRepository);
            var sut = new DessertsController(getDesserts);
            var expectedResult = _fixture.Create<List<DessertItem>>();

            mockContext.Setup(x => x.GetDesserts<DessertItem>(Desserts)).ReturnsAsync(expectedResult);

            // Act
            var result = await sut.GetDesserts() as OkObjectResult;

            // Assert
            result.Value.Should().Be(expectedResult);
        }
    }
}
