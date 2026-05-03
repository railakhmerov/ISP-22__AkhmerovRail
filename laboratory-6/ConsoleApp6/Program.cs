namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] price = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < price.Length; i++)
                price[i] = rnd.Next(20, 301);

            int min = price[0];
            int index = 0;

            for (int i = 1; i < price.Length; i++)
            {
                if (price[i] < min)
                {
                    min = price[i];
                    index = i;
                }
            }

            Console.WriteLine("Самый дешевый товар " + index + " цена: " + min);
        }
    }
}
