using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownload
{
 public   interface IFileDownload
    {
        void FileDirectoryCount(string FilePath);

        void FileDirectorySize(string FilePath);
    }
}
