using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class EmployeeModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IList<WattsALoanServiceReference.Employee> GetEmployees()
        {
            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            IList<WattsALoanServiceReference.Employee> employees = client.GetEmployees();
            client.Close();
            return employees;
        }

        protected void ListView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                e.Item.Visible = false;
                WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
                client.DeleteEmployee(int.Parse(e.CommandArgument.ToString()));
                client.Close();
            }
            else if (e.CommandName == "Edit")
            {
                string url = "~/Employee/Edit?id=" + e.CommandArgument;
                Response.Redirect(url);
            }
        }
    }
}