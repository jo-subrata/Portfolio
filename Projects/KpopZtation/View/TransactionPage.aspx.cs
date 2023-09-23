using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        public List<int> tranHeadID = new List<int>();
        public List<TransactionDetail> tranDetail = new List<TransactionDetail>();

        protected int getUserID()
        {
            String userID = Session["User"].ToString();
            int currUserID = int.Parse(userID);
            return currUserID;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            } else if (!checkUserRole())
            {
                Response.Redirect("../View/Homepage.aspx");
            }
            tranHeadID = TransactionController.getAllTransactionHeaderID(getUserID());
            foreach (var tran in tranHeadID)
            {
                List<TransactionDetail> tranDetTemp = TransactionController.getAllTransactionDetail(tran);
                foreach (var tranDet in tranDetTemp)
                {
                    tranDetail.Add(tranDet);
                }
            }
        }

        protected bool checkUserRole()
        {
            Customer data = AccountController.GetCustomer(getUserID());

            if (data.CustomerRole.Equals("User"))
            {
                return true;
            }
            return false;
        }
    }
}