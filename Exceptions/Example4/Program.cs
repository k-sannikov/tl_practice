/*
 * 4.1 try-finally
 */
namespace Example4;

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
        finally
        {
            if (fileStream != null)
            {
                fileStream.Close();
                Console.WriteLine("Файл закрыт");
            }
            else
            {
                Console.WriteLine("Файл не открыт, закрывать не надо");
            }
        }
    }
}