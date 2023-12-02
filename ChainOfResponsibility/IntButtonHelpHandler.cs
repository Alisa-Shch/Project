namespace ChainOfResponsibility
{
    internal class IntButtonHelpHandler : ButtonHelpHandler
    {
        public IntButtonHelpHandler(HelpHandler helpHandler) 
            : base(helpHandler) { }

        protected override bool IsRequest(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return char.IsDigit(request.Sign);
        }

        protected override string HelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return $"Это кнопка для цифры '{request.Sign}'";
        }

        protected override string DefaultHelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Вы нажимаете на числовую кнопку";
        }
    }
}