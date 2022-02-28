using System;
namespace ChessCSharp
{
    
    public class Board
    {
        private Pieces[,] pieces;
        public Board()
        {
            pieces = new Pieces[8,8];

            for (int i = 0; i < 8; i++)
            {
                pieces[1, i] = new Pieces(1, i, 1);
            }

            for (int i = 0; i < 8; i++)
            {
                pieces[i, 1] = new Pieces(i, 1, 1);
            }

            //pieces[5, 3] = new Pieces(5, 3 ,5);
            pieces[0,7] = new Pieces(0,7,-5);
            pieces[7,0] = new Pieces(7,0,5);
            pieces[7,7] = new Pieces(7,7,5);
            pieces[0,0] = new Pieces(0,0,-5);
        }

        public Pieces[,] getBoard()
        {
            return pieces;
        }

    }
    
}
