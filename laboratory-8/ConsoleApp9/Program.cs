namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string x = Console.ReadLine();
            Console.Write("Что заменить: ");
            string old = Console.ReadLine();
            Console.Write("На что заменить: ");
            string n = Console.ReadLine();

            Console.WriteLine(x.Replace(old, n));
        }
    }
}
