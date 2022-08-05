using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public abstract void Draw(params string[]? ps);

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"The shape is a {Name}");
        }

        public static Shape GetShapeObject(string? customerInput)
        {
            switch (customerInput.ToLower())
            {
                case "rectangle":
                    return new Rectangle() { Name=customerInput};
                case "square":
                    return new Square() { Name = customerInput };
                case "rhombus":
                    return new Rhombus() { Name = customerInput };
                default:
                    throw new Exception("Invalid shape input");
            }
        }
    }
}
