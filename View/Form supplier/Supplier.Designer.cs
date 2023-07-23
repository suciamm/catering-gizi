
namespace Suci_CateringGizi
{
    partial class Supplier
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
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttonhapus = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA SUPPLIER BAHAN BAKU";
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(797, 39);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 48);
            this.buttonadd.TabIndex = 2;
            this.buttonadd.Text = "Tambah";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(797, 139);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(94, 48);
            this.buttonedit.TabIndex = 2;
            this.buttonedit.Text = "Edit";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttonhapus
            // 
            this.buttonhapus.Location = new System.Drawing.Point(797, 231);
            this.buttonhapus.Name = "buttonhapus";
            this.buttonhapus.Size = new System.Drawing.Size(94, 48);
            this.buttonhapus.TabIndex = 2;
            this.buttonhapus.Text = "Hapus";
            this.buttonhapus.UseVisualStyleBackColor = true;
            this.buttonhapus.Click += new System.EventHandler(this.buttonhapus_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(797, 328);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(94, 48);
            this.buttonback.TabIndex = 2;
            this.buttonback.Text = "Kembali";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.buttonadd);
            this.panel1.Controls.Add(this.buttonedit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.buttonhapus);
            this.panel1.Location = new System.Drawing.Point(31, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 418);
            this.panel1.TabIndex = 3;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(979, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttonhapus;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Panel panel1;
    }
}