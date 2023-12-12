namespace MementoN
{
    internal class TextEditorMemento : Memento
    {
        private string _text;

        public TextEditorMemento(string text)
        {
            _text = text;
        }

        public string GetState()
        {
            return _text;
        }
    }
}