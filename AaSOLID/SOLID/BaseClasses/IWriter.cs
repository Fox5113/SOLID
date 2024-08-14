using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Интерфейс записи куда угодно
 */
namespace AaSOLID.SOLID.BaseClasses
{
    /*
     Принцип открытости/закрытости (Open-closed Principle или OCP)
    */

    internal interface IWriter
    {
        abstract bool Write(object data);
    }
}
