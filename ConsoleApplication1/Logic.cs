using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownload
{
   public class Logic
    {
        public IFileDownload _filedownload;
        public Logic(IFileDownload filedownload)
        {
            this._filedownload = filedownload;
        }

        public void printFileSizeCount(string filePath)
        {
            _filedownload.FileDirectorySize(filePath);
        }

        public void printFileSize(string filepaht)
        {
            _filedownload.FileDirectoryCount(filepaht);
        }
    }
}
