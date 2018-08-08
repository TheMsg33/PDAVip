﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Media;
using System.Net;

namespace SmartDeviceProject1
{
    public partial class Loc : Form
    {
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public String refe2;
        public String bar2;
        public String Atual = "";

        public String TempAccess;

        String[] array;

        private static MainMenu menu;

        private static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

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
                label3.Visible = false;

                if (text == "nulo")
                {
                    SystemSounds.Exclamation.Play();
                    SystemSounds.Exclamation.Play();
                    SystemSounds.Exclamation.Play();
                    settar("", "", "", "", "", "", "", "", "");
                    return "";
                }
                else
                {
                    label3.Visible = false;
                    Atual = barcode;
                    array = text.Split(';');
                    settar(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[9], array[10]);

                    if (array[7] == "1")
                    {
                        checkBox1.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkBox1.CheckState = CheckState.Unchecked;
                    }
                    if (array[11] == "1")
                    {
                        checkBox2.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkBox2.CheckState = CheckState.Unchecked;
                    }

                    if ((array[3].Split('.')[0] == "0" || array[7].ToLower() == "1") && array[8].ToLower() != "1")
                    {
                        SystemSounds.Hand.Play();
                        SystemSounds.Hand.Play();
                        SystemSounds.Hand.Play();
                        this.BackColor = Color.Blue;
                    }
                    else if (array[8].ToLower() == "1")
                    {
                        SystemSounds.Hand.Play();
                        SystemSounds.Hand.Play();
                        SystemSounds.Hand.Play();
                        label3.Visible = true;
                        this.BackColor = Color.Purple;
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
                    }

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
                    menu.Visible = true;
                    this.Dispose();
                }


            }
            return "";



        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public string atualizarSem(String barcode)
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

                if (text == "nulo")
                {
                    settar("", "", "", "", "", "", "", "", "");
                    return "";
                }
                else
                {
                    label3.Visible = false;
                    Atual = barcode;
                    array = text.Split(';');
                    settar(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[9], array[10]);

                    if (array[7] == "1")
                    {
                        checkBox1.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkBox1.CheckState = CheckState.Unchecked;
                    }
                    if (array[11] == "1")
                    {
                        checkBox2.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkBox2.CheckState = CheckState.Unchecked;
                    }

                    if ((array[3].Split('.')[0] == "0" || array[7].ToLower() == "1") && array[8].ToLower() != "1")
                    {
                        this.BackColor = Color.Blue;
                    }
                    else if (array[8].ToLower() == "1")
                    {
                        label3.Visible = true;
                        this.BackColor = Color.Purple;
                    }
                    else
                    {
                        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
                    }

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
                    menu.Visible = true;
                    this.Dispose();
                }


            }
            return "";



        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public string atualizarSemApitar(String barcode)
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

                if (text == "nulo")
                {
                    this.BackColor = Color.White;
                    return "";
                }
                else
                {

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
                    menu.Visible = true;
                    this.Dispose();
                }


            }
            return "";
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void set(MainMenu menu2)
        {
            menu = menu2;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static void sendInfo(String barcode, String tipo, string valor)
        {
            byte[] buffer = Encoding.ASCII.GetBytes("up='" + barcode + "';" + tipo + ";'" + valor + "'");
            clientSocket.Send(buffer);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void settar(String barcode, String refe, String des, String stock, String gav, String prat, String pal, String encForn, String resCliente)
        {
            refe2 = refe;
            bar2 = barcode;


            txbCod.Text = barcode;
            txbRefe.Text = refe;
            txbDes.Text = des;
            txbStock.Text = stock.Split('.')[0];
            textBox2.Text = resCliente.Split('.')[0];
            textBox3.Text = encForn.Split('.')[0];
            txbGav.Text = gav;
            txbPrat.Text = prat;
            txbPal.Text = pal;

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void setLoc(String barcode, String loc)
        {
            textBox1.Text = "";

            if (loc.ToUpper().StartsWith("B"))
            {
                sendInfo(barcode, "lpalete", loc);
            }
            else
            {
                if (loc.Contains("-"))
                {
                    sendInfo(barcode, "lgaveta", loc);
                }
                else
                {
                    sendInfo(barcode, "lcaixa", loc);
                }
            }

            textBox1.Text = "";



            atualizar(barcode);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void connect()
        {

            LoopConnect();

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public Loc()
        {
            InitializeComponent();

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblDes_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Loc_Load(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && textBox1.Text != "")
            {
                try
                {
                    long.Parse(textBox1.Text);
                    atualizar(textBox1.Text);
                }
                catch (Exception)
                {
                    if (Atual != "")
                    {
                        setLoc(Atual, textBox1.Text);
                    }

                }

                textBox1.Text = "";
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Loc_KeyDown(object sender, KeyEventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Loc_Closing(object sender, CancelEventArgs e)
        {
            menu.Visible = true;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            TempAccess = txbGav.Text;
            txbGav.Text = "";
            txbGav.ReadOnly = false;
            txbGav.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbGav_LostFocus(object sender, EventArgs e)
        {
            if (txbGav.Text != "" && txbGav.ReadOnly == false)
            {
                sendInfo(Atual, "lgaveta", txbGav.Text);
            }
            else if (txbGav.Text == "" && txbGav.ReadOnly == false)
            {
                txbGav.Text = TempAccess;
                txbGav.ReadOnly = true;
            }

            txbGav.ReadOnly = true;
            atualizar(Atual);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbGav_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                if (txbGav.Text != "")
                {
                    if (Atual != "")
                    {
                        sendInfo(Atual, "lgaveta", txbGav.Text);
                        txbGav.ReadOnly = true;
                        textBox1.Focus();
                        atualizar(Atual);
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecione um codigo de barras primeiro");
                    }
                }
                else
                {
                    txbGav.Text = TempAccess;
                    txbGav.ReadOnly = true;
                }
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPrat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txbPrat.Text != "")
                {
                    sendInfo(Atual, "lcaixa", txbPrat.Text);
                    txbPrat.ReadOnly = true;

                    textBox1.Focus();
                    atualizar(Atual);
                }
                else
                {
                    txbPrat.Text = TempAccess;
                    txbPrat.ReadOnly = true;
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txbPal.Text != "")
                {
                    sendInfo(Atual, "lpalete", txbPal.Text);
                    txbPal.ReadOnly = true;

                    textBox1.Focus();
                    atualizar(Atual);
                }
                else
                {
                    txbPal.Text = TempAccess;
                    txbPal.ReadOnly = true;
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPal_LostFocus(object sender, EventArgs e)
        {
            if (txbPal.Text != "" && txbPal.ReadOnly == false)
            {

                sendInfo(Atual, "lpalete", txbPal.Text);
                atualizar(Atual);

            }
            else if (txbPal.Text == "" && txbPal.ReadOnly == false)
            {
                txbPal.Text = TempAccess;
                txbPal.ReadOnly = true;
            }
            txbPal.ReadOnly = true;


        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPrat_LostFocus(object sender, EventArgs e)
        {
            if (txbPrat.Text != "" && txbPrat.ReadOnly == false)
            {
                sendInfo(Atual, "lcaixa", txbPrat.Text);
                atualizar(Atual);
            }
            else if (txbPrat.Text == "" && txbPrat.ReadOnly == false)
            {
                txbPrat.Text = TempAccess;
                txbPrat.ReadOnly = true;
            }

            txbPrat.ReadOnly = true;


        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbCod_GotFocus(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbRefe_GotFocus(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbDes_GotFocus(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbGav_GotFocus(object sender, EventArgs e)
        {
            if (txbGav.ReadOnly == true)
            {
                textBox1.Focus();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPrat_GotFocus(object sender, EventArgs e)
        {
            if (txbPrat.ReadOnly == true)
            {
                textBox1.Focus();
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPal_GotFocus(object sender, EventArgs e)
        {
            if (txbPal.ReadOnly == true)
            {
                textBox1.Focus();
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbStock_GotFocus(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button3_GotFocus(object sender, EventArgs e)
        {
            if (Atual != "")
            {
                TempAccess = txbPal.Text;
                txbPal.Text = "";
                txbPal.ReadOnly = false;
                txbPal.Focus();
            }
            else
            {
                textBox1.Focus();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button2_GotFocus(object sender, EventArgs e)
        {
            if (Atual != "")
            {
                TempAccess = txbPrat.Text;
                txbPrat.Text = "";
                txbPrat.ReadOnly = false;
                txbPrat.Focus();
            }
            else
            {
                textBox1.Focus();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button1_GotFocus(object sender, EventArgs e)
        {
            if (Atual != "")
            {
                TempAccess = txbGav.Text;
                txbGav.Text = "";
                txbGav.ReadOnly = false;
                txbGav.Focus();
            }
            else
            {
                textBox1.Focus();
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button6_GotFocus(object sender, EventArgs e)
        {
            if (Atual != "")
            {
                sendInfo(Atual, "lgaveta", "");
                txbGav.ReadOnly = true;


                atualizar(Atual);
            }
            textBox1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button5_GotFocus(object sender, EventArgs e)
        {
            if (Atual != "")
            {
                sendInfo(Atual, "lcaixa", "");
                txbPrat.ReadOnly = true;


                atualizar(Atual);
            }
            textBox1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button4_GotFocus(object sender, EventArgs e)
        {
            if (Atual != "")
            {
                sendInfo(Atual, "lpalete", "");
                txbPal.ReadOnly = true;


                atualizar(Atual);
            }
            textBox1.Focus();

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbRefe_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbCod_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pretende sair?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                menu.Visible = true;
                this.Dispose();
            }
            textBox1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPal_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbCod_TextChanged_1(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbStock_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbPrat_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbGav_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbDes_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void txbRefe_TextChanged_1(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblStock_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblPrat_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblPal_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblGav_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblRef_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblBar_ParentChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
            sendInfo(Atual, "nstknet", "" + ((checkBox1.CheckState == CheckState.Checked) ? 1 : 0));
            atualizarSem(Atual);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
            byte[] buffer2 = Encoding.ASCII.GetBytes("upconfirma='" + Atual + "';'" + ((checkBox2.CheckState == CheckState.Checked) ? 1 : 0) + "'");
            clientSocket.Send(buffer2);
            atualizarSem(Atual);
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblPrat_ParentChanged_1(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void lblPal_ParentChanged_1(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}