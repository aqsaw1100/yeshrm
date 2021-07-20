using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeshrmfromscratch
{
    enum propertytype
    {
        Id,
        Name,
        CssSelector,
        Class,
        XPath,
        LinkText,

    }
    class propertiesClass
    {
       
        public static IWebDriver driver { get; set; }



    }
}
