﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BarterBound.Core.Interfaces;

public interface IXmlSerializer
{
    void Serialize(Type type, XmlWriter xmlWriter, object? obj);
}
