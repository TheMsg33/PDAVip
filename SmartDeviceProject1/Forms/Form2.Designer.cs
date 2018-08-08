namespace SmartDeviceProject1
{
    partial class Form2
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblBar = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblGav = new System.Windows.Forms.Label();
            this.lblPal = new System.Windows.Forms.Label();
            this.lblPrat = new System.Windows.Forms.Label();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnRejeitar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.txbRefe = new System.Windows.Forms.TextBox();
            this.txbDes = new System.Windows.Forms.TextBox();
            this.txbGav = new System.Windows.Forms.TextBox();
            this.txbPrat = new System.Windows.Forms.TextBox();
            this.txbPal = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBar
            // 
            this.lblBar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblBar.Location = new System.Drawing.Point(4, 18);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(233, 20);
            this.lblBar.Text = "Código barras:";
            // 
            // lblRef
            // 
            this.lblRef.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRef.Location = new System.Drawing.Point(4, 46);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(233, 20);
            this.lblRef.Text = "Referência:";
            // 
            // lblGav
            // 
            this.lblGav.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblGav.Location = new System.Drawing.Point(4, 103);
            this.lblGav.Name = "lblGav";
            this.lblGav.Size = new System.Drawing.Size(233, 20);
            this.lblGav.Text = "Gaveta:";
            // 
            // lblPal
            // 
            this.lblPal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPal.Location = new System.Drawing.Point(4, 159);
            this.lblPal.Name = "lblPal";
            this.lblPal.Size = new System.Drawing.Size(233, 20);
            this.lblPal.Text = "Palete:";
            // 
            // lblPrat
            // 
            this.lblPrat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrat.Location = new System.Drawing.Point(4, 131);
            this.lblPrat.Name = "lblPrat";
            this.lblPrat.Size = new System.Drawing.Size(233, 20);
            this.lblPrat.Text = "Prateleira:";
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(165, 245);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(72, 20);
            this.btnAceitar.TabIndex = 6;
            this.btnAceitar.TabStop = false;
            this.btnAceitar.Text = "Exportar";
            // 
            // btnRejeitar
            // 
            this.btnRejeitar.Location = new System.Drawing.Point(4, 245);
            this.btnRejeitar.Name = "btnRejeitar";
            this.btnRejeitar.Size = new System.Drawing.Size(72, 20);
            this.btnRejeitar.TabIndex = 7;
            this.btnRejeitar.TabStop = false;
            this.btnRejeitar.Text = "Importar";
            this.btnRejeitar.Click += new System.EventHandler(this.btnRejeitar_Click);
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(4, 187);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(233, 20);
            this.lblStock.Text = "Stock: ";
            // 
            // txbRefe
            // 
            this.txbRefe.Location = new System.Drawing.Point(111, 44);
            this.txbRefe.Name = "txbRefe";
            this.txbRefe.ReadOnly = true;
            this.txbRefe.Size = new System.Drawing.Size(126, 21);
            this.txbRefe.TabIndex = 17;
            // 
            // txbDes
            // 
            this.txbDes.Location = new System.Drawing.Point(4, 73);
            this.txbDes.Name = "txbDes";
            this.txbDes.ReadOnly = true;
            this.txbDes.Size = new System.Drawing.Size(233, 21);
            this.txbDes.TabIndex = 18;
            // 
            // txbGav
            // 
            this.txbGav.Location = new System.Drawing.Point(111, 101);
            this.txbGav.Name = "txbGav";
            this.txbGav.ReadOnly = true;
            this.txbGav.Size = new System.Drawing.Size(126, 21);
            this.txbGav.TabIndex = 19;
            // 
            // txbPrat
            // 
            this.txbPrat.Location = new System.Drawing.Point(111, 129);
            this.txbPrat.Name = "txbPrat";
            this.txbPrat.ReadOnly = true;
            this.txbPrat.Size = new System.Drawing.Size(126, 21);
            this.txbPrat.TabIndex = 20;
            // 
            // txbPal
            // 
            this.txbPal.Location = new System.Drawing.Point(111, 157);
            this.txbPal.Name = "txbPal";
            this.txbPal.ReadOnly = true;
            this.txbPal.Size = new System.Drawing.Size(126, 21);
            this.txbPal.TabIndex = 21;
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(111, 185);
            this.txbStock.Name = "txbStock";
            this.txbStock.ReadOnly = true;
            this.txbStock.Size = new System.Drawing.Size(126, 21);
            this.txbStock.TabIndex = 28;
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(111, 16);
            this.txbCod.Name = "txbCod";
            this.txbCod.ReadOnly = true;
            this.txbCod.Size = new System.Drawing.Size(126, 21);
            this.txbCod.TabIndex = 35;
            this.txbCod.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(127)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbPal);
            this.Controls.Add(this.txbPrat);
            this.Controls.Add(this.txbGav);
            this.Controls.Add(this.txbDes);
            this.Controls.Add(this.txbRefe);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnRejeitar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.lblPrat);
            this.Controls.Add(this.lblPal);
            this.Controls.Add(this.lblGav);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.lblBar);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Localização";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblGav;
        private System.Windows.Forms.Label lblPal;
        private System.Windows.Forms.Label lblPrat;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnRejeitar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txbRefe;
        private System.Windows.Forms.TextBox txbDes;
        private System.Windows.Forms.TextBox txbGav;
        private System.Windows.Forms.TextBox txbPrat;
        private System.Windows.Forms.TextBox txbPal;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.TextBox txbCod;
    }
}