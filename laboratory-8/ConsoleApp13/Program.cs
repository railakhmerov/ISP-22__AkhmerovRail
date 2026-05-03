namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("file1.txt") || !File.Exists("file2.txt"))
            {
                Console.WriteLine("Файлы не найдены");
                return;
            }

            string text1 = File.ReadAllText("file1.txt");
            string text2 = File.ReadAllText("file2.txt");

            File.WriteAllText("result.txt", text1 + text2);
            Console.WriteLine("Выполнено");
        }
    }
}
