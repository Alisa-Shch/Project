namespace ChainOfResponsibility
{
    internal class OperationButtonHelpHandler : ButtonHelpHandler
    {
        public OperationButtonHelpHandler(HelpHandler helpHandler) 
            : base(helpHandler) { }

        protected override bool IsRequest(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            char[] validSigns = { '/', '*', '-', '+' };
            return validSigns.Contains(request.Sign);
        }

        protected override string HelpString(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            return $"Это кнопка операции '{request.Sign}'";
        }

        protected override string DefaultHelpString(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            return $"Вы нажимаете на кнопку операции";
        }
    }
}