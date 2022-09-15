using System.Reflection.Metadata.Ecma335;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el usuario de su identificados");
            string lidentificador = Console.ReadLine();
            Console.WriteLine("Ingrese el Password");
            string lpassword = Console.ReadLine();

        string login = f_validacion(lidentificador, lpassword) ? "Logeo exitoso" : "Logeo erroneo";
        Console.WriteLine(login);
        }
        public static Boolean f_validacion(string user, string pass)
        {
            bool lreturn = false;
            if (user == "1234"  & pass == "1111") 
                {             
                lreturn = true;
                }
            return lreturn;
        }
    }
}