using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine( " ingrese un numero: ");
            n =int.Parse(Console.ReadLine()); 

            if ( n > 10){
                Console.WriteLine( " es mayor a 10 ");

            }   
            else
            {
                Console.WriteLine("es menor a 10");
            }    
        }
    
    
    }
    
}

