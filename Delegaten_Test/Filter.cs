using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten_Test
{
    public class Filter
    {
        // return true if index [0] from value = 'S'
        public static bool FilterFirstIndexS(string value)
        {
            char filter = 'S';

            if (value != null && value.Length >= 1)
            {
                if (value[0] == filter)
                {
                    return true;
                }
            }

            return false;
        }

        // todo
        // return true if members in list first charakter == v exist. if not return false!
        public static bool FilterFirstIndexS(List<string> list, char filter)
        {
            if (list != null && list.Count > 0)
            {
                foreach (string item in list)
                {
                    if (item.Length >= 1)
                    {
                        if (item[0] == filter)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        // return true if value >=5 chars
        public static bool FilterMoreThen5(string value)
        {
            int number = 5;

            if (value != null && value.Length >= 1)
            {
                if (value.Length >= number)
                {
                    return true;
                }
            }

            return false;
        }

        // return true if value <=3 chars
        public static bool FilterLessThen4(string value)
        {
            int number = 3;

            if (value != null && value.Length >= 1)
            {
                if (value.Length <= number)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
