using System;

namespace Uml
{
    public class D : A
    {
        public override void M(int a, long b)
        {
            Console.WriteLine("M implemented by class D");
        }
    }
}
