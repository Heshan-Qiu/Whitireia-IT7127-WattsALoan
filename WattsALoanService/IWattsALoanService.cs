using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WattsALoanService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWattsALoanService" in both code and config file together.
    [ServiceContract]
    public interface IWattsALoanService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        bool InsertEmployee(Employee employee);

        [OperationContract]
        bool DeleteEmployee(int employeeID);

        [OperationContract]
        bool UpdateEmployee(Employee employee);

        [OperationContract]
        bool InsertCustomer(Customer customer);

        [OperationContract]
        bool UpdateCustomer(Customer customer);

        [OperationContract]
        bool InsertLoanType(LoanType loanType);

        [OperationContract]
        IList<LoanType> GetLoanTypes();

        [OperationContract]
        bool InsertLoanAllocation(LoanAllocation loanAllocation);

        [OperationContract]
        IList<LoanAllocation> GetLoanAllocations(int customerID);

        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        IList<Employee> GetEmployees();

        [OperationContract]
        Customer GetCustomer(int id);

        [OperationContract]
        IList<Customer> GetCustomers();

        [OperationContract]
        bool RecordPayment(Payment payment);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Employee
    {
        int employeeID;
        string employeeNumber;
        string firstName;
        string lastName;
        string titles;
        float hourlySalary;

        [DataMember]
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        [DataMember]
        public string EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
        [DataMember]
        public string Titles { get => titles; set => titles = value; }
        [DataMember]
        public float HourlySalary { get => hourlySalary; set => hourlySalary = value; }
    }

    [DataContract]
    public class Customer
    {
        int customerID;
        DateTime dateCreated = DateTime.Now;
        string fullName;
        string billingAddress;
        string billingCity;
        string billingState;
        string billingZIPCide;
        string emailAddress;

        [DataMember]
        public int CustomerID { get => customerID; set => customerID = value; }
        [DataMember]
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        [DataMember]
        public string FullName { get => fullName; set => fullName = value; }
        [DataMember]
        public string BillingAddress { get => billingAddress; set => billingAddress = value; }
        [DataMember]
        public string BillingCity { get => billingCity; set => billingCity = value; }
        [DataMember]
        public string BillingState { get => billingState; set => billingState = value; }
        [DataMember]
        public string BillingZIPCide { get => billingZIPCide; set => billingZIPCide = value; }
        [DataMember]
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
    }

    [DataContract]
    public class LoanType
    {
        int loanTypeID;
        string loanTypeName;

        [DataMember]
        public int LoanTypeID { get => loanTypeID; set => loanTypeID = value; }
        [DataMember]
        public string LoanTypeName { get => loanTypeName; set => loanTypeName = value; }
    }

    [DataContract]
    public class LoanAllocation
    {
        int loanAllocationID;
        DateTime datePrepared;
        int employeeID;
        int customerID;
        string accountNumber;
        int loanTypeID;
        double loanAmount;
        double interestRate;
        double periods;

        [DataMember]
        public int LoanAllocationID { get => loanAllocationID; set => loanAllocationID = value; }
        [DataMember]
        public DateTime DatePrepared { get => datePrepared; set => datePrepared = value; }
        [DataMember]
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        [DataMember]
        public int CustomerID { get => customerID; set => customerID = value; }
        [DataMember]
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        [DataMember]
        public int LoanTypeID { get => loanTypeID; set => loanTypeID = value; }
        [DataMember]
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        [DataMember]
        public double InterestRate { get => interestRate; set => interestRate = value; }
        [DataMember]
        public double Periods { get => periods; set => periods = value; }
    }

    [DataContract]
    public class Payment
    {
        int paymentID;
        DateTime paymentDate;
        int employeeID;
        int loanAllocationID;
        double paymentAmount;

        [DataMember]
        public int PaymentID { get => paymentID; set => paymentID = value; }
        [DataMember]
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        [DataMember]
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        [DataMember]
        public int LoanAllocationID { get => loanAllocationID; set => loanAllocationID = value; }
        [DataMember]
        public double PaymentAmount { get => paymentAmount; set => paymentAmount = value; }
    }
}
