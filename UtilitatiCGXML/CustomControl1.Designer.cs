using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace UtilitatiCGXML
{
    partial class CustomControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.backgroundImageLogo = new System.Windows.Forms.PictureBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.intrareLabel = new System.Windows.Forms.Label();
            this.iesireLabel = new System.Windows.Forms.Label();
            this.obtainAFileBtn = new System.Windows.Forms.Button();
            this.obtainMultipleFilesBtn = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.renameFileCheck = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.cgToShpBtn); // CGXML -> SHP
            this.panel1.Controls.Add(this.constrCheckbox); // Checkbox for exporting constructii
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
            // cgToShpBtn
            // 
            this.cgToShpBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.cgToShpBtn.FlatAppearance.BorderSize = 0;
            this.cgToShpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cgToShpBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cgToShpBtn.ForeColor = System.Drawing.Color.White;
            this.cgToShpBtn.Location = new System.Drawing.Point(0, 220);
            this.cgToShpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cgToShpBtn.Name = "cgToShpBtn";
            this.cgToShpBtn.Size = new System.Drawing.Size(214, 51);
            this.cgToShpBtn.TabIndex = 4;
            this.cgToShpBtn.Text = "CGXML -> SHP";
            this.cgToShpBtn.UseVisualStyleBackColor = false;
            this.cgToShpBtn.Click += new System.EventHandler(this.cgToShpBtn_Click);
            this.cgToShpBtn.MouseHover += new System.EventHandler(this.cgToShpBtn_MouseHover);
            //
            // constrCheckbox
            //
            this.constrCheckbox.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.constrCheckbox.ForeColor = System.Drawing.Color.Black;
            this.constrCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.constrCheckbox.AutoSize = true;
            this.constrCheckbox.Location = new System.Drawing.Point(50, 250);
            this.constrCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.constrCheckbox.Name = "constrCheckbox";
            this.constrCheckbox.Size = new System.Drawing.Size(167, 17);
            this.constrCheckbox.TabIndex = 5;
            this.constrCheckbox.Text = "+ export constructii";
            this.constrCheckbox.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);    
            this.constrCheckbox.UseVisualStyleBackColor = false;
            this.constrCheckbox.Visible = true;
            this.constrCheckbox.Click += new System.EventHandler(this.constrCheckbox_Click);
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
            this.combinePdfs.Size = new System.Drawing.Size(214, 51);
            this.combinePdfs.TabIndex = 0;
            this.combinePdfs.Text = "Combina PDF-uri";
            this.combinePdfs.UseVisualStyleBackColor = false;
            this.combinePdfs.Click += new System.EventHandler(this.combinePdfs_Click);
            this.combinePdfs.MouseHover += new System.EventHandler(this.combinePdfs_MouseHover);
            // 
            // copyArchiveCgBtn
            // 
            this.copyArchiveCgBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.copyArchiveCgBtn.FlatAppearance.BorderSize = 0;
            this.copyArchiveCgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyArchiveCgBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyArchiveCgBtn.ForeColor = System.Drawing.Color.White;
            this.copyArchiveCgBtn.Location = new System.Drawing.Point(0, 118);
            this.copyArchiveCgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.copyArchiveCgBtn.Name = "copyArchiveCgBtn";
            this.copyArchiveCgBtn.Size = new System.Drawing.Size(214, 51);
            this.copyArchiveCgBtn.TabIndex = 1;
            this.copyArchiveCgBtn.Text = "Copiere si arhivare fișiere CGXML";
            this.copyArchiveCgBtn.UseVisualStyleBackColor = false;
            this.copyArchiveCgBtn.Click += new System.EventHandler(this.copyArchiveCgBtn_Click);
            this.copyArchiveCgBtn.MouseHover += new System.EventHandler(this.copyArchiveCgBtn_MouseHover);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 20);
            this.textBox3.TabIndex = 28;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(313, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 20);
            this.textBox4.TabIndex = 29;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(313, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(264, 20);
            this.textBox5.TabIndex = 30;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(313, 272);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(264, 20);
            this.textBox6.TabIndex = 31;
            this.textBox6.Visible = false;
            // 
            // button11
            // 
            this.button11.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.button11.Location = new System.Drawing.Point(254, 119);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(25, 25);
            this.button11.TabIndex = 33;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button10.Location = new System.Drawing.Point(224, 119);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(25, 25);
            this.button10.TabIndex = 32;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.button12.Location = new System.Drawing.Point(254, 150);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(25, 25);
            this.button12.TabIndex = 35;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button13.Location = new System.Drawing.Point(224, 150);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(25, 25);
            this.button13.TabIndex = 34;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.button14.Location = new System.Drawing.Point(254, 181);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(25, 25);
            this.button14.TabIndex = 37;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button15.Location = new System.Drawing.Point(224, 181);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(25, 25);
            this.button15.TabIndex = 36;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Visible = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.button16.Location = new System.Drawing.Point(254, 210);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(25, 25);
            this.button16.TabIndex = 39;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button17.Location = new System.Drawing.Point(224, 210);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(25, 25);
            this.button17.TabIndex = 38;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Visible = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.button18.Location = new System.Drawing.Point(254, 241);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(25, 25);
            this.button18.TabIndex = 41;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Visible = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button19.Location = new System.Drawing.Point(224, 241);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(25, 25);
            this.button19.TabIndex = 40;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Visible = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.button20.Location = new System.Drawing.Point(254, 272);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(25, 25);
            this.button20.TabIndex = 43;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Visible = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button21.Location = new System.Drawing.Point(224, 272);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(25, 25);
            this.button21.TabIndex = 42;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Visible = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(599, 364);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 44;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Visible = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // button23
            // 
            this.button23.Image = global::VerificareCGXML.Properties.Resources.FolderR_2png;
            this.button23.Location = new System.Drawing.Point(253, 339);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(25, 25);
            this.button23.TabIndex = 46;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Visible = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Image = global::VerificareCGXML.Properties.Resources.fileR2;
            this.button24.Location = new System.Drawing.Point(224, 339);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(25, 25);
            this.button24.TabIndex = 45;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Visible = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(312, 339);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(264, 20);
            this.textBox7.TabIndex = 47;
            this.textBox7.Visible = false;
            // 
            // intrareLabel
            // 
            this.intrareLabel.AutoSize = true;
            this.intrareLabel.Location = new System.Drawing.Point(301, 66);
            this.intrareLabel.Name = "intrareLabel";
            this.intrareLabel.Size = new System.Drawing.Size(37, 13);
            this.intrareLabel.TabIndex = 48;
            this.intrareLabel.Text = "Intrare";
            this.intrareLabel.Visible = false;
            // 
            // iesireLabel
            // 
            this.iesireLabel.AutoSize = true;
            this.iesireLabel.Location = new System.Drawing.Point(310, 316);
            this.iesireLabel.Name = "iesireLabel";
            this.iesireLabel.Size = new System.Drawing.Size(32, 13);
            this.iesireLabel.TabIndex = 49;
            this.iesireLabel.Text = "Iesire";
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
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(312, 392);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(264, 20);
            this.textBox8.TabIndex = 52;
            this.textBox8.Visible = false;
            // 
            // renameFileCheck
            // 
            this.renameFileCheck.AutoSize = true;
            this.renameFileCheck.Location = new System.Drawing.Point(264, 369);
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
            this.listBox1.Location = new System.Drawing.Point(536, 171);
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
            this.Controls.Add(this.constrCheckbox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.obtainMultipleFilesBtn);
            this.Controls.Add(this.obtainAFileBtn);
            this.Controls.Add(this.iesireLabel);
            this.Controls.Add(this.intrareLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label intrareLabel;
        private System.Windows.Forms.Label iesireLabel;
        private System.Windows.Forms.Button obtainAFileBtn;
        private System.Windows.Forms.Button obtainMultipleFilesBtn;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox renameFileCheck;
        private System.Windows.Forms.ListBox listBox1;
    }
}
