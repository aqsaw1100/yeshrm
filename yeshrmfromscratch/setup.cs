using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeshrmfromscratch
{
    [TestClass]
   public class setup
    {
        [TestInitialize]  
      
        public void TestMethodInitialize()
        {
            Login.initialize();          

        }

       
        [TestMethod]
        [Priority(1)]

        public void TestMethodTitle()
        {

            Functionalities.titleFunctionality();
        }


        [TestMethod]
        [Priority(2)]
        public void TestMethodAddNewDepartment()
        {
            Administrator.addNewDepartment();
        }

        [TestMethod]
        [Priority(3)]
        public void TestMethodAddNewTeam()
        {
            team.addNewTeam();
        }

        [TestMethod]
        [Priority(4)]
        public void TestMethodEmployeeMangement()
        {
            employemanagement.addNewEmployee();
        }


        [TestCleanup]        
       public void teardown()
        {
            delayfor._delayfor(4000);
            Logoutfunctionality _logout = new Logoutfunctionality();
            _logout.Logout();            
            delayfor._delayfor();
            properties.driver.Close();            
            properties.driver.Quit();
        }            
    }
}
