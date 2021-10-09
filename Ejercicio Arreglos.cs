using System;

namespace EjercicioArreglo
{
    public class main
    {
        public static void Main()
        {
            int i;
            float SumarValores = 0;
            float Media = 0;
            
            float[] Valores = new float[] {7,15,20,21,25,29,100};

            for(i = 0; i < Valores.Length; i++) {
                SumarValores += Valores[i];
            }

            Media = SumarValores / Valores.Length;
            
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\t La media de dichos valores es: " + Media);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}