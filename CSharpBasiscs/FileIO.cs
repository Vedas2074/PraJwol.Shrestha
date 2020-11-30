using System;
using System.IO;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText(@"C:\Users\Shrestha Pzl\OneDrive\Desktop\Semester VI\Subjects\Net Centric Computing\git note.txt");
            Console.WriteLine(fileContent);
        }

        public void LearnFileWriting()
        {
            File.WriteAllText("A.html", "This is the new fine just created.");
        }

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;

            Console.WriteLine($"File Size: {x} bytes");
            Console.WriteLine($"Created: {y}");
            Console.WriteLine($"Directory: {z}");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\a.Shrestha", "This is my own just created file.");
        }

        internal void LearnDirectoryInfo()
        {
            string folderPath = @"C:\Users\Shrestha Pzl\OneDrive\Desktop\Semester VI\Subjects\Net Centric Computing";
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var files = directory = new DirectoryInfo(folderPath);
            Console.WriteLine("File count: " + files.LastAccessTime);
        }
    }
}