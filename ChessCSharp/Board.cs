using System;
namespace ChessCSharp
{
    public class Board
    {
        private int col;
        private int row;

        public Board()
        {
            col = 0;
            row = 0;
        }

        public int getCol()
        {
            return this.col;
        }

        public void setCol(int num)
        {
            col = num;
        }

    }
}
