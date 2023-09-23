using Kpop_Ztation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Redirect("../View/Homepage.aspx");
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string Name = nameTxt.Text;
            string Email = emailTxt.Text;
            string Gender = GenderSelect.SelectedItem.Value.ToString();
            string Address = addressTxt.Text;
            string Password = passwordTxt.Text;            

            String labelText = AccountController.CreateAccount(Name, Email, Password, Gender, Address);
            errorTxt.Text = labelText;
        }
    }
}