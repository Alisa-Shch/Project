namespace MementoN
{
    internal class TextEditor
    {
        private string _text;

        public TextEditor()
        {
            _text = string.Empty;
        }

        public TextEditor(Memento memento)
        {
            if (memento is TextEditorMemento texEditorMemento)
            {
                _text = texEditorMemento.GetState();
            }
            else
            {
                throw new ArgumentException("Недопустимый тип");
            }
        }

        public string GetState()
        {
            return _text;
        }

        public Memento CreateMemento()
        {
            return new TextEditorMemento(_text);
        }
    }
}