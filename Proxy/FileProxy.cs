namespace Proxy
{
    internal class FileProxy : IFile
    {
        private File? _file;
        private string _path;

        public FileProxy(string path)
        {
            _ = path ?? throw new ArgumentNullException(nameof(path), "Путь пуст");

            _path = path;
            _file = new File(_path);
        }

        public double GetSize()
        {
            return _file == null ? new FileInfo(_path).Length : _file.GetSize();
        }

        public string GetPath()
        {
            return _file == null ? _path : _file.GetPath();
        }

        public byte[] Show()
        {
            _file ??= new File(_path);
            return _file.Show();
        }

        public void Dispose()
        {
            _file?.Dispose();
        }
    }
}