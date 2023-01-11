
namespace Telephony.IO
{
    using Interfaces;
    using System;
    using System.IO;
    using System.Text;

    public class FileWriter : IWriter
    {
        private string filePath;
        public FileWriter(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath
        {
            get
            {
                return this.filePath;
            }
            private set
            {
                if (File.Exists(value))
                {
                    throw new ArgumentException("Invalid file path!");
                }
                this.filePath = value;
            }
        }
        public void Write(string text)
        {
            File.WriteAllText(filePath, text);
        }

        public void WriteLine(string text)
        {
            File.WriteAllText(filePath
            ,$"{text} {Environment.NewLine}");
        }
    }
}
