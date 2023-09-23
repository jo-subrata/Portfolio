using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class LoginPage : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("../View/Homepage.aspx");
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {            
            string Email = emailTxt.Text;
            string Password = passwordTxt.Text;
            if (AccountController.Login(Email, Password))
            {
                Customer u = AccountRepository.GetUserByEmail(Email, Password);                
                if(emailTxt.Text.Equals("") || passwordTxt.Text.Equals(""))
                {
                    errorText.Text = "Please fill all empty fields";
                }
                else if (u == null)
                {
                    errorText.Text = "User does not exist";
                }
                else
                {
                    String CustomerID = u.CustomerID.ToString();
                    Session["User"] = CustomerID;
                    Response.Redirect("../View/Homepage.aspx");
                }
            }
        }

        protected void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            HttpCookie userCookie = new HttpCookie("userCookie");
            userCookie.Value = emailTxt.Text.ToString();
            userCookie.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(userCookie);
        }
    }
}