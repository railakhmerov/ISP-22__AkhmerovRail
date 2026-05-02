namespace ConsoleApp3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество предметов: ");
            int count = int.Parse(Console.ReadLine());

            double weight = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Масса: ");
                weight += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Средняя масса = " + weight / count);
        }
    }
}
