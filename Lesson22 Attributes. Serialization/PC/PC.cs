using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class PC
    {
        private string type;
        private string mark;
        private int serialNumber;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public int SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public PC() { }

        public PC(string type, string mark, int serialNumber)
        {
            this.type = type;
            this.mark = mark;
            this.serialNumber = serialNumber;
        }
    }
}
