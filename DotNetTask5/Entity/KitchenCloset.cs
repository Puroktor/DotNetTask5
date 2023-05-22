using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTask5.Entity
{
    public class KitchenCloset : Closet
    {
        public double SpaceVolume { get; set; }

        public bool HasDishesShelf { get; set; }

        public override string PutObjectInside(string objectName) => $"Putting {objectName} into the kitchen closet";

        public override bool SuitsForClothes() => false;

        public string TakeMeal(string mealName, bool needDish) => $"Taking {mealName} {(needDish && HasDishesShelf ? "with dishes" : "")} from kitchen closet";

        public string DiscardSpoiledProducts() => $"Discarding spoiled products";
    }
}
