namespace ChainOfResponsibility
{
    internal class ButtonHelpHandler : HelpHandler
    {
        public ButtonHelpHandler(HelpHandler helpHandler) 
            : base(helpHandler) { }

        protected override bool IsRequest(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            char[] validSigns = { '/', '*', '-', '+' };
            return char.IsDigit(request.Sign) || validSigns.Contains(request.Sign);
        }

        protected override string HelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return $"Это кнопка для символа '{request.Sign}'";
        }

        protected override string DefaultHelpString(HelpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return "Вы нажимаете на кнопку, которая не касается калькулятора";
        }
    }
}