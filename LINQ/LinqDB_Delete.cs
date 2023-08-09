using System;
using System.Linq;
using System.Data.Linq;

class Program
{
    static void Main()
    {
        string connectionString = "YourConnectionString";
        DataContext dataContext = new DataContext(connectionString);

        var customerToDelete = dataContext.GetTable<Customer>().Single(c => c.CustomerID == "ALFKI");
        dataContext.GetTable<Customer>().DeleteOnSubmit(customerToDelete);
        
        dataContext.SubmitChanges();

        Console.WriteLine("Customer deleted.");
    }
}
