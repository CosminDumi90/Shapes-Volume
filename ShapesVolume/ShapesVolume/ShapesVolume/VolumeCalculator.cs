using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesVolume
{
    public class VolumeCalculator
    {
        
        
        
   
        public static void TrianglePrismVolume(Triangle triangleprism)
        {
            Console.WriteLine($"Volume: {((triangleprism.BaseSide * triangleprism.Height * triangleprism.Length) / 2).ToString("n3")}");
        }
        public static void CubeVolume(Cube cube)
        {
            Console.WriteLine($"Volume: {(Math.Pow(cube.SideLength, 3).ToString("n3"))}");
        }
        public static void Cylinder(Cylinder cylinder)
        {
            Console.WriteLine($"Volume: {(Math.Pow(cylinder.Radius, 2) * Math.PI * cylinder.Height).ToString("n3")}");
        }
    }
}
