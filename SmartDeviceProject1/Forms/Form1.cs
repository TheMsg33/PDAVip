using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1
{
    public partial class Form1 : Form
    {
        public Form2 visor = new Form2();

        

        private int item;

        private List<string> listCodBarras = new List<string>();

        private List<string> ListRef = new List<string>();

        private List<string> ListDesign = new List<string>();

        private List<string> ListCaixa = new List<string>();

        private List<string> ListPalete = new List<string>();

        private List<string> ListGaveta = new List<string>();

        private List<Produto> listProd = new List<Produto>();




        public Form1()
        {            
            InitializeComponent();
            dataGrid1.DataSource = listProd;
        }

        public void updateTable()
        {

            var list = new BindingList<Produto>(listProd);
            dataGrid1.DataSource = list;
        }

        public void add(String refe, int qtd)
        {
            if (procurarList(refe) != -1)
            {
                listProd[procurarList(refe)].qtd = listProd[procurarList(refe)].qtd+qtd;
                
            }
            else
            {
                listProd.Add(new Produto(refe,qtd));
            }
            updateTable();
        }

        public void setQtd(String refe, int qtd)
        {
            if (procurarList(refe) != -1)
            {
                listProd[procurarList(refe)].qtd = qtd;
            }
            else
            {
                listProd.Add(new Produto(refe, qtd));
            }
            updateTable();
        }

        public void remove(String refe)
        {
            try
            {
                listProd.RemoveAt(procurarList(refe));
                
            }
            catch (Exception)
            {
                
            }
            
            updateTable();
        }

        public void import()
        {
            int counter = 1;

            StreamReader reader;

            if (File.Exists("C:\\Users\\TheMsg\\Documents\\LOCAL.csv"))
            {
                reader = File.OpenText("C:\\Users\\TheMsg\\Documents\\LOCAL.csv");
            }
            else
            {
                reader = File.OpenText("\\LOCAL.csv");
            }
            string text;
            string[] array;
            while (!reader.EndOfStream)
            {
                try
                {
                    
                    text = reader.ReadLine();



                    array = text.Split(';');
                    listCodBarras.Add(array[0]);
                    ListRef.Add(array[1]);
                    ListDesign.Add(array[2]);
                    ListCaixa.Add(array[3]);
                    ListPalete.Add(array[4]);
                    ListGaveta.Add(array[5]);
                    counter++;
                }
                catch { reader.DiscardBufferedData(); }                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Verificar()
        {
            string text = textBox1.Text;
            if (item > 0)
            {
                if (listCodBarras.Count > ~item)
                {
                    if (procurarList(ListRef[item]) == -1)
                    {
                        if (visor.IsDisposed)
                        {
                            visor = new Form2();
                        }
                        visor.Show();
                        visor.settar(textBox1.Text, ListRef[item].ToString(), ListDesign[item].ToString(), ListCaixa[item].ToString(), ListGaveta[item].ToString(), ListPalete[item].ToString(), procurarListQTD(ListRef[item].ToString()), this);
                    }
                    else
                    {
                        add(ListRef[item].ToString(), 1);
                    }
                }
                else
                {
                    MessageBox.Show("Não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Não encontrado");
            }
            textBox1.Text = "";
        }

        public void visao(String bar)
        {
            try
            {
                if (procurarList(ListRef[listCodBarras.IndexOf(bar)]) != -1)
                {
                    add(ListRef[listCodBarras.IndexOf(bar)], 1);

                }
                else
                {
                    item = listCodBarras.IndexOf(bar);
                    Verificar();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Não encontrado");
            }
            

                textBox1.Text = "";
        }
        public void visao2(String bar, String oldref)
        {


            add(oldref, 1);

            if (procurarList(ListRef[listCodBarras.IndexOf(bar)]) != -1)
            {
                
                add(ListRef[listCodBarras.IndexOf(bar)], 1);
                visor.Hide();
            }
            else
            {
                item = listCodBarras.IndexOf(bar);
                Verificar();
            }

            textBox1.Text = "";
        }

        public int procurarListQTD(String refe)
        {
            for (int i = 0; i < listProd.Count; i++)
            {
                if (listProd[i].refe==refe)
                {
                    return listProd[i].qtd;
                }
            }
            return 1;
        }

        public int procurarList(String refe)
        {
            for (int i = 0; i < listProd.Count; i++)
            {
                if (listProd[i].refe == refe)
                {
                    return i;
                }
            }
            return -1;
        }

        public void seguido(String refe, int qtd)
        {
            setQtd(refe, qtd);

        }

        public void apagado(String refe)
        {
            remove(refe);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            import();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            import();

            textBox1.Focus();
        }



        public void exportar()
        {
            using (var file = File.CreateText(".\\Exports\\export1.csv"))
            {
                foreach (Produto prod in listProd)
                {
                    string a = prod.refe.PadRight(22);
                    string b = a + "" + prod.qtd;
                    file.WriteLine(b);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            exportar();

            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && textBox1.Text!="")
            {
                visao(textBox1.Text);
            }
        }

        public void removerForm(String barcode)
        {
            apagado(ListRef[listCodBarras.IndexOf(barcode)]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                remove(listProd[dataGrid1.CurrentCell.RowNumber].refe);
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor selecione uma referencia");
            }
            
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }
        }


    }
}