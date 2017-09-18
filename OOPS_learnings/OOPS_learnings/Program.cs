using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_learnings
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //Console.WriteLine("A Reference :: A Object");
            //Console.WriteLine();

            //A a1 = new B();
            //Console.WriteLine("A Reference :: B Object");
            //Console.WriteLine();

            B b = new B();// Static B,Static A, A, B
            Console.WriteLine("B Reference :: B Object");

            Console.Read();
        }
    }

    public class A
    {
        static A()
        {
            Console.WriteLine("static A");
        }

        public A()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        static B()
        {
            Console.WriteLine("static B");
        }

        public B()
        {
            Console.WriteLine("B");
        }
    }

}
