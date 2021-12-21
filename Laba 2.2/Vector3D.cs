using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2._2
{
    class Vector3D
    {
        public int x { get; set; }

        public int y { get; set; }

        public int z { get; set; }

        public Vector3D(int x, int y, int z)

        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static double operator *(Vector3D a, Vector3D b)
        {
            return (a.x * b.x + a.y * b.y + a.z * b.z);
        }

        public static Vector3D operator *(int a, Vector3D b)
        {

            return new Vector3D(a * b.x, a * b.y, a * b.z);
        }

        public double length
        {
            get { return Math.Sqrt(x * x + y * y + z * z); }
        }
    }
}
