using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class EnvironmentExample
    {
        public void Run()
        {
            var variables = Environment.GetEnvironmentVariables();

            string expanded = Environment.ExpandEnvironmentVariables("%TEMP%\\test.txt");

            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string mydocsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
