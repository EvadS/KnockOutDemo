using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockOutDemo.Models
{
    public class CustomerRepository
    {
        private static CustomerContext db = new CustomerContext();
 
        public static IEnumerable<Customer> GetCustomers()
        {
            var query = from cust in db.Customers
                        select cust;

            return query.ToList();  
        }    


        public static void InsertCustomer(Customer cust)
        {       
            db.Customers.Add(cust);
            db.SaveChanges();
        }

    }
}