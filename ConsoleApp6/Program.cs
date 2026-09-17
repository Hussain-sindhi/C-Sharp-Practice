using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp6
//{
//    class A
//    {
//        string[] s = new string[5];
//        public string this[int index]
//        {
//            get { return s[index]; }
//            set { s[index] = value; }
//        }
//    }

//    internal class Program
//    {

//        static void Main(string[] args)
//        {
//         A r=new A();
//            r[0] = "Hello";
//            Console.WriteLine(r[0]);
//            //r.ToString[0]
//        }
//    }
//}    

namespace Inheritance
{
    class C
    {

    }
    class A:C
    {
        public A() {
            Console.WriteLine("Constructor of class A");
        }
    }

    class B: A
    {
        public B()
        {
            Console.WriteLine("Constructor of class B");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            B b=new B();


        }
    }
}