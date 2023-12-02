namespace ChainOfResponsibility
{
    internal class IntButtonHelpHandler : ButtonHelpHandler
    {
        public IntButtonHelpHandler(HelpHandler helpHandler) 
            : base(helpHandler) { }

        protected override bool IsRequest(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "Пустое значение");
            return char.IsDigit(request.Sign);
        }

        protected override string HelpString(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            return $"Это кнопка для цифры '{request.Sign}'";
        }

        protected override string DefaultHelpString(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            return $"Вы нажимаете на числовую кнопку";
        }
    }
}