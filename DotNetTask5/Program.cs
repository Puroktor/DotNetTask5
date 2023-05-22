using DotNetTask5.Entity;

namespace DotNetTask5
{
    internal class Program
    {
        static void Main()
        {
            var furnitures = new List<IFurniture>();

            var bookCloset = new BookCloset()
            {
                Price = 1000.0,
                Material = "Oak",
                Color = "Brown",
                ShelfNumber = 5,
                CurrentBooksNumber = 2,
                MaxBooksNumber = 100
            };

            var kitchenCloset = new KitchenCloset()
            {
                Price = 1500.0,
                Material = "Glass",
                Color = "White",
                ShelfNumber = 7,
                SpaceVolume = 3.0,
                HasDishesShelf = true,
            };

            var wardrobe = new Wardrobe()
            {
                Price = 500.0,
                Material = "Chipboard",
                Color = "Black",
                ShelfNumber = 4,
                HasMirror = false,
                CurrentClothesNumber = 12,
            };

            furnitures.Add(bookCloset);
            furnitures.Add(kitchenCloset);
            furnitures.Add(wardrobe);

            foreach (var furniture in furnitures)
            {
                Console.WriteLine(">{0}", furniture.Price);
                Console.WriteLine(">{0}", furniture.Sell(0.1));
                if (furniture is Closet closet)
                {
                    Console.WriteLine("--->{0}", closet.PutObjectInside("book"));
                    Console.WriteLine("--->{0}", closet.Move(1, 1));
                    if (closet is BookCloset booksCloset)
                    {
                        Console.WriteLine("------>{0}", booksCloset.WipeDust());
                        Console.WriteLine("------>{0}", booksCloset.ReorderBooks(true));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}