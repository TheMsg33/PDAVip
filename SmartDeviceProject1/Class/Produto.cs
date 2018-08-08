using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1
{
    class Produto
    {
        public string refe { get; set; }
        public int qtd { get; set; }

        public Produto( String refe, int qtd)
        {
            this.refe = refe;
            this.qtd = qtd;
        }
    }
}
