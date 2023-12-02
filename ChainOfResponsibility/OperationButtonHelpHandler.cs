namespace ChainOfResponsibility
{
    internal class OperationButtonHelpHandler : ButtonHelpHandler
    {
        public OperationButtonHelpHandler(HelpHandler helpHandler) 
            : base(helpHandler) { }

        protected override bool IsRequest(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            char[] validSigns = { '/', '*', '-', '+' };
            return validSigns.Contains(request.Sign);
        }

        protected override string HelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return $"Это кнопка операции '{request.Sign}'";
        }

        protected override string DefaultHelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Вы нажимаете на кнопку операции";
        }
    }
}