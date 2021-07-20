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


    public class LoginPageClass
    {
        public static void LoginPageMethodFeatures()
        {
            propertiesClass.driver = new ChromeDriver();
            propertiesClass.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("GoogleUrl"));
            propertiesClass.driver.Manage().Window.Maximize();



            //propertiesClass.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("url"));
            //propertiesClass.driver.Manage().Window.Maximize();
            //// Driver.findelementby cssseletor                      ("kdsjfls").                             sendkeys("lskdjfls");  for remind
            ////                      ["cssseletor"-----elementtype]  {("kdsjfls"----webelementvalue)}.        ||||sendkeys(--value"lskdjfls");|||| 
            //customcontrolClass.Entertext(PageObjectsClass.Login_Screen(1), propertytype.CssSelector, ConfigurationManager.AppSettings.Get("email"));
            //customcontrolClass.Entertext(PageObjectsClass.Login_Screen(2), propertytype.CssSelector, ConfigurationManager.AppSettings.Get("password"));
            //customcontrolClass.click(PageObjectsClass.Login_Screen(3), propertytype.CssSelector);
            //delayforClass._delayfor();
            //FunctionalitiesClass.alertBoxFunctonality();
        }
    }
}



