using System;
using System.Linq;
using System.Data.Linq;

class Program
{
    static void Main()
    {
        string connectionString = "YourConnectionString";
        DataContext dataContext = new DataContext(connectionString);

        Customer newCustomer = new Customer
        {
            CustomerID = "NEWCUST",
            ContactName = "John Doe",
            Country = "Canada"
        };

        dataContext.GetTable<Customer>().InsertOnSubmit(newCustomer);
        dataContext.SubmitChanges();

        Console.WriteLine("New customer inserted.");
    }
}
