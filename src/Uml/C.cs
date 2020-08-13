using System;
using System.Collections.Generic;
using System.Text;

namespace Uml
{
    public class C : A
    {
        public override void M(int a, long b)
        {
            Console.WriteLine("M implemented by class C");
        }

        protected void H()
        {
            Console.WriteLine("protected (#) method M implemented by class B");
        }
    }
}
