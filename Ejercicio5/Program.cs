using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main()
        {
            int A = 1, B = 2, C = 3, D = 4;
            Console.WriteLine($" Valor de A, B, C, D {A} , {B} , {C} , {D}");
            B = C;
            C = A;
            A = D;
            D = B;
            Console.WriteLine($" Valor de A, B, C, D {A} , {B} , {C} , {D}");
        }
    }
}
