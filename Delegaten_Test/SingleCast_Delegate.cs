using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten_Test
{
    public delegate bool FilterDelegate(string value); // Delegate
    public class SingleCast_Delegate
    {
        public static void Start()
        {
            Console.WriteLine("Single Cast Delegate!");
            Console.WriteLine("\t Verwendung z.B. verschiedener Sortierrungen einer Liste mit Delegaten. \n");

            TestDelegate();
        }

        private static void TestDelegate()
        {
            // original string list
            List<string> originalList = new List<string>
            {
                "Lea",
                "Hanz Rum",
                "Janse",
                "Berta",
                "Shiki Magata",
                "S",
                " ",
                "Alexi",
                "Su"
            };

            // use delegate long way:
            // create a list and a delegate variable.
            List<string> sortWithS = new List<string>();

            FilterDelegate filterDelegateOne = new FilterDelegate(Filter.FilterFirstIndexS);

            sortWithS = GetFilteredList(originalList, filterDelegateOne);

            // use delegate short way:
            // create list and use an instant delegate variable
            List<string> sortMore5 = GetFilteredList(originalList, Filter.FilterMoreThen5);
            List<string> sortLess4 = GetFilteredList(originalList, Filter.FilterLessThen4);

            // view list in console
            Program.ViewList(originalList, "Originale Mitglieder Liste");
            Program.ViewList(sortWithS, "Sortierte nach: Anfangsbuchstaben S");
            Program.ViewList(sortMore5, "Sortierte nach: Namen >= als 5 Zeichen ");
            Program.ViewList(sortLess4, "Sortierte nach: Namen <= als 4 Zeiche");
        }

        // add elemts to a list if value is true from called delegate method
        private static List<string> GetFilteredList(List<string> originalList, FilterDelegate filterMethod)
        {
            List<string> filterList = new List<string>();

            if (originalList != null && originalList.Count >= 1)
            {
                if (filterList != null)
                {
                    filterList.Clear();
                }

                foreach(string value in originalList)
                {
                    if(filterMethod(value) == true)
                    {
                        filterList.Add(value);
                    }
                }
            }

            return filterList;
        }

    }
}
