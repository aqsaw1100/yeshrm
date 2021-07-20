using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace yeshrmfromscratch
{
    class customcontrolClass
    {
        public static IWebElement element;
        public static void Entertext(string webelementvalue, propertytype elementtype, string value)
        {
            switch (elementtype)
            {

                case propertytype.Name:
                    propertiesClass.driver.FindElement(By.Name(webelementvalue)).SendKeys(value);
                    break;

                case propertytype.XPath:
                    propertiesClass.driver.FindElement(By.XPath(webelementvalue)).SendKeys(value);
                    break;
                case propertytype.CssSelector:
                    propertiesClass.driver.FindElement(By.CssSelector(webelementvalue)).SendKeys(value );
                    break;
                case propertytype.Id:
                    propertiesClass.driver.FindElement(By.Id(webelementvalue)).SendKeys(value);
                    break;

            }
        }
        public static void Enter_StackOverFlow_Text_In_GoogleSearchBar(string webelementvalue,string value)
        {
           
                
                    propertiesClass.driver.FindElement(By.CssSelector(webelementvalue)).SendKeys(value + Keys.Enter);
                    
               
        }
        public static IWebElement findElement(string webelementvalue, propertytype elementtype)
        {


            switch (elementtype)
            {

                case propertytype.Name:
                    element = propertiesClass.driver.FindElement(By.Name(webelementvalue));
                    break;

                case propertytype.XPath:
                    element = propertiesClass.driver.FindElement(By.XPath(webelementvalue));
                    break;
                case propertytype.CssSelector:
                    element = propertiesClass.driver.FindElement(By.CssSelector(webelementvalue));
                    break;

            }
            return element;
        }


        public static void click(string webelementvalue, propertytype elementtype)

        {
            switch (elementtype)
            {

                case propertytype.Name:
                    propertiesClass.driver.FindElement(By.Name(webelementvalue)).Click();
                    break;
                case propertytype.XPath:

                    propertiesClass.driver.FindElement(By.XPath(webelementvalue)).Click();
                    break;
                case propertytype.CssSelector:

                    propertiesClass.driver.FindElement(By.CssSelector(webelementvalue)).Click();
                    break;

            }
        }
        public static void Selectdropdown(string webelementvalue, string Text, propertytype elementtype)
        {
            switch (elementtype)
            {
                case propertytype.Id:

                    new SelectElement(propertiesClass.driver.FindElement(By.Id(webelementvalue))).SelectByText(Text);
                    break;
                case propertytype.Name:

                    new SelectElement(propertiesClass.driver.FindElement(By.Name(webelementvalue))).SelectByText(Text);
                    break;
                case propertytype.XPath:

                    new SelectElement(propertiesClass.driver.FindElement(By.Name(webelementvalue))).SelectByText(Text);
                    break;
            }
        }
    }

}