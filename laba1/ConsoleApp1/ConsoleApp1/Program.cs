namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1";
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Задание 2");
            Console.Write("Нажми любую клавишу...");
            Console.ReadKey();

            //Console.Write("Введи свое имя: ");
            //string name = Console.ReadLine();
            //Console.Write(name);
            Console.WriteLine("Привет {1} {0}!", "Петров", "Иван");


            Console.Title = "Работа 1 Проект 2."; // оглавление программы
            Console.WindowWidth = 60; // ширина окна
            Console.WindowHeight = 13; // высота окна
            Console.BackgroundColor = ConsoleColor.Blue; // задний фон
            Console.Clear(); // очищение консоли
            Console.SetCursorPosition(15, 6); // позиция курсора

        }
    }
}
