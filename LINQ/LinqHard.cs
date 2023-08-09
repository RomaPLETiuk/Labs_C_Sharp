using System;
using System.Linq;
using System.Data.Linq;


public class Customer
{
    public string CustomerID { get; set; }
    public string ContactName { get; set; }
}

public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
}


class Program
{
    static void Main()
    {
        string connectionString = "YourConnectionString";
        DataContext dataContext = new DataContext(connectionString);

        var query = from order in dataContext.GetTable<Order>()
                    join customer in dataContext.GetTable<Customer>() on order.CustomerID equals customer.CustomerID
                    select new
                    {
                        OrderID = order.OrderID,
                        CustomerName = customer.ContactName,
                        OrderDate = order.OrderDate
                    };

        foreach (var result in query)
        {
            Console.WriteLine($"Order ID: {result.OrderID}, Customer: {result.CustomerName}, Order Date: {result.OrderDate}");
        }
    }
}
