using System.Text;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFile file = new FileProxy("...\\text.txt");

            Console.WriteLine($"Размер: {file.GetSize()} \nПуть: {file.GetPath()} \nСодержание: {Encoding.UTF8.GetString(file.Show())}");
        }
    }
}