using System.Text;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string x = Console.ReadLine();

            StringBuilder res = new StringBuilder();
            foreach (char c in x)
                if (!char.IsDigit(c))
                    res.Append(c);

            Console.WriteLine(res.ToString());
        }
    }
}
