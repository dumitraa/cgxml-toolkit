using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace UtilitatiCGXML
{
    partial class DoneMsgBox
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

        // Add this to the class level
        public const int WM_NCHITTEST = 0x84;
        public const int HTCLIENT = 0x1;
        public const int HTCAPTION = 0x2;

        // Add this to your form's class
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // CS_DROPSHADOW
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
         
            }
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {
            // Drawing a border around the form
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 130, 237), 2), this.DisplayRectangle);
        }

        private void Panel1Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(Color.FromArgb(0, 130, 237), 1);
            e.Graphics.DrawRectangle(borderPen, 0, 0, panel1.Width - 1, panel1.Height - 1);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeDialogBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeDialogBtn
            // 
            this.closeDialogBtn.FlatAppearance.BorderSize = 0;
            this.closeDialogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeDialogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeDialogBtn.ForeColor = System.Drawing.Color.Black;
            this.closeDialogBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Same as the dialog's background
            this.closeDialogBtn.Location = new System.Drawing.Point(370, 3);
            this.closeDialogBtn.Name = "closeDialogBtn";
            this.closeDialogBtn.Size = new System.Drawing.Size(22, 22);
            this.closeDialogBtn.TabIndex = 3;
            this.closeDialogBtn.Text = "X";
            this.closeDialogBtn.UseVisualStyleBackColor = true;
            this.closeDialogBtn.Click += new System.EventHandler(this.closeDialogBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Same as the dialog's background
            this.panel1.Paint += new PaintEventHandler(Panel1Paint);
            this.panel1.Controls.Add(this.closeDialogBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 32);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openFileBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.openFileBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openFileBtn.Image = global::VerificareCGXML.Properties.Resources.excelR1;
            this.openFileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openFileBtn.Location = new System.Drawing.Point(12, 46);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(171, 64);
            this.openFileBtn.TabIndex = 6;
            this.openFileBtn.Text = "Deschide Fisier";
            this.openFileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openFileBtn.UseVisualStyleBackColor = false;
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.openFolderBtn.FlatAppearance.BorderSize = 0;
            this.openFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolderBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openFolderBtn.Image = global::VerificareCGXML.Properties.Resources.FolderR;
            this.openFolderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openFolderBtn.Location = new System.Drawing.Point(205, 46);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(187, 64);
            this.openFolderBtn.TabIndex = 7;
            this.openFolderBtn.Text = "Deschide Dosar";
            this.openFolderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openFolderBtn.UseVisualStyleBackColor = true;
            // 
            // DoneMsgBox
            // 
            this.Paint += new PaintEventHandler(FormPaint);
            this.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 122);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoneMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoneMsgBox";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeDialogBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button openFolderBtn;
    }
}