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
        bool InsertCustomer(Customer customer);
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
    public class Customer
    {
        DateTime dateCreated = DateTime.Now;
        string fullName;
        string billingAddress;
        string billingCity;
        string billingState;
        string billingZIPCide;
        string emailAddress;

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
}
