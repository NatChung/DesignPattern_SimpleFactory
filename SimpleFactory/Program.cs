using System;

namespace SimpleFactory
{
	interface IOperator
	{
		double getResult(double operand1, double operand2);
	}

	class Adder : IOperator
	{
		double IOperator.getResult(double operand1, double operand2)
		{
			return operand1 + operand2;
		}
	}

	class Subtractor : IOperator
	{
		public double getResult(double operand1, double operand2)
		{
			return operand1 - operand2;
		}
	}

	class Multiplier : IOperator
	{
		public double getResult(double operand1, double operand2)
		{
			return operand1 * operand2;
		}
	}

	class Divider : IOperator
	{
		public double getResult(double operand1, double operand2)
		{
			return operand1 / operand2;
		}
	}

	class OperatorSimpleFactory
	{
		public static IOperator createOperator(string type)
		{
			switch (type)
			{
				case "+":
					return new Adder();
				case "-":
					return new Subtractor();
				case "*":
					return new Multiplier();
				case "/":
					return new Divider();
				default:
					return null;
			}
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Add:" + OperatorSimpleFactory.createOperator("+").getResult(3, 6));
			Console.WriteLine("Substract:" + OperatorSimpleFactory.createOperator("-").getResult(3, 6));
			Console.WriteLine("Multiple:" + OperatorSimpleFactory.createOperator("*").getResult(3, 6));
			Console.WriteLine("Divider:" + OperatorSimpleFactory.createOperator("/").getResult(3, 6));
		}
	}
}
