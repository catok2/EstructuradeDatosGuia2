using System.ComponentModel.DataAnnotations;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Letra o Palabra");
            string lcaracter = Console.ReadLine();
            string lvocales = "aeiou";

                for (int i = 0; i < lcaracter.Length;i++)
                 {
                    for (int j = 0; j < lvocales.Length; j++) { 

                       if (lvocales.Substring(j, 1).Equals(lcaracter.Substring(i, 1)))
                        {
                        Console.WriteLine("La letra: " + (lcaracter.Substring(i, 1)).ToUpper() + " Es vocal");
                        }
                    }
                }
        }
    }
}