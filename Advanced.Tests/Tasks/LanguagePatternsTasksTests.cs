using Advanced.Tasks.LanguagePatterns;

namespace Advanced.Tests.Tasks;

using Xunit;

public class LanguagePatternsTasksTests
{
    private readonly LanguagePatternsTasks _tasks = new();


    [Fact]
    public void GetObjectTypeInt_RetInt()
    {
        
        // Act
        var result = _tasks.GetObjectType(10);

        // Assert
        Assert.Equal("Integer", result);
    }

    [Fact]
    public void GetObjectTypeInt_RetDouble()
    {

        // Act
        var result = _tasks.GetObjectType(5.5);

        // Assert
        Assert.Equal("Double", result);
    }

    [Fact]
    public void GetObjectTypeInt_RetString()
    {

        // Act
        var result = _tasks.GetObjectType("Hello World!");

        // Assert
        Assert.Equal("String", result);
    }

    [Fact]
    public void GetObjectTypeInt_RetPerson()
    {
        // Arrange
        var person = new Person("Алекс", 30);

        // Act
        var result = _tasks.GetObjectType(person);

        // Assert
        Assert.Equal("Имя: Алекс, возраст: 30", result);
    }

    [Fact]
    public void GetObjectTypeInt_RetProduct()
    {
        // Arrange
        var product = new Product { Name = "Ноутбук", Price = 50000 };

        // Act
        var result = _tasks.GetObjectType(product);

        // Assert
        Assert.Equal("Наименование: Ноутбук, цена: 50000", result);
    }

    [Fact]
    public void GetObjectTypeInt_RetUnknown()
    {

        // Act
        var result = _tasks.GetObjectType(new object());

        // Assert
        Assert.Equal("Неизвестный тип", result);
    }

    [Fact]
    public void CalculateShippingCost_Standart()
    {

        // Act
        var result = _tasks.CalculateShippingCost("Стандартная доставка", 3);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void CalculateShippingCost_Express()
    {

        // Act
        var result = _tasks.CalculateShippingCost("Срочная доставка", 40);

        // Assert
        Assert.Equal(200, result);
    }

    [Fact]
    public void CalculateShippingCost_Err()
    {

        // Act
        var result = _tasks.CalculateShippingCost("Почтальон",150);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void GetProductStatus_CheapProduct()
    {
        // Arrange
        var product = new Product { Name = "Книга", Price = 50 };

        // Act
        var result = _tasks.GetProductStatus(product);

        // Assert
        Assert.Equal("Бюджетный товар", result);
    }

    [Fact]
    public void GetProductStatus_ErrorPrice()
    {
        // Arrange
        var product = new Product { Name = "Часы", Price = -50 };

        // Act
        var result = _tasks.GetProductStatus(product);

        // Assert
        Assert.Equal("Некорректная стоимость", result);
    }
}
