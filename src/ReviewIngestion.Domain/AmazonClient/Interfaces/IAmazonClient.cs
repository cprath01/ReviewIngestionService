using ReviewIngestion.Domain.Common.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewIngestion.Domain.AmazonClient.Interfaces
{
    public interface IAmazonClient
    {
        Product GetProduct(int id);
    }
}
