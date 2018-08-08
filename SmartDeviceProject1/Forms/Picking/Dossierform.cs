using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1.Forms
{
    public partial class EscolherDossier : Form
    {

        public MainMenu menu;

        public EscolherDossier()
        {
            InitializeComponent();
        }

        public void settar(MainMenu menu2)
        {
            this.menu = menu2;
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

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Return&&textBox1.Text!="")
            {
                if (textBox1.Text.Split('-').Length!=2)
                {
                    MessageBox.Show("Erro na introdoção do numero de fatura");
                    textBox1.Text = "";
                    return;
                }
                FaturaForm fatura = new FaturaForm();
                int msg = fatura.connect(textBox1.Text,this);
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

        private void button10_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Dispose();
        }

        private void EscolherDossier_Load(object sender, EventArgs e)
        {

        }
    }
}