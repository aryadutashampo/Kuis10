namespace Kuis10
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelJudul = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelangka2 = new System.Windows.Forms.Label();
            this.labelangka1 = new System.Windows.Forms.Label();
            this.txtangka2 = new System.Windows.Forms.TextBox();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.txtangka1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.labelJudul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 140);
            this.panel1.TabIndex = 0;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(333, 53);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(169, 32);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Kalkulatore";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.btnbagi);
            this.panel2.Controls.Add(this.btnkali);
            this.panel2.Controls.Add(this.btnminus);
            this.panel2.Controls.Add(this.btnplus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelangka2);
            this.panel2.Controls.Add(this.labelangka1);
            this.panel2.Controls.Add(this.txtangka2);
            this.panel2.Controls.Add(this.txthasil);
            this.panel2.Controls.Add(this.txtangka1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 310);
            this.panel2.TabIndex = 1;
            // 
            // btnbagi
            // 
            this.btnbagi.Location = new System.Drawing.Point(539, 177);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(68, 45);
            this.btnbagi.TabIndex = 9;
            this.btnbagi.Text = ":";
            this.btnbagi.UseVisualStyleBackColor = true;
            this.btnbagi.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnkali
            // 
            this.btnkali.Location = new System.Drawing.Point(434, 177);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(68, 45);
            this.btnkali.TabIndex = 8;
            this.btnkali.Text = "*";
            this.btnkali.UseVisualStyleBackColor = true;
            this.btnkali.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(339, 177);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(68, 45);
            this.btnminus.TabIndex = 7;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(235, 177);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(68, 45);
            this.btnplus.TabIndex = 6;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.operator_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(148, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasil";
            // 
            // labelangka2
            // 
            this.labelangka2.AutoSize = true;
            this.labelangka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelangka2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelangka2.Location = new System.Drawing.Point(148, 70);
            this.labelangka2.Name = "labelangka2";
            this.labelangka2.Size = new System.Drawing.Size(70, 20);
            this.labelangka2.TabIndex = 4;
            this.labelangka2.Text = "Angka2";
            // 
            // labelangka1
            // 
            this.labelangka1.AutoSize = true;
            this.labelangka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelangka1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelangka1.Location = new System.Drawing.Point(142, 28);
            this.labelangka1.Name = "labelangka1";
            this.labelangka1.Size = new System.Drawing.Size(76, 20);
            this.labelangka1.TabIndex = 3;
            this.labelangka1.Text = "Angka 1";
            // 
            // txtangka2
            // 
            this.txtangka2.Location = new System.Drawing.Point(230, 70);
            this.txtangka2.Multiline = true;
            this.txtangka2.Name = "txtangka2";
            this.txtangka2.Size = new System.Drawing.Size(377, 34);
            this.txtangka2.TabIndex = 2;
            // 
            // txthasil
            // 
            this.txthasil.Enabled = false;
            this.txthasil.Location = new System.Drawing.Point(230, 110);
            this.txthasil.Multiline = true;
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(377, 35);
            this.txthasil.TabIndex = 1;
            // 
            // txtangka1
            // 
            this.txtangka1.Location = new System.Drawing.Point(230, 28);
            this.txtangka1.Multiline = true;
            this.txtangka1.Name = "txtangka1";
            this.txtangka1.Size = new System.Drawing.Size(377, 36);
            this.txtangka1.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuis Pertemuan 10";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelangka2;
        private System.Windows.Forms.Label labelangka1;
        private System.Windows.Forms.TextBox txtangka2;
        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.TextBox txtangka1;
    }
}

