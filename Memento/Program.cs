namespace MementoN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditorMemento textEditor = new("Текст");
            TextEditor editor = new(textEditor);

            Memento editorMemento = editor.CreateMemento();

            Store store = new();
            store.Add(editorMemento);
            Memento previousMemento = store.Previous();

            TextEditor restoredEditor = new(previousMemento);            
            Console.WriteLine(restoredEditor.GetState());
        }
    }
}