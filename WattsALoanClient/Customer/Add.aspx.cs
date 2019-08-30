using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class CustomerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            WattsALoanServiceReference.Customer customer = new WattsALoanServiceReference.Customer();
            customer.DateCreated = DateTime.Now;
            customer.FullName = TbxFullName.Text;
            customer.BillingAddress = TbxAddress.Text;
            customer.BillingCity = TbxCity.Text;
            customer.BillingState = TbxState.Text;
            customer.BillingZIPCide = TbxZipCide.Text;
            customer.EmailAddress = TbxEmail.Text;

            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanClient.WattsALoanServiceReference.WattsALoanServiceClient();
            bool result = client.InsertCustomer(customer);
            client.Close();

            string script = @"alert(""Add customer " + TbxFullName.Text;
            if (result)
            {
                script += @" success."");";
                TbxFullName.Text = "";
                TbxAddress.Text = "";
                TbxCity.Text = "";
                TbxState.Text = "";
                TbxZipCide.Text = "";
                TbxEmail.Text = "";
            }
            else
            {
                script += @" failed."");";
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
}