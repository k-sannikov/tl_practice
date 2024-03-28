/*
 * 2.1 Как ловить исключение?
 * 2.2 try-catch,try-finally, try-catch-finally
 * 2.3 Ловля исключений определенного типа
 */
namespace Example2;

class Program
{
    static void Main()
    {
        // try-catch
        try
        {
            // выполняется всегда
            // тут ловим исключение
        }
        catch
        {
            // выполняется, если в блоке try
            // было брошено исключение
        }



        // try-finally
        try
        {
            // выполняется всегда
            // тут ловим исключение
        }
        finally
        {
            // выполняется после try
            // выполняется всегда
        }



        // try-catch-finally
        try
        {
            // выполняется всегда
            // тут ловим исключение
        }
        catch
        {
            // выполняется, если в блоке try
            // было брошено исключение
        }
        finally
        {
            // выполняется после try и catch
            // выполняется всегда
        }



        // Ловля исключений определенного типа
        try
        {
        }
        catch (NullReferenceException)
        {
        }
        catch (SystemException)
        {
        }
        catch (Exception)
        {
        }
    }
}