using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Medicine
    {
        private static int _id;
        private static int _count;
        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public bool isDeleted = false;
        public Medicine(string name, int price, int count,bool isdeleted)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
            isDeleted = isdeleted;
        }
        public void Sell()
        {
            Count--;
        }
        public string ShowInfo()
        {
            return $"{Id} {Name} {Price} {Count} {isDeleted}";
        }
    }
}
