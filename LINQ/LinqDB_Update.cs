using System;
using System.Linq;
using System.Data.Linq;

class Program
{
    static void Main()
    {
        string connectionString = "YourConnectionString";
        DataContext dataContext = new DataContext(connectionString);

        var customerToUpdate = dataContext.GetTable<Customer>().Single(c => c.CustomerID == "ALFKI");
        customerToUpdate.ContactName = "New Contact Name";
        
        dataContext.SubmitChanges();

        Console.WriteLine("Customer updated.");
    }
}
