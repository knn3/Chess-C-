using System;
using System.Collections.Generic;

namespace ChessCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Board test = new Board();
            Pieces Rook1 = test.getBoard()[0,0];
            Pieces Rook2 = test.getBoard()[7,7];
            Pieces Rook3 = test.getBoard()[0,7];
            Pieces Rook4 = test.getBoard()[7,0];


            Console.WriteLine(Rook1.getX() + " " + Rook1.getY() + " " + Rook1.getValue());
            Console.WriteLine(Rook2.getX() + " " + Rook2.getY() + " " + Rook2.getValue());
            Console.WriteLine(Rook3.getX() + " " + Rook3.getY() + " " + Rook3.getValue());
            Console.WriteLine(Rook4.getX() + " " + Rook4.getY() + " " + Rook4.getValue());

            //di chuyen
            if (test.getBoard()[5, 3] == null )
            {
                test.getBoard()[5, 3] = Rook4;
                Rook4.setX(5);
                Rook4.setY(3);
                test.getBoard()[7, 0] = null;
                Console.WriteLine(test.getBoard()[5, 3].getX() + " " + test.getBoard()[5, 3].getY() + test.getBoard()[5,3].getValue());
            } 
            else if (test.getBoard()[5, 3].getValue() * Rook4.getValue() < 0)
            {
                Console.WriteLine("Eat piece");
            }
            
            else
            {
                Console.WriteLine("Not allow to move");
            }
        }
    }
}

