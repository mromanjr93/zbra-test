using System;

namespace Uml
{
    class Program
    {
        static void Main(string[] args)
        {
            A b = new B();

            b.M(1, 2); // Show 'M implemented by class B'

            A c = new C();

            c.M(1, 2); // Show 'M implemented by class C'

            A d = new D();

            d.M(1, 2); // Show 'M implemented by class D'


            B.W(); // Call static method of B class

            // the implementation of protected method of class C only can be called by classes that inherit C

            Console.ReadKey();
        }
    }
}
