using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class Loan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            WattsALoanServiceReference.Loan loan = new WattsALoanServiceReference.Loan();
            loan.LoanType = TbxLoanType.Text;

            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            bool result = client.InsertLoan(loan);
            client.Close();

            string script = @"alert(""Add loan type " + TbxLoanType.Text;
            if (result)
            {
                script += @" success."");";
                TbxLoanType.Text = "";
            }
            else
            {
                script += @" failed."");";
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
}