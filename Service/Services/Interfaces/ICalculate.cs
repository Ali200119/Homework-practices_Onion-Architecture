using System;
namespace Service.Services.Interfaces
{
	public interface ICalculate
	{
		int Multiply(params int[] array);
		int SquareOfSum(params int[] array);
	}
}