namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("input.txt"))
            {
                Console.WriteLine("Файл не найден");
                return;
            }

            string text = File.ReadAllText("input.txt");
            Console.WriteLine(text);
        }
    }
}
