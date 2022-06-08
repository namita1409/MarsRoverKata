using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class InputValidator
    {
        private static PlateauGrid plateauDimensions;
        private static Position currentPositionAndDirection;
        private static readonly List<string> AllowedDirections = new List<string> { "N", "W", "E", "S" };


        public static PlateauGrid parseGrid(string input) {            

            string[] stringPlateauDimensions = input.Split(' ');

            if (PlateauDimensionsAreInvalid(stringPlateauDimensions))
            {
                throw new Exception("incorrect plateau dimention");
            }
            plateauDimensions = new PlateauGrid(Convert.ToInt32(stringPlateauDimensions[0]), Convert.ToInt32(stringPlateauDimensions[1]));

            return plateauDimensions;
        }
        private static bool PlateauDimensionsAreInvalid(string[] stringPlateauDimensions)
        {
            if (stringPlateauDimensions.Length != 2 || !stringPlateauDimensions[0].All(char.IsDigit)
                                                    || !stringPlateauDimensions[1].All(char.IsDigit))
            {
                return true;
            }

            return false;
        }
        public static Position SetStartPositionAndDirection(string positionDirectionString) {            

            string[] positionDirectionArr = positionDirectionString.Split(' ');
            if (StartPositionIsInvalid(positionDirectionArr))
            {
                throw new Exception("incorrect starting position");
            }
            int xCoOrdinate = Convert.ToInt32(positionDirectionArr[0]);
            int yCoOrdinate = Convert.ToInt32(positionDirectionArr[1]);
            Direction _currentDirection = Direction.Get(positionDirectionArr[2]);
            currentPositionAndDirection = new Position(xCoOrdinate, yCoOrdinate, _currentDirection);

            return currentPositionAndDirection;

        }
        private static bool StartPositionIsInvalid(string[] stringCurrentPositionAndDirection)
        {     

            if (stringCurrentPositionAndDirection.Length != 3 || !stringCurrentPositionAndDirection[0].All(char.IsDigit)
                                                              || !stringCurrentPositionAndDirection[1].All(char.IsDigit) || !AllowedDirections.Any(stringCurrentPositionAndDirection[2].ToUpper().Contains))
            {
                return true;
            }

            if (int.Parse(stringCurrentPositionAndDirection[0]) > plateauDimensions.X ||
                int.Parse(stringCurrentPositionAndDirection[1]) > plateauDimensions.Y)
            {
                return true;
            }

            return false;
        }

    }
}
