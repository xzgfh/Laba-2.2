using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Vector3D a = new Vector3D(1, 1, 1);
                Vector3D b = new Vector3D(2, 2, 2);
                Vector3D c = a + b;
                Vector3D d = a - b;
                double r = a * b;
                Vector3D h = 3 * a;
                double k = a.length;
                Console.WriteLine(c);

            
        }
    }
}
