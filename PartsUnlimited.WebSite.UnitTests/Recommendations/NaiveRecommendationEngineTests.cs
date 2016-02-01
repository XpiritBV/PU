using System.Collections.Generic;
using System.Linq;

using PartsUnlimited.Recommendations;

using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PartsUnlimited.WebSite.UnitTests.Recommendations
{
    public class NaiveRecommendationEngineTests
    {
        [Fact]
        [TestCategory("Unit")]
        public void NaiveRecommendationEngineReturnsSameProductId()
        {
            IRecommendationEngine engine = new NaiveRecommendationEngine();

            string productId = "MyProduct";

            IEnumerable<string> recommendations = engine.GetRecommendationsAsync(productId).Result;

            Xunit.Assert.Equal(new[] { productId }, recommendations.ToArray());
        }

        [Fact]
        [TestCategory("Unit")]
        public void NaiveRecommendationEngineReturnsNullArrayForNull()
        {
            IRecommendationEngine engine = new NaiveRecommendationEngine();

            string productId = null;

            IEnumerable<string> recommendations = engine.GetRecommendationsAsync(productId).Result;

            Xunit.Assert.Equal(new[] { productId }, recommendations.ToArray());
        }
    }
}
