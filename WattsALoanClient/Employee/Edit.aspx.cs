using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class EmployeeEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
                WattsALoanServiceReference.Employee employee = client.GetEmployee(int.Parse(Request.QueryString["id"]));
                client.Close();

                TbxEmployeeID.Text = employee.EmployeeID.ToString();
                TbxEmployeeNumber.Text = employee.EmployeeNumber;
                TbxFirstName.Text = employee.FirstName;
                TbxLastName.Text = employee.LastName;
                TbxTitles.Text = employee.Titles;
                TbxHourlySalary.Text = employee.HourlySalary.ToString();
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            WattsALoanServiceReference.Employee employee = new WattsALoanServiceReference.Employee();
            employee.EmployeeID = int.Parse(TbxEmployeeID.Text);
            employee.EmployeeNumber = TbxEmployeeNumber.Text;
            employee.FirstName = TbxFirstName.Text;
            employee.LastName = TbxLastName.Text;
            employee.Titles = TbxTitles.Text;
            employee.HourlySalary = float.Parse(TbxHourlySalary.Text);

            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            bool result = client.UpdateEmployee(employee);
            client.Close();

            string script = @"alert(""Edit employee " + TbxEmployeeNumber.Text;
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