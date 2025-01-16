using BarterBound.Core.Interfaces;
using BarterBound.Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarterBound.Admin.AddScene
{
    public class FileManagementController
    {
        private readonly IFile _file;

        public FileManagementController(IFile file)
        {
            _file = file;
        }
    }
}
