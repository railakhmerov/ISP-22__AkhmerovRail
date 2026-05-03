namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char ch = Console.ReadLine()[0];

            if (char.IsUpper(ch))
                Console.WriteLine(char.ToLower(ch));
            else
                Console.WriteLine(char.ToUpper(ch));
        }
    }
}
