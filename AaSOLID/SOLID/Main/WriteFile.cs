using AaSOLID.SOLID.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AaSOLID.SOLID.Main
{
    internal class WriteFile(string filePath) : IWriter
    {
        public string? FilePath { get; private set; } = filePath;

        public void SetFilePath(string path)
        {
            this.FilePath = path;
        }

        public bool Write(object data)
        {
            if(FilePath== null) { return false; }
            using StreamWriter writetext = new(path: FilePath);
            string jsonString = JsonSerializer.Serialize(data);
            writetext.WriteLine(jsonString);
            writetext.Close();

            return true;
        }
    }
}
