using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class FileExample
    {
        const string filename = "TextFile.txt";

        public void Run()
        {
            string alltext = File.ReadAllText(filename);
            Console.WriteLine("All the text inside the file: {0}", alltext);

            string[] allLines = File.ReadAllLines(filename);
            Console.WriteLine("All the lines inside the file:");
            foreach(string line in allLines)
            {
                Console.WriteLine(line);
            }

            File.WriteAllText(filename, "New text");

            File.WriteAllLines(filename, new[] { "New line 1", "New line 2" });

            File.AppendAllText(filename, "Appended text");

            File.AppendAllLines(filename, new[] { "Appended line 1", "Appended line 2" });

            File.Copy(filename, "TextFile2.txt");

            File.Move("TextFile2.txt", "TextFile3.txt");

            File.Delete("TextFile3.txt");

            using (FileStream fs1 = File.Create("CreatedFile1.txt"))
            {
                fs1.WriteByte((byte)'a');
            }

            bool fileExists = File.Exists("CreatedFile1.txt");

            using (StreamWriter sw1 = File.CreateText("CreatedFile2.txt"))
            {
                sw1.Write(12.34);
            }

            using (FileStream fs2 = File.Open(filename, FileMode.Open))
            {
                int result = fs2.ReadByte();
            }

            using (FileStream fs3 = File.OpenRead(filename))
            {
                int result = fs3.ReadByte();
            }

            using (FileStream fs4 = File.OpenWrite(filename))
            {
                fs4.WriteByte((byte)'b');
            }
        }
    }
}
