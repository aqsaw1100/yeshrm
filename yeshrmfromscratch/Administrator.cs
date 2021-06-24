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
    class Administrator
    {
        public static void addNewDepartment()
        {

            IWebElement adminLink = customcontrol.findElement("//span[normalize-space()='Administrator']", propertytype.XPath);
            adminLink.Click();//click on administrator link
            customcontrol.click("#ContentPlaceHolder3_AdminMenu1_lnkDepartment", propertytype.CssSelector);//click on department link
            customcontrol.click("#ContentPlaceHolder3_ContentPlaceHolder1_btnCreateDepartment", propertytype.CssSelector);//create new department in department module
            customcontrol.Entertext("#ContentPlaceHolder3_ContentPlaceHolder1_txtDepartmentName", propertytype.CssSelector, "IT");//department field Name
            IWebElement element = customcontrol.findElement("#ContentPlaceHolder3_ContentPlaceHolder1_DDLStatus", propertytype.CssSelector);//department field Status
            SelectElement select = new SelectElement(element);
            select.SelectByValue("1");// status field ends
            customcontrol.Entertext("//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtOwner']", propertytype.XPath, "Jalil");// department field autoSuggest Box
            delayfor._delayfor();
            customcontrol.click("//a[normalize-space()='Jalil Ahmad(Operations)']", propertytype.XPath);//autoSuggest box Ends.


            customcontrol.click("//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtStartDate']", propertytype.XPath);//Departmen field Date 
            customcontrol.click("//td[normalize-space()='23']", propertytype.XPath);
            delayfor._delayfor();
            customcontrol.click("//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtEndDate']", propertytype.XPath);
            customcontrol.click("//td[@class='day'][normalize-space()='30']", propertytype.XPath);
            delayfor._delayfor();
            customcontrol.click("//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_btnSave']", propertytype.XPath);
            delayfor._delayfor();
            
        }

    }


}







