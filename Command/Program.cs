using Command.Commands;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Remote remote = new();
            Conditioner conditioner = new();
            Light light = new();

            remote.Add(0, new OnConditioner(conditioner), new OffConditioner(conditioner));
            remote.Execute(0);

            Console.WriteLine("Отмена последнего действия.");
            remote.Undo();

            Multicommand multiCommandOn = new(new List<ICommand> { new OnLight(light), new OnConditioner(conditioner) });
            Multicommand multiCommandOff = new(new List<ICommand> { new OffConditioner(conditioner), new OffLight(light) });

            remote.Add(1, multiCommandOn, multiCommandOff);
            remote.Execute(1);

            Console.WriteLine("Отмена действий.");
            remote.Undo();
        }
    }
}