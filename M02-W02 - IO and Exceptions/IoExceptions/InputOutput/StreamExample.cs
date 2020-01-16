using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class StreamExample
    {
        public void Run()
        {
            using (FileStream fileStream = new FileStream("test.txt", FileMode.Create))
            {
                fileStream.WriteByte((byte)'a');
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.WriteByte((byte)'a');
                byte[] array = memoryStream.ToArray();
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (Stream bufferedStream = new BufferedStream(memoryStream))
                {
                    bufferedStream.WriteByte((byte)'a');
                }
                byte[] array = memoryStream.ToArray();
            }
        }
    }
}
