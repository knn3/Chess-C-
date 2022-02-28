using System;
using System.Collections.Generic;

namespace ChessCSharp
{
    public class Pieces
    {
        private int x, y;
        private List<int[]> move;
        private int value;

        public Pieces()
        {
            x = y = 0;
            value = 0;
            move = new List<int[]>();
        }

        public Pieces(int x, int y, int value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }

        public int getValue()
        {
            return value;
        }
        public void setValue(int num)
        {
            value = num;
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
