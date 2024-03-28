/*
 * 1.1 Как бросить исключение?
 * 1.2 Что происходит при выбрасывании исключения?
 * 1.3 Какую информацию несет в себе исключение? (Message, StackTrace, InnerException)
 * 1.4 Как еще может быть выброшено исключение?
 */
namespace Example1;

class Program
{
    static void Main()
    {
        //throw new Exception("Мое первое исключение!!!");
        Method1();
    }

    static void Method1()
    {
        Method2();
    }

    static void Method2()
    {
        Method3();
    }

    static void Method3()
    {
        //Console.WriteLine(int.Parse("qwerty"));
        ArgumentNullException.ThrowIfNull(null);
    }
}