using OpenQA.Selenium;
using System;

namespace yeshrmfromscratch
{
   class customcontrol
    {
        public static IWebElement element;
        public static void Entertext(string webelementvalue, propertytype elementtype, string value)
        {            
                switch (elementtype)
                {

                    case propertytype.Name:
                        properties.driver.FindElement(By.Name(webelementvalue)).SendKeys(value);
                        break;

                    case propertytype.XPath:
                        properties.driver.FindElement(By.XPath(webelementvalue)).SendKeys(value);
                        break;
                    case propertytype.CssSelector:
                        properties.driver.FindElement(By.CssSelector(webelementvalue)).SendKeys(value);
                        break;

                }            
        }
        public static IWebElement findElement(string webelementvalue, propertytype elementtype)
        {


            switch (elementtype)
            {

                case propertytype.Name:
                    element = properties.driver.FindElement(By.Name(webelementvalue));
                    break;

                case propertytype.XPath:
                    element = properties.driver.FindElement(By.XPath(webelementvalue));
                    break;
                case propertytype.CssSelector:
                    element = properties.driver.FindElement(By.CssSelector(webelementvalue));
                    break;

            }
            return element;
        }

      
        public static void click(string webelementvalue, propertytype elementtype)

        {
            switch (elementtype)
            {

                case propertytype.Name:
                    properties.driver.FindElement(By.Name(webelementvalue)).Click();
                    break;
                case propertytype.XPath:

                    properties.driver.FindElement(By.XPath(webelementvalue)).Click();
                    break;
                case propertytype.CssSelector:

                    properties.driver.FindElement(By.CssSelector(webelementvalue)).Click();
                    break;

            }
        }
    }

}