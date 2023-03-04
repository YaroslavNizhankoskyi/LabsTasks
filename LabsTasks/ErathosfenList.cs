using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks
{
    internal class ErathosfenList
    {
        public static List<int> Get(int max) 
        {
            List<int> list = Enumerable.Range(2, max - 1).ToList(); //Range returns IEnumerable<int>,
                                                                //than we trnasform into List<int>

            int counter = 0;
            while (counter < list.Count)
            {
                var divisionNum = list[counter]; 

                list.RemoveAll(num => 
                {
                    if (num == divisionNum) return false;
                    return num % divisionNum == 0;
                });

                counter++;
            }

            return list;
        }
    }
}
