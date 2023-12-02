namespace Proxy
{
    internal class File : IFile
    {
        private string _path;
        private StreamReader _reader;

        public File(string path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path), "Путь пуст");
            _reader = new StreamReader(_path);
        }

        public double GetSize()
        {
            FileInfo file = new(_path);
            return file.Length;
        }

        public string GetPath()
        {
            return _path;
        }

        public byte[] Show()
        {
            return System.IO.File.ReadAllBytes(_path);
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}