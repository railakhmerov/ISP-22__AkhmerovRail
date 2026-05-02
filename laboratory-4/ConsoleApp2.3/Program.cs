namespace ConsoleApp2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.Write("Введите число от 1 до 100: ");
                number = int.Parse(Console.ReadLine());

            } while (number < 1 || number > 100);

            Console.WriteLine("Вы ввели: " + number);
            Console.WriteLine();
        }
    }
}
