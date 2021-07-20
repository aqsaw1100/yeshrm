using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeshrmfromscratch
{
    class LogoutfunctionalityClass
    {
        public void Logout()
        {
          
            customcontrolClass.click(PageObjectsClass.Login_Screen(4), propertytype.XPath);
            Console.WriteLine("user is successfully logged out and landed on Hrm Login Page");

        }

    }

}