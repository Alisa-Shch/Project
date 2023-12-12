namespace Command
{
    internal class Remote
    {
        private Dictionary<int, (ICommand, ICommand)> _commands = new();
        private Stack<ICommand> _undo = new();

        public void Add(int number, ICommand remult, ICommand undo)
        {
            _commands.Add(number, (remult, undo));
        }

        public void Execute(int number)
        {
            if (_commands.ContainsKey(number))
            {
                _commands[number].Item1.Execute();
                _undo.Push(_commands[number].Item2);
            }
            else
            {
                throw new ArgumentException("Кнопка не найдена", nameof(number));
            }
        }

        public void Undo()
        {
            if (_undo.Count > 0)
            {
                _undo.Pop().Execute();
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены");
            }
        }
    }
}