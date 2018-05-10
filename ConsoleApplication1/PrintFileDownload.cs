using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownload
{
    public class PrintFileDownload : IFileDownload
    {
        public void FileDirectoryCount(string FilePath)
        {
            string[] a = Directory.GetFiles(FilePath, "*.*");


            long b = 0;
            foreach (string name in a)
            {

                b++;
            }

            Console.WriteLine("FileDirectorySize", b);
            Console.WriteLine(b);
        }

        public void FileDirectorySize(string FilePath)
        {
            
            string[] a = Directory.GetFiles(FilePath, "*.*");

            
            long b = 0;
            foreach (string name in a)
            {
                
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }

            Console.WriteLine("FileDirectorySize", b);
            Console.WriteLine(b);
        }
    }
}
