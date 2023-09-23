using Kpop_Ztation.Handler;
using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class AccountController
    {
        public static String CreateAccount(String Name, String Email, String Password, String Gender, String Address)
        {
            if(Functions.CheckEmpty(Name) || Functions.CheckEmpty(Email) || Functions.CheckEmpty(Password) || Functions.CheckEmpty(Gender) || Functions.CheckEmpty(Address))
            {
                return "Please fill all fields";
            }

            if(Functions.CheckName(Name))
            {
                return "Name must be between 5-50 characters";
            }

            if (Functions.CheckEmailFormat(Email) || Functions.CheckEmailUnique(Email))
            {
                return "Email must be in the correct format and has not been used before.";
            }

            if(Gender.Equals(""))
            {
                return "Gender option must be selected";
            }

            if(Functions.CheckAddress(Address))
            {
                return "Address must end with 'Street'";
            }

            if(Functions.CheckPassword(Password))
            {
                return "Password must be alphanumeric";
            }
            AccountHandler.CreateAccount(Name, Email, Password, Gender, Address);
            return "Account Successfully Created.";
        }

        public static bool Login(String Email, String Password)
        {
            if(Email.Equals("") || Password.Equals(""))
            {
                return false;
            }
            return true;
        }
        
        public static String UpdateProfile(int ID, String Name, String Email, String Password, String Gender, String Address)
        {
            if(Functions.CheckEmpty(Name) || Functions.CheckEmpty(Email) || Functions.CheckEmpty(Password) || Functions.CheckEmpty(Gender) || Functions.CheckEmpty(Address))
            {
                return "Please fill all fields";
            }

            if (Functions.CheckName(Name))
            {
                return "Name must be between 5-50 characters";
            }

            if (Functions.CheckEmailFormat(Email))
            {
                return "Email must be in the correct format and has not been used before.";
            }

            if (Gender.Equals(""))
            {
                return "Gender option must be selected";
            }

            if (Functions.CheckAddress(Address))
            {
                return "Address must end with 'Street'";
            }

            if (Functions.CheckPassword(Password))
            {
                return "Password must be alphanumeric";
            }
            AccountHandler.UpdateProfile(ID, Name, Email, Password, Gender, Address);
            return "Account successfully updated.";
        }

        public static Customer GetCustomer(int id)
        {
            return AccountHandler.GetUser(id);
        }
    }
}