using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Core.Interfaces;
public interface IFile
{
    bool Exists(string filePath);
    void WriteFile(string path);

}

