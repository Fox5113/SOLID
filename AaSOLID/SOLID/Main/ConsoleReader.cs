using AaSOLID.SOLID.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaSOLID.SOLID.Main
{
    internal class ConsoleUIntReader : IReader
    {
        
        public static  object  Read()
        {
            string? Read = null;
            int userNumber = default;
            while (Read == null)
            {
                try
                {
                    Read = Console.ReadLine();
                    if(Read == null)
                    {
                        continue;
                    }
                    userNumber = Math.Abs(int.Parse(Read));
                }
                catch (Exception)
                {
                    Console.WriteLine(TextResource.InputFail);
                    Read = null;
                }
            }

            return userNumber;
        }
    }
}
