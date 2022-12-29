using System;
using Service.Services;
using Service.Services.Interfaces;

namespace Main.Controllers
{
	public class CalculateController
	{
		private readonly ICalculate _calculate;

		public CalculateController()
		{
			_calculate = new Calculate();
		}

        //public void Calculate()
        //{
        //	Console.WriteLine($"First method's answer is {_calculate.Multiply(1, 2, 67, 89, 43, 7, 32, 45, 13)}");
        //  Console.WriteLine($"Second method's answer is {_calculate.SquareOfSum(1, 2, 67, 89, 43, 7, 32, 45, 13)}");
        //}

        public void Calculate() => Console.WriteLine($"First method's answer is {_calculate.Multiply(1, 2, 67, 89, 43, 7, 32, 45, 13)}\n" + $"Second method's answer is {_calculate.SquareOfSum(1, 2, 67, 89, 43, 7, 32, 45, 13)}");
    }
}