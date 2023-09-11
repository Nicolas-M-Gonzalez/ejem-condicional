using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
          int edad ;
          Console.WriteLine("ingrese la edad");
          edad= int.Parse(Console.ReadLine());

        if( edad >=21){
            Console.WriteLine("30% of ");
        }else if(edad > 20){
            Console.WriteLine("21 of");
        }else if(edad == 18){
            Console.WriteLine("105 of");
        }else{ 
            Console.WriteLine(" 5% of");
        }
        
        Console.WriteLine(" fin del programa");
        
        }



        
    }
}
