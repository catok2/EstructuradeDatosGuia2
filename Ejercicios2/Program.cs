namespace Ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero");
            int numero = int.Parse(Console.ReadLine());
            int cifras = 0;
            while (numero > 0)
            {
                numero = numero / 10;              
              cifras++;           
            }
            Console.WriteLine("tiene : "+ cifras +" cifras");
        }
    }
}