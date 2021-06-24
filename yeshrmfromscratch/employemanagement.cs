using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeshrmfromscratch
{
   class employemanagement

    {
        public static void addNewEmployee()
        {
            IWebElement managelink = customcontrol.findElement("//span[normalize-space()='Manage']", propertytype.XPath);
            managelink.Click();
            customcontrol.click("#ContentPlaceHolder3_AdminMenu1_lnkUsers", propertytype.CssSelector);
            customcontrol.click("#ContentPlaceHolder3_ContentPlaceHolder1_btnCreateUser", propertytype.CssSelector);
            delayfor._delayfor();
            customcontrol.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtFirstName", propertytype.CssSelector,"jade");
            customcontrol.Entertext("# ContentPlaceHolder3_ContentPlaceHolder1_txtLastName", propertytype.CssSelector, "hale");
            IWebElement element = customcontrol.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_ddlDept", propertytype.CssSelector);
            SelectElement select = new SelectElement(element);
            select.SelectByValue("46");
            IWebElement elementEmployeeManagement = customcontrol.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_ddlDesig", propertytype.CssSelector);
            SelectElement selectEmployeeManagement = new SelectElement(elementEmployeeManagement);
            select.SelectByValue("43");
            IWebElement elementEmployeeManagement2 = customcontrol.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_ddlRepTo", propertytype.CssSelector);
            SelectElement selectEmployeeManagement2 = new SelectElement(elementEmployeeManagement2);
            select.SelectByValue("30359");
            customcontrol.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtEmailAddress", propertytype.CssSelector, "aqsawh123@gmail.com");
            IWebElement elementEmployeeManagement3 = customcontrol.findElement("input[value='Choose a Team...']", propertytype.CssSelector);
            
            SelectElement selectteam= new SelectElement(elementEmployeeManagement3);
            select.SelectByIndex(0);




        }







    }





}
