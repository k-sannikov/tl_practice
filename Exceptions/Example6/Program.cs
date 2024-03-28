/*
 * 6.2 Разные типы исключений (NullReferenceException, IndexOutOfRangeException, ArgumentNullException)
 * 6.3 Ловля исключения конкретного типа
 */
namespace Example6;

class Program
{
    static void Main()
    {
        try
        {
            throw new NullReferenceException("Тестовое исключение NullReference");
            throw new IndexOutOfRangeException("Тестовое исключение IndexOutOfRange");
            throw new ArgumentNullException("Тестовое исключение ArgumentNull");
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine($"{e.Message} обработано");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"{e.Message} обработано");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"{e.Message} обработано");
        }
        catch
        {
            Console.WriteLine("Неизвестное исключение");
        }
    }
}
