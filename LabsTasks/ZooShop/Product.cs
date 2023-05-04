using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsTasks.ZooShop
{
    internal abstract class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public TypeOfProduct TypeOfProduct { get; set; }
        public AnimalType AnimalType { get; set; }
        public ProductTier ProductTier { get; set; }
        public double Price { get; set; }

        public virtual void ToString()
        {
            Console.WriteLine($"\n *** Product Id: {Id}\n");
            Console.WriteLine($"Product Name {Name} has Price " +
                $"of {Price} for Animal {AnimalType.ToString()}");
        }
    }

    public enum TypeOfProduct
    {
        Default,
        Food,
        Toy
    }

    public enum ProductTier
    {
        Basic,
        Normal,
        Top,
        Vip
    }

    public enum AnimalType
    {
        All,
        Cats,
        Dogs
    }
}
