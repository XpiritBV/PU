using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partsunlimited.PageObjectModel.PageObjects
{
    public class ProductDetailsPage
    {
        BrowserWindow _bw;
        public ProductDetailsPage(BrowserWindow bw)
        {
            _bw = bw;
        }
        public ShoppingBasketPage AddProductToCart()
        {
            HtmlHyperlink ProductLink = new HtmlHyperlink(_bw);
            ProductLink.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, "Add to Cart", PropertyExpressionOperator.Contains);
            Mouse.Click(ProductLink);

            return new ShoppingBasketPage(_bw);
        }
    }
}
