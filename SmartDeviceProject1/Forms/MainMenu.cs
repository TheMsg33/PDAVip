using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.Forms;
using SmartDeviceProject1.Forms.Localização;
using System.IO;

namespace SmartDeviceProject1
{
    public partial class MainMenu : Form
    {

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static String serverIP;
        public static Dictionary<string, string> props;
        

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public MainMenu()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.Text = GetProperties("./Loc/Props.txt")["ip"];
                props = GetProperties("./Loc/Props.txt");
                serverIP = props["ip"];
            }
            catch
            {
                Directory.CreateDirectory("./Loc/");
                
                File.CreateText("./Loc/Props.txt").Close();
                using (var file = new StreamWriter("./Loc/Props.txt"))
                {
                    file.Write("ip=192.168.100.57");
                    file.Close();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static Dictionary<string, string> GetProperties(string path)
        {
            StreamReader sr;
            
                string fileData = "";
                sr = new StreamReader(path);
            try{
                fileData = sr.ReadToEnd().Replace("\r", "");



                Dictionary<string, string> Properties = new Dictionary<string, string>();
                string[] kvp;
                string[] records = fileData.Split("\n".ToCharArray());
                foreach (string record in records)
                {
                    if (!(record == "" || record == null))
                    {
                        kvp = record.Split("=".ToCharArray());
                        Properties.Add(kvp[0], kvp[1]);
                    }

                }
                sr.Close();
                return Properties;
            }
            catch (Exception)
            {
                sr.Close();
                throw;
            }
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            Loc loc = new Loc();
            loc.set(this);
            try
            {
                loc.connect();
                loc.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sem conexão, por favor ligue o wifi");
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            LocAuto loc = new LocAuto();
            loc.set(this);
            try
            {
                loc.connect();
                loc.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Sem conexão, por favor ligue o wifi");
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            EscolherDossier d = new EscolherDossier();
            d.settar(this);
            d.Show();
            this.Hide();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void button6_Click(object sender, EventArgs e)
        {

            serverIP = textBox1.Text;

            using (var file = new StreamWriter("./Loc/Props.txt"))
            {
                file.Write("ip=" + serverIP);
                file.Close();
            }

            MessageBox.Show("Ip alterado para " + serverIP);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dentro d = new Dentro();
            if (d.connect(this) == 1)
            {
                d.Show();
                this.Hide();
            }
            else
            {
                d.Dispose();
                MessageBox.Show("Sem wifi, por favor verifique a ligaçao");
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}