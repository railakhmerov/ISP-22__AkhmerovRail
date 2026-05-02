namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = true, B = false, C = true;

            Console.WriteLine(!(A || (!B && C)));
            Console.WriteLine(A && !(B && A || !C));
            Console.WriteLine(!(!A || B && C));
            Console.WriteLine(!(A || !B && C) || C);
            Console.WriteLine(!(A && !B || C) && B);
            Console.WriteLine(!(!A || B && C) || A);
        }
    }
}
