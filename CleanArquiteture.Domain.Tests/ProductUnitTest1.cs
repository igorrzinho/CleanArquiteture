using CleanArquiteture.Domain.Entities;
using FluentAssertions;

namespace CleanArquiteture.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact]
        public void CreateProduct_WhenValidProductProvided_ReturnsCreatedProduct()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 1, "Product Image");
            action.Should()
                .NotThrow<Validation.DomainExceptionValidation>();
        }
    }
}