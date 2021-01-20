/* CharpExercise implementation are created based on the C++ course that
 * I have taken at DTU Compute. Each week had a topic regarding
 * basic concepts of programming.
 */

// Week3 - Data Types
// Example: Enumaration

using System;

namespace CSharpExercise
{
    public class Program
    {
        public enum Direction { north, east, south, west }
        //                   0,    1,     2,    3

        static public string DirToText(Direction dir)
        {
            string directionString = "Undefined";
            switch (dir)
            {
                case Direction.north:
                    directionString = "North";
                    break;
                case Direction.east:
                    directionString = "East";
                    break;
                case Direction.south:
                    directionString = "South";
                    break;
                case Direction.west:
                    directionString = "West";
                    break;
                default:
                    Console.WriteLine("Problematic Case!!");
                    break;
            }
            return directionString;
        }

        static void Main(string[] args)
        {
            Direction dir = Direction.east;
            string direction = DirToText(dir);
            Console.WriteLine($"Selected direction is {direction}.");
        }
    }
}
