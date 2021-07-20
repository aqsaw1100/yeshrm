namespace yeshrmfromscratch
{
  class PageObjectsClass
    {       
        static string required_object;
        public static string GoogleSearchBarVariable = "input[title='Search']";
        public static string webelementvalueofStackoverflow = "//span[normalize-space()='Stack Overflow']";
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

       

        public static string PageObjectsForAlertBox(int which_object)
        {
            string AlertboxVisible = "//div[@class='sweet-alert showSweetAlert visible']";
            string AlertBoxConfirmButton = "//button[@class='confirm']";
            switch(which_object)
            {
                case 1:
                    required_object = AlertboxVisible;
                    break;
                case 2:
                    required_object = AlertBoxConfirmButton;
                    break;

            }
            return required_object;

        }

        public static string AddNewDepartment(int which_object)
        {
            string ClickAdministrationMenu = "//span[normalize-space()='Administrator']";
            string ClickDepartmentLink = "#ContentPlaceHolder3_AdminMenu1_lnkDepartment";
            string ClickCreatNewDepartment= "#ContentPlaceHolder3_ContentPlaceHolder1_btnCreateDepartment";
            string DepartmentNameInputField = "#ContentPlaceHolder3_ContentPlaceHolder1_txtDepartmentName";
            string DepartmentDropDownList = "//select[@id='ContentPlaceHolder3_ContentPlaceHolder1_DDLStatus']";
            string OwnerNameInputField = "//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtOwner']";
            string AutoSuggestBox = "//a[normalize-space()='Jalil Ahmad(Operations)']";
            string StartDate = "//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtStartDate']";
            string SelectStartDateValue = "//td[normalize-space()='23']";
            string EndDate = "//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_txtEndDate']";
            string SelectEndDateValue = "//td[@class='day'][normalize-space()='30']";
            string SaveButton = "//input[@id='ContentPlaceHolder3_ContentPlaceHolder1_btnSave']";

            switch (which_object)
            {
                case 1:
                    required_object = ClickAdministrationMenu;
                    break;
                case 2:
                    required_object = ClickDepartmentLink;
                    break;
                case 3:
                    required_object = ClickCreatNewDepartment;
                    break;                
                case 4:
                    required_object = DepartmentNameInputField;
                    break;
                case 5:
                    required_object = DepartmentDropDownList;
                    break;
                case 6:
                    required_object = OwnerNameInputField;
                    break;
                case 7:
                    required_object = AutoSuggestBox;
                    break;
                case 8:
                    required_object = StartDate;
                    break;
                case 9:
                    required_object = SelectStartDateValue;
                    break;
                case 10:
                    required_object = EndDate;
                    break;
                case 11:
                    required_object = SelectEndDateValue;
                    break;
                case 12:
                    required_object = SaveButton;
                    break;
            }
            return required_object;
        }
    }

}