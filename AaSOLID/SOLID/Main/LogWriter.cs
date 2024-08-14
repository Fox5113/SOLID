using AaSOLID.SOLID.BaseClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaSOLID.SOLID.Main
{
    /*
     * Принцип единственной ответственности
     */
    internal class LogWriter : IWriter
    {
        public LogWriter(string path)
        {
            SetFilePath(path);
            if (path == null) throw new ArgumentNullException(nameof(path));
        }

        private static string FilePath = "Log.txt";

        public static string GetFilePath()
        {
            return FilePath;
        }

        public static void SetFilePath(string path)
        {
            FilePath = path;
        }

        public bool Write(object data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true, System.Text.Encoding.Default))
                {
                    writer.WriteLine((string)data);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
