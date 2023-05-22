using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTask5.Entity
{
    internal class Wardrobe : Closet
    {
        private const string CLOTH_NAME = "book";

        public int CurrentClothesNumber { get; set; }

        public bool HasMirror { get; set; }

        public override string PutObjectInside(string objectName)
        {
            if (objectName.ToLower() == CLOTH_NAME)
            {
                CurrentClothesNumber++;
            }
            return $"Putting {objectName} into the wardrode";
        }

        public override bool SuitsForClothes() => true;

        public string Open() => "Opening the wardeobe";

        public string Close() => "Closing the wardeobe";
    }
}
