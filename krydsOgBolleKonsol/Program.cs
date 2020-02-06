using System;

namespace krydsOgBolleKonsol
{
    class Program
    {
        static void PrintBoard(string[,] board)
        {
            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    Console.Write(board[x, y]);
                }
                Console.WriteLine();
            }
        }

        static int IndtastV(string text)
        {
            Console.Write(text + ":");
            string xstring = Console.ReadLine();
            int a = Convert.ToInt32(xstring);
            return a;
        }

        static void Main(string[] args)
        {
            string[,] b = new string[,] { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };

            for(; ; )
            {
                PrintBoard(b);

                Console.WriteLine("Nu er det X tur");

                int ix = IndtastV("indtast x");
                int iy = IndtastV("indtast y");
                b[ix, iy] = "X";

                PrintBoard(b);

                Console.WriteLine("Nu er det O tur");

                ix = IndtastV("indtast x");
                iy = IndtastV("indtast y");
                b[ix, iy] = "O";
            }



        }

    }
}
