// See https://aka.ms/new-console-template for more information

using MarsRoverKata;
using System.Collections;
using static MarsRoverKata.InputValidator;
Console.WriteLine("enter grid value");
PlateauGrid plateauGrid = parseGrid(Console.ReadLine());

Console.WriteLine("enter position and Direction value");
try
{
    Position positionAndDirection = SetStartPositionAndDirection(Console.ReadLine());
    Rover rover = new Rover(plateauGrid, positionAndDirection);
    Console.WriteLine("enter Command");
    rover.Process(Console.ReadLine());
    Console.WriteLine(rover.ToString());
}
catch (Exception ex) { 
    Console.WriteLine(ex.Message);
}




