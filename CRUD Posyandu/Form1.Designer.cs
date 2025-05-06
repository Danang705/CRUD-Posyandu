namespace CRUD_Posyandu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btInput = new Button();
            NamaAnak = new TextBox();
            label4 = new Label();
            label5 = new Label();
            NamaIbu = new TextBox();
            tglLahir = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btInputdata = new Button();
            btBatal = new Button();
            GenderBox = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 39);
            label1.TabIndex = 0;
            label1.Text = "DATA POSYANDU";
            // 
            // btInput
            // 
            btInput.Font = new Font("Arial Rounded MT Bold", 7.8F);
            btInput.Location = new Point(176, 330);
            btInput.Name = "btInput";
            btInput.Size = new Size(94, 29);
            btInput.TabIndex = 1;
            btInput.Text = "INPUT";
            btInput.UseVisualStyleBackColor = true;
            btInput.Click += btInput_Click;
            // 
            // NamaAnak
            // 
            NamaAnak.Font = new Font("Arial Rounded MT Bold", 7.8F);
            NamaAnak.Location = new Point(24, 92);
            NamaAnak.Name = "NamaAnak";
            NamaAnak.Size = new Size(229, 23);
            NamaAnak.TabIndex = 4;
            NamaAnak.TextChanged += NamaAnak_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 7.8F);
            label4.Location = new Point(24, 72);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 5;
            label4.Text = "Nama Anak";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 7.8F);
            label5.Location = new Point(24, 260);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 7;
            label5.Text = "Nama Ibu";
            // 
            // NamaIbu
            // 
            NamaIbu.BackColor = SystemColors.HighlightText;
            NamaIbu.Font = new Font("Arial Rounded MT Bold", 7.8F);
            NamaIbu.Location = new Point(20, 280);
            NamaIbu.Name = "NamaIbu";
            NamaIbu.Size = new Size(250, 23);
            NamaIbu.TabIndex = 6;
            // 
            // tglLahir
            // 
            tglLahir.Font = new Font("Arial Rounded MT Bold", 7.8F);
            tglLahir.Location = new Point(24, 215);
            tglLahir.Name = "tglLahir";
            tglLahir.Size = new Size(250, 23);
            tglLahir.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 7.8F);
            label2.Location = new Point(24, 195);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 12;
            label2.Text = "Tanggal Lahir";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F);
            label3.Location = new Point(24, 41);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 13;
            label3.Text = "Input Biodata Peserta";
            // 
            // btInputdata
            // 
            btInputdata.Font = new Font("Arial Rounded MT Bold", 9F);
            btInputdata.Location = new Point(584, 393);
            btInputdata.Name = "btInputdata";
            btInputdata.Size = new Size(126, 29);
            btInputdata.TabIndex = 14;
            btInputdata.Text = "EDIT DATA";
            btInputdata.UseVisualStyleBackColor = true;
            btInputdata.Click += button1_Click;
            // 
            // btBatal
            // 
            btBatal.Font = new Font("Arial Rounded MT Bold", 7.8F);
            btBatal.Location = new Point(35, 330);
            btBatal.Name = "btBatal";
            btBatal.Size = new Size(94, 29);
            btBatal.TabIndex = 15;
            btBatal.Text = "CANCEL";
            btBatal.UseVisualStyleBackColor = true;
            btBatal.Click += button2_Click;
            // 
            // GenderBox
            // 
            GenderBox.Font = new Font("Arial Rounded MT Bold", 7.8F);
            GenderBox.FormattingEnabled = true;
            GenderBox.Items.AddRange(new object[] { "Laki - Laki", "Perempuan" });
            GenderBox.Location = new Point(24, 153);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(151, 23);
            GenderBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 7.8F);
            label6.Location = new Point(24, 130);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 8;
            label6.Text = "Jenis Kelamin";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(GenderBox);
            groupBox1.Controls.Add(NamaIbu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btInput);
            groupBox1.Controls.Add(btBatal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(NamaAnak);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tglLahir);
            groupBox1.Location = new Point(24, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 387);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btInputdata);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btInput;
        private TextBox NamaAnak;
        private Label label4;
        private Label label5;
        private TextBox NamaIbu;
        private DateTimePicker tglLahir;
        private Label label2;
        private Label label3;
        private Button btInputdata;
        private Button btBatal;
        private ComboBox GenderBox;
        private Label label6;
        private GroupBox groupBox1;
    }
}
