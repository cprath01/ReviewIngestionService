using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewIngestion.Domain.Common.Objects
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string ImageURL { get; set; }
        public double BestPrice { get; set; }
        public double ListPrice { get; set; }
        public Review[] Reviews { get; set; }
    }
}
