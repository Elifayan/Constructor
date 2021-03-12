using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Elif", LastName="Ayan", City="Samsun" };
            
            Customer customer2 = new Customer (2, "Mehmet", "Aydın", "Samsun");
            Console.WriteLine(customer2.FirstName);
        

            Customer customer3 = new Customer();
            customer3.FirstName = "Ayşe";

            Customer customer4= new Customer();

        }

       
        class Customer
        {
            public Customer(int id, string firstname, string lastname , string city)
            {
                Id = id;
                FirstName = firstname;
                LastName = lastname;
                City = city;

            }
            /// Default constructor
            public Customer()
            {

            }
           

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
