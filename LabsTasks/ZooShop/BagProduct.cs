using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.ZooShop
{
    internal class BagProduct : Product
    {
        public double Weight { get; set; }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"This BagProduct has Weight of {Weight}");
        }
    }
}
