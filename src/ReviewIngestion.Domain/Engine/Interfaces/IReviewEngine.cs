using ReviewIngestion.Domain.Common.Objects;

namespace ReviewIngestion.Domain.Engine.Interfaces
{
    public interface IReviewEngine
    {
        Product GetReviews(int id);
    }
}