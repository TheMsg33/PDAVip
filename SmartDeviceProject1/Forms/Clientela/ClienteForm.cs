using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1.Forms.Clientela
{
    public partial class ClienteForm : Form
    {

        MainMenu menu;

        public ClienteForm()
        {
            InitializeComponent();
        }

        public void settar(MainMenu menu)
        {
            this.menu = menu;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && textBox1.Text != "")
            {
                FaturaForm fatura = new FaturaForm();
                int msg = 0;
                textBox1.Text = "";
                if (msg > 0)
                {
                    fatura.Show();
                }
                else if (msg == -1)
                {
                    MessageBox.Show("Dossier fechado");
                    fatura.Dispose();
                }
                else if (msg == -3)
                {
                    MessageBox.Show("Dossier já conferido");
                    fatura.Dispose();
                }
                else
                {
                    MessageBox.Show("Não encontrado");
                    fatura.Dispose();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}