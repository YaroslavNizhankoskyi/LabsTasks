
using LabsTasks.ZooShop;

var shop = new ZooShop();

shop.ShowAll();

Console.WriteLine("\n ################## \n");

shop.ShowProductsByAnimalType(AnimalType.Cats);
shop.ShowProductsByAnimalType(AnimalType.Dogs);

