
namespace Suci_CateringGizi
{
    partial class FormPasien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonhapus = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(785, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Pasien ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(461, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.Beige;
            this.buttonback.Location = new System.Drawing.Point(825, 355);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(82, 38);
            this.buttonback.TabIndex = 3;
            this.buttonback.Text = "Kembali";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonhapus
            // 
            this.buttonhapus.BackColor = System.Drawing.Color.Beige;
            this.buttonhapus.Location = new System.Drawing.Point(825, 272);
            this.buttonhapus.Name = "buttonhapus";
            this.buttonhapus.Size = new System.Drawing.Size(82, 38);
            this.buttonhapus.TabIndex = 4;
            this.buttonhapus.Text = "Hapus";
            this.buttonhapus.UseVisualStyleBackColor = false;
            this.buttonhapus.Click += new System.EventHandler(this.buttonhapus_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.BackColor = System.Drawing.Color.Beige;
            this.buttonedit.Location = new System.Drawing.Point(825, 185);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(82, 38);
            this.buttonedit.TabIndex = 5;
            this.buttonedit.Text = "Edit";
            this.buttonedit.UseVisualStyleBackColor = false;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.Beige;
            this.buttonadd.Location = new System.Drawing.Point(825, 101);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(82, 38);
            this.buttonadd.TabIndex = 6;
            this.buttonadd.Text = "Tambah";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonhapus);
            this.panel1.Controls.Add(this.buttonadd);
            this.panel1.Controls.Add(this.buttonedit);
            this.panel1.Location = new System.Drawing.Point(39, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 427);
            this.panel1.TabIndex = 8;
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1001, 507);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPasien";
            this.Text = "FormPasien";
            this.Load += new System.EventHandler(this.FormPasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonhapus;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttonadd;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonpesan;
        private System.Windows.Forms.Panel panel1;
    }
}