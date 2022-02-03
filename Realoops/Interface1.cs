using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realoops
{
    public  interface Interface1
    {
        void mymethod1();
        void mymethod2();


    }
    public interface Interface2 : Interface1
    {
        void mymethod3();
    }
    public class Interface3 : Interface2
    {
        public void mymethod1()
        {
            Console.WriteLine("mplement method1");
        }
        public void mymethod2()
        {
            Console.WriteLine("mplement method2");
        }
        public void mymethod3()
        {
            Console.WriteLine("mplement method3");
        }

    }

}
