using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            SingleCast_Delegate.Start();

            MultiCast_Delegate.Start();

            Console.ReadLine();
        }

        // view list in console
        public static void ViewList(List<string> list, string headline)
        {
            Console.WriteLine($"\n --- {headline} ---  \n");

            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
