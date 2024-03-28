/*
 * 5.1 try-catch-finally
 */
namespace Example5;

class Program
{
    static void Main()
    {
        FileStream? fileStream = null;

        try
        {
            fileStream = File.Open("example.txt", FileMode.Open);
            Console.WriteLine("Файл открыт для чтения");

            // Логика работы с файлом
            // Например, чтение данных из файла
        }
        catch
        {
            Console.WriteLine("Ошибка при работе с файлом");
        }
        finally
        {
            if (fileStream != null)
            {
                fileStream.Close();
                Console.WriteLine("Файл закрыт");
            }
        }
    }
}