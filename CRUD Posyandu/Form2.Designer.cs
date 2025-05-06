namespace CRUD_Posyandu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btChange = new Button();
            btDelete = new Button();
            btBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 35);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "BIODATA PESERTA";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(669, 188);
            dataGridView1.TabIndex = 1;
            // 
            // btChange
            // 
            btChange.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btChange.Location = new Point(220, 348);
            btChange.Name = "btChange";
            btChange.Size = new Size(94, 29);
            btChange.TabIndex = 2;
            btChange.Text = "CHANGE";
            btChange.UseVisualStyleBackColor = true;
            btChange.Click += btChange_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btDelete.Location = new Point(481, 348);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 3;
            btDelete.Text = "DELETE";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btBack
            // 
            btBack.BackgroundImageLayout = ImageLayout.Zoom;
            btBack.Font = new Font("Arial Rounded MT Bold", 10.2F);
            btBack.Location = new Point(662, 403);
            btBack.Name = "btBack";
            btBack.Size = new Size(94, 29);
            btBack.TabIndex = 4;
            btBack.Text = "EXIT=>";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btBack);
            Controls.Add(btDelete);
            Controls.Add(btChange);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btChange;
        private Button btDelete;
        private Button btBack;
    }
}