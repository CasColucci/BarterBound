using BarterBound.Core.Interfaces;
using System.Xml;

namespace BarterBound.Tests.Controllers.ServicesTestable
{
    internal class XmlSerializerTestable : IXmlSerializer
    {
        public XmlSerializerTestable()
        {
        }

        public void Serialize(Type type, XmlWriter xmlWriter, object? obj)
        {
        }
    }
}