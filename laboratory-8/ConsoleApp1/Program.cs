namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char ch = Console.ReadLine()[0];

            if (char.IsDigit(ch))
                Console.WriteLine("Цифра");
            else if (char.IsLetter(ch))
                Console.WriteLine("Буква");
            else
                Console.WriteLine("Спецсимвол");
        }
    }
}
