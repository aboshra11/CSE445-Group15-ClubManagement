using System;

namespace ClubManagementWeb
{
    public partial class TryIt_Stock : System.Web.UI.Page
    {
        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            StockService service = new StockService();
            lblResult.Text = service.GetStockPrice(txtSymbol.Text);
        }
    }
}