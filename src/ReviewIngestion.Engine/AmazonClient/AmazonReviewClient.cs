using ReviewIngestion.Domain.AmazonClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewIngestion.Domain.Common.Objects;

namespace ReviewIngestion.Engine.AmazonClient
{
    /// <summary>
    /// This class should make a call to as service like Amazons Product Advertising API to get product reviews.
    /// </summary>
    public class AmazonReviewClient : IAmazonClient
    {
        #region Fake data
        private List<Product> products = new List<Product>()
        {
            new Product
            {
                 Title ="Test"
                ,Author = "Chris Prather"
                ,ProductID = 1
                ,Category = ""
                ,ImageURL = ""
                ,BestPrice = 0.1
                ,ListPrice = 0.1
                ,Reviews = new Review[1]
                {
                    new Review
                    {
                        Title = "Bad Test"
                        ,Content = "This is a Bad way to get reviews"
                        ,StarCount = 1
                        ,SubmittedBy = "Chris Prather"
                        ,SubmittedOn = new DateTime(2017,1,24)
                        ,UsefulCount = 1
                    }
                }
            },
            new Product
            {
                 Title ="Test 2"
                ,Author = "Chris Prather"
                ,ProductID = 2
                ,Category = ""
                ,ImageURL = ""
                ,BestPrice = 0.1
                ,ListPrice = 0.1
                ,Reviews = new Review[2]
                {
                    new Review
                    {
                        Title = "Really Bad Test"
                        ,Content = "This is a Really Bad way to get reviews"
                        ,StarCount = 1
                        ,SubmittedBy = "Chris Prather"
                        ,SubmittedOn = new DateTime(2017,1,24)
                        ,UsefulCount = 1
                    },
                    new Review
                    {
                        Title = "Aggree on the Really Bad Test"
                        ,Content = "Aggree with previos review on this is a Really Bad way to get reviews"
                        ,StarCount = 1
                        ,SubmittedBy = "Chris Prather"
                        ,SubmittedOn = new DateTime(2017,1,24)
                        ,UsefulCount = 1
                    }
                }
            }
        };
        #endregion

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(p => p.ProductID == id);
        }
    }
}
