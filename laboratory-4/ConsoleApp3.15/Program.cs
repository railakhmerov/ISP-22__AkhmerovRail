namespace ConsoleApp3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ввод значения n с проверкой условия 1 < n <= 10
            int n;
            do
            {
                Console.Write("Введите целое число n (1 < n <= 10): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 1 || n > 10);

            double sum = 1.0;
            double factorial = 1.0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += 1.0 / factorial;
            }

            Console.WriteLine($"Сумма = {sum}");
            Console.ReadKey();
        }
    }
}
