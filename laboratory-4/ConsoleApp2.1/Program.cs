namespace ConsoleApp2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            do
            {
                Console.Write("Введите число (0 для выхода): ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            } while (number != 0);

            Console.WriteLine("Сумма = " + sum);
            Console.WriteLine();
        }
    }
}
