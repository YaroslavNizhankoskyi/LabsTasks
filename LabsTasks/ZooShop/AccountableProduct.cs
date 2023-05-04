using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.ZooShop
{
    internal class AccountableProduct : Product
    {
        public int Count { get; set; }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"This AccountableProduct has Count of {Count}");
        }
    }
}
