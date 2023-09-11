using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            Console.WriteLine( " escriba un numero");
            n = int.Parse(Console.ReadLine());

            if ( n == 0){
                Console.WriteLine(" es cero");
            } else if ( n < 0) {
                Console.WriteLine("es negativo");
            }
            else {
                Console.WriteLine(" es positivo");
            }
        }
    }
}
