using DesignPatterns.Interpreter.Implementations;
using DesignPatterns.Interpreter.Interfaces;

namespace DesignPatterns.Interpreter
{
    public class ExpressionParser
    {
        Stack<IExpression> stack = new Stack<IExpression>();

        private static bool IsOperator(string input) => input.Equals("+") || input.Equals("-") || input.Equals("*");

        private static IExpression GetExpressionObject(IExpression firstExpression, IExpression secondExpression, string symbol)
        {
            if (symbol.Equals("+"))
                return new AdditionExpression(firstExpression, secondExpression);
            else if (symbol.Equals("-"))
                return new SubstractionExpression(firstExpression, secondExpression);
            else
                return new MultiplicationExpression(firstExpression, secondExpression);
        }

        public int Parse(string input)
        {
            string[] tokenList = input.Split(" ");
            foreach (string symbol in tokenList)
            {
                if (IsOperator(symbol))
                {
                    IExpression firstExpression = stack.Pop();
                    IExpression secondExpression = stack.Pop();

                    IExpression expressionObject = GetExpressionObject(firstExpression, secondExpression, symbol);

                    Console.WriteLine($"Aplying operator: {expressionObject}");

                    NumericExpression resultExpression = new(expressionObject.Interpret());
                    stack.Push(resultExpression);
                }
                else
                {
                    IExpression number = new NumericExpression(symbol);
                    stack.Push(number);
                    Console.WriteLine($"Adding to stack: {number.Interpret()}");
                }
            }

            return stack.Pop().Interpret();
        }
    }
}
