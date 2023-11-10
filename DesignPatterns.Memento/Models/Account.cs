namespace DesignPatterns.Memento.Models
{
    public class Account
    {
        public int Balance { get; set; }
        private List<Memento> _operations = new();
        private int _current;

        public Account(int balance)
        {
            Balance = balance;
            _operations.Add(new Memento(Balance));
        }

        public Memento Deposit(int amount)
        {
            Balance += amount;

            Memento memento = new(Balance);

            _operations.Add(memento);
            _current += 1;

            return memento;
        }

        public Memento? Undo()
        {
            if (_current <= 0)
                return null;

            var memento = _operations[--_current];
            Balance = memento.Balance;

            return memento;
        }

        public Memento? Redo()
        {
            if (_current + 1 >= _operations.Count)
                return null;

            var memento = _operations[++_current];
            Balance = memento.Balance;

            return memento;
        }

        public void Restore(Memento memento)
        {
            Balance = memento.Balance;
        }

        public override string ToString()
        {
            return $"Balance: {Balance}";
        }
    }
}