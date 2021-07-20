using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace yeshrmfromscratch
{
    class teamClass
   
    {
        public static void addNewTeam()
        {
            IWebElement adminLink = customcontrolClass.findElement("//span[normalize-space()='Administrator']", propertytype.XPath);

            adminLink.Click();//click on administrator link
            customcontrolClass.click("#ContentPlaceHolder3_AdminMenu1_lnkTeam", propertytype.CssSelector);//click on department link
            customcontrolClass.click("#ContentPlaceHolder3_ContentPlaceHolder1_btnCreateTeam", propertytype.CssSelector);
            customcontrolClass.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtTeamName", propertytype.CssSelector, "cdc");
            customcontrolClass.click("#ContentPlaceHolder3_ContentPlaceHolder1_btnSave",propertytype.CssSelector);
            delayforClass._delayfor();

        }



    }



}
