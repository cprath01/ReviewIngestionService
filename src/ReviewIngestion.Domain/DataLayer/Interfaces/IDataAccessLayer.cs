using ReviewIngestion.Domain.Common.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewIngestion.Domain.DataLayer.Interfaces
{
    public interface IDataAccessLayer
    {
        Product GetProduct(int id);
        void StoreProduct(Product product);
    }
}
