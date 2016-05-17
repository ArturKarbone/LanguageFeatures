using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    class Customer
    {

        //public Customer()
        //{
        //    FirstOrderDate = DateTime.Today;
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime FirstOrderDate { get; } = DateTime.Today;
        public Address Address = new Address();

        
        public DateTime FirstOrderDate2 { get; private set; } = DateTime.Today;
        void Test()
        {
            //FirstOrderDate = DateTime.Now;
            //Readonly. Could be changed only when marked as private set;
            //FirstOrderDate2 = DateTime.Now;        
        }
    }

    class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}
