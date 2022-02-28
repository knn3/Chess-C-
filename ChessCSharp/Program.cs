using System;
using System.Collections.Generic;

namespace ChessCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Pieces test = new Pieces();
            
            test.getArrayMove().ForEach((move) =>
            {
                Console.WriteLine(move[0]);
                Console.WriteLine(move[1]);
            });
            
            test.setArrayMove(0, 1);
            test.getArrayMove().ForEach((T) =>
            {
                Console.WriteLine(T[0]);
                Console.WriteLine(T[1]);
            });
        }
    }
}

