using DesignPatterns.Interpreter.Interfaces;

namespace DesignPatterns.Interpreter.Implementations
{
    public class MultiplicationExpression : IExpression
    {
        private IExpression _firstExpresion, _secondExpresion;

        public MultiplicationExpression(IExpression firstExpresion, IExpression secondExpresion)
        {
            _firstExpresion = firstExpresion;
            _secondExpresion = secondExpresion;
        }

        public int Interpret()
        {
            return _firstExpresion.Interpret() * _secondExpresion.Interpret();
        }

        public override string ToString()
        {
            return "*";
        }
    }
}
