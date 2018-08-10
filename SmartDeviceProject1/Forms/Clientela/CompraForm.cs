using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SmartDeviceProject1.Class;

namespace SmartDeviceProject1.Forms.Clientela
{
    public partial class CompraForm : Form
    {

        public List<ProdutoCompra> listProd;
        
        public CompraForm()
        {
            InitializeComponent();
        }


        private void CompraForm_Load(object sender, EventArgs e)
        {
            listProd = new List<ProdutoCompra>();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_GotFocus(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}