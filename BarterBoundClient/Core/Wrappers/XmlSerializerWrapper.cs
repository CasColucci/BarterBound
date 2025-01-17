using BarterBound.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BarterBound.Core.Wrappers
{
    internal class XmlSerializerWrapper : IXmlSerializer
    {
        public void Serialize(Type type, XmlWriter xmlWriter, object? obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            xmlSerializer.Serialize(xmlWriter, obj);
        }
    }
}
