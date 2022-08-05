using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public class A
    {
        public virtual void Call()
        {
            Console.WriteLine("In 'A'");
        }
    }

    public class B : A
    {
    new public void Call()
        {
            //
        }
    }

    public class C : B
    {
        public new void Call()
        {
            base.Call();
        }
    }
}
