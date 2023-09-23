using Kpop_Ztation.Controller;
using Kpop_Ztation.Handler;
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
    public partial class Homepage : System.Web.UI.Page
    {
        KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        private void updateListView()
        {
            ArtistListView.DataSource = ArtistRepository.GetAllArtist();
            ArtistListView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            updateListView();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/ArtistDetail.aspx");
        }

        protected void InsertArtistButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/InsertArtist.aspx");
        }

        protected void ArtistGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("../View/ArtistDetail.aspx");
        }
        public bool checkRole()
        {
            if(Session["User"] == null)
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

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            LinkButton deleteButton = (LinkButton)sender;
            string ID = deleteButton.CommandArgument;
            int artistID = int.Parse(ID);

            if(AlbumHandler.CheckArtistAlbum(artistID))
            {
                AlbumHandler.DeleteAllAlbum(artistID);
                db.SaveChanges();
            }

            ArtistHandler.DeleteArtist(artistID);
            db.SaveChanges();
            updateListView();
        }        
    }
}