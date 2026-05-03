namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            bool allPositiveNumbers = true;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] <= 0)
                    allPositiveNumbers = false;
            }

            Console.WriteLine(allPositiveNumbers);
        }
    }
}
