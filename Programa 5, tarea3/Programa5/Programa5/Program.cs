using System;

namespace Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            float b, c, d;
            Console.WriteLine("Hola bienvenido al programa");
            Console.WriteLine("Que es lo que desea calcular: (1. triangulo, 2. cuadrado, 3. rectangulo) ELIJA UN NUMERO DEL 1 AL 3");
            a = Console.ReadLine();

            if (a == "1")

            {
                Console.WriteLine("ELIGIO CALCULAR EL TRIANGULO");
                Console.WriteLine("Ingrese la base");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura");
            c = float.Parse(Console.ReadLine());

                d = (float)(b * c / 2);
                Console.WriteLine("El resultado del area es: " + c);
             }

            if (a == "2")

            {
                Console.WriteLine("ELIGIO CALCULAR EL CUADRADO");
                Console.WriteLine("Ingrese la base");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura");
                c = float.Parse(Console.ReadLine());

                d = (float)(b * c);
                Console.WriteLine("El resultado del area es: " + c);
            }

            if (a == "3")

            {
                Console.WriteLine("ELIGIO CALCULAR EL RECTANGULO");
                Console.WriteLine("Ingrese la base");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura");
                c = float.Parse(Console.ReadLine());

                d = (float)(b * c);
                Console.WriteLine("El resultado del area es: " + c);
            }



        }
    }
}
