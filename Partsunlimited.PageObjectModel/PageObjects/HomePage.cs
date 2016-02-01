using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partsunlimited.PageObjectModel.PageObjects
{
    public class HomePage
    {

        BrowserWindow _bw;
        public HomePage(BrowserWindow bw)
        {
            _bw = bw;
        }
        public CategoryPage SelectCategory(string categoryName)
        {

            HtmlDiv categoryDiv = new HtmlDiv(_bw);
            categoryDiv.SearchProperties.Add(HtmlControl.PropertyNames.Class, "hidden-xs", PropertyExpressionOperator.Contains);

            HtmlHyperlink lightingCategoryLink = new HtmlHyperlink(categoryDiv);
            lightingCategoryLink.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, categoryName, PropertyExpressionOperator.Contains);

            Mouse.Click(lightingCategoryLink);



            return new CategoryPage(_bw);
        }
    }
}
