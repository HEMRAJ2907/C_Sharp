using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct Point3D
    {
        
        private readonly double _x;
        private readonly double _y;
        private readonly double _z;

        
        public double X => _x;
        public double Y => _y;
        public double Z => _z;

        
        public Point3D(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        
        public void Display()
        {
            Console.WriteLine($"Point in 3D space: ({X}, {Y}, {Z})");
        }

        
        public double DistanceTo(Point3D other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            double dz = Z - other.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}
internal class struct2
    {
      public  static void Main()
      {
        Struct.Point3D p1 = new Struct.Point3D(3.0, 4.0, 5.0);
        Struct.Point3D p2 = new Struct.Point3D(0.0, 0.0, 0.0);

        p1.Display();  
        p2.Display();  

        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"Distance between points: {distance:F2}");  
      }
}

