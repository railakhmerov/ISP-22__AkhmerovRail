namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string x = Console.ReadLine();

            string res = "";
            for (int i = x.Length - 1; i >= 0; i--)
                res += x[i];

            Console.WriteLine(res);
        }
    }
}
