using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SmartDeviceProject1.Forms.Picking
{
    class ProdutoPicking
    {

        public String refe{ get; set; }
        public int QttPickada { get; set; }
        public int qtt { get; set; }
        
        public String design{ get; set; }
        public String codigo{ get; set; }



        public ProdutoPicking(String refe, String design, String qtt, String codigo, String qtt2)
        {
            this.refe = refe;
            this.design = design;
            this.qtt = Int32.Parse(qtt);
            this.codigo = codigo;
            try
            {
                this.QttPickada = Int32.Parse(qtt2);
            }
            catch (Exception)
            {
                this.QttPickada = 0;
            }
            
        }

    }
}
