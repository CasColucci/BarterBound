using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BarterBound.Services.Interfaces
{
    public interface IXmlWriterService
    {
        public void Create(string outputFileName, XmlWriterSettings? settings);
    }
}
