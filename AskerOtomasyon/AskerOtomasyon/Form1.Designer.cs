namespace AskerOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtasker1 = new TextBox();
            label1 = new Label();
            txtasker2 = new TextBox();
            label2 = new Label();
            txttabur1 = new TextBox();
            label3 = new Label();
            asker_ekle = new Button();
            asker_sil = new Button();
            asker_guncelle = new Button();
            label4 = new Label();
            label5 = new Label();
            taburlar_ekle = new Button();
            taburlar_sil = new Button();
            taburlar_guncelle = new Button();
            dataGridView1 = new DataGridView();
            txtaskerid = new TextBox();
            label6 = new Label();
            txttaburid = new TextBox();
            label7 = new Label();
            btngec = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtasker1
            // 
            txtasker1.Location = new Point(127, 72);
            txtasker1.Name = "txtasker1";
            txtasker1.Size = new Size(100, 23);
            txtasker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.ScrollBar;
            label1.AutoSize = true;
            label1.Location = new Point(62, 75);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "İsim:";
            // 
            // txtasker2
            // 
            txtasker2.Location = new Point(127, 108);
            txtasker2.Name = "txtasker2";
            txtasker2.Size = new Size(100, 23);
            txtasker2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 111);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim:";
            // 
            // txttabur1
            // 
            txttabur1.Location = new Point(523, 72);
            txttabur1.Name = "txttabur1";
            txttabur1.Size = new Size(100, 23);
            txttabur1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 75);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 1;
            label3.Text = "Adı:";
            // 
            // asker_ekle
            // 
            asker_ekle.Location = new Point(25, 149);
            asker_ekle.Name = "asker_ekle";
            asker_ekle.Size = new Size(75, 23);
            asker_ekle.TabIndex = 2;
            asker_ekle.Text = "Ekle";
            asker_ekle.UseVisualStyleBackColor = true;
            asker_ekle.Click += asker_ekle_Click;
            // 
            // asker_sil
            // 
            asker_sil.Location = new Point(187, 149);
            asker_sil.Name = "asker_sil";
            asker_sil.Size = new Size(75, 23);
            asker_sil.TabIndex = 2;
            asker_sil.Text = "Sil";
            asker_sil.UseVisualStyleBackColor = true;
            asker_sil.Click += asker_sil_Click;
            // 
            // asker_guncelle
            // 
            asker_guncelle.Location = new Point(106, 149);
            asker_guncelle.Name = "asker_guncelle";
            asker_guncelle.Size = new Size(75, 23);
            asker_guncelle.TabIndex = 2;
            asker_guncelle.Text = "Güncelle";
            asker_guncelle.UseVisualStyleBackColor = true;
            asker_guncelle.Click += asker_guncelle_Click;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.ScrollBar;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(89, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 1;
            label4.Text = "Askerler";
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.ScrollBar;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(493, 9);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 1;
            label5.Text = "Taburlar";
            // 
            // taburlar_ekle
            // 
            taburlar_ekle.Location = new Point(429, 111);
            taburlar_ekle.Name = "taburlar_ekle";
            taburlar_ekle.Size = new Size(75, 23);
            taburlar_ekle.TabIndex = 2;
            taburlar_ekle.Text = "Ekle";
            taburlar_ekle.UseVisualStyleBackColor = true;
            taburlar_ekle.Click += taburlar_ekle_Click;
            // 
            // taburlar_sil
            // 
            taburlar_sil.Location = new Point(591, 111);
            taburlar_sil.Name = "taburlar_sil";
            taburlar_sil.Size = new Size(75, 23);
            taburlar_sil.TabIndex = 2;
            taburlar_sil.Text = "Sil";
            taburlar_sil.UseVisualStyleBackColor = true;
            taburlar_sil.Click += taburlar_sil_Click;
            // 
            // taburlar_guncelle
            // 
            taburlar_guncelle.Location = new Point(510, 111);
            taburlar_guncelle.Name = "taburlar_guncelle";
            taburlar_guncelle.Size = new Size(75, 23);
            taburlar_guncelle.TabIndex = 2;
            taburlar_guncelle.Text = "Güncelle";
            taburlar_guncelle.UseVisualStyleBackColor = true;
            taburlar_guncelle.Click += taburlar_guncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(369, 228);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // txtaskerid
            // 
            txtaskerid.Location = new Point(127, 43);
            txtaskerid.Name = "txtaskerid";
            txtaskerid.Size = new Size(100, 23);
            txtaskerid.TabIndex = 0;
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.ScrollBar;
            label6.AutoSize = true;
            label6.Location = new Point(62, 46);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 1;
            label6.Text = "Id:";
            // 
            // txttaburid
            // 
            txttaburid.Location = new Point(523, 40);
            txttaburid.Name = "txttaburid";
            txttaburid.Size = new Size(100, 23);
            txttaburid.TabIndex = 0;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.ScrollBar;
            label7.AutoSize = true;
            label7.Location = new Point(458, 43);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 1;
            label7.Text = "Id:";
            // 
            // btngec
            // 
            btngec.Location = new Point(693, 159);
            btngec.Name = "btngec";
            btngec.Size = new Size(85, 45);
            btngec.TabIndex = 4;
            btngec.Text = "Dağıtıma Geç";
            btngec.UseVisualStyleBackColor = true;
            btngec.Click += btngec_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(476, 210);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(267, 228);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellEnter += dataGridView2_CellEnter_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(btngec);
            Controls.Add(dataGridView1);
            Controls.Add(taburlar_guncelle);
            Controls.Add(asker_guncelle);
            Controls.Add(taburlar_sil);
            Controls.Add(asker_sil);
            Controls.Add(taburlar_ekle);
            Controls.Add(asker_ekle);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtasker2);
            Controls.Add(txttaburid);
            Controls.Add(txttabur1);
            Controls.Add(txtaskerid);
            Controls.Add(txtasker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtasker1;
        private Label label1;
        private TextBox txtasker2;
        private Label label2;
        private TextBox txttabur1;
        private Label label3;
        private Button asker_ekle;
        private Button asker_sil;
        private Button asker_guncelle;
        private Label label4;
        private Label label5;
        private Button taburlar_ekle;
        private Button taburlar_sil;
        private Button taburlar_guncelle;
        private DataGridView dataGridView1;
        private TextBox txtaskerid;
        private Label label6;
        private TextBox txttaburid;
        private Label label7;
        private Button btngec;
        private DataGridView dataGridView2;
    }
}
