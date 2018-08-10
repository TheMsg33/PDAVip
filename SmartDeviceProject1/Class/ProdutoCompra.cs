using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Class
{
    class ProdutoCompra
    {
        public string refe { get; set; }
        public int qtd { get; set; }
        public string design { get; set; }
        public int preço { get; set; }
        public string barcode;

        public ProdutoCompra(String refe, int qtd, String design, int preço, String barcode)
        {
            this.refe = refe;
            this.qtd = qtd;
        }

    }
}
