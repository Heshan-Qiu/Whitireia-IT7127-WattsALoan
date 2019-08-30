using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WattsALoanService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WattsALoanService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WattsALoanService.svc or WattsALoanService.svc.cs at the Solution Explorer and start debugging.
    public class WattsALoanService : IWattsALoanService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private SqlConnection GetDBConnection()
        {
            return new SqlConnection("Data Source=HESHAN-MBP;Initial Catalog=WattsALoan;Integrated Security=True");
        }

        private SqlCommand GetSqlCommand(SqlConnection connection, string procedureName)
        {
            SqlCommand command = new SqlCommand(procedureName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            return command;
        }

        private void SetInputSqlParameter(SqlCommand command, SqlParameter parameter, object value)
        {
            command.Parameters.Add(parameter);
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = value;
        }

        private void SetOutputSqlParameter(SqlCommand command, SqlParameter parameter)
        {
            command.Parameters.Add(parameter);
            parameter.Direction = ParameterDirection.Output;
        }

        public bool InsertEmployee(Employee employee)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "InsertEmployee");

            SqlParameter employeeNumber = new SqlParameter("@EmployeeNumber", SqlDbType.NChar, 10);
            SetInputSqlParameter(command, employeeNumber, employee.EmployeeNumber);
            SqlParameter firstName = new SqlParameter("@FirstName", SqlDbType.NVarChar, 20);
            SetInputSqlParameter(command, firstName, employee.FirstName);
            SqlParameter lastName = new SqlParameter("@LastName", SqlDbType.NVarChar, 10);
            SetInputSqlParameter(command, lastName, employee.LastName);
            SqlParameter titles = new SqlParameter("@Titles", SqlDbType.NVarChar, 100);
            SetInputSqlParameter(command, titles, employee.Titles);
            SqlParameter hourlySalary = new SqlParameter("@HourlySalary", SqlDbType.Money);
            SetInputSqlParameter(command, hourlySalary, employee.HourlySalary);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }

        public bool DeleteEmployee(int employeeID)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "DeleteEmployee");

            SqlParameter id = new SqlParameter("@EmployeeID", SqlDbType.Int);
            SetInputSqlParameter(command, id, employeeID);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "UpdateEmployee");

            SqlParameter id = new SqlParameter("@EmployeeID", SqlDbType.Int);
            SetInputSqlParameter(command, id, employee.EmployeeID);
            SqlParameter employeeNumber = new SqlParameter("@EmployeeNumber", SqlDbType.NChar, 10);
            SetInputSqlParameter(command, employeeNumber, employee.EmployeeNumber);
            SqlParameter firstName = new SqlParameter("@FirstName", SqlDbType.NVarChar, 20);
            SetInputSqlParameter(command, firstName, employee.FirstName);
            SqlParameter lastName = new SqlParameter("@LastName", SqlDbType.NVarChar, 10);
            SetInputSqlParameter(command, lastName, employee.LastName);
            SqlParameter titles = new SqlParameter("@Titles", SqlDbType.NVarChar, 100);
            SetInputSqlParameter(command, titles, employee.Titles);
            SqlParameter hourlySalary = new SqlParameter("@HourlySalary", SqlDbType.Money);
            SetInputSqlParameter(command, hourlySalary, employee.HourlySalary);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }

        public bool InsertCustomer(Customer customer)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "InsertCustomer");

            SqlParameter dateCreated = new SqlParameter("@DateCreated", SqlDbType.DateTime2);
            SetInputSqlParameter(command, dateCreated, customer.DateCreated);
            SqlParameter fullName = new SqlParameter("@FullName", SqlDbType.NVarChar, 50);
            SetInputSqlParameter(command, fullName, customer.FullName);
            SqlParameter address = new SqlParameter("@BillingAddress", SqlDbType.NVarChar, 100);
            SetInputSqlParameter(command, address, customer.BillingAddress);
            SqlParameter city = new SqlParameter("@BillingCity", SqlDbType.NVarChar, 50);
            SetInputSqlParameter(command, city, customer.BillingCity);
            SqlParameter state = new SqlParameter("@BillingState", SqlDbType.NVarChar, 50);
            SetInputSqlParameter(command, state, customer.BillingState);
            SqlParameter zipCode = new SqlParameter("@BillingZIPCide", SqlDbType.NVarChar, 10);
            SetInputSqlParameter(command, zipCode, customer.BillingZIPCide);
            SqlParameter email = new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 100);
            SetInputSqlParameter(command, email, customer.EmailAddress);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }

        public bool UpdateCustomer(Customer customer)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "UpdateCustomer");

            SqlParameter id = new SqlParameter("@CustomerID", SqlDbType.Int);
            SetInputSqlParameter(command, id, customer.CustomerID);
            SqlParameter dateCreated = new SqlParameter("@DateCreated", SqlDbType.DateTime2);
            SetInputSqlParameter(command, dateCreated, customer.DateCreated);
            SqlParameter fullName = new SqlParameter("@FullName", SqlDbType.NVarChar, 50);
            SetInputSqlParameter(command, fullName, customer.FullName);
            SqlParameter address = new SqlParameter("@BillingAddress", SqlDbType.NVarChar, 100);
            SetInputSqlParameter(command, address, customer.BillingAddress);
            SqlParameter city = new SqlParameter("@BillingCity", SqlDbType.NVarChar, 50);
            SetInputSqlParameter(command, city, customer.BillingCity);
            SqlParameter state = new SqlParameter("@BillingState", SqlDbType.NVarChar, 50);
            SetInputSqlParameter(command, state, customer.BillingState);
            SqlParameter zipCode = new SqlParameter("@BillingZIPCide", SqlDbType.NVarChar, 10);
            SetInputSqlParameter(command, zipCode, customer.BillingZIPCide);
            SqlParameter email = new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 100);
            SetInputSqlParameter(command, email, customer.EmailAddress);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }

        public bool InsertLoanType(LoanType loanType)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "InsertLoan");

            SqlParameter loanTypeName = new SqlParameter("@LoanType", SqlDbType.NVarChar, 50);
            SetInputSqlParameter(command, loanTypeName, loanType.LoanTypeName);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }

        public IList<LoanType> GetLoanTypes()
        {
            IList<LoanType> loanTypes = new List<LoanType>();

            SqlConnection connection = GetDBConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT LoanTypeID, LoanType FROM LoanTypes", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LoanType type = new LoanType();
                type.LoanTypeID = int.Parse(reader.GetValue(0).ToString());
                type.LoanTypeName = reader.GetValue(1).ToString();
                loanTypes.Add(type);
            }
            command.Dispose();
            connection.Close();

            return loanTypes;
        }

        public bool InsertLoanAllocation(LoanAllocation loanAllocation)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "InsertLoanAllocation");

            SqlParameter datePrepared = new SqlParameter("@DatePrepared", SqlDbType.DateTime2);
            SetInputSqlParameter(command, datePrepared, loanAllocation.DatePrepared);
            SqlParameter employeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
            SetInputSqlParameter(command, employeeID, loanAllocation.EmployeeID);
            SqlParameter customerID = new SqlParameter("@CustomerID", SqlDbType.Int);
            SetInputSqlParameter(command, customerID, loanAllocation.CustomerID);
            SqlParameter accountNumber = new SqlParameter("@AccountNumber", SqlDbType.NChar, 10);
            SetInputSqlParameter(command, accountNumber, loanAllocation.AccountNumber);
            SqlParameter loanTypeID = new SqlParameter("@LoanTypeID", SqlDbType.Int);
            SetInputSqlParameter(command, loanTypeID, loanAllocation.LoanTypeID);
            SqlParameter loanAmount = new SqlParameter("@LoanAmount", SqlDbType.Money);
            SetInputSqlParameter(command, loanAmount, loanAllocation.LoanAmount);
            SqlParameter interestRate = new SqlParameter("@InterestRate", SqlDbType.Decimal);
            SetInputSqlParameter(command, interestRate, loanAllocation.InterestRate);
            SqlParameter periods = new SqlParameter("@Periods", SqlDbType.Decimal);
            SetInputSqlParameter(command, periods, loanAllocation.Periods);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }

        public IList<LoanAllocation> GetLoanAllocations(int customerID)
        {
            IList<LoanAllocation> allocations = new List<LoanAllocation>();

            SqlConnection connection = GetDBConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT LoanAllocationID, DatePrepared, EmployeeID, CustomerID, AccountNumber, LoanTypeID, LoanAmount, InterestRate, Periods FROM LoanAllocations WHERE CustomerID=" + customerID, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LoanAllocation allocation = new LoanAllocation
                {
                    LoanAllocationID = int.Parse(reader.GetValue(0).ToString()),
                    DatePrepared = DateTime.Parse(reader.GetValue(1).ToString()),
                    EmployeeID = int.Parse(reader.GetValue(2).ToString()),
                    CustomerID = int.Parse(reader.GetValue(3).ToString()),
                    AccountNumber = reader.GetValue(4).ToString(),
                    LoanTypeID = int.Parse(reader.GetValue(5).ToString()),
                    LoanAmount = double.Parse(reader.GetValue(6).ToString()),
                    InterestRate = double.Parse(reader.GetValue(7).ToString()),
                    Periods = double.Parse(reader.GetValue(8).ToString())
                };
                allocations.Add(allocation);
            }
            command.Dispose();
            connection.Close();

            return allocations;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = new Employee();

            SqlConnection connection = GetDBConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT EmployeeID, EmployeeNumber, FirstName, LastName, Titles, HourlySalary FROM Employees WHERE EmployeeID=" + id, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                employee.EmployeeID = int.Parse(reader.GetValue(0).ToString());
                employee.EmployeeNumber = reader.GetValue(1).ToString();
                employee.FirstName = reader.GetValue(2).ToString();
                employee.LastName = reader.GetValue(3).ToString();
                employee.Titles = reader.GetValue(4).ToString();
                employee.HourlySalary = float.Parse(reader.GetValue(5).ToString());
            }
            command.Dispose();
            connection.Close();

            return employee;
        }

        public IList<Employee> GetEmployees()
        {
            IList<Employee> employees = new List<Employee>();

            SqlConnection connection = GetDBConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT EmployeeID, EmployeeNumber, FirstName, LastName, Titles, HourlySalary FROM Employees", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeID = int.Parse(reader.GetValue(0).ToString());
                employee.EmployeeNumber = reader.GetValue(1).ToString();
                employee.FirstName = reader.GetValue(2).ToString();
                employee.LastName = reader.GetValue(3).ToString();
                employee.Titles = reader.GetValue(4).ToString();
                employee.HourlySalary = float.Parse(reader.GetValue(5).ToString());
                employees.Add(employee);
            }
            command.Dispose();
            connection.Close();

            return employees;
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = new Customer();

            SqlConnection connection = GetDBConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CustomerID, DateCreated, FullName, BillingAddress, BillingCity, BillingState, BillingZIPCide, EmailAddress FROM Customers WHERE CustomerID=" + id, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                customer.CustomerID = int.Parse(reader.GetValue(0).ToString());
                customer.DateCreated = DateTime.Parse(reader.GetValue(1).ToString());
                customer.FullName = reader.GetValue(2).ToString();
                customer.BillingAddress = reader.GetValue(3).ToString();
                customer.BillingCity = reader.GetValue(4).ToString();
                customer.BillingState = reader.GetValue(5).ToString();
                customer.BillingZIPCide = reader.GetValue(6).ToString();
                customer.EmailAddress = reader.GetValue(7).ToString();
            }
            command.Dispose();
            connection.Close();

            return customer;
        }

        public IList<Customer> GetCustomers()
        {
            IList<Customer> customers = new List<Customer>();

            SqlConnection connection = GetDBConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CustomerID, DateCreated, FullName, BillingAddress, BillingCity, BillingState, BillingZIPCide, EmailAddress FROM Customers", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.CustomerID = int.Parse(reader.GetValue(0).ToString());
                customer.DateCreated = DateTime.Parse(reader.GetValue(1).ToString());
                customer.FullName = reader.GetValue(2).ToString();
                customer.BillingAddress = reader.GetValue(3).ToString();
                customer.BillingCity = reader.GetValue(4).ToString();
                customer.BillingState = reader.GetValue(5).ToString();
                customer.BillingZIPCide = reader.GetValue(6).ToString();
                customer.EmailAddress = reader.GetValue(7).ToString();
                customers.Add(customer);
            }
            command.Dispose();
            connection.Close();

            return customers;
        }

        public bool RecordPayment(Payment payment)
        {
            SqlConnection connection = GetDBConnection();
            SqlCommand command = GetSqlCommand(connection, "SpecifyCurrentBalance");

            SqlParameter paymentDate = new SqlParameter("@PmtDate", SqlDbType.DateTime2);
            SetInputSqlParameter(command, paymentDate, payment.PaymentDate);
            SqlParameter employeeID = new SqlParameter("@EmplID", SqlDbType.Int);
            SetInputSqlParameter(command, employeeID, payment.EmployeeID);
            SqlParameter loanAllocationID = new SqlParameter("@LaID", SqlDbType.Int);
            SetInputSqlParameter(command, loanAllocationID, payment.LoanAllocationID);
            SqlParameter paymentAmount = new SqlParameter("@PmtAmt", SqlDbType.Money);
            SetInputSqlParameter(command, paymentAmount, payment.PaymentAmount);
            SqlParameter response = new SqlParameter("@Response", SqlDbType.Bit);
            SetOutputSqlParameter(command, response);

            connection.Open();
            command.ExecuteNonQuery();
            Boolean retValue = (Boolean)command.Parameters["@Response"].Value;
            command.Dispose();
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }
    }
}
