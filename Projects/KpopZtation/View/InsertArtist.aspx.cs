using Kpop_Ztation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Kpop_Ztation.View
{
    public partial class InsertArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }
        }

        protected void InsertArtistButton_Click(object sender, EventArgs e)
        {
            string Name = artistNameTxt.Text;
            string Filename = ImageUpload.PostedFile.FileName;
            string Filepath = "/Images/Artist/" + ImageUpload.FileName;
            string imageExtension = Path.GetExtension(Filename).ToLower();
            int fileSize = ImageUpload.PostedFile.ContentLength;
           
            String labelText = ArtistController.CreateArtist(Name, Filepath, imageExtension, fileSize);
            errorTxt.Text = labelText;

            if (labelText.Equals("Artist Succesfully Added"))
            {
                ImageUpload.PostedFile.SaveAs(Server.MapPath("~/Images/Artist/") + Filename);
            }
        }
    }
}