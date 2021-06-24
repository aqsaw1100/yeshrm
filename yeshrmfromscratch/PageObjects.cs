namespace yeshrmfromscratch
{
  class PageObjects
    {
        static string required_object;

        public static string Login_Screen(int which_object)
        {

            string User_Name = "#inputEmail"; // cssselector for site id
            string password = "#inputPassword"; //  cssselector for usser id
            string Login_Button = "button[type = 'submit']"; // cssselector for password
            string Logout = "//a[normalize-space()='Log Out, Administrator']";//xpath
            switch (which_object)
            {
                case 1:
                    required_object = User_Name;
                    break;
                case 2:
                    required_object = password;
                    break;
                case 3:
                    required_object = Login_Button;
                    break;
                case 4:
                    required_object = Logout;
                    break;

            }
            return required_object;

        }
    }
}