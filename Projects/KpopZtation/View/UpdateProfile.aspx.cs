using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;

namespace Kpop_Ztation.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                string UserID = Session["User"].ToString();
                int ID = int.Parse(UserID);
                Customer u = AccountRepository.GetUserByID(ID);

                nameTxt.Text = u.CustomerName;
                emailTxt.Text = u.CustomerEmail;
                GenderSelect.SelectedValue = u.CustomerGender;
                addressTxt.Text = u.CustomerAddress;
                passwordTxt.Text = u.CustomerPassword;
            }
        }

        protected void updateProfile_Click(object sender, EventArgs e)
        {
            string UserID = Session["User"].ToString();
            int ID = int.Parse(UserID);

            string Name = nameTxt.Text;
            string Email = emailTxt.Text;
            string Gender = GenderSelect.SelectedItem.Value.ToString();
            string Address = addressTxt.Text;
            string Password = passwordTxt.Text;

            String labelText = AccountController.UpdateProfile(ID, Name, Email, Password, Gender, Address);
            errorTxt.Text = labelText;

        }
    }
}