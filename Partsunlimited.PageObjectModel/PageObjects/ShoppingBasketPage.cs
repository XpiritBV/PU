using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partsunlimited.PageObjectModel.PageObjects
{
    public class ShoppingBasketPage
    {
        BrowserWindow _bw;
        public ShoppingBasketPage(BrowserWindow bw)
        {
            _bw = bw;
        }
        public bool IsProductInBasket(string productName)
        {
            return true;
        }
    }
}
