using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1
{
    public partial class Form2 : Form
    {
        private String refe2;
        private String bar2;
        private Form1 form2;
        public Form2()
        {
            InitializeComponent();
        }

        public void settar(String barcode, String refe, String des, String prateleira, String palete, String gaveta, int qtd, Form1 form)
        {
            refe2 = refe;
            form2 = form;
            bar2 = barcode;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbStock.Text!="")
            {
                try
                {
                    seguir(Int32.Parse(txbStock.Text));
                }
                catch (Exception)
                {
                    
                    
                }
                
            }

            txbStock.Focus();
            
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                seguir(Int32.Parse(txbStock.Text));
            }
        }

        public void seguir(int qtd)
        {
            this.Hide();
            form2.Show();
            form2.seguido(refe2, qtd);
        }

        private void btnRejeitar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
            form2.apagado(refe2);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txbStock.Text != "")
                {
                    try
                    {
                        if (long.Parse(txbStock.Text) > 999999)
                        {
                            form2.visao2(txbStock.Text, refe2);
                            
                        }
                        else
                        {
                            seguir(Int32.Parse(txbStock.Text));
                        }
                    }
                    catch (Exception)
                    {


                    }

                }
                txbStock.Text = "";
            }
        }


    }
}