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
            this.combinePdfs = new System.Windows.Forms.Button();
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
            this.fileTextBox1 = new System.Windows.Forms.TextBox();
            this.fileTextBox2 = new System.Windows.Forms.TextBox();
            this.fileTextBox3 = new System.Windows.Forms.TextBox();
            this.fileTextBox4 = new System.Windows.Forms.TextBox();
            this.fileTextBox5 = new System.Windows.Forms.TextBox();
            this.fileTextBox6 = new System.Windows.Forms.TextBox();
            this.fileFolderBtn1 = new System.Windows.Forms.Button();
            this.pdfFileBtn1 = new System.Windows.Forms.Button();
            this.backgroundImageLogo = new System.Windows.Forms.PictureBox();
            this.folderBtn2 = new System.Windows.Forms.Button();
            this.pdfFileBtn2 = new System.Windows.Forms.Button();
            this.folderBtn3 = new System.Windows.Forms.Button();
            this.pdfFileBtn3 = new System.Windows.Forms.Button();
            this.folderBtn4 = new System.Windows.Forms.Button();
            this.pdfFileBtn4 = new System.Windows.Forms.Button();
            this.folderBtn5 = new System.Windows.Forms.Button();
            this.pdfFileBtn5 = new System.Windows.Forms.Button();
            this.folderBtn6 = new System.Windows.Forms.Button();
            this.pdfFileBtn6 = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.folderBtn7 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.fileTextBox7 = new System.Windows.Forms.TextBox();
            this.intrareLabel = new System.Windows.Forms.Label();
            this.iesireLabel = new System.Windows.Forms.Label();
            this.obtainAFileBtn = new System.Windows.Forms.Button();
            this.obtainMultipleFilesBtn = new System.Windows.Forms.Button();
            this.renameFileTextBox = new System.Windows.Forms.TextBox();
            this.renameFileCheck = new System.Windows.Forms.CheckBox();
            this.imobileCheckbox = new System.Windows.Forms.CheckBox();
            this.constrCheckbox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.userControlPDF11 = new UtilitatiCGXML.UserControlPDF1();
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
            this.panel1.Controls.Add(this.combinePdfs);
            this.panel1.Controls.Add(this.label1); 
            this.panel1.Controls.Add(this.copyArchiveCgBtn); // Copiere arhivare CGXML
            this.panel1.Controls.Add(this.button4); 
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 480);
            this.panel1.TabIndex = 15;

            // 
            // button6
            // 
            // this.button6.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            // this.button6.FlatAppearance.BorderSize = 0;
            // this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // this.button6.ForeColor = System.Drawing.Color.White;
            // this.button6.Location = new System.Drawing.Point(0, 373);
            // this.button6.Margin = new System.Windows.Forms.Padding(0);
            // this.button6.Name = "button6";
            // this.button6.Size = new System.Drawing.Size(214, 51);
            // this.button6.TabIndex = 5;
            // this.button6.Text = "button 6";
            // this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            // this.button5.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            // this.button5.FlatAppearance.BorderSize = 0;
            // this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // this.button5.ForeColor = System.Drawing.Color.White;
            // this.button5.Location = new System.Drawing.Point(0, 322);
            // this.button5.Margin = new System.Windows.Forms.Padding(0);
            // this.button5.Name = "button5";
            // this.button5.Size = new System.Drawing.Size(214, 51);
            // this.button5.TabIndex = 2;
            // this.button5.Text = "button 5";
            // this.button5.UseVisualStyleBackColor = false;
            // this.button5.Click += new System.EventHandler(this.button5_Click);
            // this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            Button[] fileButtons = { pdfFileBtn1, pdfFileBtn2, pdfFileBtn3, pdfFileBtn4, pdfFileBtn5, pdfFileBtn6, folderBtn2, folderBtn3, folderBtn4, folderBtn5, folderBtn6, folderBtn7, fileFolderBtn1 };
            foreach (Button btn in fileButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.Transparent;
                btn.Size = new Size(40, 40); // Adjust the size as needed
            }

            TextBox[] textBoxes = { fileTextBox1, fileTextBox2, fileTextBox3, fileTextBox4, fileTextBox5, fileTextBox6, fileTextBox7 };
            foreach (TextBox txt in textBoxes)
            {
                txt.Font = new Font("Segoe UI", 9);
                txt.ForeColor = Color.Black;
                txt.BackColor = Color.White; // A softer white
                txt.BorderStyle = BorderStyle.FixedSingle; // A flat border
            }
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
            cgShpGroupBox.Location = new System.Drawing.Point(10, 200); // Position it accordingly on the form
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
            // combinePdfs
            // 
            this.combinePdfs.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.combinePdfs.FlatAppearance.BorderSize = 0;
            this.combinePdfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combinePdfs.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combinePdfs.ForeColor = System.Drawing.Color.White;
            this.combinePdfs.Location = new System.Drawing.Point(0, 169);
            this.combinePdfs.Margin = new System.Windows.Forms.Padding(0);
            this.combinePdfs.Name = "combinePdfs";
            this.combinePdfs.Size = new System.Drawing.Size(220, 51);
            this.combinePdfs.TabIndex = 0;
            this.combinePdfs.Text = " Combină PDF-uri";
            this.combinePdfs.UseVisualStyleBackColor = false;
            this.combinePdfs.Click += new System.EventHandler(this.combinePdfs_Click);
            this.combinePdfs.MouseHover += new System.EventHandler(this.combinePdfs_MouseHover);
            this.combinePdfs.Image = Image.FromFile("C:\\Users\\USER\\Documents\\scripts\\cgxml-toolkit\\UtilitatiCGXML\\Resources\\pdf-file.png"); // Ensure the path is correct
            this.combinePdfs.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.combinePdfs.ImageAlign = ContentAlignment.MiddleRight;

            ToolTip pdftToolTip = new ToolTip();
            pdftToolTip.SetToolTip(this.combinePdfs, "Unește mai multe fișiere PDF într-un singur document.");
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
            // fileTextBox1
            // 
            this.fileTextBox1.Location = new System.Drawing.Point(413, 65);
            this.fileTextBox1.Name = "fileTextBox1";
            this.fileTextBox1.Size = new System.Drawing.Size(264, 20);
            this.fileTextBox1.TabIndex = 26;
            this.fileTextBox1.Visible = false;
            // 
            // fileTextBox2
            // 
            this.fileTextBox2.Location = new System.Drawing.Point(413, 96);
            this.fileTextBox2.Name = "fileTextBox2";
            this.fileTextBox2.Size = new System.Drawing.Size(264, 20);
            this.fileTextBox2.TabIndex = 27;
            this.fileTextBox2.Visible = false;
            // 
            // fileTextBox3
            // 
            this.fileTextBox3.Location = new System.Drawing.Point(413, 127);
            this.fileTextBox3.Name = "fileTextBox3";
            this.fileTextBox3.Size = new System.Drawing.Size(264, 20);
            this.fileTextBox3.TabIndex = 28;
            this.fileTextBox3.Visible = false;
            // 
            // fileTextBox4
            // 
            this.fileTextBox4.Location = new System.Drawing.Point(413, 156);
            this.fileTextBox4.Name = "fileTextBox4";
            this.fileTextBox4.Size = new System.Drawing.Size(264, 20);
            this.fileTextBox4.TabIndex = 29;
            this.fileTextBox4.Visible = false;
            // 
            // fileTextBox5
            // 
            this.fileTextBox5.Location = new System.Drawing.Point(413, 187);
            this.fileTextBox5.Name = "fileTextBox5";
            this.fileTextBox5.Size = new System.Drawing.Size(264, 20);
            this.fileTextBox5.TabIndex = 30;
            this.fileTextBox5.Visible = false;
            // 
            // fileTextBox6
            // 
            this.fileTextBox6.Location = new System.Drawing.Point(413, 220);
            this.fileTextBox6.Name = "fileTextBox6";
            this.fileTextBox6.Size = new System.Drawing.Size(264, 20);
            this.fileTextBox6.TabIndex = 31;
            this.fileTextBox6.Visible = false;
            // 
            // fileFolderBtn1
            // 
            this.fileFolderBtn1.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.fileFolderBtn1.Location = new System.Drawing.Point(370, 65);
            this.fileFolderBtn1.Name = "fileFolderBtn1";
            this.fileFolderBtn1.Size = new System.Drawing.Size(25, 25);
            this.fileFolderBtn1.TabIndex = 33;
            this.fileFolderBtn1.UseVisualStyleBackColor = true;
            this.fileFolderBtn1.Visible = false;
            this.fileFolderBtn1.Click += new System.EventHandler(this.fileFolderBtn1_Click);
            // 
            // pdfFileBtn1
            // 
            this.pdfFileBtn1.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.pdfFileBtn1.FlatAppearance.BorderSize = 0;
            this.pdfFileBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfFileBtn1.BackColor = System.Drawing.Color.Transparent;
            this.pdfFileBtn1.Location = new System.Drawing.Point(370, 65);
            this.pdfFileBtn1.Name = "pdfFileBtn1";
            this.pdfFileBtn1.Size = new System.Drawing.Size(25, 25);
            this.pdfFileBtn1.TabIndex = 32;
            this.pdfFileBtn1.UseVisualStyleBackColor = true;
            this.pdfFileBtn1.Visible = false;
            this.pdfFileBtn1.Click += new System.EventHandler(this.pdfFileBtn1_Click);
            // 
            // folderBtn2
            // 
            this.folderBtn2.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.folderBtn2.Location = new System.Drawing.Point(340, 96);
            this.folderBtn2.Name = "folderBtn2";
            this.folderBtn2.Size = new System.Drawing.Size(25, 25);
            this.folderBtn2.TabIndex = 35;
            this.folderBtn2.UseVisualStyleBackColor = true;
            this.folderBtn2.Visible = false;
            this.folderBtn2.Click += new System.EventHandler(this.folderBtn2_Click);
            // 
            // pdfFileBtn2
            // 
            this.pdfFileBtn2.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.pdfFileBtn2.Location = new System.Drawing.Point(370, 96);
            this.pdfFileBtn2.Name = "pdfFileBtn2";
            this.pdfFileBtn2.Size = new System.Drawing.Size(25, 25);
            this.pdfFileBtn2.TabIndex = 34;
            this.pdfFileBtn2.UseVisualStyleBackColor = true;
            this.pdfFileBtn2.Visible = false;
            this.pdfFileBtn2.Click += new System.EventHandler(this.pdfFileBtn2_Click);
            // 
            // folderBtn3
            // 
            this.folderBtn3.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.folderBtn3.Location = new System.Drawing.Point(340, 127);
            this.folderBtn3.Name = "folderBtn3";
            this.folderBtn3.Size = new System.Drawing.Size(25, 25);
            this.folderBtn3.TabIndex = 37;
            this.folderBtn3.UseVisualStyleBackColor = true;
            this.folderBtn3.Visible = false;
            this.folderBtn3.Click += new System.EventHandler(this.folderBtn3_Click);
            // 
            // pdfFileBtn3
            // 
            this.pdfFileBtn3.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.pdfFileBtn3.Location = new System.Drawing.Point(370, 127);
            this.pdfFileBtn3.Name = "pdfFileBtn3";
            this.pdfFileBtn3.Size = new System.Drawing.Size(25, 25);
            this.pdfFileBtn3.TabIndex = 36;
            this.pdfFileBtn3.UseVisualStyleBackColor = true;
            this.pdfFileBtn3.Visible = false;
            this.pdfFileBtn3.Click += new System.EventHandler(this.pdfFileBtn3_Click);
            // 
            // folderBtn4
            // 
            this.folderBtn4.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.folderBtn4.Location = new System.Drawing.Point(340, 156);
            this.folderBtn4.Name = "folderBtn4";
            this.folderBtn4.Size = new System.Drawing.Size(25, 25);
            this.folderBtn4.TabIndex = 39;
            this.folderBtn4.UseVisualStyleBackColor = true;
            this.folderBtn4.Visible = false;
            this.folderBtn4.Click += new System.EventHandler(this.folderBtn4_Click);
            // 
            // pdfFileBtn4
            // 
            this.pdfFileBtn4.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.pdfFileBtn4.Location = new System.Drawing.Point(370, 156);
            this.pdfFileBtn4.Name = "pdfFileBtn4";
            this.pdfFileBtn4.Size = new System.Drawing.Size(25, 25);
            this.pdfFileBtn4.TabIndex = 38;
            this.pdfFileBtn4.UseVisualStyleBackColor = true;
            this.pdfFileBtn4.Visible = false;
            this.pdfFileBtn4.Click += new System.EventHandler(this.pdfFileBtn4_Click);
            // 
            // folderBtn5
            // 
            this.folderBtn5.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.folderBtn5.Location = new System.Drawing.Point(340, 187);
            this.folderBtn5.Name = "folderBtn5";
            this.folderBtn5.Size = new System.Drawing.Size(25, 25);
            this.folderBtn5.TabIndex = 41;
            this.folderBtn5.UseVisualStyleBackColor = true;
            this.folderBtn5.Visible = false;
            this.folderBtn5.Click += new System.EventHandler(this.folderBtn5_Click);
            // 
            // pdfFileBtn5
            // 
            this.pdfFileBtn5.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.pdfFileBtn5.Location = new System.Drawing.Point(370, 187);
            this.pdfFileBtn5.Name = "pdfFileBtn5";
            this.pdfFileBtn5.Size = new System.Drawing.Size(25, 25);
            this.pdfFileBtn5.TabIndex = 40;
            this.pdfFileBtn5.UseVisualStyleBackColor = true;
            this.pdfFileBtn5.Visible = false;
            this.pdfFileBtn5.Click += new System.EventHandler(this.pdfFileBtn5_Click);
            // 
            // folderBtn6
            // 
            this.folderBtn6.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.folderBtn6.Location = new System.Drawing.Point(340, 218);
            this.folderBtn6.Name = "folderBtn6";
            this.folderBtn6.Size = new System.Drawing.Size(25, 25);
            this.folderBtn6.TabIndex = 43;
            this.folderBtn6.UseVisualStyleBackColor = true;
            this.folderBtn6.Visible = false;
            this.folderBtn6.Click += new System.EventHandler(this.folderBtn6_Click);
            // 
            // pdfFileBtn6
            // 
            this.pdfFileBtn6.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.pdfFileBtn6.Location = new System.Drawing.Point(370, 218);
            this.pdfFileBtn6.Name = "pdfFileBtn6";
            this.pdfFileBtn6.Size = new System.Drawing.Size(25, 25);
            this.pdfFileBtn6.TabIndex = 42;
            this.pdfFileBtn6.UseVisualStyleBackColor = true;
            this.pdfFileBtn6.Visible = false;
            this.pdfFileBtn6.Click += new System.EventHandler(this.pdfFileBtn6_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(485, 380);
            this.startBtn.FlatStyle = FlatStyle.Flat;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.BackColor = Color.DodgerBlue;
            this.startBtn.ForeColor = Color.White;
            this.startBtn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(90, 35);
            this.startBtn.TabIndex = 44;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Visible = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // folderBtn7
            // 
            this.folderBtn7.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.folderBtn7.Location = new System.Drawing.Point(370, 285);
            this.folderBtn7.Name = "folderBtn7";
            this.folderBtn7.Size = new System.Drawing.Size(25, 25);
            this.folderBtn7.TabIndex = 46;
            this.folderBtn7.UseVisualStyleBackColor = true;
            this.folderBtn7.Visible = false;
            this.folderBtn7.Click += new System.EventHandler(this.folderBtn7_Click);
            // 
            // button24
            // 
            this.button24.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button24.Location = new System.Drawing.Point(284, 339);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(25, 25);
            this.button24.TabIndex = 45;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Visible = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // fileTextBox7
            // 
            this.fileTextBox7.Location = new System.Drawing.Point(412, 285);
            this.fileTextBox7.Name = "fileTextBox7";
            this.fileTextBox7.Size = new System.Drawing.Size(264, 20);
            this.fileTextBox7.TabIndex = 47;
            this.fileTextBox7.Visible = false;
            // 
            // intrareLabel
            // 
            this.intrareLabel.AutoSize = true;
            this.intrareLabel.Location = new System.Drawing.Point(360, 35);
            this.intrareLabel.Name = "intrareLabel";
            this.intrareLabel.Size = new System.Drawing.Size(37, 13);
            this.intrareLabel.TabIndex = 48;
            this.intrareLabel.Text = "Intrare";
            this.intrareLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.intrareLabel.Visible = false;
            // 
            // iesireLabel
            // 
            this.iesireLabel.AutoSize = true;
            this.iesireLabel.Location = new System.Drawing.Point(375, 262);
            this.iesireLabel.Name = "iesireLabel";
            this.iesireLabel.Size = new System.Drawing.Size(32, 13);
            this.iesireLabel.TabIndex = 49;
            this.iesireLabel.Text = "Iesire";
            this.iesireLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.iesireLabel.Visible = false;
            // 
            // obtainAFileBtn
            // 
            // Define button size and location parameters
            int buttonWidth = 195;
            int buttonHeight = 157;
            int horizontalSpacing = 50; // Space between the buttons
            int leftMargin = 300; // Centering the buttons horizontally in the form

            this.obtainAFileBtn.Location = new System.Drawing.Point(leftMargin, 133); // Adjusted for symmetry
            this.obtainAFileBtn.Name = "obtainAFileBtn";
            this.obtainAFileBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.obtainAFileBtn.TabIndex = 50;
            this.obtainAFileBtn.Text = "Obtine un fisier";
            this.obtainAFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obtainAFileBtn.BackColor = System.Drawing.Color.FromArgb(225, 235, 245); // A shade that fits the theme
            this.obtainAFileBtn.Font = new System.Drawing.Font("Segoe UI", 10);
            this.obtainAFileBtn.ForeColor = System.Drawing.Color.Black;
            this.obtainAFileBtn.UseVisualStyleBackColor = false;
            this.obtainAFileBtn.Visible = false;
            this.obtainAFileBtn.Click += new System.EventHandler(this.obtainAFileBtn_Click);
            this.obtainAFileBtn.Cursor = Cursors.Hand;
            // 
            // obtainMultipleFilesBtn
            // 
            this.obtainMultipleFilesBtn.Location = new System.Drawing.Point(leftMargin + buttonWidth + horizontalSpacing, 133); // Positioned with spacing from obtainAFileBtn
            this.obtainMultipleFilesBtn.Name = "obtainMultipleFilesBtn";
            this.obtainMultipleFilesBtn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.obtainMultipleFilesBtn.TabIndex = 51;
            this.obtainMultipleFilesBtn.Text = "Obtine fisiere multiple";
            this.obtainMultipleFilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obtainMultipleFilesBtn.BackColor = System.Drawing.Color.FromArgb(225, 235, 245); // Consistent with the other button
            this.obtainMultipleFilesBtn.Font = new System.Drawing.Font("Segoe UI", 10);
            this.obtainMultipleFilesBtn.ForeColor = System.Drawing.Color.Black;
            this.obtainMultipleFilesBtn.UseVisualStyleBackColor = false;
            this.obtainMultipleFilesBtn.Visible = false;
            this.obtainMultipleFilesBtn.Cursor = Cursors.Hand;
            this.obtainMultipleFilesBtn.Click += new System.EventHandler(this.obtainMultipleFilesBtn_Click);

            // Define colors for button states
            Color primaryColor = Color.FromArgb(200, 220, 240); // Light, soft blue
            Color hoverColor = Color.FromArgb(170, 187, 204); // A darker shade for hover state
            Color fontColor = Color.Black; // Choose a color that contrasts well with the button colors

            foreach (var btn in new[] { this.obtainAFileBtn, this.obtainMultipleFilesBtn })
            {
                btn.BackColor = primaryColor;
                btn.ForeColor = fontColor;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(160, 180, 200); // Slightly darker than the primaryColor for the border
                btn.FlatAppearance.BorderSize = 1;
                btn.Cursor = Cursors.Hand;

                btn.MouseEnter += (sender, e) => 
                {
                    var button = (Button)sender;
                    button.BackColor = hoverColor; // Apply hover color
                    button.FlatAppearance.BorderColor = Color.FromArgb(150, 170, 190); // Even darker for the border
                };
                btn.MouseLeave += (sender, e) =>
                {
                    var button = (Button)sender;
                    button.BackColor = primaryColor; // Revert to primary color
                    button.FlatAppearance.BorderColor = Color.FromArgb(160, 180, 200); // Revert border color
                };
            }

            // 
            // renameFileTextBox
            // 
            this.renameFileTextBox.Location = new System.Drawing.Point(382, 350);
            this.renameFileTextBox.Name = "renameFileTextBox";
            this.renameFileTextBox.Size = new System.Drawing.Size(310, 20);
            this.renameFileTextBox.TabIndex = 52;
            this.renameFileTextBox.Visible = false;
            // 
            // renameFileCheck
            // 
            this.renameFileCheck.AutoSize = true;
            this.renameFileCheck.FlatStyle = FlatStyle.Flat;
            this.renameFileCheck.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            this.renameFileCheck.Location = new Point(380, fileTextBox7.Location.Y + 40);
            this.renameFileCheck.Name = "renameFileCheck";
            this.renameFileCheck.Size = new System.Drawing.Size(159, 17);
            this.renameFileCheck.TabIndex = 53;
            this.renameFileCheck.Text = "Schimba denumirea fisierului";
            this.renameFileCheck.UseVisualStyleBackColor = true;
            this.renameFileCheck.Visible = false;
            this.renameFileCheck.Click += new System.EventHandler(this.renameFileCheck_Click);
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
            // userControlPDF11
            // 
            this.userControlPDF11.Location = new System.Drawing.Point(220, 44);
            this.userControlPDF11.Name = "userControlPDF11";
            this.userControlPDF11.Size = new System.Drawing.Size(640, 380);
            this.userControlPDF11.TabIndex = 25;
            this.userControlPDF11.Visible = false;
            // 
            // CustomControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.renameFileCheck);
            this.Controls.Add(this.renameFileTextBox);
            this.Controls.Add(this.obtainMultipleFilesBtn);
            this.Controls.Add(this.obtainAFileBtn);
            this.Controls.Add(this.iesireLabel);
            this.Controls.Add(this.intrareLabel);
            this.Controls.Add(this.fileTextBox7);
            this.Controls.Add(this.folderBtn7);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.folderBtn6);
            this.Controls.Add(this.pdfFileBtn6);
            this.Controls.Add(this.folderBtn5);
            this.Controls.Add(this.pdfFileBtn5);
            this.Controls.Add(this.folderBtn4);
            this.Controls.Add(this.pdfFileBtn4);
            this.Controls.Add(this.folderBtn3);
            this.Controls.Add(this.pdfFileBtn3);
            this.Controls.Add(this.folderBtn2);
            this.Controls.Add(this.pdfFileBtn2);
            this.Controls.Add(this.fileFolderBtn1);
            this.Controls.Add(this.pdfFileBtn1);
            this.Controls.Add(this.fileTextBox6);
            this.Controls.Add(this.fileTextBox5);
            this.Controls.Add(this.fileTextBox4);
            this.Controls.Add(this.fileTextBox3);
            this.Controls.Add(this.fileTextBox2);
            this.Controls.Add(this.fileTextBox1);
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
        private System.Windows.Forms.Button combinePdfs;
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
        private UserControlPDF1 userControlPDF11;
        private System.Windows.Forms.TextBox fileTextBox1;
        private System.Windows.Forms.TextBox fileTextBox2;
        private System.Windows.Forms.TextBox fileTextBox3;
        private System.Windows.Forms.TextBox fileTextBox4;
        private System.Windows.Forms.TextBox fileTextBox5;
        private System.Windows.Forms.TextBox fileTextBox6;
        private System.Windows.Forms.Button pdfFileBtn1;
        private System.Windows.Forms.Button fileFolderBtn1;
        private System.Windows.Forms.Button folderBtn2;
        private System.Windows.Forms.Button pdfFileBtn2;
        private System.Windows.Forms.Button folderBtn3;
        private System.Windows.Forms.Button pdfFileBtn3;
        private System.Windows.Forms.Button folderBtn4;
        private System.Windows.Forms.Button pdfFileBtn4;
        private System.Windows.Forms.Button folderBtn5;
        private System.Windows.Forms.Button pdfFileBtn5;
        private System.Windows.Forms.Button folderBtn6;
        private System.Windows.Forms.Button pdfFileBtn6;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button folderBtn7;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox fileTextBox7;
        private System.Windows.Forms.Label intrareLabel;
        private System.Windows.Forms.Label iesireLabel;
        private System.Windows.Forms.Button obtainAFileBtn;
        private System.Windows.Forms.Button obtainMultipleFilesBtn;
        private System.Windows.Forms.TextBox renameFileTextBox;
        private System.Windows.Forms.CheckBox renameFileCheck;
        private System.Windows.Forms.ListBox listBox1;
    }
}
