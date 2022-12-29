using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface ICustomers
	{
		int Count(Customer[] customers);
		double Average(Customer[] customers);
	}
}