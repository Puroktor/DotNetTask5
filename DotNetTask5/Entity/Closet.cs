using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTask5.Entity
{
    public abstract class Closet : IFurniture
    {
        public double Price { get; set; }

        public string Material { get; set; }

        public string Color { get; set; }

        public int ShelfNumber { get; set; }

        public string Buy() => $"Bying closet for {Price}";

        public string Sell(double discount) =>  $"Selling closet for {(1- discount) * Price}";

        public string Move(double x, double y) =>  $"Moving closet in space to ({x}, {y})";

        public abstract bool SuitsForClothes();

        public abstract string PutObjectInside(string objectName);
    }
}
