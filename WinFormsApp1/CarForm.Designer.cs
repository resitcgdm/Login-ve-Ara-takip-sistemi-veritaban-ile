namespace WinFormsApp1
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_arackiralanma = new System.Windows.Forms.TextBox();
            this.lbl_kiralanma = new System.Windows.Forms.Label();
            this.txt_aracrenk = new System.Windows.Forms.TextBox();
            this.txt_aracmarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_aracrenk = new System.Windows.Forms.Label();
            this.txt_aracad = new System.Windows.Forms.TextBox();
            this.lbl_aracad = new System.Windows.Forms.Label();
            this.txt_aracno = new System.Windows.Forms.TextBox();
            this.lbl_aracno = new System.Windows.Forms.Label();
            this.dtg_car = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sil.Location = new System.Drawing.Point(654, 295);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(82, 26);
            this.btn_sil.TabIndex = 27;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_güncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_güncelle.Location = new System.Drawing.Point(654, 250);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(82, 28);
            this.btn_güncelle.TabIndex = 26;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ekle.Location = new System.Drawing.Point(654, 204);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(82, 32);
            this.btn_ekle.TabIndex = 25;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_arackiralanma
            // 
            this.txt_arackiralanma.Location = new System.Drawing.Point(390, 222);
            this.txt_arackiralanma.Name = "txt_arackiralanma";
            this.txt_arackiralanma.Size = new System.Drawing.Size(100, 23);
            this.txt_arackiralanma.TabIndex = 24;
            // 
            // lbl_kiralanma
            // 
            this.lbl_kiralanma.AutoSize = true;
            this.lbl_kiralanma.Location = new System.Drawing.Point(384, 204);
            this.lbl_kiralanma.Name = "lbl_kiralanma";
            this.lbl_kiralanma.Size = new System.Drawing.Size(106, 15);
            this.lbl_kiralanma.TabIndex = 23;
            this.lbl_kiralanma.Text = "Kiralanma durumu";
            // 
            // txt_aracrenk
            // 
            this.txt_aracrenk.Location = new System.Drawing.Point(244, 213);
            this.txt_aracrenk.Name = "txt_aracrenk";
            this.txt_aracrenk.Size = new System.Drawing.Size(100, 23);
            this.txt_aracrenk.TabIndex = 22;
            // 
            // txt_aracmarka
            // 
            this.txt_aracmarka.Location = new System.Drawing.Point(243, 268);
            this.txt_aracmarka.Name = "txt_aracmarka";
            this.txt_aracmarka.Size = new System.Drawing.Size(100, 23);
            this.txt_aracmarka.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Aracın markası";
            // 
            // lbl_aracrenk
            // 
            this.lbl_aracrenk.AutoSize = true;
            this.lbl_aracrenk.Location = new System.Drawing.Point(244, 195);
            this.lbl_aracrenk.Name = "lbl_aracrenk";
            this.lbl_aracrenk.Size = new System.Drawing.Size(71, 15);
            this.lbl_aracrenk.TabIndex = 19;
            this.lbl_aracrenk.Text = "Aracın rengi";
            // 
            // txt_aracad
            // 
            this.txt_aracad.Location = new System.Drawing.Point(68, 267);
            this.txt_aracad.Name = "txt_aracad";
            this.txt_aracad.Size = new System.Drawing.Size(100, 23);
            this.txt_aracad.TabIndex = 18;
            // 
            // lbl_aracad
            // 
            this.lbl_aracad.AutoSize = true;
            this.lbl_aracad.Location = new System.Drawing.Point(60, 245);
            this.lbl_aracad.Name = "lbl_aracad";
            this.lbl_aracad.Size = new System.Drawing.Size(52, 15);
            this.lbl_aracad.TabIndex = 17;
            this.lbl_aracad.Text = "Araç Adı";
            // 
            // txt_aracno
            // 
            this.txt_aracno.Location = new System.Drawing.Point(69, 213);
            this.txt_aracno.Name = "txt_aracno";
            this.txt_aracno.Size = new System.Drawing.Size(100, 23);
            this.txt_aracno.TabIndex = 16;
            // 
            // lbl_aracno
            // 
            this.lbl_aracno.AutoSize = true;
            this.lbl_aracno.Location = new System.Drawing.Point(69, 195);
            this.lbl_aracno.Name = "lbl_aracno";
            this.lbl_aracno.Size = new System.Drawing.Size(50, 15);
            this.lbl_aracno.TabIndex = 15;
            this.lbl_aracno.Text = "Araç No";
            // 
            // dtg_car
            // 
            this.dtg_car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_car.Location = new System.Drawing.Point(12, 22);
            this.dtg_car.Name = "dtg_car";
            this.dtg_car.RowTemplate.Height = 25;
            this.dtg_car.Size = new System.Drawing.Size(478, 130);
            this.dtg_car.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_arackiralanma);
            this.Controls.Add(this.lbl_kiralanma);
            this.Controls.Add(this.txt_aracrenk);
            this.Controls.Add(this.txt_aracmarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_aracrenk);
            this.Controls.Add(this.txt_aracad);
            this.Controls.Add(this.lbl_aracad);
            this.Controls.Add(this.txt_aracno);
            this.Controls.Add(this.lbl_aracno);
            this.Controls.Add(this.dtg_car);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_sil;
        private Button btn_güncelle;
        private Button btn_ekle;
        private TextBox txt_arackiralanma;
        private Label lbl_kiralanma;
        private TextBox txt_aracrenk;
        private TextBox txt_aracmarka;
        private Label label2;
        private Label lbl_aracrenk;
        private TextBox txt_aracad;
        private Label lbl_aracad;
        private TextBox txt_aracno;
        private Label lbl_aracno;
        private DataGridView dtg_car;
        private PictureBox pictureBox1;
    }
}