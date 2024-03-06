namespace UtilitatiCGXML
{
    partial class VerificareCGXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificareCGXML));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.alteleTabBtn = new System.Windows.Forms.Button();
            this.rapoarteCgxmlTabBtn = new System.Windows.Forms.Button();
            this.minimizeWindowBtn = new System.Windows.Forms.Button();
            this.closeWindowBtn = new System.Windows.Forms.Button();
            this.CustomControl00 = new UtilitatiCGXML.VerificareCGXML.CustomControl0();
            this.CustomControl11 = new UtilitatiCGXML.CustomControl1();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.alteleTabBtn);
            this.panel2.Controls.Add(this.rapoarteCgxmlTabBtn);
            this.panel2.Controls.Add(this.minimizeWindowBtn);
            this.panel2.Controls.Add(this.closeWindowBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 57);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(380, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "CC6";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // alteleTabBtn
            // 
            this.alteleTabBtn.BackColor = System.Drawing.Color.Transparent;
            this.alteleTabBtn.ForeColor = System.Drawing.Color.Black;
            this.alteleTabBtn.FlatAppearance.BorderSize = 0;
            this.alteleTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alteleTabBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point); // Bold font for better visibility
            this.alteleTabBtn.Location = new System.Drawing.Point(94, 0);
            this.alteleTabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.alteleTabBtn.Name = "alteleTabBtn";
            this.alteleTabBtn.Size = new System.Drawing.Size(105, 55);
            this.alteleTabBtn.TabIndex = 11;
            this.alteleTabBtn.Text = "Altele";
            this.alteleTabBtn.UseVisualStyleBackColor = false;
            this.alteleTabBtn.Click += new System.EventHandler(this.alteleTabBtn_Click);
            // 
            // rapoarteCgxmlTabBtn
            // 
            this.rapoarteCgxmlTabBtn.BackColor = System.Drawing.Color.Transparent;
            this.rapoarteCgxmlTabBtn.ForeColor = System.Drawing.Color.Black;
            this.rapoarteCgxmlTabBtn.FlatAppearance.BorderSize = 0;
            this.rapoarteCgxmlTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rapoarteCgxmlTabBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rapoarteCgxmlTabBtn.Location = new System.Drawing.Point(0, 0);
            this.rapoarteCgxmlTabBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rapoarteCgxmlTabBtn.Name = "rapoarteCgxmlTabBtn";
            this.rapoarteCgxmlTabBtn.Size = new System.Drawing.Size(105, 55);
            this.rapoarteCgxmlTabBtn.TabIndex = 11;
            this.rapoarteCgxmlTabBtn.Text = "Rapoarte\r\nCGXML";
            this.rapoarteCgxmlTabBtn.UseVisualStyleBackColor = false;
            this.rapoarteCgxmlTabBtn.BackColor = System.Drawing.Color.FromArgb(153, 204, 255); // Lighter blue for active state
            this.rapoarteCgxmlTabBtn.ForeColor = System.Drawing.Color.Black; // You may adjust if needed
            this.rapoarteCgxmlTabBtn.Click += new System.EventHandler(this.rapoarteCgxmlTabBtn_Click);
            // 
            // minimizeWindowBtn
            // 
            this.minimizeWindowBtn.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeWindowBtn.ForeColor = System.Drawing.Color.Black;
            this.minimizeWindowBtn.FlatAppearance.BorderSize = 0;
            this.minimizeWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeWindowBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimizeWindowBtn.Location = new System.Drawing.Point(796, 11);
            this.minimizeWindowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeWindowBtn.Name = "minimizeWindowBtn";
            this.minimizeWindowBtn.Size = new System.Drawing.Size(27, 27);
            this.minimizeWindowBtn.TabIndex = 10;
            this.minimizeWindowBtn.Text = "_";
            this.minimizeWindowBtn.UseVisualStyleBackColor = false;
            this.minimizeWindowBtn.Click += new System.EventHandler(this.minimizeWindowBtn_Click);
            // 
            // closeWindowBtn
            // 
            this.closeWindowBtn.ForeColor = System.Drawing.Color.Transparent;
            this.closeWindowBtn.ForeColor = System.Drawing.Color.Black;          
            this.closeWindowBtn.FlatAppearance.BorderSize = 0;
            this.closeWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindowBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeWindowBtn.Location = new System.Drawing.Point(827, 11);
            this.closeWindowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeWindowBtn.Name = "closeWindowBtn";
            this.closeWindowBtn.Size = new System.Drawing.Size(27, 27);
            this.closeWindowBtn.TabIndex = 9;
            this.closeWindowBtn.Tag = "";
            this.closeWindowBtn.Text = "X";
            this.closeWindowBtn.UseVisualStyleBackColor = false;
            this.closeWindowBtn.Click += new System.EventHandler(this.closeWindowBtn_Click);
            // 
            // CustomControl00
            // 
            this.CustomControl00.Location = new System.Drawing.Point(0, 59);
            this.CustomControl00.Name = "CustomControl00";
            this.CustomControl00.Size = new System.Drawing.Size(865, 600);
            this.CustomControl00.TabIndex = 10;
            // 
            // CustomControl11
            // 
            this.CustomControl11.Location = new System.Drawing.Point(0, 59);
            this.CustomControl11.Name = "CustomControl11";
            this.CustomControl11.Size = new System.Drawing.Size(865, 600);
            this.CustomControl11.TabIndex = 11;
            // 
            // VerificareCGXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 250, 255);
            this.ClientSize = new System.Drawing.Size(865, 485);
            this.Controls.Add(this.CustomControl00);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustomControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Utilitati CGXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilitati CGXML";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UtilitatiCGXML_FormClosed);
            this.Load += new System.EventHandler(this.UtilitatiCGXML_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

            this.panel2.BackColor = System.Drawing.Color.FromArgb(255, 255, 255); // White background for the panel

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button alteleTabBtn;
        private System.Windows.Forms.Button rapoarteCgxmlTabBtn;
        private System.Windows.Forms.Button minimizeWindowBtn;
        private System.Windows.Forms.Button closeWindowBtn;
        private CustomControl0 CustomControl00;
        private CustomControl1 CustomControl11;

        private class CustomControl0 : global::UtilitatiCGXML.CustomControl0
        {
        }
    }
}

