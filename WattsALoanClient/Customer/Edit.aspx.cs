using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class CustomerEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
                WattsALoanServiceReference.Customer customer = client.GetCustomer(int.Parse(Request.QueryString["id"]));
                client.Close();

                TbxCustomerID.Text = customer.CustomerID.ToString();
                TbxFullName.Text = customer.FullName;
                TbxAddress.Text = customer.BillingAddress;
                TbxCity.Text = customer.BillingCity;
                TbxState.Text = customer.BillingState;
                TbxZipCide.Text = customer.BillingZIPCide;
                TbxEmail.Text = customer.EmailAddress;
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            WattsALoanServiceReference.Customer customer = new WattsALoanServiceReference.Customer();
            customer.CustomerID = int.Parse(TbxCustomerID.Text);
            customer.DateCreated = DateTime.Now;
            customer.FullName = TbxFullName.Text;
            customer.BillingAddress = TbxAddress.Text;
            customer.BillingCity = TbxCity.Text;
            customer.BillingState = TbxState.Text;
            customer.BillingZIPCide = TbxZipCide.Text;
            customer.EmailAddress = TbxEmail.Text;

            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            bool result = client.UpdateCustomer(customer);
            client.Close();

            string script = @"alert(""Edit customer " + TbxFullName.Text;
            if (result)
            {
                script += @" success."");";
            }
            else
            {
                script += @" failed."");";
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
}