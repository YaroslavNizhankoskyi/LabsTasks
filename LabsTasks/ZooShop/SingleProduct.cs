using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.ZooShop
{
    internal class SingleProduct : Product
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"This SingleProduct has Color {Color}" +
                $" and Material {Material}");
        }
    }
}
