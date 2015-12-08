using System.Collections.Generic;
using System.Linq;

using PartsUnlimited.Recommendations;

using Xunit;

namespace PartsUnlimited.WebSite.UnitTests.Recommendations
{
    public class NaiveRecommendationEngineTests
    {
        [Fact]
        public void NaiveRecommendationEngineReturnsSameProductId()
        {
            IRecommendationEngine engine = new NaiveRecommendationEngine();

            string productId = "MyProduct";

            IEnumerable<string> recommendations = engine.GetRecommendationsAsync(productId).Result;

            Assert.Equal(new[] { productId }, recommendations.ToArray());
        }

        [Fact]
        public void NaiveRecommendationEngineReturnsNullArrayForNull()
        {
            IRecommendationEngine engine = new NaiveRecommendationEngine();

            string productId = null;

            IEnumerable<string> recommendations = engine.GetRecommendationsAsync(productId).Result;

            Assert.Equal(new[] { productId }, recommendations.ToArray());
        }
    }
}
