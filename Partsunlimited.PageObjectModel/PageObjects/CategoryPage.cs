using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partsunlimited.PageObjectModel.PageObjects
{
    public class CategoryPage
    {
        BrowserWindow _bw;
        public CategoryPage(BrowserWindow bw)
        {
            _bw = bw;
        }

        public ProductDetailsPage SelectProduct(string productName)
        {
            HtmlDiv LightingList = new HtmlDiv(_bw);
            LightingList.SearchProperties.Add(HtmlControl.PropertyNames.Class, "list-item-part", PropertyExpressionOperator.Contains);
  
            HtmlHyperlink lightingProduct = new HtmlHyperlink(LightingList);
            lightingProduct.SearchProperties.Add(HtmlControl.PropertyNames.Title, productName, PropertyExpressionOperator.Contains);
  
            Mouse.Click(lightingProduct);

            return new ProductDetailsPage(_bw);
        }
    }
}
