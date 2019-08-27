using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            WattsALoanServiceReference.Employee employee = new WattsALoanServiceReference.Employee();
            employee.EmployeeNumber = TbxEmployeeNumber.Text;
            employee.FirstName = TbxFirstName.Text;
            employee.LastName = TbxLastName.Text;
            employee.Titles = TbxTitles.Text;
            employee.HourlySalary = float.Parse(TbxHourlySalary.Text);

            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            bool result = client.InsertEmployee(employee);
            client.Close();

            string script = @"alert(""Add employee " + TbxEmployeeNumber.Text;
            if (result)
            {
                script += @" success."");";
                TbxEmployeeNumber.Text = "";
                TbxFirstName.Text = "";
                TbxLastName.Text = "";
                TbxTitles.Text = "";
                TbxHourlySalary.Text = "";
            }
            else
            {
                script += @" failed."");";
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
    }
}