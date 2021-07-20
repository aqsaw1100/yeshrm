using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeshrmfromscratch
{
    [TestClass]
   public class EntryPointOfAllTestCasesAndTestMethodsClass
    {
        [TestInitialize]

        public void InitializeOfLoginPage()
        {
            LoginPageClass.LoginPageMethodFeatures();

        }


        //[TestMethod]
        //[Priority(1)]

        //public void Title()
        //{

        //    GetTittleClass.GetTitleClassMethod();
        //}


        //[TestMethod]
        //[Priority(2)]
        //public void AddNewDepartment()
        //{
        //    AdministratorClass.addNewDepartment();
        //}
        [TestMethod]
       // [Priority(3)]
        public void Stackflow()
        {
            StackflowClass.SearchForStackflowLabel();
        }

        //[TestMethod]
        //[Priority(3)]
        //public void TestMethodAddNewTeam()
        //{
        //    teamClass.addNewTeam();
        //}

        //[TestMethod]
        //[Priority(4)]
        //public void TestMethodEmployeeMangement()
        //{
        //    employemanagementClass.addNewEmployee();
        //}


        [TestCleanup]
        public void teardown()
        {
            //delayforClass._delayfor(4000);
            //LogoutfunctionalityClass _logout = new LogoutfunctionalityClass();
            //_logout.Logout();
            //delayforClass._delayfor();
            propertiesClass.driver.Close();
            propertiesClass.driver.Quit();
        }
    }
}
