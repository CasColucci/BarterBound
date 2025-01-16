using BarterBound.Core.Interfaces;

namespace BarterBound.Core.Wrappers
{
    internal class FileWrapper : IFile
    {
        public void WriteFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string path)
        {
            return File.Exists(path);
        }
    }
}
