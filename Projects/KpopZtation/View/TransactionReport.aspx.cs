using Kpop_Ztation.Dataset;
using Kpop_Ztation.Handler;
using Kpop_Ztation.Model;
using Kpop_Ztation.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("../View/LoginPage.aspx");
            }
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            KpopZtationDataset data = getData(TransactionHandler.getTransaction());
            report.SetDataSource(data);
        }

        private KpopZtationDataset getData(List<TransactionHeader> transaction)
        {
            KpopZtationDataset data = new KpopZtationDataset();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;


            foreach (TransactionHeader th in transaction)
            {


                int subTotal = 0;
                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    var Detail_Row = detailTable.NewRow();
                    Detail_Row["TransactionID"] = td.TransactionID;
                    Detail_Row["AlbumName"] = td.Album.AlbumName;
                    Detail_Row["Qty"] = td.Qty;
                    Detail_Row["AlbumPrice"] = td.Qty * td.Album.AlbumPrice;
                    subTotal += td.Qty * td.Album.AlbumPrice;
                    Detail_Row["SubTotal"] = subTotal;
                    detailTable.Rows.Add(Detail_Row);
                }

                var Header_Row = headerTable.NewRow();
                Header_Row["TransactionID"] = th.TransactionID;
                Header_Row["CustomerID"] = th.CustomerID;
                Header_Row["TransactionDate"] = th.TransactionDate;
                Header_Row["GrandTotal"] = subTotal;
                headerTable.Rows.Add(Header_Row);
            }

            return data;
        }
    }
}