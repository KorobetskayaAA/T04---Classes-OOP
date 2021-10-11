using System;
using System.Collections.Generic;

namespace MyandexMurrrcatLibrary.Dtos
{
    public class Cat
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public double CutenessSum { get; set; }
        public int VotesCount { get; set; }
        // не сохранять в БД
        public double Cuteness { get => CutenessSum / VotesCount; }
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public string Description { get; set; }
    }
}
