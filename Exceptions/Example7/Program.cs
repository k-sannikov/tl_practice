/*
 * 7.1 Для чего InnerException
 */
namespace Example7;

class Program
{
    static void Main()
    {
        try
        {
            try
            {
                string str = "123abc";
                int num = int.Parse(str);
            }
            catch (FormatException e)
            {
                throw new InvalidOperationException("Ошибка при преобразовании строки в число", e);
            }
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Ошибка: " + e.Message);

            if (e.InnerException != null)
            {
                Console.WriteLine("Причина: " + e.InnerException.Message);
            }
        }
    }
}