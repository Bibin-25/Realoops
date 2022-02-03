using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realoops
{
    public  class polymorphismoverriding
    {
        public virtual void voice()
        {
            Console.WriteLine("animal sound");

        }
       

    }
    public class pig : polymorphismoverriding
    {
        public override void voice()
        {
            Console.WriteLine("my sound is gre gre");
        }
    }
    public class dog : polymorphismoverriding
    {
        public override void voice()
        {
            Console.WriteLine("my sound is bow");
        }
    }
}
