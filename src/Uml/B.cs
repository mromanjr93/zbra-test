using System;

namespace Uml
{
    public class B : A
    {
        public override void M(int a, long b)
        {
            Console.WriteLine("M implemented by class B");
        }

        public static void W()
        {
            Console.WriteLine("Implementation of underlined (static) W method, class B");
        }
    }
}
