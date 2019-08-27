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
            return new SqlConnection("Data Source=HESHAN-MBP\\MSSQLSVR;Initial Catalog=WattsALoan;Integrated Security=True");
        }

        private SqlCommand GetSqlCommand(SqlConnection connection, string procedureName)
        {
            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
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
            connection.Close();

            if (retValue)
                return true;
            else
                return false;
        }
    }
}
