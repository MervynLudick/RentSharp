namespace RentSharp.Web.Client.Client
{
    using System.Collections.Generic;

    public static class MockCustomerData
    {
        public static List<CustomerListModel> GetCustomers()
        {
            return new List<CustomerListModel>
            {
                new CustomerListModel()
                {
                    FirstName = "John",
                    Surname = "Doe",
                    Cellphone = "555-123-4567",
                    IdNumber = "1234567890"
                },
                new CustomerListModel()
                {
                    FirstName = "Jane",
                    Surname = "Doe",
                    Cellphone = "555-987-6543",
                    IdNumber = "0987654321"
                },
                new CustomerListModel()
                {
                    FirstName = "Alice",
                    Surname = "Smith",
                    Cellphone = "555-123-9876",
                    IdNumber = "1029384756"
                },
                new CustomerListModel()
                {
                    FirstName = "Bob",
                    Surname = "Johnson",
                    Cellphone = "555-654-3210",
                    IdNumber = "5647382910"
                }
            };
        }
    }

}
