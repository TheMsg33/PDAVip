using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Forms.Localização
{
    class ProdGav
    {
        public String refe { get; set; }
        public String codigo { get; set; }
        public int stock { get; set; }
        public String design { get; set; }
        public String gav { get; set; }
        public String prat { get; set; }
        public String pal { get; set; }


        public ProdGav(String refe, String codigo, String stock, String design, String gav, String prat, String pal)
        {
            this.refe = refe;
            this.codigo = codigo;
            this.stock = Int32.Parse(stock);
            this.design = design;
            this.gav = gav;
            this.prat = prat;
            this.pal = pal;
        }
    }
}
