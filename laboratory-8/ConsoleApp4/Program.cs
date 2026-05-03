namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char ch = char.ToLower(Console.ReadLine()[0]);

            string glas = "aeiouy";

            if (glas.Contains(ch))
                Console.WriteLine("Гласная");
            else
                Console.WriteLine("Не гласная");
        }
    }
}
