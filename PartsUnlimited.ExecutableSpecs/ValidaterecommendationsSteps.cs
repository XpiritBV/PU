using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartsUnlimited.Recommendations;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;

namespace PartsUnlimited.ExecutableSpecs
{
    [Binding]

    public class ValidaterecommendationsSteps
    {
        NaiveRecommendationEngine recomendationengine;

        string boughtproduct = null;
        IEnumerable<string> recommendations = null;
        [Given(@"I have bought a (.*)")]
        public void GivenIHaveBoughtA(string product)
        {
            recomendationengine = new NaiveRecommendationEngine();
            boughtproduct = product;
        }
        
        [When(@"I ask alternative products")]
        public void WhenIAskAlternativeProducts()
        {
             recommendations = recomendationengine.GetRecommendationsAsync(boughtproduct).Result;


        }

        [Then(@"the result should include my original (.*)")]
        public void ThenTheResultShouldIncludeMyOriginal(string product)
        {
   
    
            Assert.IsTrue(product == recommendations.FirstOrDefault());

        }
    }
}
