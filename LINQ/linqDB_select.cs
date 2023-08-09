using System;
using System.Linq;
using System.Data.Linq; // Підключення до LINQ to SQL

class Program
{
    static void Main()
    {
        string connectionString = "YourConnectionString";
        DataContext dataContext = new DataContext(connectionString);

        var query = from customer in dataContext.GetTable<Customer>()
                    where customer.Country == "USA"
                    select customer;

        foreach (var customer in query)
        {
            Console.WriteLine($"{customer.CustomerID}: {customer.ContactName}");
        }
    }
}
