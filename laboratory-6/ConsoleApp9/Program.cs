namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            bool allEvenNumbers = true;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 != 0)
                    allEvenNumbers = false;
            }

            Console.WriteLine(allEvenNumbers);
        }
    }
}
