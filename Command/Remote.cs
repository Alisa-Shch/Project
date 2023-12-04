namespace Command
{
    internal class Remote
    {
        private Dictionary<int, ICommand> _commands = new();
        private Stack<ICommand> _undo = new();

        public void Add(int number, ICommand remult, ICommand undo)
        {
            _commands.Add(number, remult);
            _undo.Push(undo);
        }

        public void Execute(int number)
        {
            if (_commands.ContainsKey(number))
            {
                ICommand remult = _commands[number];
                remult.Execute();
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

                ICommand command = _undo.Pop();
                command.Execute();
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены");
            }
        }
    }
}