using System;
using System.Collections.Generic;

namespace ChessCSharp
{
    public class Pieces
    {
        private int x, y;
        private List<int[]> move;

        public Pieces()
        {
            x = y = 0;
            move = new List<int[]>();
        }

        public int getX() 
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int num)
        {
            x = num;
        }
        public void setY(int num)
        {
            y = num;
        }
        public List<int[]> getArrayMove()
        {
            return move;
        }
        public void setArrayMove(int numX, int numY)
        {
            int[] possibleMove = { numX, numY };
            move.Add(possibleMove);
        }

    }
}
