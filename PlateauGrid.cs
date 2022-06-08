using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class PlateauGrid
    {
        private int x;
        private int y;

        public PlateauGrid(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public bool isValidMove(Position position)
        {
            return position.isWithin(this.x, this.y) && position.isOutside(0, 0);
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }


           
        }
    }
}
