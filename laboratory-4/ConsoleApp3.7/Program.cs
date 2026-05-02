using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int average_score = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Оценка " + i + ": ");
                average_score += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Средняя = " + average_score / 10.0);
        }
    }
}
