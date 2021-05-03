using System;

namespace EjercicioImpar
{
    class Animales
    {
        
        private string nombre;
        private int edad;
       

        public string Nomb
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value <= 0)
                {
                   
                    Console.WriteLine("No puede asignar valores negativos");
                }
                else { edad = value; }
            }
        }

     
    }
    class Perros : Animales
    {

        private string perrarinafav;
        private string raza;

        public string Perrarinafav
        {
            get { return perrarinafav; }
            set { perrarinafav = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }


        class Program

        {
            static void Main(string[] args)
            {
                Perros p = new Perros();

                Console.WriteLine("----Historias Clínicas del Hospital Veterianario:---- ");
                Console.WriteLine("Ingrese nombre del ejemplar:");
                p.Nomb = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del ejemplar: ");
                p.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese raza del perro: ");
                p.Raza = Console.ReadLine();
                Console.WriteLine("Ingrese Marca de su Perrarina Preferida: ");
                p.Perrarinafav = Console.ReadLine();

                //Datos de salida

                Console.WriteLine("\n ----Datos:---- \n");
                Console.WriteLine("Nombre: {0}", p.Nomb);
                Console.WriteLine("Edad: {0}", p.Edad);
                Console.WriteLine("Raza: {0}", p.Raza);
                Console.WriteLine("Perrarina Favorita: {0}", p.Perrarinafav);
            }
        }
    }
}
