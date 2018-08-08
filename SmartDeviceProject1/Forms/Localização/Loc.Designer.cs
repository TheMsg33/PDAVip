using System.Drawing;
namespace SmartDeviceProject1
{
    partial class Loc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loc));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblBar = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblGav = new System.Windows.Forms.Label();
            this.lblPal = new System.Windows.Forms.Label();
            this.lblPrat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txbRefe = new System.Windows.Forms.TextBox();
            this.txbDes = new System.Windows.Forms.TextBox();
            this.txbGav = new System.Windows.Forms.TextBox();
            this.txbPrat = new System.Windows.Forms.TextBox();
            this.txbPal = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBar
            // 
            this.lblBar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblBar.Location = new System.Drawing.Point(4, 31);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(233, 20);
            this.lblBar.Text = "Código barras:";
            // 
            // lblRef
            // 
            this.lblRef.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRef.Location = new System.Drawing.Point(4, 54);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(233, 20);
            this.lblRef.Text = "Referência:";
            // 
            // lblGav
            // 
            this.lblGav.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblGav.Location = new System.Drawing.Point(4, 177);
            this.lblGav.Name = "lblGav";
            this.lblGav.Size = new System.Drawing.Size(233, 20);
            this.lblGav.Text = "Gaveta:";
            // 
            // lblPal
            // 
            this.lblPal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPal.Location = new System.Drawing.Point(4, 221);
            this.lblPal.Name = "lblPal";
            this.lblPal.Size = new System.Drawing.Size(233, 20);
            this.lblPal.Text = "Palete:";
            this.lblPal.ParentChanged += new System.EventHandler(this.lblPal_ParentChanged_1);
            // 
            // lblPrat
            // 
            this.lblPrat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrat.Location = new System.Drawing.Point(4, 199);
            this.lblPrat.Name = "lblPrat";
            this.lblPrat.Size = new System.Drawing.Size(233, 20);
            this.lblPrat.Text = "Prat.:";
            this.lblPrat.ParentChanged += new System.EventHandler(this.lblPrat_ParentChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(4, 100);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(233, 20);
            this.lblStock.Text = "Stock Actual:";
            // 
            // txbRefe
            // 
            this.txbRefe.Location = new System.Drawing.Point(111, 52);
            this.txbRefe.Name = "txbRefe";
            this.txbRefe.ReadOnly = true;
            this.txbRefe.Size = new System.Drawing.Size(126, 21);
            this.txbRefe.TabIndex = 17;
            this.txbRefe.TextChanged += new System.EventHandler(this.txbRefe_TextChanged);
            this.txbRefe.GotFocus += new System.EventHandler(this.txbRefe_GotFocus);
            // 
            // txbDes
            // 
            this.txbDes.Location = new System.Drawing.Point(4, 75);
            this.txbDes.Name = "txbDes";
            this.txbDes.ReadOnly = true;
            this.txbDes.Size = new System.Drawing.Size(233, 21);
            this.txbDes.TabIndex = 18;
            this.txbDes.GotFocus += new System.EventHandler(this.txbDes_GotFocus);
            // 
            // txbGav
            // 
            this.txbGav.Location = new System.Drawing.Point(89, 175);
            this.txbGav.Name = "txbGav";
            this.txbGav.ReadOnly = true;
            this.txbGav.Size = new System.Drawing.Size(58, 21);
            this.txbGav.TabIndex = 19;
            this.txbGav.GotFocus += new System.EventHandler(this.txbGav_GotFocus);
            this.txbGav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbGav_KeyDown);
            this.txbGav.LostFocus += new System.EventHandler(this.txbGav_LostFocus);
            // 
            // txbPrat
            // 
            this.txbPrat.Location = new System.Drawing.Point(89, 197);
            this.txbPrat.Name = "txbPrat";
            this.txbPrat.ReadOnly = true;
            this.txbPrat.Size = new System.Drawing.Size(58, 21);
            this.txbPrat.TabIndex = 20;
            this.txbPrat.GotFocus += new System.EventHandler(this.txbPrat_GotFocus);
            this.txbPrat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPrat_KeyDown);
            this.txbPrat.LostFocus += new System.EventHandler(this.txbPrat_LostFocus);
            // 
            // txbPal
            // 
            this.txbPal.Location = new System.Drawing.Point(89, 219);
            this.txbPal.Name = "txbPal";
            this.txbPal.ReadOnly = true;
            this.txbPal.Size = new System.Drawing.Size(58, 21);
            this.txbPal.TabIndex = 21;
            this.txbPal.GotFocus += new System.EventHandler(this.txbPal_GotFocus);
            this.txbPal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPal_KeyDown);
            this.txbPal.LostFocus += new System.EventHandler(this.txbPal_LostFocus);
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(89, 98);
            this.txbStock.Name = "txbStock";
            this.txbStock.ReadOnly = true;
            this.txbStock.Size = new System.Drawing.Size(58, 21);
            this.txbStock.TabIndex = 28;
            this.txbStock.GotFocus += new System.EventHandler(this.txbStock_GotFocus);
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(111, 29);
            this.txbCod.Name = "txbCod";
            this.txbCod.ReadOnly = true;
            this.txbCod.Size = new System.Drawing.Size(126, 21);
            this.txbCod.TabIndex = 35;
            this.txbCod.TabStop = false;
            this.txbCod.TextChanged += new System.EventHandler(this.txbCod_TextChanged);
            this.txbCod.GotFocus += new System.EventHandler(this.txbCod_GotFocus);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(70, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 42;
            this.button1.Text = "N";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.GotFocus += new System.EventHandler(this.button1_GotFocus);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(70, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 15);
            this.button2.TabIndex = 43;
            this.button2.Text = "N";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.GotFocus += new System.EventHandler(this.button2_GotFocus);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(70, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(15, 15);
            this.button3.TabIndex = 44;
            this.button3.Text = "N";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.GotFocus += new System.EventHandler(this.button3_GotFocus);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(52, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(15, 15);
            this.button4.TabIndex = 53;
            this.button4.Text = "X";
            this.button4.GotFocus += new System.EventHandler(this.button4_GotFocus);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(52, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(15, 15);
            this.button5.TabIndex = 52;
            this.button5.Text = "X";
            this.button5.GotFocus += new System.EventHandler(this.button5_GotFocus);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(52, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(15, 15);
            this.button6.TabIndex = 51;
            this.button6.Text = "X";
            this.button6.GotFocus += new System.EventHandler(this.button6_GotFocus);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(165, 266);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 20);
            this.button9.TabIndex = 68;
            this.button9.Text = "Voltar";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.Text = "Enc. Cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(58, 21);
            this.textBox2.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(166, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.Text = "Obsoleto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(58, 21);
            this.textBox3.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.Text = "Enc. Forn.:";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(155, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 20);
            this.checkBox1.TabIndex = 90;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(158, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.Text = "N. stck net";
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(155, 147);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(29, 20);
            this.checkBox2.TabIndex = 92;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(158, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.Text = "Confirmar stock";
            // 
            // Loc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbPal);
            this.Controls.Add(this.txbPrat);
            this.Controls.Add(this.txbGav);
            this.Controls.Add(this.txbDes);
            this.Controls.Add(this.txbRefe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPrat);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPal);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGav);
            this.KeyPreview = true;
            this.Name = "Loc";
            this.Text = "Localização";
            this.Load += new System.EventHandler(this.Loc_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Loc_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Loc_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblGav;
        private System.Windows.Forms.Label lblPal;
        private System.Windows.Forms.Label lblPrat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txbRefe;
        private System.Windows.Forms.TextBox txbDes;
        private System.Windows.Forms.TextBox txbGav;
        private System.Windows.Forms.TextBox txbPrat;
        private System.Windows.Forms.TextBox txbPal;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}