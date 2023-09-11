using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor,a,b,c,d ;

            Console.WriteLine("escriba un numero:");
            a= int.Parse (Console.ReadLine());
            Console.WriteLine("escriba otro:");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("escriba otro:");
            c= int.Parse(Console.ReadLine());
            Console.WriteLine("escriba el ultimo:");
            d= int.Parse(Console.ReadLine());

            if( a < b)
                menor =  a;
            else
            
                menor=b ;
            if ( c < menor )
               menor= c;
            if ( d < menor )
               menor= d;        
            

                 Console.WriteLine( "el resultado es:" + menor);
        }
    }
}
