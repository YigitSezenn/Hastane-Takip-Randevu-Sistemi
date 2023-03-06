namespace Randevu_Otomasyonu
{
    partial class HastaKayıt
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdogum = new System.Windows.Forms.TextBox();
            this.txtsoy = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.maskTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsıfre = new System.Windows.Forms.TextBox();
            this.kangrubu = new System.Windows.Forms.ComboBox();
            this.hastaneVeriDataSet1 = new Randevu_Otomasyonu.HastaneVeriDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Adress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.Label();
            this.txtkmlik = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnkontrol = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnHastaARA = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(101, 218);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(197, 22);
            this.txtemail.TabIndex = 6;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtdogum
            // 
            this.txtdogum.Location = new System.Drawing.Point(607, 330);
            this.txtdogum.Margin = new System.Windows.Forms.Padding(4);
            this.txtdogum.Name = "txtdogum";
            this.txtdogum.Size = new System.Drawing.Size(197, 22);
            this.txtdogum.TabIndex = 12;
            this.txtdogum.Visible = false;
            // 
            // txtsoy
            // 
            this.txtsoy.Location = new System.Drawing.Point(129, 76);
            this.txtsoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoy.Name = "txtsoy";
            this.txtsoy.Size = new System.Drawing.Size(197, 22);
            this.txtsoy.TabIndex = 3;
            this.txtsoy.TextChanged += new System.EventHandler(this.txtsoy_TextChanged);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(129, 44);
            this.txtad.Margin = new System.Windows.Forms.Padding(4);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(197, 22);
            this.txtad.TabIndex = 2;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // maskTxtPhone
            // 
            this.maskTxtPhone.Location = new System.Drawing.Point(115, 263);
            this.maskTxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.maskTxtPhone.Mask = "(999) 000-0000";
            this.maskTxtPhone.Name = "maskTxtPhone";
            this.maskTxtPhone.Size = new System.Drawing.Size(135, 22);
            this.maskTxtPhone.TabIndex = 7;
            this.maskTxtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskTxtPhone_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "DogumTarihi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kangrubu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "SoyAdı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(77, 522);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(197, 47);
            this.btnkaydet.TabIndex = 12;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(563, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtresim
            // 
            this.txtresim.Location = new System.Drawing.Point(109, 314);
            this.txtresim.Margin = new System.Windows.Forms.Padding(4);
            this.txtresim.Name = "txtresim";
            this.txtresim.Size = new System.Drawing.Size(197, 22);
            this.txtresim.TabIndex = 8;
            this.txtresim.TextChanged += new System.EventHandler(this.txtresim_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Resim";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(316, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "şeç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 357);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtsıfre
            // 
            this.txtsıfre.Location = new System.Drawing.Point(151, 357);
            this.txtsıfre.Margin = new System.Windows.Forms.Padding(4);
            this.txtsıfre.Name = "txtsıfre";
            this.txtsıfre.Size = new System.Drawing.Size(197, 22);
            this.txtsıfre.TabIndex = 10;
            this.txtsıfre.Visible = false;
            this.txtsıfre.TextChanged += new System.EventHandler(this.txtsıfre_TextChanged);
            // 
            // kangrubu
            // 
            this.kangrubu.FormattingEnabled = true;
            this.kangrubu.Location = new System.Drawing.Point(137, 116);
            this.kangrubu.Margin = new System.Windows.Forms.Padding(4);
            this.kangrubu.Name = "kangrubu";
            this.kangrubu.Size = new System.Drawing.Size(213, 24);
            this.kangrubu.TabIndex = 4;
            this.kangrubu.SelectedIndexChanged += new System.EventHandler(this.kangrubu_SelectedIndexChanged);
            // 
            // hastaneVeriDataSet1
            // 
            this.hastaneVeriDataSet1.DataSetName = "HastaneVeriDataSet";
            this.hastaneVeriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 450);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Statu";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(591, 297);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Visible = false;
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adress.Location = new System.Drawing.Point(11, 401);
            this.Adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(94, 29);
            this.Adress.TabIndex = 21;
            this.Adress.Text = "Adress";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(151, 401);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(325, 114);
            this.txtAdress.TabIndex = 11;
            this.txtAdress.TextChanged += new System.EventHandler(this.txtAdress_TextChanged);
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(4, 1);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(115, 29);
            this.tc.TabIndex = 0;
            this.tc.Text = "TcKimlik";
            this.tc.Click += new System.EventHandler(this.tc_Click);
            // 
            // txtkmlik
            // 
            this.txtkmlik.Location = new System.Drawing.Point(129, 5);
            this.txtkmlik.Margin = new System.Windows.Forms.Padding(4);
            this.txtkmlik.Name = "txtkmlik";
            this.txtkmlik.Size = new System.Drawing.Size(197, 22);
            this.txtkmlik.TabIndex = 0;
            this.txtkmlik.TextChanged += new System.EventHandler(this.txtkmlik_TextChanged);
            this.txtkmlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkmlik_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnkontrol
            // 
            this.btnkontrol.Location = new System.Drawing.Point(336, 1);
            this.btnkontrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnkontrol.Name = "btnkontrol";
            this.btnkontrol.Size = new System.Drawing.Size(140, 33);
            this.btnkontrol.TabIndex = 1;
            this.btnkontrol.Text = "Kontrol et";
            this.btnkontrol.UseVisualStyleBackColor = true;
            this.btnkontrol.Click += new System.EventHandler(this.btnkontrol_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(616, 360);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 95);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(282, 520);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(184, 52);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "Temizle";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHastaARA
            // 
            this.btnHastaARA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnHastaARA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaARA.Location = new System.Drawing.Point(473, 520);
            this.btnHastaARA.Name = "btnHastaARA";
            this.btnHastaARA.Size = new System.Drawing.Size(183, 49);
            this.btnHastaARA.TabIndex = 26;
            this.btnHastaARA.Text = "HastaAra";
            this.btnHastaARA.UseVisualStyleBackColor = false;
            this.btnHastaARA.Click += new System.EventHandler(this.btnHastaARA_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // HastaKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 612);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnHastaARA);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnkontrol);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kangrubu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsıfre);
            this.Controls.Add(this.txtresim);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdogum);
            this.Controls.Add(this.txtsoy);
            this.Controls.Add(this.txtkmlik);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.maskTxtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HastaKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaKayıt";
            this.Load += new System.EventHandler(this.HastaKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdogum;
        private System.Windows.Forms.TextBox txtsoy;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox maskTxtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtresim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsıfre;
        private System.Windows.Forms.ComboBox kangrubu;
        private HastaneVeriDataSet hastaneVeriDataSet1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.TextBox txtkmlik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnkontrol;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnHastaARA;
        private System.Windows.Forms.Label label10;
    }
}