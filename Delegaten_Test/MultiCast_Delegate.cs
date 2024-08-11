using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten_Test
{
    public delegate void MessageDelegate(string value);
    public class MultiCast_Delegate
    {
        public static void Start()
        {
            Console.WriteLine("\n\n Multi Cast Delegaten!");
            Console.WriteLine("\t Wie man Delegaten erzeugt und verkettet. \n");

            CreateMulticastDelegate();
        }

        // create delegate variable and call delegate method
        private static void CreateMulticastDelegate()
        {
            // create delegate variable
            MessageDelegate myMessage = new MessageDelegate(SayHello);
            
            // add extra delegate method
            myMessage += SayGoodbey;

            // call delegate methods
            myMessage("Shiki");
        }

        // delegate method
        private static void SayHello(string name)
        {
            Console.WriteLine($"Hello my friend {name} :)");
        }

        // delegate method
        private static void SayGoodbey(string name)
        {
            Console.WriteLine($"See you later {name} ._. ");
        }
    }
}
