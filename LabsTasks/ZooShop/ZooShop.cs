namespace LabsTasks.ZooShop
{
    internal class ZooShop
    {
        public List<Product> AllProducts { get; set; } = new List<Product>()
        {
            new SingleProduct
            {
                Name = "Bumerang",
                Color = "Red",
                TypeOfProduct = TypeOfProduct.Toy,
                AnimalType = AnimalType.Cats,
                Price = 10,
                ProductTier = ProductTier.Top,
                Material = "Plastic"
            },
            new BagProduct
            {
                Name = "Cats food",
                TypeOfProduct = TypeOfProduct.Food,
                AnimalType = AnimalType.Cats,
                Price = 100,
                ProductTier = ProductTier.Top,
                Weight = 1000.0
            },
            new BagProduct
            {
                Name = "Dogs food",
                TypeOfProduct = TypeOfProduct.Food,
                AnimalType = AnimalType.Dogs,
                Price = 100,
                ProductTier = ProductTier.Top,
                Weight = 1000.0
            },
            new AccountableProduct
            {
                Name = "Cats medicine",
                TypeOfProduct = TypeOfProduct.Food,
                AnimalType = AnimalType.Cats,
                Price = 100,
                ProductTier = ProductTier.Top,
                Count = 5
            },
        };

        public ZooShop(List<Product> products)
        {
            this.AllProducts = products;
        }

        public ZooShop()
        {
            
        }

        public void ShowAll() 
        {
            foreach(var pr in AllProducts)
            {
                pr.ToString();
            }
        }

        void ShowAll(List<Product> products)
        {
            foreach (var pr in products)
            {
                pr.ToString();
            }
        }

        public void ShowProductsByAnimalType(AnimalType animalType)
        {
            Console.WriteLine($"Showing products for {animalType.ToString()}");

            var filtered = AllProducts
                .Where(x => x.AnimalType == animalType)
                .ToList(); //LINQ

            ShowAll(filtered);
        }
    }
}
