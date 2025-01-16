using BarterBound.Services.Interfaces;

namespace BarterBound.Services
{
    internal class FileService : IFileService
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
