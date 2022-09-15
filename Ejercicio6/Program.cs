namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b= ++a;
            int c = a++;
            b = b * 5;
            a = a * 2;
            Console.WriteLine(a);

        }
    }
}