using AaSOLID.SOLID.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaSOLID.SOLID.Main
{
    internal class ConsoleWriter : IWriter
    {
        public ConsoleWriter() { } 
        public bool Write(object data)
        {
            Console.WriteLine(data);
            return true;
        }
    }
}
