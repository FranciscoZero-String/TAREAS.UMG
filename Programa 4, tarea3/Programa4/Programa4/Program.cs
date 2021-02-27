using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte día;
            Console.WriteLine("Dame un numero de 1 al 7");
            día = Convert.ToByte(Console.ReadLine());


            switch (día)
            {
                case 1:
                    Console.WriteLine("Escogiste Lunes");
                    break;

                case 2:
                    Console.WriteLine("Escogiste Martes");
                    break;

                case 3:
                    Console.WriteLine("Escogiste Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Escogiste Jueves");
                    break;
                case 5: 
                    Console.WriteLine(" Escogiste Viernes");
                    break;
                case 6:
                    Console.WriteLine(" Escogiste Sabado");
                    break;
                case 7:
                    Console.WriteLine(" Escogiste Domingo");
                    break;

                default:  Console.WriteLine("Huy! TE HAS CONFUNDIDO");
                    break;
            }

            }
        }
    }

