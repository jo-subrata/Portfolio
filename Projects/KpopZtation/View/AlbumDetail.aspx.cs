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
    public partial class AlbumDetail : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["albumId"] != null)
            {
                string ID = Request.QueryString["albumId"];
                int albumID = int.Parse(ID);
                Album album = AlbumRepository.GetAlbumByAlbumID(albumID);

                albumImage.ImageUrl = album.AlbumImage;
                albumTitle.Text = "Album Title: " + album.AlbumName;
                albumDesc.Text = album.AlbumDescription;
                albumPrice.Text = "Price: Rp." + album.AlbumPrice;
                albumStock.Text = "Available stock: " + album.AlbumStock;
            }
            else
            {
                Response.Redirect("../View/Homepage.aspx");
            }
        }

        protected void addCart_Click(object sender, EventArgs e)
        {
            int albumID = int.Parse(Request.QueryString["albumId"]);
            int userID = int.Parse(Session["User"].ToString());

            int cartAmount = int.Parse(purchaseAmount.Text);
            
            string labelTxt = AlbumController.AddToCart(userID, albumID, cartAmount);
            errorTxt.Text = labelTxt;

        }

        public bool checkRole()
        {
            if (Session["User"] == null)
            {
                return false;
            }
            else
            {
                int ID = int.Parse(Session["User"].ToString());
                Customer data = AccountController.GetCustomer(ID);

                if (data.CustomerRole.Equals("Admin"))
                {
                    return true;
                }
                return false;
            }
        }
    }
}