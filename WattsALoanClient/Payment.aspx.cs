using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WattsALoanClient
{
    public partial class Payment : System.Web.UI.Page
    {
        protected Dictionary<int, string> loanTypeNames;

        protected void LoadTypeNames_Init()
        {
            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            IList<WattsALoanServiceReference.LoanType> types = client.GetLoanTypes();

            loanTypeNames = new Dictionary<int, string>();
            foreach (WattsALoanServiceReference.LoanType type in types)
                loanTypeNames.Add(type.LoanTypeID, type.LoanTypeName);

            client.Close();
        }

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

                if (loanTypeNames == null)
                    LoadTypeNames_Init();

                IList<WattsALoanServiceReference.LoanAllocation> loanAllocations = client.GetLoanAllocations(int.Parse(DdlCustomer.SelectedValue));

                DataTable allocationTable = new DataTable();
                allocationTable.Columns.Add(new DataColumn("LoanAllocationNameField", typeof(string)));
                allocationTable.Columns.Add(new DataColumn("LoanAllocationIDField", typeof(int)));

                foreach (WattsALoanServiceReference.LoanAllocation loanAllocation in loanAllocations)
                    allocationTable.Rows.Add(CreateDataRow(loanTypeNames[loanAllocation.LoanTypeID] + " Amount:" + loanAllocation.LoanAmount + " Rate:" + loanAllocation.InterestRate + " Periods:" + loanAllocation.Periods, loanAllocation.LoanAllocationID, allocationTable));

                DdlLoanAllocation.DataSource = allocationTable;
                DdlLoanAllocation.DataTextField = "LoanAllocationNameField";
                DdlLoanAllocation.DataValueField = "LoanAllocationIDField";
                DdlLoanAllocation.DataBind();

                client.Close();
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            WattsALoanServiceReference.Payment payment = new WattsALoanServiceReference.Payment();
            payment.PaymentDate = DateTime.Now;
            payment.EmployeeID = int.Parse(DdlEmployee.SelectedValue);
            payment.LoanAllocationID = int.Parse(DdlLoanAllocation.SelectedValue);
            payment.PaymentAmount = double.Parse(TbxPaymentAmount.Text);

            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();
            bool result = client.RecordPayment(payment);
            client.Close();

            string script = @"alert(""Record payment " + DdlEmployee.SelectedItem.Text + " " + DdlLoanAllocation.SelectedItem.Text;
            if (result)
            {
                script += @" success."");";
                DdlEmployee.SelectedIndex = 0;
                DdlCustomer.SelectedIndex = 0;
                TbxPaymentAmount.Text = "";
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

        protected void DdlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            WattsALoanServiceReference.WattsALoanServiceClient client = new WattsALoanServiceReference.WattsALoanServiceClient();

            if (loanTypeNames == null)
                LoadTypeNames_Init();

            IList<WattsALoanServiceReference.LoanAllocation> loanAllocations = client.GetLoanAllocations(int.Parse(DdlCustomer.SelectedValue));

            DataTable allocationTable = new DataTable();
            allocationTable.Columns.Add(new DataColumn("LoanAllocationNameField", typeof(string)));
            allocationTable.Columns.Add(new DataColumn("LoanAllocationIDField", typeof(int)));

            foreach (WattsALoanServiceReference.LoanAllocation loanAllocation in loanAllocations)
                allocationTable.Rows.Add(CreateDataRow(loanTypeNames[loanAllocation.LoanTypeID] + " Amount:" + loanAllocation.LoanAmount + " Rate:" + loanAllocation.InterestRate + " Periods:" + loanAllocation.Periods, loanAllocation.LoanAllocationID, allocationTable));

            DdlLoanAllocation.DataSource = allocationTable;
            DdlLoanAllocation.DataTextField = "LoanAllocationNameField";
            DdlLoanAllocation.DataValueField = "LoanAllocationIDField";
            DdlLoanAllocation.DataBind();

            client.Close();
        }
    }
}