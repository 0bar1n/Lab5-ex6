using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: "); string name = Console.ReadLine(); // просим пользователя ввести данные; ввод переменной строкового типа
            Console.Write("Введите возраст: "); // просим пользователя ввести данные
            int age = Convert.ToInt32(Console.ReadLine()); Console.Write("Введите рост: "); //ввод переменной целочисленного типа,преобразование переменной к целочисленному типу; просим пользователя ввести данные
            double height = Convert.ToDouble(Console.ReadLine()); //ввод переменной вещественного типа, пробразование в вещественный тпа
            Console.Write("Введите размер зарплаты: "); //просим пользователя ввести данные
            decimal salary = Convert.ToDecimal(Console.ReadLine()); //ввод переменной десятичного типа, преобразование переменной к целочисленному типу
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} м Зарплата: { salary}$"); //вывод нескольких переменных
            Console.ReadKey(); //остановка выполнения программы до тех пор, пока пользователь не нажмет клавишу, завершение работы
        }
    }
}