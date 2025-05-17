using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = GetValidInteger("Введите количество объектов недвижимости (1-30): ", 1, 30);

            var properties = new RealEstate[count];
            int highValueCount = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите данные для объекта {i + 1}:");

                int area = GetValidInteger("Площадь (м²): ", 1, int.MaxValue);
                int rooms = GetValidInteger("Количество комнат: ", 1, int.MaxValue);
                int floor = GetValidInteger("Этаж: ", 1, int.MaxValue);
                string propertyType = GetValidString("Тип недвижимости (квартира, дом, студия): ", new[] { "квартира", "дом", "студия" });
                string condition = GetValidString("Состояние объекта (новое, хорошее, требует ремонта): ", new[] { "новое", "хорошее", "требует ремонта" });
                string location = GetValidString("Расположение (центр, пригород, отдаленный район): ", new[] { "центр", "пригород", "отдаленный район" });

                properties[i] = new RealEstate(area, rooms, floor, propertyType, condition, location);
                decimal price = properties[i].CalculatePrice();

                Console.WriteLine($"Стоимость объекта {i + 1}: {Math.Round(price, 3)}");

                if (price > 10000000)
                    highValueCount++;
            }

            Console.WriteLine($"Количество объектов с высокой стоимостью (выше 10,000,000): {highValueCount}");
        }

        private static int GetValidInteger(string prompt, int minValue, int maxValue)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine(); // Используем nullable тип

                if (input != null && int.TryParse(input, out result) && result >= minValue && result <= maxValue)
                {
                    return result; // Возвращаем только если это не null
                }

                Console.WriteLine($"Ошибка: введите целое число от {minValue} до {maxValue}.");
            }
        }

        private static string GetValidString(string prompt, string[] validOptions)
        {
            string? input; // Используем nullable тип на этапе получения
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (input != null && Array.IndexOf(validOptions, input) >= 0) // Проверяем на null
                {
                    return input; // Возвращаем только если это не null
                }
                Console.WriteLine("Ошибка: введено некорректное значение.");
            }
        }
    }
}




//namespace Lab1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Введите количество объектов недвижимости (1-30): ");
//            int count = int.Parse(Console.ReadLine());

//            if (count < 1 || count > 30)
//            {
//                Console.WriteLine("Некорректное количество объектов.");
//                return;
//            }

//            var properties = new RealEstate[count];
//            int highValueCount = 0;

//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine($"Введите данные для объекта {i + 1}:");

//                Console.Write("Площадь (м²): ");
//                int area = int.Parse(Console.ReadLine());

//                Console.Write("Количество комнат: ");
//                int rooms = int.Parse(Console.ReadLine());

//                Console.Write("Этаж: ");
//                int floor = int.Parse(Console.ReadLine());

//                Console.Write("Тип недвижимости (квартира, дом, студия): ");
//                string propertyType = Console.ReadLine();

//                Console.Write("Состояние объекта (новое, хорошее, требует ремонта): ");
//                string condition = Console.ReadLine();

//                Console.Write("Расположение (центр, пригород, отдаленный район): ");
//                string location = Console.ReadLine();

//                properties[i] = new RealEstate(area, rooms, floor, propertyType, condition, location);
//                decimal price = properties[i].CalculatePrice();

//                Console.WriteLine($"Стоимость объекта {i + 1}: {Math.Round(price, 3)}");

//                if (price > 10000000)
//                    highValueCount++;
//            }

//            Console.WriteLine($"Количество объектов с высокой стоимостью (выше 10,000,000): {highValueCount}");
//        }
//    }
//}
