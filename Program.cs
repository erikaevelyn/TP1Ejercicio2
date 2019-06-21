using System;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra y te diré si es palíndroma: ");
            string palabra = Console.ReadLine();

            Solucion sol = new Solucion();
            bool repuesta = sol.IsPalindrome(palabra);
            
            Console.WriteLine(repuesta);
        }
    }
}
