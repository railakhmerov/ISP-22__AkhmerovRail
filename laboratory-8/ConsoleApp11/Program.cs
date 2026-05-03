namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("text.txt"))
            {
                Console.WriteLine("Файл не найден");
                return;
            }

            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            string text = File.ReadAllText("text.txt");
            string[] words = text.Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (string i in words)
                if (i.ToLower() == word.ToLower())
                    count++;

            Console.WriteLine(count);
        }
    }
}
