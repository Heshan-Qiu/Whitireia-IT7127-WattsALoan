using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class LoanAllocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
                IList<WattsALoanServiceReference.Employee> employees = client.GetEmployees();

                DataTable employeeTable = new DataTable();
                employeeTable.Columns.Add(new DataColumn("EmployeeNameField", typeof(string)));
                employeeTable.Columns.Add(new DataColumn("EmployeeIDField", typeof(int)));

                foreach (WattsALoanServiceReference.Employee employee in employees)
                    employeeTable.Rows.Add(CreateDataRow(employee.FirstName + " " + employee.LastName, employee.EmployeeID, employeeTable));

                DdlEmployee.DataSource = employeeTable;
                DdlEmployee.DataTextField = "EmployeeNameField";
                DdlEmployee.DataValueField = "EmployeeIDField";
                DdlEmployee.DataBind();

                IList<WattsALoanServiceReference.Customer> customers = client.GetCustomers();

                DataTable customerTable = new DataTable();
                customerTable.Columns.Add(new DataColumn("CustomerNameField", typeof(string)));
                customerTable.Columns.Add(new DataColumn("CustomerIDField", typeof(int)));

                foreach (WattsALoanServiceReference.Customer customer in customers)
                    customerTable.Rows.Add(CreateDataRow(customer.FullName, customer.CustomerID, customerTable));

                DdlCustomer.DataSource = customerTable;
                DdlCustomer.DataTextField = "CustomerNameField";
                DdlCustomer.DataValueField = "CustomerIDField";
                DdlCustomer.DataBind();

                IList<WattsALoanServiceReference.LoanType> loanTypes = client.GetLoanTypes();

                DataTable loanTypeTable = new DataTable();
                loanTypeTable.Columns.Add(new DataColumn("LoanTypeNameField", typeof(string)));
                loanTypeTable.Columns.Add(new DataColumn("LoanTypeIDField", typeof(int)));

                foreach (WattsALoanServiceReference.LoanType loanType in loanTypes)
                    loanTypeTable.Rows.Add(CreateDataRow(loanType.LoanTypeName, loanType.LoanTypeID, loanTypeTable));

                DdlLoanType.DataSource = loanTypeTable;
                DdlLoanType.DataTextField = "LoanTypeNameField";
                DdlLoanType.DataValueField = "LoanTypeIDField";
                DdlLoanType.DataBind();

                client.Close();
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            WattsALoanServiceReference.LoanAllocation loanAllocation = new WattsALoanServiceReference.LoanAllocation();
            loanAllocation.DatePrepared = DateTime.Now;
            loanAllocation.EmployeeID = int.Parse(DdlEmployee.SelectedValue);
            loanAllocation.CustomerID = int.Parse(DdlCustomer.SelectedValue);
            loanAllocation.AccountNumber = TbxAccountNumber.Text;
            loanAllocation.LoanTypeID = int.Parse(DdlLoanType.SelectedValue);
            loanAllocation.LoanAmount = double.Parse(TbxLoanAmount.Text);
            loanAllocation.InterestRate = double.Parse(TbxInterestRate.Text);
            loanAllocation.Periods = double.Parse(TbxPeriods.Text);

            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            bool result = client.InsertLoanAllocation(loanAllocation);
            client.Close();

            string script = @"alert(""Add customer " + DdlEmployee.SelectedItem.Text + " " + DdlLoanType.SelectedItem.Text + " loan allocation";
            if (result)
            {
                script += @" success."");";
                DdlEmployee.SelectedIndex = 0;
                DdlCustomer.SelectedIndex = 0;
                TbxAccountNumber.Text = "";
                DdlLoanType.SelectedIndex = 0;
                TbxLoanAmount.Text = "";
                TbxInterestRate.Text = "";
                TbxPeriods.Text = "";
            }
            else
            {
                script += @" failed."");";
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }

        private DataRow CreateDataRow(string text, int value, DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr[0] = text;
            dr[1] = value;
            return dr;
        }
    }
}