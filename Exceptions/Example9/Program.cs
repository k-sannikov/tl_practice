/*
 * 9 Альтернативные способы обработки с исключительными ситуациями
 */

namespace Example9;

class Program
{
    private static string[] _names = { "Иван", "Сергей", "Владимир" };

    static void Main()
    {
        string? result = Find(_names, "Пётр");

        if (result == null)
        {
            // обработка исключительной ситуации
        }

        DiscountResult discount = CalculationDiscount(10000, 6, 5);

        if (!discount.IsSuccess)
        {
            // обработка исключительной ситуации
        }
    }

    static string? Find(string[] array, string str)
    {
        foreach (string element in array)
        {
            if (element.ToLower() == str.ToLower())
            {
                return element;
            }
        }
        return null;
    }

    static DiscountResult CalculationDiscount(double amount, int basicDiscount, int loyaltyLevel)
    {
        if (basicDiscount < 1 || basicDiscount > 5)
        {
            return new DiscountResult(false, "Базовая скидка не может быть меньше 1% или больше 5%");
        }

        if (loyaltyLevel < 1 || loyaltyLevel > 100)
        {
            return new DiscountResult(false, "Уровень лояльности не может быть меньше 1 и больше 100");
        }

        double discount = amount * (basicDiscount * loyaltyLevel / 100.0);

        if (discount > amount)
        {
            return new DiscountResult(amount);
        }

        return new DiscountResult(discount);
    }
}
