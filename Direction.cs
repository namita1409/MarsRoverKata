using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Direction
    {
        enum DirectionEnum { N, E, S, W };

        readonly DirectionEnum currentDirection;

        public static readonly Direction North;
        public static readonly Direction East;
        public static readonly Direction South;
        public static readonly Direction West;

        static readonly IList<Direction> Directions;

        static Direction()
        {
            North = new Direction(DirectionEnum.N);
            East = new Direction(DirectionEnum.E);
            South = new Direction(DirectionEnum.S);
            West = new Direction(DirectionEnum.W);
            Directions = new List<Direction> { North, East, South, West };
        }

        private Direction(DirectionEnum direction)
        {
            currentDirection = direction;
        }

        public Direction TurnLeft()
        {
            return Directions[(4 + Directions.IndexOf(this) - 1) % 4];
        }

        public Direction TurnRight()
        {
            return Directions[(4 + Directions.IndexOf(this) + 1) % 4];
        }

        public static Direction Get(String directionSign)
        {
            switch (directionSign.ToUpper())
            {
                case "E":
                    return Direction.East;
                case "W":
                    return Direction.West;
                case "N":
                    return Direction.North;
                case "S":
                    return Direction.South;
                default:
                    throw new Exception("Unknown Direction Sign");
            }
        }

        public override string ToString()
        {
            return currentDirection.ToString();
        }
    }
}