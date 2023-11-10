using DesignPatterns.Interpreter.Interfaces;

namespace DesignPatterns.Interpreter.Implementations
{
    public class AdditionExpression : IExpression
    {
        private IExpression _firstExpresion, _secondExpresion;

        public AdditionExpression(IExpression firstExpresion, IExpression secondExpresion)
        {
            _firstExpresion = firstExpresion;
            _secondExpresion = secondExpresion;
        }

        public int Interpret()
        {
            return _firstExpresion.Interpret() + _secondExpresion.Interpret();
        }

        public override string ToString()
        {
            return "+";
        }
    }
}
