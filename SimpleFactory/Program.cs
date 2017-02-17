using System;

namespace SimpleFactory
{
	interface IOperator
	{
		double getResult(double operand1, double operand2);
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
