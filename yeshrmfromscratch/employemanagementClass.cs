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
   class employemanagementClass

    {
        public static void addNewEmployee()
        {
            IWebElement managelink = customcontrolClass.findElement("//span[normalize-space()='Manage']", propertytype.XPath);
            managelink.Click();
            customcontrolClass.click("#ContentPlaceHolder3_AdminMenu1_lnkUsers", propertytype.CssSelector);
            customcontrolClass.click("#ContentPlaceHolder3_ContentPlaceHolder1_btnCreateUser", propertytype.CssSelector);
            delayforClass._delayfor();
            customcontrolClass.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtFirstName", propertytype.CssSelector,"jade");
            customcontrolClass.Entertext("# ContentPlaceHolder3_ContentPlaceHolder1_txtLastName", propertytype.CssSelector, "hale");
            IWebElement element = customcontrolClass.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_ddlDept", propertytype.CssSelector);
            SelectElement select = new SelectElement(element);
            select.SelectByValue("46");
            IWebElement elementEmployeeManagement = customcontrolClass.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_ddlDesig", propertytype.CssSelector);
            SelectElement selectEmployeeManagement = new SelectElement(elementEmployeeManagement);
            select.SelectByValue("43");
            IWebElement elementEmployeeManagement2 = customcontrolClass.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_ddlRepTo", propertytype.CssSelector);
            SelectElement selectEmployeeManagement2 = new SelectElement(elementEmployeeManagement2);
            select.SelectByValue("30359");
            customcontrolClass.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtEmailAddress", propertytype.CssSelector, "aqsawh123@gmail.com");
            IWebElement elementEmployeeManagement3 = customcontrolClass.findElement("input[value='Choose a Team...']", propertytype.CssSelector);
            
            SelectElement selectteam= new SelectElement(elementEmployeeManagement3);
            select.SelectByIndex(0);
            IWebElement elementEmployeeManagement4 = customcontrolClass.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_ddlShift", propertytype.CssSelector);
            SelectElement selectshift = new SelectElement(elementEmployeeManagement4);
            select.SelectByValue("1");
            ////customcontrol.Entertext("//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtOwner']", propertytype.XPath, " Houston");
            ////delayfor._delayfor();
            ////customcontrol.click("//a[normalize-space()='Jalil Ahmad(Operations)']", propertytype.XPath);//autoSuggest box Ends.
            //customcontrol.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtMetricId", propertytype.CssSelector, "123");
            //customcontrol.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtContactMobile", propertytype.CssSelector, "0987654321");
            //customcontrol.click("//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtDOB']", propertytype.XPath);
            //customcontrol.click("//td[normalize-space()='23']", propertytype.XPath);
            //delayfor._delayfor();
            //customcontrol.click("//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtEndDate']", propertytype.XPath);
            //customcontrol.click("//td[@class='day'][normalize-space()='30']", propertytype.XPath);





        }







    }





}
