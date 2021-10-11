using MyandexMurrrcatLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyandexMurrrcatLibrary.BL
{
    class CategoriesManager
    {
        HashSet<Category> categories;

        public CategoriesManager()
        {
            categories = new HashSet<Category>();
        }

        public IEnumerable<string> GetAllNames()
        {
            return categories
                .Select(category => category.Name)
                .ToArray();
        }

        public void AddRange(IEnumerable<string> newCategories)
        {
            foreach (var categoryName in newCategories)
            {
                if (!categories.Any(category => category.Name == categoryName))
                {
                    categories.Add(CreateCategory(categoryName));
                }
            }
        }

        Category CreateCategory(string name)
        {
            return new Category
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
            };
        }
    }
}
