using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace LanguageFeatures
{

    class Program
    {
        static void Main(string[] args)
        {
            TestNullConditional();

            TestStaticUsing();

            ProcessCustomers(GetCustomers()).Wait();

            Console.Read();
        }

        private static void TestStaticUsing()
        {
            var radius = 10;
            //No extra ceremony. 
            //using static Extensions.ClassA';
            var result = PI * Pow(radius, 2);
        }

        private static void TestNullConditional()
        {
            var customer = new Customer();
            Logger.Log(nameof(customer), customer);
            try
            {
                Console.WriteLine(customer?.Address?.City);
            }
            catch (Exception ex) when (customer.FirstName == "John")
            {
                Logger.Log(nameof(customer), customer);
            }
        }

        private static async Task ProcessCustomers(Dictionary<int, Customer> customers)
        {
            foreach (var customer in customers)
            {
                await ProcessCustomer(customer);
            }
        }

        private async static Task ProcessCustomer(KeyValuePair<int, Customer> customer)
        {
            try
            {
                await Task.Delay(3000);
                Console.WriteLine($"Customer: {customer.Value?.FullName}");

            }
            catch (Exception ex) when (customer.Value?.FirstName == "John")
            {
                Logger.Log(nameof(customer), customer.Value);
            }
        }

        private static Dictionary<int, Customer> GetCustomers()
        {
            //return new Dictionary<int, Customer>
            //{
            //   {1, new Customer
            //        {
            //            FirstName = "John",
            //            LastName = "Smith"
            //        }
            //    },
            //    {2, new Customer
            //        {
            //            FirstName = "Mike",
            //            LastName = "Smith"
            //        }
            //   }
            //};

            return new Dictionary<int, Customer>
            {
                [1] = new Customer
                {
                    FirstName = "John",
                    LastName = "Smith"
                },
                [2] = new Customer
                {
                    FirstName = "Bill",
                    LastName = "Stein"
                },
                [3] = null

            };
            return new Dictionary<int, Customer>
            {
                [1] = new Customer
                {
                    FirstName = "John",
                    LastName = "Smith"
                },
                [2] = new Customer
                {
                    FirstName = "Bill",
                    LastName = "Stein"
                },
                [3] = null

            };
        }
    }
}
