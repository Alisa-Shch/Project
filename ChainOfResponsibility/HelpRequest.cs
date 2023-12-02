namespace ChainOfResponsibility
{
    internal class HelpRequest
    {
        public char Sign { get; private set; }

        public HelpRequest(char sign)
        {
            Sign = sign;
        }
    }
}