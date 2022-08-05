using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public class Square : Rectangle
    {
        public Square()
        {
        }

        public Square(float side) : base(side,side)
        {        
        }

        public override float CalculateArea()
        {
            Console.WriteLine("This area is calculated in collaboration with rectangle class");
            return base.CalculateArea();
        }

        public override void Draw(params string[]? ps)
        {
            Console.WriteLine($"Using modern equipments, {Name} is drawn");
            
        }

    }
}
