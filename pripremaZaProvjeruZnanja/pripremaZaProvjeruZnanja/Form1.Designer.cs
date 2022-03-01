namespace pripremaZaProvjeruZnanja
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dtpGodPro = new System.Windows.Forms.DateTimePicker();
            this.lblGodPro = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.trckSnaga = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpis = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.lblSnaga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Automobil",
            "Jetski",
            "Zrakoplov"});
            this.cmbVrsta.Location = new System.Drawing.Point(134, 73);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(121, 21);
            this.cmbVrsta.TabIndex = 0;
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(48, 76);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(64, 13);
            this.lblVrsta.TabIndex = 1;
            this.lblVrsta.Text = "Vrsta vozila:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(134, 119);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(75, 119);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv:";
            // 
            // dtpGodPro
            // 
            this.dtpGodPro.Location = new System.Drawing.Point(134, 162);
            this.dtpGodPro.Name = "dtpGodPro";
            this.dtpGodPro.Size = new System.Drawing.Size(121, 20);
            this.dtpGodPro.TabIndex = 4;
            // 
            // lblGodPro
            // 
            this.lblGodPro.AutoSize = true;
            this.lblGodPro.Location = new System.Drawing.Point(11, 162);
            this.lblGodPro.Name = "lblGodPro";
            this.lblGodPro.Size = new System.Drawing.Size(101, 13);
            this.lblGodPro.TabIndex = 5;
            this.lblGodPro.Text = "Godina proizvodnje:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(134, 206);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 20);
            this.txtMarka.TabIndex = 6;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(72, 206);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(40, 13);
            this.lblMarka.TabIndex = 7;
            this.lblMarka.Text = "Marka:";
            // 
            // trckSnaga
            // 
            this.trckSnaga.Location = new System.Drawing.Point(134, 246);
            this.trckSnaga.Maximum = 350;
            this.trckSnaga.Minimum = 45;
            this.trckSnaga.Name = "trckSnaga";
            this.trckSnaga.Size = new System.Drawing.Size(121, 45);
            this.trckSnaga.TabIndex = 8;
            this.trckSnaga.Value = 45;
            this.trckSnaga.Scroll += new System.EventHandler(this.trckSnaga_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Snaga(ks):";
            // 
            // btnUpis
            // 
            this.btnUpis.Location = new System.Drawing.Point(134, 320);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(121, 32);
            this.btnUpis.TabIndex = 10;
            this.btnUpis.Text = "Upis";
            this.btnUpis.UseVisualStyleBackColor = true;
            this.btnUpis.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(134, 360);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(121, 32);
            this.btnIspis.TabIndex = 11;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(307, 73);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(457, 319);
            this.rtxtIspis.TabIndex = 12;
            this.rtxtIspis.Text = "";
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Location = new System.Drawing.Point(182, 278);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(19, 13);
            this.lblSnaga.TabIndex = 13;
            this.lblSnaga.Text = "45";
            this.lblSnaga.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trckSnaga);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblGodPro);
            this.Controls.Add(this.dtpGodPro);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.cmbVrsta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckSnaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DateTimePicker dtpGodPro;
        private System.Windows.Forms.Label lblGodPro;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TrackBar trckSnaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.Label lblSnaga;
    }
}

