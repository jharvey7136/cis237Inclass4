using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class Program
    {
        static void Main(string[] args)
        {

            MyLinkList myLinkList = new MyLinkList();

            myLinkList.Add("first");
            myLinkList.Add("second");
            myLinkList.Add("third");
            myLinkList.Add("fourth");

            for (Node x = myLinkList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }
            Console.WriteLine();
            Console.WriteLine();

            myLinkList.Delete(2);
            myLinkList.Delete(2);

            for (Node x = myLinkList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

        }
    }
}
