namespace Advanced.Tasks.LanguagePatterns;

/// <summary>
/// Создавайте классы и рекорды в отдельном файле в папке LanguagePatterns
/// </summary>
public class LanguagePatternsTasks
{
    /// <summary>
    /// Задание 4.1: Создайте record Person с свойствами Name и Age.
    /// </summary>
    

    /// <summary>
    /// Задание 4.2: Создайте класс Product с init-only свойствами.
    /// </summary>
    

    /// <summary>
    /// Задание 4.3: Используйте pattern matching для определения типа объекта.
    /// </summary>
    public string GetObjectType(object obj)
    {
        return obj switch
        {
            int => "Integer",
            double => "Double",
            float => "Float",
            string => "String",
            Person person => $"Имя: {person.Name}, возраст: {person.Age}",
            Product product => $"Наименование: {product.Name}, цена: {product.Price}",
            _ => "Неизвестный тип"
        };
    }

    /// <summary>
    /// Задание 4.4: Используйте switch expression для вычисления стоимости доставки.
    /// </summary>
    public decimal CalculateShippingCost(string shippingType, decimal weight)
    {
        int k = 2;
        return (shippingType, weight) switch
        {
            ("Стандартная доставка", <= 5) => 10,
            ("Стандартная доставка", <= 10) => 20,
            ("Стандартная доставка", <= 50) => 100,
            ("Стандартная доставка", _ ) => 200,
            ("Срочная доставка", <= 5) => 10 * k,
            ("Срочная доставка", <= 10) => 20 * k,
            ("Срочная доставка", <= 50) => 100 * k,
            ("Срочная доставка", _ ) => 200 * k,
            ( _ , _ ) => 0
        };
    }

    /// <summary>
    /// Задание 4.5: Создайте record и напишите код (в отдельном классе DemonstrateDeconstruction) использования деконструкции.
    /// </summary>


    /// <summary>
    /// Задание 4.6: Используйте property patterns класса Product для проверки условий.
    /// </summary>
    public string GetProductStatus(Product? product)
    {
        return product switch
        {
            null => "Неизвестный товар",
            { Price: <= 0 } => "Некорректная стоимость",
            { Price: <= 100} => "Бюджетный товар",
            { Price:  >100 } => "Дорогой товар"
            
        };
    }
  
}