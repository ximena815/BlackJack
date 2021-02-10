using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a BlackJack GAME ;3");


            Random aleatorio = new Random();
            string respuesta = "s";
            int carta1 = 0, carta2 = 0;
            carta2 = aleatorio.Next(1, 11);//cartas del 1 al 10
            int total = carta2;
            Console.WriteLine("tu carta es: " + carta2);

            while (respuesta == "s")
            {
                carta1 = aleatorio.Next(1, 11); //cartas del 1 al 10
                Console.WriteLine("tu carta es: " + carta1);

                total += carta1;
                

                if(total > 21)//Perder ;3
                {
                    Console.WriteLine("tu total de cartas actual es: " + total);
                    Console.WriteLine("Mucha avaricia mijo perdio");
                    respuesta = "n";
                    string pajarito =
                      "\n  ^ ^" +
                      "\n (O,O)" +
                      "\n (   )" +
                      "\n  T T";
                    Console.WriteLine(pajarito);
                }
                else
                {
                    Console.WriteLine("tu total de cartas actual es: " + total);

                    Console.WriteLine("¿Deseas otra carta? (s/n)");
                    respuesta = Console.ReadLine();
                }


            }


        }
    }
}
