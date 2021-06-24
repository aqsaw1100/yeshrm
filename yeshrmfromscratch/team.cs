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
    class team
   
    {
        public static void addNewTeam()
        {
            IWebElement adminLink = customcontrol.findElement("//span[normalize-space()='Administrator']", propertytype.XPath);

            adminLink.Click();//click on administrator link
            customcontrol.click("#ContentPlaceHolder3_AdminMenu1_lnkTeam", propertytype.CssSelector);//click on department link
            customcontrol.click("#ContentPlaceHolder3_ContentPlaceHolder1_btnCreateTeam", propertytype.CssSelector);
            customcontrol.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtTeamName", propertytype.CssSelector, "cdc");
            customcontrol.click("#ContentPlaceHolder3_ContentPlaceHolder1_btnSave",propertytype.CssSelector);
            delayfor._delayfor();

        }



    }



}
