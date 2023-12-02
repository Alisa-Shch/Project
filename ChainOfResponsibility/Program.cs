namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationHelpHandler application = new(null);
            ButtonHelpHandler button = new(application);
            IntButtonHelpHandler intBtn = new(button);
            OperationButtonHelpHandler operationBtn = new(button);

            Console.WriteLine(intBtn.Handler(new HelpRequest('8')));
            Console.WriteLine(intBtn.Handler(new HelpRequest('*')));
            Console.WriteLine(intBtn.Handler(new HelpRequest(' ')));
            Console.WriteLine(operationBtn.Handler(new HelpRequest('1')));
            Console.WriteLine(operationBtn.Handler(new HelpRequest('/')));

            Console.ReadLine();
        }
    }
}