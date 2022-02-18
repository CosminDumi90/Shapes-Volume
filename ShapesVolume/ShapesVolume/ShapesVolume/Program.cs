using System;

namespace ShapesVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            for (;;)
            {
                Console.WriteLine("Choose the shape you wish to know the volume of exemple: cube 5");
                Console.WriteLine("1.triangleprism height length\n2.cube side length\n3.cylinder radius height\n4.end");
                string input = Console.ReadLine().ToLower();
                

                if (input == "end")
                {
                    break;

                }
                else
                {
                    
                    string[] result = input.Split(" ");
                    switch (result[0])
                    {
                        case "triangleprism":
                            VolumeCalculator.TrianglePrismVolume(
                                new Triangle
                                (
                                Convert.ToDouble(result[1]),
                                Convert.ToDouble(result[2]),
                                Convert.ToDouble(result[3])));
                            break;

                         case "cube":
                            VolumeCalculator.CubeVolume(new Cube(Convert.ToDouble(result[1])));
                            break;
                        case "cylinder":
                            VolumeCalculator.Cylinder(new Cylinder(Convert.ToDouble(result[1]), Convert.ToDouble(result[2])));
                            break;
                        default:
                            Console.WriteLine("You did not choose one of 3 options");
                            break;
                    }
                }



              
            }
        }
        static string Hello() => "hello";
    }
}
