using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public   class Productos: Interface1
    {
        public   string name { get; set; }

        public   string Usuario { get; set; }

        public string getdata(int value)
        {
            throw new NotImplementedException();
        }
    }
}
