/*
 * 8.1 Пользовательские исключения
 * 8.2 throw;
 */
namespace Example8;

class Program
{
    static void Main()
    {
        int age = -5;
        try
        {
            if (age < 0)
            {
                throw new AgeException("Возраст не может быть отрицательным!", age);
            }

            Console.WriteLine("Возраст: " + age);
        }
        catch (AgeException e)
        {
            Console.WriteLine($"Возраст {e.Age}. {e.Message}");
            //throw;
        }
    }
}