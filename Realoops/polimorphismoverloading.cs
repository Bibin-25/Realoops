using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realoops
{
    internal class polimorphismoverloading
    {
        public void  addd(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void  addd(String a,string b)
        {
            Console.Write(a + b);
        }
        public void addd(long  a,long  b)
        {
            Console.WriteLine(a +b);
        }
        
    }
}
