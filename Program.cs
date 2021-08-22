using System;

namespace Calculadora
{
    class Divisas
    {
        
        private float valor;
        private float cantidad;
       

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value }
        }

     
    }
  

    
    class Dolares : Divisas
    {
        public float preciodolar;
        public float PrecioDolar{
            get{return preciodolar;}
            set{preciodolar = value;}
        
        }
    }


   
    class PesoColombiano : Divisas 
    {
        public float preciopeso;
        public float PrecioPeso{ 
            get{return preciopeso;}
            set{preciopeso = value;}
        }
    }
   
   
    class SolPeruano : Divisas
    {
        public float preciosol;
        public float PrecioSol{
            get{ return preciosol;}
            set{preciosol = value;}
        }

    
    }
       

    class Program
    {
        static void Main(string[] args)
        {
            float PrecioDolar, PrecioPeso, PrecioSol, Cantidad;

            PrecioDolar = Cantidad * 4122843;
            PrecioPeso = Cantidad * 1066;
            PrecioSol = Cantidad * 1005229;
        }
    }


    class controlador 
    {
        private vista_Consola oDisplay;
        public controlador ()
        {
            oDisplay = new vista_Consola();
            
            if(oDisplay.Valor == 1)
            {
                Dolares oDolar;
                oDolar = new Dolares (PrecioDolar);
                oDisplay.Valor = oDolar.Valor;
                oDisplay.MuestraTotales();
            }
            
            
            if(oDisplay.Valor == 2)
            {
                PesoColombiano oPesocolombiano;
                oPesocolombiano = new PesoColombiano (PrecioPeso);
                oDisplay.Valor = oPesocolombiano.Valor;
                oDisplay.MuestraTotales();
            }
            
            if (oDisplay.Valor == 3)
            {
                SolPeruano oSolperuano;
                oSolperuano = new SolPeruano (PrecioSol);
                oDisplay.Valor = oSolperuano.Valor;
                oDisplay.MuestraTotales();
            }
            
        }
    }
    
    class vista_Consola
    {
        public float valor;
        public float cantidad;
        public float preciodolar;
        public float preciopeso;
        public float preciosol;

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        
        public float PrecioDolar{
            get{return preciodolar;}
            set{preciodolar = value;}
        
        }
        
        public float PrecioPeso{ 
            get{return preciopeso;}
            set{preciopeso = value;}
        }
        
        public float PrecioSol{
            get{ return preciosol;}
            set{preciosol = value;}
        }
        

    
        public vista_Consola()
    {
        this.ObtieneValores();
    }
    
    
        private void ObtieneValores()
        {
        Console.WriteLine("¡Calculadora de divisas con respecto al Bolivar!\n");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("--------------Ingrese la moneda a convertir---------------");
        Console.WriteLine("----------------------------------------------------------\n");
        Console.WriteLine("\t1 - Dolares");
        Console.WriteLine("\t2 - Peso Colombiano");
        Console.WriteLine("\t3 - Sol Peruano");
        
        
        
        
        switch (Console.ReadLine())
        {
            case "1":
            this.Valor = 1;
            Console.WriteLine("Ingrese la cantidad a convertir:");
            l = float.Parse(Console.ReadLine());
            Cantidad = float.Parse(Console.ReadLine());
            Console.WriteLine(PrecioDolar);
            break;
            
            case "2":
            this.Valor = 2;
            Console.WriteLine("Ingrese la cantidad a convertir:");
            l = float.Parse(Console.ReadLine());
            Cantidad = float.Parse(Console.ReadLine());
            Console.WriteLine(PrecioPeso);
            break;
            
            case"3":
            this.Valor = 3;
            Console.WriteLine("Ingrese la cantidad a convertir:");
            l = float.Parse(Console.ReadLine());
            Cantidad = float.Parse(Console.ReadLine());
            Console.WriteLine(PrecioSol);
            break;

        }
        
        Console.WriteLine("Presione cualquier tecla para cerrar este menú");
        Console.ReadKey();
    }
    
    public void MuestraTotales()
    {
        Console.WriteLine("Presione cualquier tecla para cerrar este menu");
        Console.ReadKey();
    }

    }

}
      