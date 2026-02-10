namespace Advanced.Tasks;

using System.Collections.Generic;
using System.Threading.Tasks;

public class GenericsTasks
{
    /// <summary>
    /// Задание 1.1: Напишите generic метод, который возвращает первый элемент коллекции.
    /// Если коллекция пустая, возвращает default значение типа.
    /// В каждом задании используйте async/await.
    /// </summary>
    public static async Task <T> GetFirstElement<T>(IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection);
        await Task.Yield();
        return collection.FirstOrDefault();
    }

    /// <summary>
    /// Задание 1.2: Напишите generic метод, который фильтрует коллекцию по предикату.
    /// </summary>
    public async Task <IEnumerable<T>> Filter<T>(IEnumerable<T> collection, Func<T, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(predicate);
        await Task.Yield();
        return collection.Where(predicate);
    }

    /// <summary>
    /// Задание 1.3: Напишите generic метод для обмена значений двух переменных.
    /// </summary>
    public void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    /// <summary>
    /// Задание 1.4: Создайте generic интерфейс IComparable с методом CompareTo.
    /// </summary>
    
    public interface IComparable<T>
    {
        T CompareTo (T value);
    }

}