using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using Kpop_Ztation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class AccountHandler
    {        
        public static void CreateAccount(String Name, String Email, String Password, String Gender, String Address)
        {
            Customer User = AccountFactory.CreateAccount(Name, Email, Password, Gender, Address);

            AccountRepository.CreateAccount(User);
            return;
        }
        public static void UpdateProfile(int ID, String Name, String Email, String Password, String Gender, String Address)
        {            
            Customer User = AccountFactory.UpdateProfile(ID, Name, Email, Password, Gender, Address);

            AccountRepository.UpdateProfile(User);            
            return;
        }
        public static Customer GetEmail(String Email)
        {
            return AccountRepository.GetEmail(Email);
            
        }

        public static Customer GetUser(int ID)
        {
            return AccountRepository.GetUserByID(ID);
        }
    }
}