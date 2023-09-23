using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;

namespace Kpop_Ztation.View
{
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                // Retrieve the album ID from the query string
                if (Request.QueryString["albumID"] != null)
                {
                    string ID= Request.QueryString["albumID"];
                    int albumID = int.Parse(ID);
                    LoadAlbum(albumID);
                }
            }
        }

        protected void LoadAlbum(int albumID)
        {
            // Get the album from the repository based on the ID
            // Taruh di controller?
            Album album = AlbumRepository.GetAlbumByAlbumID(albumID);

            if (album != null)
            {
                // Populate the form fields with the album data                
                albumImage.ImageUrl = album.AlbumImage.ToString();
                txtAlbumName.Text = album.AlbumName;
                txtDescription.Text = album.AlbumDescription;
                txtPrice.Text = album.AlbumPrice.ToString();
                txtStock.Text = album.AlbumStock.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve the album ID
            string ID = Request.QueryString["albumID"];
            int albumID = int.Parse(ID);

            string Name = txtAlbumName.Text;
            string Desc = txtDescription.Text;
            int Price = int.Parse(txtPrice.Text);
            int Stock = int.Parse(txtStock.Text);

            string Filename = ImageUpload.PostedFile.FileName;
            string Filepath = "/Images/Album/" + ImageUpload.FileName;
            string imageExtension = Path.GetExtension(Filename).ToLower();
            int fileSize = ImageUpload.PostedFile.ContentLength;            

            // Save the updated album to the repository
            string labelTxt = AlbumController.UpdateAlbum(albumID, Name, Desc, Price, Stock, Filepath, imageExtension, fileSize);
            lblMessage.Text = "Album updated successfully.";

            if(labelTxt.Equals("Album succesfully updated"))
            {
                ImageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/Album/") + Filename);
            }
        }
    }
}