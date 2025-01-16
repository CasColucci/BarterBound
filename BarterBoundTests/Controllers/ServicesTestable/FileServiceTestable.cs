using BarterBound.Core.Interfaces;

namespace BarterBound.Tests.Controllers.ServicesTestable
{
    internal class FileServiceTestable : IFile
    {
        public List<string> SavedFiles { get; set; } = new List<string>();

        public bool Exists(string path)
        {
            if (SavedFiles.Contains(path))
            {
                return true;
            }
            return false;
        }

        public void WriteFile(string path)
        {
            SavedFiles.Add(path);
        }
    }
}
