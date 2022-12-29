using System;
using Domain.Models;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class Customers : ICustomers
    {
        public int Count(Customer[] customers)
        {
            int count = 0;

            foreach (Customer customer in customers)
            {
                if (customer.Age >= 25 && customer.Age <= 30)
                {
                    count++;
                }
            }

            return count;
        }

        public double Average(Customer[] customers)
        {
            double sum = 0;

            foreach (Customer customer in customers)
            {
                sum += customer.Age;
            }

            return sum / customers.Length;
        }
    }
}