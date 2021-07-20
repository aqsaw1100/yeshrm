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
    class AdministratorClass
    {
        public static void addNewDepartment()
        {

            IWebElement adminLink = customcontrolClass.findElement(PageObjectsClass.AddNewDepartment(1), propertytype.XPath);
            adminLink.Click();//click on administrator link
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(2), propertytype.CssSelector);//click on department link
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(3), propertytype.CssSelector);//create new department in department module
            customcontrolClass.Entertext(PageObjectsClass.AddNewDepartment(4), propertytype.CssSelector, "IT");//department field Name          
            IWebElement element = customcontrolClass.findElement(PageObjectsClass.AddNewDepartment(5), propertytype.XPath);//department field Status
            SelectElement select = new SelectElement(element);
            select.SelectByValue("1");// status field ends           
            customcontrolClass.Entertext(PageObjectsClass.AddNewDepartment(6), propertytype.XPath, "Jalil");// department field autoSuggest Box
            delayforClass._delayfor();              
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(7), propertytype.XPath);//autoSuggest box Ends.
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(8), propertytype.XPath);//Departmen field Date 
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(9), propertytype.XPath);
            delayforClass._delayfor();
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(10), propertytype.XPath);
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(11), propertytype.XPath);
            delayforClass._delayfor();
            customcontrolClass.click(PageObjectsClass.AddNewDepartment(12), propertytype.XPath);
            delayforClass._delayfor();
            Console.WriteLine("New Department is Successfully Created");
            customcontrolClass.click(GlobalVariablesClass.GlobalVariableDashboard, propertytype.XPath);
            
        }

    }


}







