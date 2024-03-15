using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace UtilitatiCGXML
{
    partial class CustomControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // This event handler can be used for both checkboxes' Click event
        private void checkbox_Click(object sender, EventArgs e)
        {
            // Enable the "Start Conversion" button only if at least one checkbox is checked
            this.cgToShpBtn.Enabled = this.imobileCheckbox.Checked || this.constrCheckbox.Checked;
        }

public class CustomGroupBox : GroupBox
{
    private Color borderColor;

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; }
    }

    public CustomGroupBox()
    {
        borderColor = Color.Black; // Default color
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Size tSize = TextRenderer.MeasureText(this.Text, this.Font);
        Rectangle borderRect = e.ClipRectangle;
        borderRect.Y += tSize.Height / 2;
        borderRect.Height -= tSize.Height / 2;
        ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Solid);

        Rectangle textRect = e.ClipRectangle;
        textRect.X += 6;
        textRect.Width = tSize.Width;
        textRect.Height = tSize.Height;
        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
        e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
    }
}



        private void StylePanelAndButtons()
        {
            // Assuming panel1 is already defined and added to the control
            foreach (var btn in this.panel1.Controls.OfType<Button>())
            {
                // Set default button style here
                btn.BackColor = System.Drawing.Color.Transparent;
                btn.ForeColor = System.Drawing.Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                // Add hover effects
                btn.MouseEnter += (sender, e) =>
                {
                    var thisButton = (Button)sender;
                    thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237);
                    thisButton.ForeColor = System.Drawing.Color.White;
                };
                btn.MouseLeave += (sender, e) =>
                {
                    var thisButton = (Button)sender;
                    thisButton.BackColor = System.Drawing.Color.Transparent;
                    thisButton.ForeColor = System.Drawing.Color.Black;
                };
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            float borderWidth = 1; // Set the width of the border
            Color borderColor = System.Drawing.Color.FromArgb(0, 130, 237); // Set the color of the border

            // Adjust the coordinates to account for padding
            int top = panel.Padding.Top;
            int left = panel.Padding.Left;
            int right = panel.Width;
            int bottom = panel.Height;

            // Draw the border on the right edge of the panel
            using (SolidBrush brush = new SolidBrush(borderColor))
            {
                // Right border
                e.Graphics.FillRectangle(brush, right - borderWidth, top, borderWidth, bottom - top);
            }
        }

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomControl1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cgToShpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyArchiveCgBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.seVaCreaLabel = new System.Windows.Forms.Label();
            this.waitMilliseconds = new System.Windows.Forms.Label();
            this.MiliSeconds = new System.Windows.Forms.TextBox();
            this.filePrefix = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oneFileBtn = new System.Windows.Forms.Button();
            this.multipleFileBtn = new System.Windows.Forms.Button();
            this.backgroundImageLogo = new System.Windows.Forms.PictureBox();
            this.imobileCheckbox = new System.Windows.Forms.CheckBox();
            this.constrCheckbox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.panel1.Paint += new PaintEventHandler(panel1_Paint);
            this.panel1.Padding = new System.Windows.Forms.Padding(10); // Adds padding inside the panel
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5); 
            this.panel1.Controls.Add(this.label1); 
            this.panel1.Controls.Add(this.copyArchiveCgBtn); // Copiere arhivare CGXML
            this.panel1.Controls.Add(this.button4); 
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 480);
            this.panel1.TabIndex = 15;
            //
            // cgToShpBtn and constrCheckbox groupbox
            //
            // Initialize the GroupBox
            CustomGroupBox cgShpGroupBox = new CustomGroupBox();
            cgShpGroupBox.Text = "Opțiuni conversie CGXML în SHP"; // Set the title for the group box
            cgShpGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cgShpGroupBox.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            cgShpGroupBox.ForeColor = System.Drawing.Color.Black;
            cgShpGroupBox.BorderColor = System.Drawing.Color.FromArgb(0, 130, 237);
            cgShpGroupBox.Location = new System.Drawing.Point(10, 150); // Position it accordingly on the form
            cgShpGroupBox.Size = new System.Drawing.Size(200, 130); // Set the appropriate size
            cgShpGroupBox.Margin = new System.Windows.Forms.Padding(0);
            cgShpGroupBox.Padding = new System.Windows.Forms.Padding(10); // Padding inside the group box
            this.Controls.Add(cgShpGroupBox); // Add the group box to the form's controls
            // cgToShpBtn
            this.cgToShpBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.cgToShpBtn.FlatAppearance.BorderSize = 0;
            this.cgToShpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cgToShpBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cgToShpBtn.Location = new System.Drawing.Point(1, 20); // Adjust these values as needed
            this.cgToShpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cgToShpBtn.Name = "cgToShpBtn";
            this.cgToShpBtn.Size = new System.Drawing.Size(198, 40);
            this.cgToShpBtn.TabIndex = 4;
            this.cgToShpBtn.Text = " Începe conversia";
            this.cgToShpBtn.UseVisualStyleBackColor = false;
            this.cgToShpBtn.Click += new System.EventHandler(this.cgToShpBtn_Click);
            this.cgToShpBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Inactive color, same as GroupBox
            this.cgToShpBtn.ForeColor = System.Drawing.Color.Black;
            this.cgToShpBtn.Image = Image.FromFile("C:\\Users\\USER\\Documents\\scripts\\cgxml-toolkit\\UtilitatiCGXML\\Resources\\map-location.png"); // Ensure the path is correct
            this.cgToShpBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.cgToShpBtn.ImageAlign = ContentAlignment.MiddleRight;
            this.cgToShpBtn.Enabled = false; // Start as disabled

            ToolTip cgToShpToolTip = new ToolTip();
            cgToShpToolTip.SetToolTip(this.cgToShpBtn, "Începe procesul de conversie a fișierelor CGXML în format SHP după selectarea opțiunilor.");

            // Add hover effects
            this.cgToShpBtn.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237);
                thisButton.ForeColor = System.Drawing.Color.White;
            };
            this.cgToShpBtn.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Inactive color, same as GroupBox
                thisButton.ForeColor = System.Drawing.Color.Black;
            };
            //
            // imobileCheckbox
            //
            this.imobileCheckbox.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.imobileCheckbox.ForeColor = System.Drawing.Color.Black;
            this.imobileCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imobileCheckbox.AutoSize = true;
            this.imobileCheckbox.Location = new System.Drawing.Point(20, 70); // Adjust these values as needed
            this.imobileCheckbox.Margin = new System.Windows.Forms.Padding(10);
            this.imobileCheckbox.Name = "imobileCheckbox";
            this.imobileCheckbox.Size = new System.Drawing.Size(167, 17);
            this.imobileCheckbox.TabIndex = 5;
            this.imobileCheckbox.Text = "include imobile";
            this.imobileCheckbox.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);    
            this.imobileCheckbox.UseVisualStyleBackColor = false;
            this.imobileCheckbox.Visible = true;
            this.imobileCheckbox.Click += new System.EventHandler(this.imobileCheckbox_Click);
            this.imobileCheckbox.Click += new System.EventHandler(this.checkbox_Click);

            //
            // constrCheckbox
            //
            this.constrCheckbox.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.constrCheckbox.ForeColor = System.Drawing.Color.Black;
            this.constrCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.constrCheckbox.AutoSize = true;
            this.constrCheckbox.Location = new System.Drawing.Point(20, 90); // Adjust these values as needed
            this.constrCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.constrCheckbox.Name = "constrCheckbox";
            this.constrCheckbox.Size = new System.Drawing.Size(167, 17);
            this.constrCheckbox.TabIndex = 5;
            this.constrCheckbox.Text = "include construcții";
            this.constrCheckbox.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);    
            this.constrCheckbox.UseVisualStyleBackColor = false;
            this.constrCheckbox.Visible = true;
            this.constrCheckbox.Click += new System.EventHandler(this.constrCheckbox_Click);
            this.constrCheckbox.Click += new System.EventHandler(this.checkbox_Click);



            // Add the button and checkbox to the GroupBox controls, not directly to the form
            cgShpGroupBox.Controls.Add(this.cgToShpBtn);
            cgShpGroupBox.Controls.Add(this.imobileCheckbox);
            cgShpGroupBox.Controls.Add(this.constrCheckbox);
            // 
            // copyArchiveCgBtn
            // 
            this.copyArchiveCgBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.copyArchiveCgBtn.FlatAppearance.BorderSize = 0;
            this.copyArchiveCgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyArchiveCgBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyArchiveCgBtn.ForeColor = System.Drawing.Color.White;
            this.copyArchiveCgBtn.BackColor = System.Drawing.Color.Transparent;
            this.copyArchiveCgBtn.Location = new System.Drawing.Point(0, 118);
            this.copyArchiveCgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.copyArchiveCgBtn.Name = "copyArchiveCgBtn";
            this.copyArchiveCgBtn.Size = new System.Drawing.Size(220, 51);
            this.copyArchiveCgBtn.TabIndex = 1;
            this.copyArchiveCgBtn.Text = "Copiere si arhivare fișiere CGXML";
            this.copyArchiveCgBtn.UseVisualStyleBackColor = false;
            this.copyArchiveCgBtn.Click += new System.EventHandler(this.copyArchiveCgBtn_Click);
            this.copyArchiveCgBtn.MouseHover += new System.EventHandler(this.copyArchiveCgBtn_MouseHover);
            this.copyArchiveCgBtn.Image = Image.FromFile("C:\\Users\\USER\\Documents\\scripts\\cgxml-toolkit\\UtilitatiCGXML\\Resources\\archive.png"); // Ensure the path is correct
            this.copyArchiveCgBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.copyArchiveCgBtn.ImageAlign = ContentAlignment.MiddleRight;

            ToolTip copyArchiveToolTip = new ToolTip();
            copyArchiveToolTip.SetToolTip(this.copyArchiveCgBtn, "Copiază și arhivează fișierele CGXML selectate");

            // 
            // button4
            // 
            // this.button4.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            // this.button4.FlatAppearance.BorderSize = 0;
            // this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // this.button4.ForeColor = System.Drawing.Color.White;
            // this.button4.Location = new System.Drawing.Point(0, 271);
            // this.button4.Margin = new System.Windows.Forms.Padding(0);
            // this.button4.Name = "button4";
            // this.button4.Size = new System.Drawing.Size(214, 51);
            // this.button4.TabIndex = 3;
            // this.button4.Text = "button 4";
            // this.button4.UseVisualStyleBackColor = false;
            // this.button4.Click += new System.EventHandler(this.button4_Click);
            // this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // seVaCreaLabel
            // 
            this.seVaCreaLabel.AutoSize = true;
            this.seVaCreaLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seVaCreaLabel.Location = new System.Drawing.Point(234, 13);
            this.seVaCreaLabel.Name = "seVaCreaLabel";
            this.seVaCreaLabel.Size = new System.Drawing.Size(109, 20);
            this.seVaCreaLabel.TabIndex = 21;
            this.seVaCreaLabel.Text = "Se va crea:";
            this.seVaCreaLabel.Visible = false;
            // 
            // waitMilliseconds
            // 
            this.waitMilliseconds.AutoSize = true;
            this.waitMilliseconds.Location = new System.Drawing.Point(596, 117);
            this.waitMilliseconds.Name = "waitMilliseconds";
            this.waitMilliseconds.Size = new System.Drawing.Size(264, 13);
            this.waitMilliseconds.TabIndex = 20;
            this.waitMilliseconds.Text = "Asteapta X milisecunde pana sa printezi urmatorul fisier";
            this.waitMilliseconds.Visible = false;
            // 
            // MiliSeconds
            // 
            this.MiliSeconds.Location = new System.Drawing.Point(313, 93);
            this.MiliSeconds.Name = "MiliSeconds";
            this.MiliSeconds.Size = new System.Drawing.Size(287, 20);
            this.MiliSeconds.TabIndex = 19;
            this.MiliSeconds.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Visible = false;
            // 
            // oneFileBtn
            // 
            this.oneFileBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneFileBtn.Location = new System.Drawing.Point(364, 8);
            this.oneFileBtn.Name = "oneFileBtn";
            this.oneFileBtn.Size = new System.Drawing.Size(140, 30);
            this.oneFileBtn.TabIndex = 23;
            this.oneFileBtn.Text = "Un fisier";
            this.oneFileBtn.UseVisualStyleBackColor = true;
            this.oneFileBtn.Visible = false;
            // 
            // multipleFileBtn
            // 
            this.multipleFileBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multipleFileBtn.Location = new System.Drawing.Point(510, 8);
            this.multipleFileBtn.Name = "multipleFileBtn";
            this.multipleFileBtn.Size = new System.Drawing.Size(140, 30);
            this.multipleFileBtn.TabIndex = 24;
            this.multipleFileBtn.Text = "Fisiere multiple";
            this.multipleFileBtn.UseVisualStyleBackColor = true;
            this.multipleFileBtn.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(596, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 95);
            this.listBox1.TabIndex = 54;
            this.listBox1.Visible = false;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            // 
            // CustomControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.multipleFileBtn);
            this.Controls.Add(this.oneFileBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.seVaCreaLabel);
            this.Controls.Add(this.waitMilliseconds);
            this.Controls.Add(this.MiliSeconds);
            this.Controls.Add(this.filePrefix);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.backgroundImageLogo);
            this.Name = "CustomControl1";
            this.Size = new System.Drawing.Size(865, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button cgToShpBtn;
        private System.Windows.Forms.CheckBox imobileCheckbox;
        private System.Windows.Forms.CheckBox constrCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyArchiveCgBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label seVaCreaLabel;
        private System.Windows.Forms.Label waitMilliseconds;
        private System.Windows.Forms.TextBox MiliSeconds;
        private System.Windows.Forms.TextBox filePrefix;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox backgroundImageLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button oneFileBtn;
        private System.Windows.Forms.Button multipleFileBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}
