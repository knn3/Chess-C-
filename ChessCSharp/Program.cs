using System;

namespace ChessCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board test = new Board();
            Console.WriteLine(test.getCol());

            test.setCol(5);
            Console.WriteLine(test.getCol());
        }
    }
}

