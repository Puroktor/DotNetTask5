using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTask5.Entity
{
    public class BookCloset : Closet
    {
        private const string BOOK_NAME = "book";

        public int CurrentBooksNumber { get; set; }

        public int MaxBooksNumber { get; set; }

        public override string PutObjectInside(string objectName)
        {
            if (objectName.ToLower() == BOOK_NAME) 
            {
                if (MaxBooksNumber == CurrentBooksNumber) 
                {
                    throw new ArgumentException("Too many books in the closet");
                }
                CurrentBooksNumber++;
            }
            return $"Putting {objectName} into the book closet";
        }

        public override bool SuitsForClothes() => false;

        public string WipeDust() => "Whiping the dust from the book closet";

        public string ReorderBooks(bool asc) => $"Reordering boks {(asc  ? "ascending": "descending")} in the book closet";
    }
}
