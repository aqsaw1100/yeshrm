using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeshrmfromscratch
{
    class FunctionalitiesClass
    {       
        public static void alertBoxFunctonality()
        {

            string ActualUrl = propertiesClass.driver.Url;
            string ExpectedUrl = ConfigurationManager.AppSettings.Get("alertboxurl");
            if (ActualUrl == ExpectedUrl)
            {
                Console.WriteLine("you are on Homepage without clicking Alertbox");
            }
            else
            {
                if (customcontrolClass.findElement(PageObjectsClass.PageObjectsForAlertBox(1), propertytype.XPath) != null)
                {
                    customcontrolClass.click(PageObjectsClass.PageObjectsForAlertBox(2), propertytype.XPath);
                    Console.WriteLine("ConfirmationButton Clicked");
                    delayforClass._delayfor();
                }
                Assert.AreEqual(ExpectedUrl, propertiesClass.driver.Url);
                Console.WriteLine("You are on Homepage");
            }
        }
    }

}

