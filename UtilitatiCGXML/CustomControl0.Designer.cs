using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace UtilitatiCGXML
{
    partial class CustomControl0
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
            private void StylePanelAndButtons()
            {
                // Assuming panel1 is already defined and added to the control
                this.panel1.BackColor = System.Drawing.Color.Transparent;

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
                        thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Blue background on hover
                        thisButton.ForeColor = System.Drawing.Color.White; // White text on hover for contrast
                    };
                    btn.MouseLeave += (sender, e) =>
                    {
                        var thisButton = (Button)sender;
                        thisButton.BackColor = System.Drawing.Color.Transparent; // Revert to transparent
                        thisButton.ForeColor = System.Drawing.Color.Black; // Revert to original text color
                    };
                }
            }


        private void InitializeComponent()
        {

            // Set the panel to a neutral color or even transparent
            // For each button in the panel
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomControl0));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label21 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label45 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tableLayoutPanelConstructii = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelParcele = new System.Windows.Forms.TableLayoutPanel();
            this.label63 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelConstructii.SuspendLayout();
            this.tableLayoutPanelParcele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Gill Sans Nova", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(250, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(401, 25);
            this.label21.TabIndex = 72;
            this.label21.Text = "Conținutul raportului:";
            this.label21.Visible = false;
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(6, 31);
            this.label42.Name = "label42";
            this.label42.TabIndex = 49;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label42.Text = "● ID";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(220, 31);
            this.label33.Name = "label33";
            this.label33.TabIndex = 50;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label33.Text = "● Sector";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(434, 31);
            this.label34.Name = "label34";
            this.label34.TabIndex = 51;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label34.Text = "● Tip Inscriere";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(6, 180);
            this.label35.Name = "label35";
            this.label35.TabIndex = 55;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label35.Text = "● Note Proprietar";
            // 
            // label61
            // 
            this.label61.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.ForeColor = System.Drawing.Color.Black;
            this.label61.Location = new System.Drawing.Point(220, 31);
            this.label61.Name = "label61";
            this.label61.TabIndex = 54;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label61.Text = "● IE";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(6, 104);
            this.label31.Name = "label31";
            this.label31.TabIndex = 53;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label31.Text = "● Sarcini?";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(434, 31);
            this.label30.Name = "label30";
            this.label30.TabIndex = 52;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label30.Text = "● Sector";
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(6, 32);
            this.label36.Name = "label36";
            this.label36.TabIndex = 49;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label36.Text = "● ID";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(6, 31);
            this.label29.Name = "label29";
            this.label29.TabIndex = 51;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label29.Text = "● ID";
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(220, 32);
            this.label37.Name = "label37";
            this.label37.TabIndex = 50;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label37.Text = "● Sector";
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(434, 32);
            this.label38.Name = "label38";
            this.label38.TabIndex = 51;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label38.Text = "● Tip Inscriere";
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(6, 106);
            this.label39.Name = "label39";
            this.label39.TabIndex = 52;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label39.Text = "● CNP";
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(220, 106);
            this.label40.Name = "label40";
            this.label40.TabIndex = 53;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label40.Text = "● Defunct?";
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(434, 106);
            this.label41.Name = "label41";
            this.label41.TabIndex = 54;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label41.Text = "● Adresă Proprietar";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(6, 31);
            this.label32.Name = "label32";
            this.label32.TabIndex = 49;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label32.Text = "● ID";
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(326, 31);
            this.label28.Name = "label28";
            this.label28.TabIndex = 51;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label28.Text = "● Nr C";
            // 
            // label43
            // 
            this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(166, 31);
            this.label43.Name = "label43";
            this.label43.TabIndex = 50;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label43.Text = "● Sector";
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(326, 31);
            this.label44.Name = "label44";
            this.label44.TabIndex = 51;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label44.Text = "● IE";
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(486, 31);
            this.label45.Name = "label45";
            this.label45.TabIndex = 52;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label45.Text = "● Tip ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.panel1.Padding = new System.Windows.Forms.Padding(10); // Adds padding inside the panel
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 424);
            this.panel1.TabIndex = 71;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(141, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 82;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(141, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 81;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 404);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 17);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.Text = "Foloseste Esantionul Aleatoriu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 110);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(214, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "Cale fisiere CGXML";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            // this.button6.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            // this.button6.FlatAppearance.BorderSize = 0;
            // this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // this.button6.ForeColor = System.Drawing.Color.White;
            // this.button6.Location = new System.Drawing.Point(0, 364);
            // this.button6.Margin = new System.Windows.Forms.Padding(0);
            // this.button6.Name = "button6";
            // this.button6.Size = new System.Drawing.Size(214, 40);
            // this.button6.TabIndex = 5;
            // this.button6.Text = " "; // raport 10%
            // this.button6.UseVisualStyleBackColor = false;
            // this.button6.Click += new System.EventHandler(this.button6_Click);
            // this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 324);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 40);
            this.button5.TabIndex = 2;
            this.button5.Text = "Raport Proprietari";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Raport Sarcini";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Raport Constructii";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Raport Parcela";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 284);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Raport Tip Inscrieri";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(166, 31);
            this.label27.Name = "label27";
            this.label27.TabIndex = 50;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label27.Text = "● Sector";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.TabIndex = 49;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label2.Text = "● ID";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanel6.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.label42, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label43, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label44, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label45, 3, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(218, 199);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(645, 75);
            this.tableLayoutPanel6.TabIndex = 78;
            this.tableLayoutPanel6.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(166, 32);
            this.label3.Name = "label3";
            this.label3.TabIndex = 50;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label3.Text = "● Sector";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(326, 32);
            this.label4.Name = "label4";
            this.label4.TabIndex = 51;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label4.Text = "● IE";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(486, 32);
            this.label5.Name = "label5";
            this.label5.TabIndex = 52;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label5.Text = "● Nr CAD";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.TabIndex = 53;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label6.Text = "● Nr CF";
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(6, 254);
            this.Label11.Name = "Label11";
            this.Label11.TabIndex = 59;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label11.Text = "● Nr Parcelă";
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label10.Location = new System.Drawing.Point(486, 180);
            this.Label10.Name = "Label10";
            this.Label10.TabIndex = 58;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label10.Text = "● Nr Tarla";
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(326, 180);
            this.Label9.Name = "Label9";
            this.Label9.TabIndex = 57;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label9.Text = "● Nr Titlu";
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(166, 180);
            this.Label8.Name = "Label8";
            this.Label8.TabIndex = 56;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label8.Text = "● Dif Suprafațe";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanel3.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label61, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label30, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(218, 174);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(645, 150);
            this.tableLayoutPanel3.TabIndex = 75;
            this.tableLayoutPanel3.Visible = false;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(6, 180);
            this.Label7.Name = "Label7";
            this.Label7.TabIndex = 55;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label7.Text = "● Suprafața din Act";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(486, 105);
            this.label20.Name = "label20";
            this.label20.TabIndex = 56;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label20.Text = "● Note C";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(326, 105);
            this.label22.Name = "label22";
            this.label22.TabIndex = 55;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label22.Text = "● Nr. Etaje";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(166, 105);
            this.label23.Name = "label23";
            this.label23.TabIndex = 54;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label23.Text = "● Suprafata din Act";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(6, 105);
            this.label24.Name = "label24";
            this.label24.TabIndex = 53;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label24.Text = "● Suprafața Masurată";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(486, 31);
            this.label25.Name = "label25";
            this.label25.TabIndex = 52;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label25.Text = "● Are Acte?";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(6, 31);
            this.label26.Name = "label26";
            this.label26.TabIndex = 49;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label26.Text = "● ID";
            // 
            // tableLayoutPanelConstructii
            // 
            this.tableLayoutPanelConstructii.AutoSize = true;
            this.tableLayoutPanelConstructii.BackColor = System.Drawing.Color.Transparent; // Sets a white background
            this.tableLayoutPanelConstructii.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelConstructii.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanelConstructii.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanelConstructii.ColumnCount = 4;
            this.tableLayoutPanelConstructii.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelConstructii.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelConstructii.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelConstructii.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelConstructii.Controls.Add(this.label20, 3, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.label22, 2, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.label23, 1, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.label62, 1, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.label24, 0, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.label25, 3, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.label27, 1, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.label28, 2, 0);
            this.tableLayoutPanelConstructii.Location = new System.Drawing.Point(218, 174);
            this.tableLayoutPanelConstructii.Name = "tableLayoutPanelConstructii";
            this.tableLayoutPanelConstructii.RowCount = 2;
            this.tableLayoutPanelConstructii.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelConstructii.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelConstructii.Size = new System.Drawing.Size(645, 150);
            this.tableLayoutPanelConstructii.TabIndex = 74;
        
            this.tableLayoutPanelConstructii.Visible = false;
            // 
            // tableLayoutPanelParcele
            // 
            this.tableLayoutPanelParcele.AutoSize = true;
            this.tableLayoutPanelParcele.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelParcele.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelParcele.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanelParcele.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanelParcele.ColumnCount = 4;
            this.tableLayoutPanelParcele.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelParcele.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelParcele.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelParcele.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelParcele.Controls.Add(this.label63, 3, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.Label16, 2, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.Label15, 1, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.Label14, 0, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.label19, 3, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.label13, 2, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.label18, 1, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.Label11, 0, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.Label10, 3, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.Label9, 2, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.Label8, 1, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.Label7, 0, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.label12, 3, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.label17, 1, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.label62, 2, 1);
            this.tableLayoutPanelParcele.Location = new System.Drawing.Point(218, 48);
            this.tableLayoutPanelParcele.Name = "tableLayoutPanelParcele";
            this.tableLayoutPanelParcele.RowCount = 5;
            this.tableLayoutPanelParcele.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelParcele.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelParcele.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelParcele.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelParcele.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelParcele.Size = new System.Drawing.Size(645, 375);
            this.tableLayoutPanelParcele.TabIndex = 73;
            this.tableLayoutPanelParcele.Visible = false;
            // 
            // label63
            // 
            this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.ForeColor = System.Drawing.Color.Black;
            this.label63.Location = new System.Drawing.Point(486, 329);
            this.label63.Name = "label63";
            this.label63.TabIndex = 69;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label63.Text = "● Note Pers";
            // 
            // Label16
            // 
            this.Label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(326, 329);
            this.Label16.Name = "Label16";
            this.Label16.TabIndex = 64;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label16.Text = "● Note Parcelă";
            // 
            // Label15
            // 
            this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(166, 329);
            this.Label15.Name = "Label15";
            this.Label15.TabIndex = 63;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label15.Text = "● Note Imobil";
            // 
            // Label14
            // 
            this.Label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(6, 329);
            this.Label14.Name = "Label14";
            this.Label14.TabIndex = 62;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.Label14.Text = "● Tip Teren (E/I)";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(486, 254);
            this.label19.Name = "label19";
            this.label19.TabIndex = 67;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label19.Text = "● Imprejmuit?";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(326, 254);
            this.label13.Name = "label13";
            this.label13.TabIndex = 60;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label13.Text = "● Categorie de folosință";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(166, 254);
            this.label18.Name = "label18";
            this.label18.TabIndex = 66;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label18.Text = "● Suprafata din Acte";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(486, 106);
            this.label12.Name = "label12";
            this.label12.TabIndex = 54;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label12.Text = "● Suprafata  Masurata";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(166, 106);
            this.label17.Name = "label17";
            this.label17.TabIndex = 65;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label17.Text = "● Nr TOPO";
            // 
            // label62
            // 
            this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Location = new System.Drawing.Point(326, 106);
            this.label62.Name = "label62";
            this.label62.TabIndex = 68;
            this.label26.TextAlign = ContentAlignment.MiddleLeft;
            this.label26.AutoSize = true;
            this.label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.label62.Text = "● Proprietar";

            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanel5.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.label35, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label44, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label37, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label38, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label39, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label40, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label41, 2, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(218, 125);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(645, 225);
            this.tableLayoutPanel5.TabIndex = 77;
            this.tableLayoutPanel5.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanel4.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.label32, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label33, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label34, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(218, 199);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(645, 75);
            this.tableLayoutPanel4.TabIndex = 76;
            this.tableLayoutPanel4.Visible = false;
            // 
            // CustomControl0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanelConstructii);
            this.Controls.Add(this.tableLayoutPanelParcele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "CustomControl0";
            this.Size = new System.Drawing.Size(865, 425);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelConstructii.ResumeLayout(false);
            this.tableLayoutPanelConstructii.PerformLayout();
            this.tableLayoutPanelParcele.ResumeLayout(false);
            this.tableLayoutPanelParcele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConstructii;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParcele;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}
