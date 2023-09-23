using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string Email = emailTxt.Text;
            string Password = passwordTxt.Text;
            if(AccountController.Login(Email, Password))
            {
                Customer u = AccountRepository.GetUser(Email, Password);
                if (u == null)
                {
                    errorText.Text = "User does not exist";
                }
                else
                {
                    Response.Redirect("../Homepage.aspx");
                }
            }
        }
    }
}