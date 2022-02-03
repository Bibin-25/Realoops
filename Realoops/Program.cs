using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //polioverloading 
            polimorphismoverloading pol = new polimorphismoverloading();
            pol.addd(1, 2);
            pol.addd("ab", "bc");
            pol.addd(3, 4);
            Console.ReadKey();
            //abstraction
            //abstracton rect = new RectangleArea(10, 2);

            //Console.WriteLine(rect.Getarea());
            //polioverriding
            polymorphismoverriding p=new polymorphismoverriding();
            p.voice();
            pig pg = new pig();
            pg.voice();
            dog pd = new dog();
            pd.voice();

            //inheritance
            inheritances ih = new student();
            ih.Reader("Bibin", "C#");
            //interface
            Interface3 inter=new Interface3();
            inter.mymethod3();
            inter.mymethod2();
            inter.mymethod1();

        }

    }
}
