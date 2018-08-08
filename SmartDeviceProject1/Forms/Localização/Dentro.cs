using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace SmartDeviceProject1.Forms.Localização
{
    public partial class Dentro : Form
    {
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public MainMenu menu;
        private List<ProdGav> listProd = new List<ProdGav>();
        private String Atual="";
        private static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public Dentro()
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
            catch (Exception) { }

            clientSocket.Connect(new IPEndPoint(IPAddress.Parse(MainMenu.serverIP), 100));

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public int connect(MainMenu menu)
        {
            try
            {
                LoopConnect();
            }
            catch (Exception)
            {

                return 0;
            }
            this.menu = menu;
            return 1;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void loadLoc(String loc)
        {
            this.Atual = loc;
            textBox2.Text = loc;

            String text="";
            if (loc.ToUpper().StartsWith("B"))
            {
                text = "palete";
            }
            else
            {
                if (loc.Contains("-"))
                {
                    text = "gaveta";
                }
                else
                {
                    text = "caixa";
                }
            }

            byte[] buffer = Encoding.ASCII.GetBytes("getloc=l" + text + ";'" + loc + "'");
            clientSocket.Send(buffer);

            var buffer2 = new byte[2048];
            int received = clientSocket.Receive(buffer2, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer2, data, received);
            string text4 = Encoding.ASCII.GetString(data, 0, received);
            int count = Int32.Parse(text4);
            int co = 0;
            listProd = new List<ProdGav>();
            for (int i = 0; i < count; i++)
            {
                byte[] buffer3 = Encoding.ASCII.GetBytes("TheShowMustGoOn");
                clientSocket.Send(buffer3);
                buffer2 = new byte[10000];
                received = clientSocket.Receive(buffer2, SocketFlags.None);

                data = new byte[received];
                Array.Copy(buffer2, data, received);
                string text2 = Encoding.ASCII.GetString(data, 0, received);
                listProd.Add(new ProdGav(text2.Split(';')[0], text2.Split(';')[1], text2.Split(';')[2].Split('.')[0], text2.Split(';')[3], text2.Split(';')[4], text2.Split(';')[5], text2.Split(';')[6]));
                co++;
                
            }
            updateTable();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button9_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void updateTable()
        {

            var list = new BindingList<ProdGav>(listProd);
            dataGrid1.DataSource = list;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Dentro_Load(object sender, EventArgs e)
        {
            updateTable();
            textBox1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button9_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Dispose();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Return&&textBox1.Text!="")
            {
                loadLoc(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}