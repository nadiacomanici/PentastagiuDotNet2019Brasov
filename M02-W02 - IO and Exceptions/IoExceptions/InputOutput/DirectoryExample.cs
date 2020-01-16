using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class DirectoryExample
    {
        public void Run()
        {
            bool windowsExists = Directory.Exists("C:\\windows");

            Directory.CreateDirectory("NewDirectory");

            Directory.Move("NewDirectory", "MovedDirectory");

            Directory.Delete("MovedDirectory");

            string[] files = Directory.GetFiles("c:\\");

            string[] directories = Directory.GetDirectories("c:\\");

            string[] allTextFiles = Directory.GetFiles(@"c:\Users\oradoi\AppData\Local\Temp", "*.txt", SearchOption.AllDirectories);
        }
    }
}
