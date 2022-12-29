using System;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class Calculate : ICalculate
    {
        public int Multiply(params int[] array)
        {
            int multiply = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 1 && array[i] < 20)
                {
                    multiply *= array[i];
                }
            }

            return multiply;
        }

        public int SquareOfSum(params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            return sum * sum;
        }
    }
}