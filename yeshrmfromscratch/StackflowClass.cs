using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace yeshrmfromscratch
{
    class StackflowClass
    {
        public static string ActualLabelText;
        public static void SearchForStackflowLabel()
        {
            // propertiesClass.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);


            customcontrolClass.Enter_StackOverFlow_Text_In_GoogleSearchBar(PageObjectsClass.GoogleSearchBarVariable, ConfigurationManager.AppSettings.Get("EnterStackoverflowInGoogleSearchBar"));
            propertiesClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(3);
           
            try
            {
                ActualLabelText = CustomControlsGets.GettextfromLabel(PageObjectsClass.webelementvalueofStackoverflow, propertytype.XPath);


                //Assert.AreEqual(GlobalVariablesClass.GetExpectedLabel, ActualLabelText);
                //Console.WriteLine("Assertion is successful");


                if (ActualLabelText == GlobalVariablesClass.GetExpectedLabel)
                {
                    Console.WriteLine("Label Matches");
                }
                else
                    // Console.WriteLine("Not matching");
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Not matching");

            }
        }

    }         

}
