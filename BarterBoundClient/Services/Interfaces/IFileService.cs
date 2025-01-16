using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Services.Interfaces;
public interface IFileService
{
    bool Exists(string filePath);
    void WriteFile(string path);

}

