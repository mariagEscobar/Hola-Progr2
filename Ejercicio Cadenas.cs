using System;

namespace EjercicioCadena
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" \t \t ¡Bienvenido! Ingrese una frase \n \n" );
            
            string cadena = Console.ReadLine();
            string[] p = cadena.Split();
            for (int i = 0; i < p.Length; i++)  
            {
                Console.WriteLine("\n \t Palabra {0} : {1}  ",(i+1), p[i]); 
                
            }
        }
    }
}