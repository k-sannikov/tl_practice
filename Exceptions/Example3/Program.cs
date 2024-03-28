/*
 * 3.1 try-catch
 */
namespace Example3;

class Program
{
    static void Main()
    {
        int age = -5;
        try
        {
            if (age < 0)
            {
                throw new Exception("Возраст не может быть отрицательным!");
            }

            Console.WriteLine("Возраст: " + age);
        }
        catch
        {
            Console.WriteLine("Возраст не может быть отрицательным!");
        }
    }
}