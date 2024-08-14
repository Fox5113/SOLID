using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaSOLID.SOLID.BaseClasses
{
    /*
     Принцип открытости/закрытости (Open-closed Principle или OCP)
    */
    internal interface IGenerator
    {
        public abstract object Generate();
    }
}
