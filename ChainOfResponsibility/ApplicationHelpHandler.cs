namespace ChainOfResponsibility
{
    internal class ApplicationHelpHandler : HelpHandler
    {
        public ApplicationHelpHandler(HelpHandler helpHandler) 
            : base(helpHandler) { }

        protected override bool IsRequest(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            return true;
        }

        protected override string HelpString(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            return "Вы нажимаете на кнопку, которая не касается калькулятора";
        }

        protected override string DefaultHelpString(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            return "Добро пожаловать в калькулятор";
        }
    }
}