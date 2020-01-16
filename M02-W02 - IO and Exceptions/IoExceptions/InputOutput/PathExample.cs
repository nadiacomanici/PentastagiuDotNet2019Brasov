using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class PathExample
    {
        public void Run()
        {
            // Combine example
            string combinedPath = Path.Combine("c:\\", "windows", "system32");
            Console.WriteLine("The combined path is: {0}", combinedPath);

            // GetFileNameWithoutExtension example
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension("d:\\test1\\test2.txt");
            Console.WriteLine("The file name without extension: {0}", fileNameWithoutExtension);

            // GetExtension example
            string extension = Path.GetExtension("d:\\test1\\test2.txt");
            Console.WriteLine("The extension is: {0}", extension);

            // GetFullPath example
            string fullPath = Path.GetFullPath("test3.txt");
            Console.WriteLine("The full path is: {0}", fullPath);

            // GetTempFileName
            string tempFileName = Path.GetTempFileName();
            Console.WriteLine("The temp file name is: {0}", tempFileName);

            // GetTempPath
            string tempPath = Path.GetTempPath();
            Console.WriteLine("The temp path is: {0}", tempPath);

            // GetInvalidPathChars and GetInvalidFileNameChars
            char[] invalidPathChars = Path.GetInvalidPathChars();
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
        }
    }
}
