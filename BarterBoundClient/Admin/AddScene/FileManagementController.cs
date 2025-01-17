using BarterBound.Core.Interfaces;
using BarterBound.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BarterBound.Admin.AddScene
{
    public class FileManagementController
    {
        private readonly IXmlSerializer _serializer;

        public FileManagementController(IXmlSerializer xmlSerializer)
        {
            _serializer = xmlSerializer;
        }

        public bool FileExists(string sceneName)
        {
            return File.Exists(sceneName);
        }

        public void WriteFile(Type type, string fileName, object? fileContents)
        {
            using (XmlWriter writer = XmlWriter.Create(fileName))
            {
                _serializer.Serialize(type, writer, fileContents);
            }
        }

    }
}
