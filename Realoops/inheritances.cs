using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realoops
{
    public  class inheritances
    {
        public string Name;
        public string Subject;
        public void Reader(string Name,String Subject)
        {
            this.Name = Name;
            this.Subject = Subject;
            Console.WriteLine("Myself" + Name);
            Console.WriteLine("My fav subject" + Subject);
        }


    }
    public class  student : inheritances
    {
        public student()
        {
            Console.WriteLine("Welcome");
        }
    }
    public class demo
    {
        public int MyProperty { get; set; }
    }
}
