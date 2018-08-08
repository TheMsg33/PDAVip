using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SmartDeviceProject1.Forms.Picking;
using System.Media;
using System.Threading;

namespace SmartDeviceProject1.Forms
{
    public partial class FaturaForm : Form
    {

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        private static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private List<ProdutoPicking> listProd = new List<ProdutoPicking>();
        String dossier2;
        String Atual;
        EscolherDossier menu;

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public string atualizar(String barcode)
        {
            try
            {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));

                byte[] buffer = Encoding.ASCII.GetBytes("cod='" + barcode + "'");
                clientSocket.Send(buffer);


                var buffer2 = new byte[2048];
                int received = clientSocket.Receive(buffer2, SocketFlags.None);
                if (received == 0) return "";
                var data = new byte[received];
                Array.Copy(buffer2, data, received);
                string text = Encoding.ASCII.GetString(data, 0, received);
               

                if (text != "nulo")
                {
                    textBox2.Text = text.Split(';')[1];
                    
                    return "Encontrado";
                }
            }
            catch (Exception)
            {
                clientSocket.Close();
                try
                {
                    LoopConnect();
                }
                catch (Exception)
                {

                    MessageBox.Show("Sem wifi, por favor tente novamente mais tarde");
                    this.Dispose();
                }


            }
            return "";



        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public FaturaForm()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void LoopConnect()
        {
            try
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            catch (Exception) { throw; }

            clientSocket.Connect(new IPEndPoint(IPAddress.Parse(MainMenu.serverIP), 100));

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public int connect(String dossier, EscolherDossier menu)
        {
            this.menu = menu;
            LoopConnect();
            if (loadDossier(dossier)==-1)
            {
                return -1;
            }if (loadDossier(dossier)==-3)
            {
                return -3;
            }
            return listProd.Count;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //public void loadNomeDossier(String dossier)
        //{
        //    this.dossier2 = dossier;
        //    txbDossier.Text = dossier.Split('-')[1];

        //    byte[] buffer = Encoding.ASCII.GetBytes("getnomedossier='" + dossier.Split('-')[1] + "';'" + dossier.Split('-')[0] + "'");
        //    clientSocket.Send(buffer);

        //    var buffer2 = new byte[2048];
        //    int received = clientSocket.Receive(buffer2, SocketFlags.None);
        //    if (received == 0) return;
        //    var data = new byte[received];
        //    Array.Copy(buffer2, data, received);
        //    string text = Encoding.ASCII.GetString(data, 0, received);
        //    textBox3.Text = text;

        //    byte[] buffer4 = Encoding.ASCII.GetBytes("lololol");
        //    clientSocket.Send(buffer4);

        //    var buffer3 = new byte[2048];
        //    int received2 = clientSocket.Receive(buffer3, SocketFlags.None);
        //    if (received2 == 0) return;
        //    var data2 = new byte[received2];
        //    Array.Copy(buffer3, data2, received2);
        //    string text2 = Encoding.ASCII.GetString(data2, 0, received2);
        //    textBox4.Text = text2.Split(' ')[0];


        //}

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public int loadDossier(String dossier)
        {
            this.dossier2 = dossier;
            txbDossier.Text = dossier;

            byte[] buffer = Encoding.ASCII.GetBytes("getdossier='" + dossier.Split('-')[1] + "';'" + dossier.Split('-')[0] + "'");
            clientSocket.Send(buffer);

            var buffer2 = new byte[2048];
            int received = clientSocket.Receive(buffer2, SocketFlags.None);
            if (received == 0) return -2;
            var data = new byte[received];
            Array.Copy(buffer2, data, received);
            string text = Encoding.ASCII.GetString(data, 0, received);

            if (text.Equals("-1"))
            {
                return -1;
            }   else if (text.Equals("-3"))
            {
                return -3;
            }          

            int co = 0;
            listProd = new List<ProdutoPicking>();
            for (int i = 0; i < Int32.Parse(text); i++)
            {
                buffer2 = new byte[10000];
                byte[] buffer3 = Encoding.ASCII.GetBytes("lololol");
                clientSocket.Send(buffer3);
                received = clientSocket.Receive(buffer2, SocketFlags.None);

                data = new byte[received];
                Array.Copy(buffer2, data, received);
                string text2 = Encoding.ASCII.GetString(data, 0, received);
                listProd.Add(new ProdutoPicking(text2.Split(';')[0], text2.Split(';')[1], text2.Split(';')[2].Split('.')[0], text2.Split(';')[3],text2.Split(';')[4]));
                co++;
                
            }


            byte[] buffer4 = Encoding.ASCII.GetBytes("lololol");
            clientSocket.Send(buffer4);
            buffer2 = new byte[2048];
            received = clientSocket.Receive(buffer2, SocketFlags.None);
            if (received == 0) return -2;
            data = new byte[received];
            Array.Copy(buffer2, data, received);
            text = Encoding.ASCII.GetString(data, 0, received);
            textBox3.Text = text;

            buffer4 = Encoding.ASCII.GetBytes("lololol");
            clientSocket.Send(buffer4);

            var buffer8 = new byte[2048];
            int received2 = clientSocket.Receive(buffer8, SocketFlags.None);
            if (received2 == 0) return -2;
            var data2 = new byte[received2];
            Array.Copy(buffer8, data2, received2);
            String text4 = Encoding.ASCII.GetString(data2, 0, received2);
            textBox4.Text = text4.Split(' ')[0];

            updateTable();

            return 1;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void updateTable()
        {

            var list = new BindingList<ProdutoPicking>(listProd);
            dataGrid1.DataSource = list;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public int getID(string codigo)
        {
            int id = -1;
            for (int i = 0; i < listProd.Count; i++)
            {
                if (codigo == listProd[i].codigo.Trim())
                {
                    id = i;
                    return i;
                }
            }
            return -1;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void updateQtt(String codigo, int qtt)
        {
            int id = -1;
            for (int i = 0; i < listProd.Count; i++)
            {
                if (codigo == listProd[i].codigo.Trim())
                {
                    id = i;
                    break;
                }
            }
            if (id != -1)
            {
                listProd[id].QttPickada = qtt;

                if (listProd[id].QttPickada >= listProd[id].qtt)
                {
                    listProd[id].QttPickada = listProd[id].qtt;
                    byte[] buffer = Encoding.ASCII.GetBytes("updossier=" + dossier2.Trim() + ";'" + listProd[id].refe.Trim() + "';'" + listProd[id].QttPickada + "'");
                    clientSocket.Send(buffer);
                    listProd.Remove(listProd[id]);
                    if (listProd.Count==0)
                    {
                        SystemSounds.Asterisk.Play();
                        if (MessageBox.Show("Não tem mais nenhum produto por conferir. Pretende sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            menu.Show();
                            this.Dispose();
                            return;
                        }
                    }
                    Atual = "";
                }
                else
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("updossier=" + dossier2.Trim() + ";'" + listProd[id].refe.Trim() + "';'" + listProd[id].QttPickada + "'");
                    clientSocket.Send(buffer);
                }


            }



            updateTable();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void FaturaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void FaturaForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        char getChar(KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
                return (char)(keyValue + 32);
            return (char)keyValue;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void dataGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up) || (e.KeyCode == System.Windows.Forms.Keys.Down) || (e.KeyCode == System.Windows.Forms.Keys.Left) || (e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                return;
            }
            textBox1.Text = "" + getChar(e);
            textBox1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Return)
            {
                if (textBox1.Text != "")
                {
                    try
                    {

                        long temp = long.Parse(textBox1.Text);

                        if (temp < ((long)999999))
                        {
                            if (Atual != "" && getID(Atual) != -1)
                            {
                                if (((int)temp) > listProd[getID(Atual)].qtt)
                                {
                                    SystemSounds.Asterisk.Play();
                                    MessageBox.Show("Demasiados produtos");
                                    return;
                                }
                                updateQtt(Atual, (int)temp);
                            }
                            else
                            {
                                SystemSounds.Asterisk.Play();
                                MessageBox.Show("Nenhum codigo introduzido");
                            }
                        }
                        else
                        {
                            if (getID(textBox1.Text) == -1)
                            {
                                SystemSounds.Asterisk.Play();
                                MessageBox.Show("Codigo não existente na fatura");
                                textBox1.Text = "";
                                return;
                            }

                            atualizar(textBox1.Text);

                            Atual = textBox1.Text;

                            updateQtt(Atual, (listProd[getID(Atual)].QttPickada + 1));



                        }
                    }
                    catch { MessageBox.Show("Erro na introdução dos dados"); }
                    try
                    {
                        textBox1.Text = "";
                    }
                    catch (Exception)
                    {
                    }
                        
                    
                   
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            byte[] buffer4 = Encoding.ASCII.GetBytes(".");
            clientSocket.Send(buffer4);
            menu.Show();
            this.Dispose();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}