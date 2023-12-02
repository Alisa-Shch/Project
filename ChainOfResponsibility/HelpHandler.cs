namespace ChainOfResponsibility
{
    internal abstract class HelpHandler
    {
        private HelpHandler? _helpHandler;

        public HelpHandler(HelpHandler helpHandler)
        {
            _helpHandler = helpHandler;
        }

        public virtual string Handler(HelpRequest request)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));

            if (IsRequest(request))
            {
                return HelpString(request);
            }
            if (_helpHandler != null)
            {
                return _helpHandler.Handler(request);
            }
            return DefaultHelpString(request);
        }

        protected abstract bool IsRequest(HelpRequest request);

        protected abstract string HelpString(HelpRequest request);

        protected abstract string DefaultHelpString(HelpRequest request);
    }
}