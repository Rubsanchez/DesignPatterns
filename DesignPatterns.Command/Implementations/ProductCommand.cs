
using DesignPatterns.Command.Enums;
using DesignPatterns.Command.Interfaces;
using DesignPatterns.Command.Models;

namespace DesignPatterns.Command.Implementations
{
    public class ProductCommand : ICommand
    {
        private Product _product;
        private ActionType _action;
        private int _amount;

        public bool IsCommandExecuted { get; private set; }

        public ProductCommand(Product product, ActionType action, int amount)
        {
            _product = product;
            _action = action;
            _amount = amount;
        }

        public void Execute()
        {
            switch (_action)
            {
                case ActionType.Increase:
                    _product.IncreasePrice(_amount);
                    IsCommandExecuted = true;
                    break;
                case ActionType.Decrease:
                    IsCommandExecuted = _product.DecreasePrice(_amount);
                    break;
                default: break;
            }
        }

        public void Undo()
        {
            if (!IsCommandExecuted)
                return;

            switch (_action)
            {
                case ActionType.Increase:
                    _product.DecreasePrice(_amount);
                    break;
                case ActionType.Decrease:
                    _product.IncreasePrice(_amount);
                    break;
                default: break;
            }
        }
    }
}
