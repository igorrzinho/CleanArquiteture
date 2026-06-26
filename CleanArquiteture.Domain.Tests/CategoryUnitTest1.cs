using FluentAssertions;
using CleanArquiteture.Domain.Entities;
namespace CleanArquiteture.Domain.Tests;

public class CategoryUnitTest1
{
    [Fact]
    public void CreateCategory_WhenValidCategoryProvided_ReturnsCreatedCategory()
    {
        Action action = () => new Category(1, "Category Name");
        action.Should()
            .NotThrow<Validation.DomainExceptionValidation>();
    }
}
