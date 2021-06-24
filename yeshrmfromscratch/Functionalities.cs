using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeshrmfromscratch
{
    class Functionalities
    {
        public static void titleFunctionality()
        {
            string title = properties.driver.Title;
            Console.WriteLine("title is {0}", title);

        }
       
        public static void alertBoxFunctonality()
        {

            string ActualUrl = properties.driver.Url;
            string ExpectedUrl = ConfigurationManager.AppSettings.Get("alertboxurl");
            if (ActualUrl == ExpectedUrl)
            {
                Console.WriteLine("you are on Homepage without clicking Alertbox");
            }
            else
            {
                if (customcontrol.findElement("//div[@class='sweet-alert showSweetAlert visible']", propertytype.XPath) != null)
                {
                    customcontrol.click("//button[@class='confirm']", propertytype.XPath);
                    Console.WriteLine("ConfirmationButtonClicked");
                    delayfor._delayfor();
                }
                Assert.AreEqual(ExpectedUrl, properties.driver.Url);
                Console.WriteLine("You are on Homepage");
            }
        }
    }

}

