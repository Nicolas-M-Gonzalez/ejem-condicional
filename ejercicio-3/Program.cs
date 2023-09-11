using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe;
          
          Console.WriteLine( " ingrese un importe: ");
          importe= float.Parse(Console.ReadLine());

          if( importe>=1000){

             if(importe>5000)
             importe= importe * 0.82f;
             else
             importe= importe * 0.90f;

          }

          Console.WriteLine("el importe a pagar es: " + importe);
        
        }

    }
}
