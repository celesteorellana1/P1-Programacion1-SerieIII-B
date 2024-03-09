using System;

namespace PrimerParcialProgra1
{
    class Miprimerprograma
    {
        public static void Main(string[] args)
        {
            string correo;
            string correoNuevo;

            Console.WriteLine("Bienvenido a mi generador de correos");

            Console.Write("Ingresa tu correo electronico  gmail: ");
            correo = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(correo) && correo.EndsWith("@gmail.com"))
            {
                correoNuevo = correo.Replace("@gmail.com", "@miumg.edu.gt");
                Console.WriteLine($"Tu nuevo correo es: {correoNuevo}");
            }
            else
            {
                Console.WriteLine("El correo ingresado no es correcto");
            }

        }
    }
}




