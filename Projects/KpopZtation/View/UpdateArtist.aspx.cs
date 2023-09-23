using Kpop_Ztation.Controller;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }
            if(!IsPostBack)
            {
                if(Request.QueryString["artistID"] != null)
                {
                    string artistID = Request.QueryString["artistID"];
                    int ID = int.Parse(artistID);
                    Artist Artist = ArtistRepository.GetArtistByID(ID);

                    artistImage.ImageUrl = Artist.ArtistImage;
                    artistNameTxt.Text = Artist.ArtistName;
                }
            }
        }

        protected void UpdateArtistButton_Click(object sender, EventArgs e)
        {
            string artistID = Request.QueryString["artistID"];
            int ID = int.Parse(artistID);

            string Name = artistNameTxt.Text;
            string Filename = ImageUpload.PostedFile.FileName;
            string Filepath = "/Images/Artist/" + ImageUpload.FileName;
            string imageExtension = Path.GetExtension(Filename).ToLower();
            int fileSize = ImageUpload.PostedFile.ContentLength;                      

            string labelText = ArtistController.UpdateArtist(ID, Name, Filepath, imageExtension, fileSize);
            errorTxt.Text = labelText;

            if(labelText.Equals("Artist succesfully updated"))
            {
                ImageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/Artist/") + Filename);
            }
        }
    }
}