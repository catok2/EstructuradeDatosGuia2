namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el usuario de su identificados");
            string lidentificador = Console.ReadLine();
            bool lretorno = false;
                while(!lretorno)
                {
                    Console.WriteLine("Ingrese el Password");
                    string lpassword = Console.ReadLine();
                    string lpassValidar = lpassword;
                    Console.WriteLine("Confirme el Password");
                            lpassword = Console.ReadLine();
                        if (f_validacion(lpassValidar, lpassword)){
                             lretorno = true;
                        }
                         else
                        {
                             Console.WriteLine("Error de Password Vuelva a tipear");
                         }            
                }
                 Console.WriteLine("USUARIO INGRESADO");
         }
            public static Boolean f_validacion(string valpass, string pass)
            {
                bool lreturn = false;
                if (valpass.Equals(pass))
                {
                    lreturn = true;
                }
                return lreturn;
            }
    }     

}
     
