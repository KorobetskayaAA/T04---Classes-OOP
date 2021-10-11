using MyandexMurrrcatLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyandexMurrrcatLibrary.BL
{
    public static class CatFabric
    {
        public static Cat CreateCat(string name, decimal price, IEnumerable<Category> categories = null,
            string description = "")
        {
            return new Cat()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                CutenessSum = 0,
                VotesCount = 0,
                Categories = categories ?? new List<Category>(),
                Price = price,
                OldPrice = null,
                Description = description,
            };
        }
    }
}
