using AaSOLID.SOLID.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaSOLID.SOLID.Main
{
    internal class GeneratorIntRandom(BaseSetting setting) : IGenerator
    {
        private readonly BaseSetting Setting = setting;

        public object Generate()
        {
            var random = new Random();
            Int32 target = random.Next(Setting.Min, Setting.Max);
            return target;
        }
    }
}
