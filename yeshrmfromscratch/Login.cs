using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace yeshrmfromscratch
{


    public class Login
    {
        public static void initialize()
        {
            properties.driver = new ChromeDriver();
            properties.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("url"));
            properties.driver.Manage().Window.Maximize();
            customcontrol.Entertext(PageObjects.Login_Screen(1), propertytype.CssSelector, ConfigurationManager.AppSettings.Get("email"));
            customcontrol.Entertext(PageObjects.Login_Screen(2), propertytype.CssSelector, ConfigurationManager.AppSettings.Get("password"));
            customcontrol.click(PageObjects.Login_Screen(3), propertytype.CssSelector);
            delayfor._delayfor();
            Functionalities.alertBoxFunctonality();
        }
    }
}



