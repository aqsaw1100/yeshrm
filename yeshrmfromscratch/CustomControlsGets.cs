using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace yeshrmfromscratch
{
    class CustomControlsGets
    {

        public static string GettextfromLabel(string webelementvalue, propertytype elementtype)
        {
            //if (elementtype == propertytype.Model)
            //    return  propertiesClass.driver.FindElement(NgBy.Model(webelementvalue)).Text;

            //else
                if (elementtype == propertytype.Name)
                return  propertiesClass.driver.FindElement(By.Name(webelementvalue)).Text;

            else
                if (elementtype == propertytype.XPath)
                return  propertiesClass.driver.FindElement(By.XPath(webelementvalue)).Text;

            else

            if (elementtype == propertytype.CssSelector)
                return  propertiesClass.driver.FindElement(By.CssSelector(webelementvalue)).Text;
            else
            if (elementtype == propertytype.LinkText)
                return  propertiesClass.driver.FindElement(By.CssSelector(webelementvalue)).Text;


            return (string.Empty);

        }

        public static string Geettextfromtextbox(string webelementvalue, propertytype elementtype)
        {
            //if (elementtype == propertytype.Model)
            //    return  propertiesClass.driver.FindElement(NgBy.Model(webelementvalue)).GetAttribute("value");

            //else
            if (elementtype == propertytype.Name)
                return propertiesClass.driver.FindElement(By.Name(webelementvalue)).GetAttribute("value");
            else
             if (elementtype == propertytype.XPath)
                return  propertiesClass.driver.FindElement(By.XPath(webelementvalue)).GetAttribute("value");

            else

             if (elementtype == propertytype.CssSelector)
                return  propertiesClass.driver.FindElement(By.CssSelector(webelementvalue)).GetAttribute("value");
            else
                return (string.Empty);

        }


        public static string Gettextfromdropdown(string webelementvalue, string elementtype)


        {
            if (elementtype == "id")
                return  propertiesClass.driver.FindElement(By.Id(webelementvalue)).GetAttribute("value");

            else
               if (elementtype == "Name")
                return new SelectElement( propertiesClass.driver.FindElement(By.Name(webelementvalue))).SelectedOption.Text;
            if (elementtype == "XPath")
                return  propertiesClass.driver.FindElement(By.XPath(webelementvalue)).GetAttribute("value");

            else

            if (elementtype == "CssSelector")
                return  propertiesClass.driver.FindElement(By.CssSelector(webelementvalue)).GetAttribute("value");
            else
                return (string.Empty);



        }
    }
}
