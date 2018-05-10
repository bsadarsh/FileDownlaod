using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic c = new Logic(new PrintFileDownload());

            c.printFileSize("D:\\TempFolder");
            c.printFileSizeCount("D:\\TempFolder");
            Console.ReadLine();
        }
    }
}
