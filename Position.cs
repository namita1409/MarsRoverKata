using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Position
    {
        private int x;
        private int y;
        private Direction direction;

        public Position(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
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
       
        public Position rotateRight() {
            return new Position(X, Y, direction.TurnRight());
        }
        public Position rotateLeft()
        {
            return new Position(X, Y, direction.TurnLeft());
        }

        public bool isWithin(int x,int y) {
            return this.x <= x && this.y <= y;
        }
        public bool isOutside(int x, int y)
        {
            return this.x >= x && this.y >= y;
        }
        
        public Position Move()
        {
            switch (direction.ToString())
            {
                case "E":   
                    return new Position(x + 1, y, direction);
                case "W":
                    return new Position(x - 1, y, direction);
                case "N":
                    return new Position(x, y + 1, direction);
                case "S":
                    return new Position(x, y - 1, direction);
                default:
                    throw new Exception("Unknown Direction");
            }
        }

        public override String ToString()
        {
            return x + " " + y + " " + direction.ToString();
        }


    }
}
