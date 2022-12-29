using System;
using Service.Services;
using Service.Services.Interfaces;

namespace Main.Controllers
{
	public class AccountController
	{
		private readonly IAccount _account;

		public AccountController()
		{
			_account = new Account();
		}

		public void Login()
		{
			Console.WriteLine("Add email:");
			string email = Console.ReadLine();

            Console.WriteLine("Add password:");
            string password = Console.ReadLine();

			int roleId = 2;

			Console.WriteLine(_account.Login(email, password, roleId));
        }
	}
}