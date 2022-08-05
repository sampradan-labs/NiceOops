using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{

    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public Rectangle(float length, float breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public float Length { get; set; }
        public float Breadth { get; set; }

        public virtual float CalculateArea()
        {
            return Length * Breadth;
        }

        public override void Draw(params string[]? ps)
        {
            Console.WriteLine($"{Name} is drawn with Length = {Length}, Breadth = {Breadth}");
        }

    }
}
