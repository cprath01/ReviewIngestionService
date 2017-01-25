using ReviewIngestion.Domain.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewIngestion.Domain.Common.Objects;

namespace ReviewIngestion.DataLayer
{
    /// <summary>
    /// This class should connect to a real SQL Database using EF
    /// </summary>
    public class SQLDataLayer : IDataAccessLayer
    {
        private List<Product> _dbProducts = new List<Product>();
        public Product GetProduct(int id)
        {
            return _dbProducts.FirstOrDefault(p => p.ProductID == id);
        }

        public void StoreProduct(Product product)
        {
            if (product != null && !_dbProducts.Contains(product))
            {
                _dbProducts.Add(product);
            }

        }
    }
}
