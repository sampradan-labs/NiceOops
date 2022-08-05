using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public class Rhombus : Rectangle
    {
        public float Angle { get; set; }

        //Shadowing == hiding
        public override float CalculateArea()
        {
            return (float)(Length * Breadth * Math.Sin(Angle));
        }
    }
}
