using DesignPatterns.Interpreter.Interfaces;

namespace DesignPatterns.Interpreter.Implementations
{
    public class NumericExpression : IExpression
    {
        public int _number;

        public NumericExpression(int number)
        {
            _number = number;
        }

        public NumericExpression(string number)
        {
            _number = int.Parse(number);
        }

        public int Interpret()
        {
            return _number;
        }
    }
}
