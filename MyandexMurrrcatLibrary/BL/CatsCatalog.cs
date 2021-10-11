using MyandexMurrrcatLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyandexMurrrcatLibrary.BL
{
    public class CatsCatalog
    {
        readonly List<Cat> cats;

        public CatsCatalog()
        {
            cats = new List<Cat>();
        }

        public IEnumerable<Cat> GetCatsByCategory(Category category)
        {
            return cats.Where(cat => cat.Categories.Contains(category));
        }

        public void AddCat(Cat cat)
        {
            cats.Add(cat);
        }

        public void RemoveCat(Cat cat)
        {
            cats.Remove(cat);
        }

        public void ChangePrice(Cat cat, decimal newPrice)
        {
            cat.OldPrice = cat.Price;
            cat.Price = newPrice;
        }

        public void VoteCat(Cat cat, double newVote)
        {
            cat.CutenessSum += newVote;
            cat.VotesCount += 1;
        }

        //public Cat Cats { get; }

        public Cat this[string id]
        {
            get => cats.Find(cat => cat.Id == id);
        }
    }
}
