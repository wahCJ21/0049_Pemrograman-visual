namespace parkir.Views
{
    partial class FormGaji
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
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.txtGajiPerHari = new System.Windows.Forms.MaskedTextBox();
            this.numHariKerja = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalGaji = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHariKerja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(156, 67);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(252, 26);
            this.txtNamaKaryawan.TabIndex = 0;
            // 
            // txtGajiPerHari
            // 
            this.txtGajiPerHari.Location = new System.Drawing.Point(156, 167);
            this.txtGajiPerHari.Name = "txtGajiPerHari";
            this.txtGajiPerHari.Size = new System.Drawing.Size(252, 26);
            this.txtGajiPerHari.TabIndex = 1;
            // 
            // numHariKerja
            // 
            this.numHariKerja.Location = new System.Drawing.Point(156, 109);
            this.numHariKerja.Name = "numHariKerja";
            this.numHariKerja.Size = new System.Drawing.Size(252, 26);
            this.numHariKerja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NamaKaryawan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "HariKerja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "GajiPerHari";
            // 
            // lblTotalGaji
            // 
            this.lblTotalGaji.AutoSize = true;
            this.lblTotalGaji.Location = new System.Drawing.Point(198, 230);
            this.lblTotalGaji.Name = "lblTotalGaji";
            this.lblTotalGaji.Size = new System.Drawing.Size(72, 20);
            this.lblTotalGaji.TabIndex = 6;
            this.lblTotalGaji.Text = "TotalGaji";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(46, 274);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 30);
            this.btnHitung.TabIndex = 7;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(195, 274);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 37);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(62, 327);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(363, 26);
            this.txtCari.TabIndex = 9;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(469, 321);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 39);
            this.btnCari.TabIndex = 10;
            this.btnCari.Text = "cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(745, 201);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::parkir.Properties.Resources.gg;
            this.button1.Location = new System.Drawing.Point(1, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::parkir.Properties.Resources.gg;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.lblTotalGaji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHariKerja);
            this.Controls.Add(this.txtGajiPerHari);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Name = "FormGaji";
            this.Text = "FormGaji";
            ((System.ComponentModel.ISupportInitialize)(this.numHariKerja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.MaskedTextBox txtGajiPerHari;
        private System.Windows.Forms.NumericUpDown numHariKerja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalGaji;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}