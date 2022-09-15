namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Nombre del Usuario");
            String lnombreUser = Console.ReadLine();

            if (lnombreUser.ToUpper().Equals("MARTIN"))
            {
                Console.WriteLine("Hola ");

            }
            else
            {
                Console.WriteLine("No te conozco");
            }           
        }
    }
}