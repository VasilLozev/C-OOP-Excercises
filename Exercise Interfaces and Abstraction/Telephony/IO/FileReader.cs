

namespace Telephony.IO
{
    using System;
    using Telephony.IO;

    using Interfaces;
    using System.IO;

    public class FileReader : IReader
    {
        private string filePath;
        private string[] fileAllLines;

        
        public FileReader(string filePath)
        {
             FilePath = filePath;
            this.fileAllLines = File.ReadAllLines(filePath);
            this.RowNumber = 0;
        }

        public string FilePath 
        { 
            get
            {
                return this.filePath;
            }
            private set
            {
                if (Directory.Exists(value))
                {
                    throw new ArgumentException("Invalid file path!");
                }
                this.filePath = value;
            }
        }
        public int RowNumber { get; private set; }

        public string ReadLine()
        {
            if (this.RowNumber >= this.fileAllLines.Length)
            {
                throw new InvalidOperationException("No more content in the file!");
            }

            return this.fileAllLines[this.RowNumber++];
        }
    }
}
