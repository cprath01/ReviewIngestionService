using ReviewIngestion.Domain.Common.Objects;
using ReviewIngestion.Domain.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewIngestion.Domain.DataLayer.Interfaces;
using ReviewIngestion.Domain.AmazonClient.Interfaces;

namespace ReviewIngestion.Engine
{
    public class AmanzonEngine : IReviewEngine
    {
        private readonly IAmazonClient _client;
        private readonly IDataAccessLayer _dal;

        public AmanzonEngine(IDataAccessLayer dal, IAmazonClient client)
        {
            _client = client;
            _dal = dal;
        }
        public Product GetReviews(int id)
        {
            var product = _dal.GetProduct(id);
            if(product == null)
            {
                product = _client.GetProduct(id);
                _dal.StoreProduct(product);
            }
            return product;
        }
    }
}
