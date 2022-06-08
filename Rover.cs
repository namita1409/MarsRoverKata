using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Rover
    {
        private Position position;        
        private PlateauGrid plateauGrid;
        public Rover(PlateauGrid plateauGrid, Position position)
        {
            this.plateauGrid = plateauGrid;
            this.position = position;
            
        }
        public Position getPosition()
        {
            return position;
        }
        public void Process(String instruction) {
            for (int i = 0; i < instruction.Length; i++) { 
                processInstruction(instruction[i]);
                    }
        }
        private void processInstruction(char c) {
            
            switch (char.ToUpper(c)) {
                case 'R':
                        turnRight();
                        break;
                case 'L':              
                    
                    turnLeft();
                    break;
                case 'M':
                    move();
                    break;
            }
        }
        private void turnRight() {
            position = position.rotateRight();           

        }
        private void move() {
            if (plateauGrid.isValidMove(position.Move()))
            {
                position = position.Move();                
            }

        }
        private void turnLeft() {
            position = position.rotateLeft();            
        }
        public override string ToString()
        {
            return position.ToString();
        }
        
    }
}
