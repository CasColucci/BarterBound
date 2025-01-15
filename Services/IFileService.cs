using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Services;
public interface IFileService
{
    bool FileExists(string path);
    void WriteFile(string path);
    
}

