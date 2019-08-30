using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class CustomerModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IList<WattsALoanServiceReference.Customer> GetCustomers()
        {
            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            IList<WattsALoanServiceReference.Customer> customers = client.GetCustomers();
            client.Close();
            return customers;
        }

        protected void ListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                string url = "~/Customer/Edit?id=" + e.CommandArgument;
                Response.Redirect(url);
            }
        }
    }
}