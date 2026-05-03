namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string x = Console.ReadLine();

            string[] words = x.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
        }
    }
}
