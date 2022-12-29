using System;
using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;

namespace Main.Controllers
{
	public class CustomersController
	{
        private readonly ICustomers _customers;

        public CustomersController()
        {
            _customers = new Customers();
        }

        //public void Show()
        //{
        //          Console.WriteLine($"First method's answer is {_customers.Count}\n" + $"Second method's answer is {_customers.Average}");
        //}

        public void Show() => Console.WriteLine($"First method's answer is {_customers.Count(GetCustomers())}\n" + $"Second method's answer is {_customers.Average(GetCustomers())}");

        public Customer[] GetCustomers()
		{
			Customer c1 = new Customer
			{
                Id = 1,
                Name = "Ali",
				Surname = "Talibov",
				Age = 21,
				Position = "Software Developer"
			};

            Customer c2 = new Customer
            {
                Id = 2,
                Name = "Teymur",
                Surname = "Isayev",
                Age = 23,
                Position = "System Administrator"
            };

            Customer c3 = new Customer
            {
                Id = 3,
                Name = "Charlotte",
                Surname = "Gordon",
                Age = 28,
                Position = "Web Design"
            };

            Customer c4 = new Customer
            {
                Id = 4,
                Name = "Melissa",
                Surname = "Cook",
                Age = 30,
                Position = "Digital Marketing"
            };

            Customer c5 = new Customer
            {
                Id = 5,
                Name = "Peter",
                Surname = "Davis",
                Age = 25,
                Position = "Software Developer"
            };

            return new Customer[] { c1, c2, c3, c4, c5 };
        }
	}
}