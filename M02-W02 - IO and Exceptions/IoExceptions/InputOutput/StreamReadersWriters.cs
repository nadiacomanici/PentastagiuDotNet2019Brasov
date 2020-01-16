using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    class StreamReadersWriters
    {
        public void Run()
        {
            using (Stream fileStream = new FileStream("file.txt", FileMode.Create))
            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("Hello world!");
            }

            using (Stream fileStream = new FileStream("file.txt", FileMode.Open))
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                string line = streamReader.ReadLine();
            }

            using (Stream fileStream = new FileStream("file.bin", FileMode.Create))
            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                binaryWriter.Write(3.14);
            }

            using (Stream fileStream = new FileStream("file.bin", FileMode.Open))
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                double pi = binaryReader.ReadDouble();
            }
        }
    }
}
