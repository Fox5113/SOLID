using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AaSOLID.SOLID.BaseClasses
    /*
     Принцип открытости/закрытости (Open-closed Principle или OCP)
    */
{
    abstract class BaseSetting: ISave, ILoad //I — Принцип разделения интерфейса (Interface Segregation Principle или ISP)
    {

        [JsonPropertyName("Min")]
        public int Min { get; protected set; }
        [JsonPropertyName("Max")]
        public int Max { get; protected set; }
        [JsonPropertyName("NumberAttempts")]
        public int NumberAttempts { get; protected set; }

        public BaseSetting() { }

        public abstract (int, int, int) GetSettings();
        public abstract void Save(); ///D — Принцип инверсии зависимостей (dependency inversion principle или DIP)
        public abstract void Load(); //D — Принцип инверсии зависимостей (dependency inversion principle или DIP)
    }
}
