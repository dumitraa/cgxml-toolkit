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
            this.raportContentLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.tipInscriereLabel = new System.Windows.Forms.Label();
            this.noteProprietarLabel = new System.Windows.Forms.Label();
            this.ieLabel = new System.Windows.Forms.Label();
            this.sarciniLabel = new System.Windows.Forms.Label();
            this.sectorLabel2 = new System.Windows.Forms.Label();
            this.idLabel2 = new System.Windows.Forms.Label();
            this.idLabel3 = new System.Windows.Forms.Label();
            this.sectorLabel3 = new System.Windows.Forms.Label();
            this.tipInscriereLabel2 = new System.Windows.Forms.Label();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.defunctLabel = new System.Windows.Forms.Label();
            this.adresaProprietarLabel = new System.Windows.Forms.Label();
            this.idLabel4 = new System.Windows.Forms.Label();
            this.nrConstructieLabel = new System.Windows.Forms.Label();
            this.sectorLabel4 = new System.Windows.Forms.Label();
            this.ieLabel2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tipIdLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.caleFisiereCgxmlBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.raportProprietariBtn = new System.Windows.Forms.Button();
            this.raportSarciniBtn = new System.Windows.Forms.Button();
            this.raportConstructiiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.raportParcelaBtn = new System.Windows.Forms.Button();
            this.raportTipInscrieriBtn = new System.Windows.Forms.Button();
            this.sectorLabel5 = new System.Windows.Forms.Label();
            this.idLabel5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.sectorLabel6 = new System.Windows.Forms.Label();
            this.ieLabel3 = new System.Windows.Forms.Label();
            this.nrCadLabel = new System.Windows.Forms.Label();
            this.nrCfLabel = new System.Windows.Forms.Label();
            this.nrParcelaLabel = new System.Windows.Forms.Label();
            this.nrTarlaLabel = new System.Windows.Forms.Label();
            this.nrTitluLabel = new System.Windows.Forms.Label();
            this.diferentaSuprafeteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.suprafataActeLabel = new System.Windows.Forms.Label();
            this.noteConstructiiLabel = new System.Windows.Forms.Label();
            this.nrEtajeLabel = new System.Windows.Forms.Label();
            this.suprafataActeLabel2 = new System.Windows.Forms.Label();
            this.suprafataMasurataLabel = new System.Windows.Forms.Label();
            this.areActeLabel = new System.Windows.Forms.Label();
            this.idLabel6 = new System.Windows.Forms.Label();
            this.tableLayoutPanelConstructii = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelParcele = new System.Windows.Forms.TableLayoutPanel();
            this.noteProprietarLabel1 = new System.Windows.Forms.Label();
            this.noteParcelaLabel2 = new System.Windows.Forms.Label();
            this.noteImobilLabel = new System.Windows.Forms.Label();
            this.tipTerenLabel = new System.Windows.Forms.Label();
            this.imprejmuitLabel = new System.Windows.Forms.Label();
            this.categorieFolosintaLabel = new System.Windows.Forms.Label();
            this.suprafataActeLabel3 = new System.Windows.Forms.Label();
            this.suprafataMasurataLabel2 = new System.Windows.Forms.Label();
            this.nrTopoLabel = new System.Windows.Forms.Label();
            this.proprietarLabel = new System.Windows.Forms.Label();
            this.backgroundImageLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelConstructii.SuspendLayout();
            this.tableLayoutPanelParcele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageLogo)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // raportContentLabel
            // 
            this.raportContentLabel.AutoSize = true;
            this.raportContentLabel.Font = new System.Drawing.Font("Gill Sans Nova", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.raportContentLabel.ForeColor = System.Drawing.Color.Black;
            this.raportContentLabel.Location = new System.Drawing.Point(250, 25);
            this.raportContentLabel.Name = "raportContentLabel";
            this.raportContentLabel.Size = new System.Drawing.Size(401, 25);
            this.raportContentLabel.TabIndex = 72;
            this.raportContentLabel.Text = "Conținutul raportului:";
            this.raportContentLabel.Visible = false;
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(6, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.TabIndex = 49;
            this.idLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.idLabel.Text = "● ID";
            // 
            // sectorLabel
            // 
            this.sectorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.BackColor = System.Drawing.Color.Transparent;
            this.sectorLabel.ForeColor = System.Drawing.Color.Black;
            this.sectorLabel.Location = new System.Drawing.Point(220, 31);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.TabIndex = 50;
            this.sectorLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.sectorLabel.Text = "● Sector";
            // 
            // tipInscriereLabel
            // 
            this.tipInscriereLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tipInscriereLabel.AutoSize = true;
            this.tipInscriereLabel.BackColor = System.Drawing.Color.Transparent;
            this.tipInscriereLabel.ForeColor = System.Drawing.Color.Black;
            this.tipInscriereLabel.Location = new System.Drawing.Point(434, 31);
            this.tipInscriereLabel.Name = "tipInscriereLabel";
            this.tipInscriereLabel.TabIndex = 51;
            this.tipInscriereLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.tipInscriereLabel.AutoSize = true;
            this.tipInscriereLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.tipInscriereLabel.Text = "● Tip Inscriere";
            // 
            // noteProprietarLabel
            // 
            this.noteProprietarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteProprietarLabel.AutoSize = true;
            this.noteProprietarLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteProprietarLabel.Location = new System.Drawing.Point(6, 180);
            this.noteProprietarLabel.Name = "noteProprietarLabel";
            this.noteProprietarLabel.TabIndex = 55;
            this.noteProprietarLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.noteProprietarLabel.AutoSize = true;
            this.noteProprietarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.noteProprietarLabel.Text = "● Note Proprietar";
            // 
            // ieLabel
            // 
            this.ieLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ieLabel.AutoSize = true;
            this.ieLabel.BackColor = System.Drawing.Color.Transparent;
            this.ieLabel.ForeColor = System.Drawing.Color.Black;
            this.ieLabel.Location = new System.Drawing.Point(220, 31);
            this.ieLabel.Name = "ieLabel";
            this.ieLabel.TabIndex = 54;
            this.ieLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.ieLabel.AutoSize = true;
            this.ieLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.ieLabel.Text = "● IE";
            // 
            // sarciniLabel
            // 
            this.sarciniLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sarciniLabel.AutoSize = true;
            this.sarciniLabel.BackColor = System.Drawing.Color.Transparent;
            this.sarciniLabel.ForeColor = System.Drawing.Color.Black;
            this.sarciniLabel.Location = new System.Drawing.Point(6, 104);
            this.sarciniLabel.Name = "sarciniLabel";
            this.sarciniLabel.TabIndex = 53;
            this.sarciniLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.sarciniLabel.AutoSize = true;
            this.sarciniLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.sarciniLabel.Text = "● Sarcini?";
            // 
            // sectorLabel2
            // 
            this.sectorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorLabel2.AutoSize = true;
            this.sectorLabel2.BackColor = System.Drawing.Color.Transparent;
            this.sectorLabel2.ForeColor = System.Drawing.Color.Black;
            this.sectorLabel2.Location = new System.Drawing.Point(434, 31);
            this.sectorLabel2.Name = "sectorLabel2";
            this.sectorLabel2.TabIndex = 52;
            this.sectorLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.sectorLabel2.AutoSize = true;
            this.sectorLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.sectorLabel2.Text = "● Sector";
            // 
            // idLabel2
            // 
            this.idLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel2.AutoSize = true;
            this.idLabel2.BackColor = System.Drawing.Color.Transparent;
            this.idLabel2.Location = new System.Drawing.Point(6, 32);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.TabIndex = 49;
            this.idLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.idLabel2.AutoSize = true;
            this.idLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.idLabel2.Text = "● ID";
            // 
            // idLabel3
            // 
            this.idLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel3.AutoSize = true;
            this.idLabel3.BackColor = System.Drawing.Color.Transparent;
            this.idLabel3.ForeColor = System.Drawing.Color.Black;
            this.idLabel3.Location = new System.Drawing.Point(6, 31);
            this.idLabel3.Name = "idLabel3";
            this.idLabel3.TabIndex = 51;
            this.idLabel3.TextAlign = ContentAlignment.MiddleLeft;
            this.idLabel3.AutoSize = true;
            this.idLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.idLabel3.Text = "● ID";
            // 
            // sectorLabel3
            // 
            this.sectorLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorLabel3.AutoSize = true;
            this.sectorLabel3.BackColor = System.Drawing.Color.Transparent;
            this.sectorLabel3.Location = new System.Drawing.Point(220, 32);
            this.sectorLabel3.Name = "sectorLabel3";
            this.sectorLabel3.TabIndex = 50;
            this.sectorLabel3.TextAlign = ContentAlignment.MiddleLeft;
            this.sectorLabel3.AutoSize = true;
            this.sectorLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.sectorLabel3.Text = "● Sector";
            // 
            // tipInscriereLabel2
            // 
            this.tipInscriereLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tipInscriereLabel2.AutoSize = true;
            this.tipInscriereLabel2.BackColor = System.Drawing.Color.Transparent;
            this.tipInscriereLabel2.Location = new System.Drawing.Point(434, 32);
            this.tipInscriereLabel2.Name = "tipInscriereLabel2";
            this.tipInscriereLabel2.TabIndex = 51;
            this.tipInscriereLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.tipInscriereLabel2.AutoSize = true;
            this.tipInscriereLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.tipInscriereLabel2.Text = "● Tip Inscriere";
            // 
            // cnpLabel
            // 
            this.cnpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.BackColor = System.Drawing.Color.Transparent;
            this.cnpLabel.Location = new System.Drawing.Point(6, 106);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.TabIndex = 52;
            this.cnpLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.cnpLabel.Text = "● CNP";
            // 
            // defunctLabel
            // 
            this.defunctLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.defunctLabel.AutoSize = true;
            this.defunctLabel.BackColor = System.Drawing.Color.Transparent;
            this.defunctLabel.Location = new System.Drawing.Point(220, 106);
            this.defunctLabel.Name = "defunctLabel";
            this.defunctLabel.TabIndex = 53;
            this.defunctLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.defunctLabel.AutoSize = true;
            this.defunctLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.defunctLabel.Text = "● Defunct?";
            // 
            // adresaProprietarLabel
            // 
            this.adresaProprietarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.adresaProprietarLabel.AutoSize = true;
            this.adresaProprietarLabel.BackColor = System.Drawing.Color.Transparent;
            this.adresaProprietarLabel.Location = new System.Drawing.Point(434, 106);
            this.adresaProprietarLabel.Name = "adresaProprietarLabel";
            this.adresaProprietarLabel.TabIndex = 54;
            this.adresaProprietarLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.adresaProprietarLabel.AutoSize = true;
            this.adresaProprietarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.adresaProprietarLabel.Text = "● Adresă Proprietar";
            // 
            // idLabel4
            // 
            this.idLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel4.AutoSize = true;
            this.idLabel4.BackColor = System.Drawing.Color.Transparent;
            this.idLabel4.ForeColor = System.Drawing.Color.Black;
            this.idLabel4.Location = new System.Drawing.Point(6, 31);
            this.idLabel4.Name = "idLabel4";
            this.idLabel4.TabIndex = 49;
            this.idLabel4.TextAlign = ContentAlignment.MiddleLeft;
            this.idLabel4.AutoSize = true;
            this.idLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.idLabel4.Text = "● ID";
            // 
            // nrConstructieLabel
            // 
            this.nrConstructieLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrConstructieLabel.AutoSize = true;
            this.nrConstructieLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrConstructieLabel.ForeColor = System.Drawing.Color.Black;
            this.nrConstructieLabel.Location = new System.Drawing.Point(326, 31);
            this.nrConstructieLabel.Name = "nrConstructieLabel";
            this.nrConstructieLabel.TabIndex = 51;
            this.nrConstructieLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrConstructieLabel.AutoSize = true;
            this.nrConstructieLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrConstructieLabel.Text = "● Nr Constructie";
            // 
            // sectorLabel4
            // 
            this.sectorLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorLabel4.AutoSize = true;
            this.sectorLabel4.BackColor = System.Drawing.Color.Transparent;
            this.sectorLabel4.ForeColor = System.Drawing.Color.Black;
            this.sectorLabel4.Location = new System.Drawing.Point(166, 31);
            this.sectorLabel4.Name = "sectorLabel4";
            this.sectorLabel4.TabIndex = 50;
            this.sectorLabel4.TextAlign = ContentAlignment.MiddleLeft;
            this.sectorLabel4.AutoSize = true;
            this.sectorLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.sectorLabel4.Text = "● Sector";
            // 
            // ieLabel2
            // 
            this.ieLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ieLabel2.AutoSize = true;
            this.ieLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ieLabel2.ForeColor = System.Drawing.Color.Black;
            this.ieLabel2.Location = new System.Drawing.Point(326, 31);
            this.ieLabel2.Name = "ieLabel2";
            this.ieLabel2.TabIndex = 51;
            this.ieLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.ieLabel2.AutoSize = true;
            this.ieLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.ieLabel2.Text = "● IE";
            // 
            // tipIdLabel
            // 
            this.tipIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tipIdLabel.AutoSize = true;
            this.tipIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.tipIdLabel.ForeColor = System.Drawing.Color.Black;
            this.tipIdLabel.Location = new System.Drawing.Point(486, 31);
            this.tipIdLabel.Name = "tipIdLabel";
            this.tipIdLabel.TabIndex = 52;
            this.tipIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.tipIdLabel.AutoSize = true;
            this.tipIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.tipIdLabel.Text = "● Tip ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.panel1.Padding = new System.Windows.Forms.Padding(10); // Adds padding inside the panel
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.caleFisiereCgxmlBtn);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.raportProprietariBtn);
            this.panel1.Controls.Add(this.raportSarciniBtn);
            this.panel1.Controls.Add(this.raportConstructiiBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.raportParcelaBtn);
            this.panel1.Controls.Add(this.raportTipInscrieriBtn);
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
            // caleFisiereCgxmlBtn
            // 
            this.caleFisiereCgxmlBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.caleFisiereCgxmlBtn.FlatAppearance.BorderSize = 0;
            this.caleFisiereCgxmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caleFisiereCgxmlBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caleFisiereCgxmlBtn.ForeColor = System.Drawing.Color.White;
            this.caleFisiereCgxmlBtn.Location = new System.Drawing.Point(0, 110);
            this.caleFisiereCgxmlBtn.Margin = new System.Windows.Forms.Padding(0);
            this.caleFisiereCgxmlBtn.Name = "caleFisiereCgxmlBtn";
            this.caleFisiereCgxmlBtn.Size = new System.Drawing.Size(214, 40);
            this.caleFisiereCgxmlBtn.TabIndex = 9;
            this.caleFisiereCgxmlBtn.Text = "Cale fisiere CGXML";
            this.caleFisiereCgxmlBtn.UseVisualStyleBackColor = false;
            this.caleFisiereCgxmlBtn.Click += new System.EventHandler(this.caleFisiereCgxmlBtn_Click);
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
            // raportProprietariBtn
            // 
            this.raportProprietariBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportProprietariBtn.FlatAppearance.BorderSize = 0;
            this.raportProprietariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportProprietariBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportProprietariBtn.ForeColor = System.Drawing.Color.White;
            this.raportProprietariBtn.Location = new System.Drawing.Point(0, 324);
            this.raportProprietariBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportProprietariBtn.Name = "raportProprietariBtn";
            this.raportProprietariBtn.Size = new System.Drawing.Size(214, 40);
            this.raportProprietariBtn.TabIndex = 2;
            this.raportProprietariBtn.Text = "Raport Proprietari";
            this.raportProprietariBtn.UseVisualStyleBackColor = false;
            this.raportProprietariBtn.Click += new System.EventHandler(this.raportProprietariBtn_Click);
            this.raportProprietariBtn.MouseHover += new System.EventHandler(this.raportProprietariBtn_MouseHover);
            // 
            // raportSarciniBtn
            // 
            this.raportSarciniBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportSarciniBtn.FlatAppearance.BorderSize = 0;
            this.raportSarciniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportSarciniBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportSarciniBtn.ForeColor = System.Drawing.Color.White;
            this.raportSarciniBtn.Location = new System.Drawing.Point(0, 244);
            this.raportSarciniBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportSarciniBtn.Name = "raportSarciniBtn";
            this.raportSarciniBtn.Size = new System.Drawing.Size(214, 40);
            this.raportSarciniBtn.TabIndex = 4;
            this.raportSarciniBtn.Text = "Raport Sarcini";
            this.raportSarciniBtn.UseVisualStyleBackColor = false;
            this.raportSarciniBtn.Click += new System.EventHandler(this.raportSarciniBtn_Click);
            this.raportSarciniBtn.MouseHover += new System.EventHandler(this.raportSarciniBtn_MouseHover);
            
            // raportConstructiiBtn
            // 
            this.raportConstructiiBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportConstructiiBtn.FlatAppearance.BorderSize = 0;
            this.raportConstructiiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportConstructiiBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportConstructiiBtn.ForeColor = System.Drawing.Color.White;
            this.raportConstructiiBtn.Location = new System.Drawing.Point(0, 204);
            this.raportConstructiiBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportConstructiiBtn.Name = "raportConstructiiBtn";
            this.raportConstructiiBtn.Size = new System.Drawing.Size(214, 40);
            this.raportConstructiiBtn.TabIndex = 0;
            this.raportConstructiiBtn.Text = "Raport Constructii";
            this.raportConstructiiBtn.UseVisualStyleBackColor = false;
            this.raportConstructiiBtn.Click += new System.EventHandler(this.raportConstructiiBtn_Click);
            this.raportConstructiiBtn.MouseHover += new System.EventHandler(this.raportConstructiiBtn_MouseHover);
            // 
            // raportParcelaBtn
            // 
            this.raportParcelaBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportParcelaBtn.FlatAppearance.BorderSize = 0;
            this.raportParcelaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportParcelaBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportParcelaBtn.ForeColor = System.Drawing.Color.White;
            this.raportParcelaBtn.Location = new System.Drawing.Point(0, 164);
            this.raportParcelaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportParcelaBtn.Name = "raportParcelaBtn";
            this.raportParcelaBtn.Size = new System.Drawing.Size(214, 40);
            this.raportParcelaBtn.TabIndex = 1;
            this.raportParcelaBtn.Text = "Raport Parcela";
            this.raportParcelaBtn.UseVisualStyleBackColor = false;
            this.raportParcelaBtn.Click += new System.EventHandler(this.raportParcelaBtn_Click);
            this.raportParcelaBtn.MouseHover += new System.EventHandler(this.raportParcelaBtn_MouseHover);
            // 
            // raportTipInscrieriBtn
            // 
            this.raportTipInscrieriBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportTipInscrieriBtn.FlatAppearance.BorderSize = 0;
            this.raportTipInscrieriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportTipInscrieriBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportTipInscrieriBtn.ForeColor = System.Drawing.Color.White;
            this.raportTipInscrieriBtn.Location = new System.Drawing.Point(0, 284);
            this.raportTipInscrieriBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportTipInscrieriBtn.Name = "raportTipInscrieriBtn";
            this.raportTipInscrieriBtn.Size = new System.Drawing.Size(214, 40);
            this.raportTipInscrieriBtn.TabIndex = 3;
            this.raportTipInscrieriBtn.Text = "Raport Tip Inscrieri";
            this.raportTipInscrieriBtn.UseVisualStyleBackColor = false;
            this.raportTipInscrieriBtn.Click += new System.EventHandler(this.raportTipInscrieriBtn_Click);
            this.raportTipInscrieriBtn.MouseHover += new System.EventHandler(this.raportTipInscrieriBtn_MouseHover);
            // 
            // sectorLabel5
            // 
            this.sectorLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorLabel5.AutoSize = true;
            this.sectorLabel5.BackColor = System.Drawing.Color.Transparent;
            this.sectorLabel5.ForeColor = System.Drawing.Color.Black;
            this.sectorLabel5.Location = new System.Drawing.Point(166, 31);
            this.sectorLabel5.Name = "sectorLabel5";
            this.sectorLabel5.TabIndex = 50;
            this.sectorLabel5.TextAlign = ContentAlignment.MiddleLeft;
            this.sectorLabel5.AutoSize = true;
            this.sectorLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.sectorLabel5.Text = "● Sector";
            // 
            // idLabel5
            // 
            this.idLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel5.AutoSize = true;
            this.idLabel5.BackColor = System.Drawing.Color.Transparent;
            this.idLabel5.ForeColor = System.Drawing.Color.Black;
            this.idLabel5.Location = new System.Drawing.Point(6, 32);
            this.idLabel5.Name = "idLabel5";
            this.idLabel5.TabIndex = 49;
            this.idLabel5.TextAlign = ContentAlignment.MiddleLeft;
            this.idLabel5.AutoSize = true;
            this.idLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.idLabel5.Text = "● ID";
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
            this.tableLayoutPanel6.Controls.Add(this.idLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.sectorLabel4, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ieLabel2, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tipIdLabel, 3, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(218, 199);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(645, 75);
            this.tableLayoutPanel6.TabIndex = 78;
            this.tableLayoutPanel6.Visible = false;
            // 
            // sectorLabel6
            // 
            this.sectorLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorLabel6.AutoSize = true;
            this.sectorLabel6.BackColor = System.Drawing.Color.Transparent;
            this.sectorLabel6.ForeColor = System.Drawing.Color.Black;
            this.sectorLabel6.Location = new System.Drawing.Point(166, 32);
            this.sectorLabel6.Name = "sectorLabel6";
            this.sectorLabel6.TabIndex = 50;
            this.sectorLabel6.TextAlign = ContentAlignment.MiddleLeft;
            this.sectorLabel6.AutoSize = true;
            this.sectorLabel6.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.sectorLabel6.Text = "● Sector";
            // 
            // ieLabel3
            // 
            this.ieLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ieLabel3.AutoSize = true;
            this.ieLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ieLabel3.ForeColor = System.Drawing.Color.Black;
            this.ieLabel3.Location = new System.Drawing.Point(326, 32);
            this.ieLabel3.Name = "ieLabel3";
            this.ieLabel3.TabIndex = 51;
            this.ieLabel3.TextAlign = ContentAlignment.MiddleLeft;
            this.ieLabel3.AutoSize = true;
            this.ieLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.ieLabel3.Text = "● IE";
            // 
            // nrCadLabel
            // 
            this.nrCadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrCadLabel.AutoSize = true;
            this.nrCadLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrCadLabel.ForeColor = System.Drawing.Color.Black;
            this.nrCadLabel.Location = new System.Drawing.Point(486, 32);
            this.nrCadLabel.Name = "nrCadLabel";
            this.nrCadLabel.TabIndex = 52;
            this.nrCadLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrCadLabel.AutoSize = true;
            this.nrCadLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrCadLabel.Text = "● Nr CAD";
            // 
            // nrCfLabel
            // 
            this.nrCfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrCfLabel.AutoSize = true;
            this.nrCfLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrCfLabel.ForeColor = System.Drawing.Color.Black;
            this.nrCfLabel.Location = new System.Drawing.Point(6, 106);
            this.nrCfLabel.Name = "nrCfLabel";
            this.nrCfLabel.TabIndex = 53;
            this.nrCfLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrCfLabel.AutoSize = true;
            this.nrCfLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrCfLabel.Text = "● Nr CF";
            // 
            // nrParcelaLabel
            // 
            this.nrParcelaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrParcelaLabel.AutoSize = true;
            this.nrParcelaLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrParcelaLabel.ForeColor = System.Drawing.Color.Black;
            this.nrParcelaLabel.Location = new System.Drawing.Point(6, 254);
            this.nrParcelaLabel.Name = "nrParcelaLabel";
            this.nrParcelaLabel.TabIndex = 59;
            this.nrParcelaLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrParcelaLabel.AutoSize = true;
            this.nrParcelaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrParcelaLabel.Text = "● Nr Parcelă";
            // 
            // nrTarlaLabel
            // 
            this.nrTarlaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrTarlaLabel.AutoSize = true;
            this.nrTarlaLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrTarlaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nrTarlaLabel.Location = new System.Drawing.Point(486, 180);
            this.nrTarlaLabel.Name = "nrTarlaLabel";
            this.nrTarlaLabel.TabIndex = 58;
            this.nrTarlaLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrTarlaLabel.AutoSize = true;
            this.nrTarlaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrTarlaLabel.Text = "● Nr Tarla";
            // 
            // nrTitluLabel
            // 
            this.nrTitluLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrTitluLabel.AutoSize = true;
            this.nrTitluLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrTitluLabel.ForeColor = System.Drawing.Color.Black;
            this.nrTitluLabel.Location = new System.Drawing.Point(326, 180);
            this.nrTitluLabel.Name = "nrTitluLabel";
            this.nrTitluLabel.TabIndex = 57;
            this.nrTitluLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrTitluLabel.AutoSize = true;
            this.nrTitluLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrTitluLabel.Text = "● Nr Titlu";
            // 
            // diferentaSuprafeteLabel
            // 
            this.diferentaSuprafeteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diferentaSuprafeteLabel.AutoSize = true;
            this.diferentaSuprafeteLabel.BackColor = System.Drawing.Color.Transparent;
            this.diferentaSuprafeteLabel.ForeColor = System.Drawing.Color.Black;
            this.diferentaSuprafeteLabel.Location = new System.Drawing.Point(166, 180);
            this.diferentaSuprafeteLabel.Name = "diferentaSuprafeteLabel";
            this.diferentaSuprafeteLabel.TabIndex = 56;
            this.diferentaSuprafeteLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.diferentaSuprafeteLabel.AutoSize = true;
            this.diferentaSuprafeteLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.diferentaSuprafeteLabel.Text = "● Dif Suprafațe";
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
            this.tableLayoutPanel3.Controls.Add(this.idLabel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ieLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.sarciniLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.sectorLabel2, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(218, 174);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(645, 150);
            this.tableLayoutPanel3.TabIndex = 75;
            this.tableLayoutPanel3.Visible = false;
            // 
            // suprafataActeLabel
            // 
            this.suprafataActeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suprafataActeLabel.AutoSize = true;
            this.suprafataActeLabel.BackColor = System.Drawing.Color.Transparent;
            this.suprafataActeLabel.ForeColor = System.Drawing.Color.Black;
            this.suprafataActeLabel.Location = new System.Drawing.Point(6, 180);
            this.suprafataActeLabel.Name = "suprafataActeLabel";
            this.suprafataActeLabel.TabIndex = 55;
            this.suprafataActeLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.suprafataActeLabel.AutoSize = true;
            this.suprafataActeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.suprafataActeLabel.Text = "● Suprafața din Act";
            // 
            // noteConstructiiLabel
            // 
            this.noteConstructiiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteConstructiiLabel.AutoSize = true;
            this.noteConstructiiLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteConstructiiLabel.ForeColor = System.Drawing.Color.Black;
            this.noteConstructiiLabel.Location = new System.Drawing.Point(486, 105);
            this.noteConstructiiLabel.Name = "noteConstructiiLabel";
            this.noteConstructiiLabel.TabIndex = 56;
            this.noteConstructiiLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.noteConstructiiLabel.AutoSize = true;
            this.noteConstructiiLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.noteConstructiiLabel.Text = "● Note Constructii";
            // 
            // nrEtajeLabel
            // 
            this.nrEtajeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrEtajeLabel.AutoSize = true;
            this.nrEtajeLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrEtajeLabel.ForeColor = System.Drawing.Color.Black;
            this.nrEtajeLabel.Location = new System.Drawing.Point(326, 105);
            this.nrEtajeLabel.Name = "nrEtajeLabel";
            this.nrEtajeLabel.TabIndex = 55;
            this.nrEtajeLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrEtajeLabel.AutoSize = true;
            this.nrEtajeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrEtajeLabel.Text = "● Nr. Etaje";
            // 
            // suprafataActeLabel2
            // 
            this.suprafataActeLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suprafataActeLabel2.AutoSize = true;
            this.suprafataActeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.suprafataActeLabel2.ForeColor = System.Drawing.Color.Black;
            this.suprafataActeLabel2.Location = new System.Drawing.Point(166, 105);
            this.suprafataActeLabel2.Name = "suprafataActeLabel2";
            this.suprafataActeLabel2.TabIndex = 54;
            this.suprafataActeLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.suprafataActeLabel2.AutoSize = true;
            this.suprafataActeLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.suprafataActeLabel2.Text = "● Suprafata din Act";
            // 
            // suprafataMasurataLabel
            // 
            this.suprafataMasurataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suprafataMasurataLabel.AutoSize = true;
            this.suprafataMasurataLabel.BackColor = System.Drawing.Color.Transparent;
            this.suprafataMasurataLabel.ForeColor = System.Drawing.Color.Black;
            this.suprafataMasurataLabel.Location = new System.Drawing.Point(6, 105);
            this.suprafataMasurataLabel.Name = "suprafataMasurataLabel";
            this.suprafataMasurataLabel.TabIndex = 53;
            this.suprafataMasurataLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.suprafataMasurataLabel.AutoSize = true;
            this.suprafataMasurataLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.suprafataMasurataLabel.Text = "● Suprafața Masurată";
            // 
            // areActeLabel
            // 
            this.areActeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.areActeLabel.AutoSize = true;
            this.areActeLabel.BackColor = System.Drawing.Color.Transparent;
            this.areActeLabel.ForeColor = System.Drawing.Color.Black;
            this.areActeLabel.Location = new System.Drawing.Point(486, 31);
            this.areActeLabel.Name = "areActeLabel";
            this.areActeLabel.TabIndex = 52;
            this.areActeLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.areActeLabel.AutoSize = true;
            this.areActeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.areActeLabel.Text = "● Are Acte?";
            // 
            // idLabel6
            // 
            this.idLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel6.AutoSize = true;
            this.idLabel6.BackColor = System.Drawing.Color.Transparent;
            this.idLabel6.ForeColor = System.Drawing.Color.Black;
            this.idLabel6.Location = new System.Drawing.Point(6, 31);
            this.idLabel6.Name = "idLabel6";
            this.idLabel6.TabIndex = 49;
            this.idLabel6.TextAlign = ContentAlignment.MiddleLeft;
            this.idLabel6.AutoSize = true;
            this.idLabel6.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.idLabel6.Text = "● ID";
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
            this.tableLayoutPanelConstructii.Controls.Add(this.noteConstructiiLabel, 3, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.nrEtajeLabel, 2, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.suprafataActeLabel2, 1, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.proprietarLabel, 1, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.suprafataMasurataLabel, 0, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.areActeLabel, 3, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.idLabel6, 0, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.sectorLabel5, 1, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.nrConstructieLabel, 2, 0);
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
            this.tableLayoutPanelParcele.Controls.Add(this.noteProprietarLabel1, 3, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.idLabel5, 0, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.sectorLabel6, 1, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.ieLabel3, 2, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.noteParcelaLabel2, 2, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.noteImobilLabel, 1, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.tipTerenLabel, 0, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.imprejmuitLabel, 3, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.categorieFolosintaLabel, 2, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.suprafataActeLabel3, 1, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.nrParcelaLabel, 0, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.nrTarlaLabel, 3, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.nrTitluLabel, 2, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.diferentaSuprafeteLabel, 1, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.suprafataActeLabel, 0, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.suprafataMasurataLabel2, 3, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.nrCadLabel, 3, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.nrCfLabel, 0, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.nrTopoLabel, 1, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.proprietarLabel, 2, 1);
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
            // noteProprietarLabel1
            // 
            this.noteProprietarLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteProprietarLabel1.AutoSize = true;
            this.noteProprietarLabel1.BackColor = System.Drawing.Color.Transparent;
            this.noteProprietarLabel1.ForeColor = System.Drawing.Color.Black;
            this.noteProprietarLabel1.Location = new System.Drawing.Point(486, 329);
            this.noteProprietarLabel1.Name = "noteProprietarLabel1";
            this.noteProprietarLabel1.TabIndex = 69;
            this.noteProprietarLabel1.TextAlign = ContentAlignment.MiddleLeft;
            this.noteProprietarLabel1.AutoSize = true;
            this.noteProprietarLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.noteProprietarLabel1.Text = "● Note Proprietar";
            // 
            // noteParcelaLabel2
            // 
            this.noteParcelaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteParcelaLabel2.AutoSize = true;
            this.noteParcelaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.noteParcelaLabel2.ForeColor = System.Drawing.Color.Black;
            this.noteParcelaLabel2.Location = new System.Drawing.Point(326, 329);
            this.noteParcelaLabel2.Name = "noteParcelaLabel2";
            this.noteParcelaLabel2.TabIndex = 64;
            this.noteParcelaLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.noteParcelaLabel2.AutoSize = true;
            this.noteParcelaLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.noteParcelaLabel2.Text = "● Note Parcelă";
            // 
            // noteImobilLabel
            // 
            this.noteImobilLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteImobilLabel.AutoSize = true;
            this.noteImobilLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteImobilLabel.ForeColor = System.Drawing.Color.Black;
            this.noteImobilLabel.Location = new System.Drawing.Point(166, 329);
            this.noteImobilLabel.Name = "noteImobilLabel";
            this.noteImobilLabel.TabIndex = 63;
            this.noteImobilLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.noteImobilLabel.AutoSize = true;
            this.noteImobilLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.noteImobilLabel.Text = "● Note Imobil";
            // 
            // tipTerenLabel
            // 
            this.tipTerenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tipTerenLabel.AutoSize = true;
            this.tipTerenLabel.BackColor = System.Drawing.Color.Transparent;
            this.tipTerenLabel.ForeColor = System.Drawing.Color.Black;
            this.tipTerenLabel.Location = new System.Drawing.Point(6, 329);
            this.tipTerenLabel.Name = "tipTerenLabel";
            this.tipTerenLabel.TabIndex = 62;
            this.tipTerenLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.tipTerenLabel.AutoSize = true;
            this.tipTerenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.tipTerenLabel.Text = "● Tip Teren (E/I)";
            // 
            // imprejmuitLabel
            // 
            this.imprejmuitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imprejmuitLabel.AutoSize = true;
            this.imprejmuitLabel.BackColor = System.Drawing.Color.Transparent;
            this.imprejmuitLabel.ForeColor = System.Drawing.Color.Black;
            this.imprejmuitLabel.Location = new System.Drawing.Point(486, 254);
            this.imprejmuitLabel.Name = "imprejmuitLabel";
            this.imprejmuitLabel.TabIndex = 67;
            this.imprejmuitLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.imprejmuitLabel.AutoSize = true;
            this.imprejmuitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.imprejmuitLabel.Text = "● Imprejmuit?";
            // 
            // categorieFolosintaLabel
            // 
            this.categorieFolosintaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categorieFolosintaLabel.AutoSize = true;
            this.categorieFolosintaLabel.BackColor = System.Drawing.Color.Transparent;
            this.categorieFolosintaLabel.ForeColor = System.Drawing.Color.Black;
            this.categorieFolosintaLabel.Location = new System.Drawing.Point(326, 254);
            this.categorieFolosintaLabel.Name = "categorieFolosintaLabel";
            this.categorieFolosintaLabel.TabIndex = 60;
            this.categorieFolosintaLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.categorieFolosintaLabel.AutoSize = true;
            this.categorieFolosintaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.categorieFolosintaLabel.Text = "● Categorie de folosință";
            // 
            // suprafataActeLabel3
            // 
            this.suprafataActeLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suprafataActeLabel3.AutoSize = true;
            this.suprafataActeLabel3.BackColor = System.Drawing.Color.Transparent;
            this.suprafataActeLabel3.ForeColor = System.Drawing.Color.Black;
            this.suprafataActeLabel3.Location = new System.Drawing.Point(166, 254);
            this.suprafataActeLabel3.Name = "suprafataActeLabel3";
            this.suprafataActeLabel3.TabIndex = 66;
            this.suprafataActeLabel3.TextAlign = ContentAlignment.MiddleLeft;
            this.suprafataActeLabel3.AutoSize = true;
            this.suprafataActeLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.suprafataActeLabel3.Text = "● Suprafata din Acte";
            // 
            // suprafataMasurataLabel2
            // 
            this.suprafataMasurataLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suprafataMasurataLabel2.AutoSize = true;
            this.suprafataMasurataLabel2.BackColor = System.Drawing.Color.Transparent;
            this.suprafataMasurataLabel2.ForeColor = System.Drawing.Color.Black;
            this.suprafataMasurataLabel2.Location = new System.Drawing.Point(486, 106);
            this.suprafataMasurataLabel2.Name = "suprafataMasurataLabel2";
            this.suprafataMasurataLabel2.TabIndex = 54;
            this.suprafataMasurataLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.suprafataMasurataLabel2.AutoSize = true;
            this.suprafataMasurataLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.suprafataMasurataLabel2.Text = "● Suprafata  Masurata";
            // 
            // nrTopoLabel
            // 
            this.nrTopoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrTopoLabel.AutoSize = true;
            this.nrTopoLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrTopoLabel.ForeColor = System.Drawing.Color.Black;
            this.nrTopoLabel.Location = new System.Drawing.Point(166, 106);
            this.nrTopoLabel.Name = "nrTopoLabel";
            this.nrTopoLabel.TabIndex = 65;
            this.nrTopoLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrTopoLabel.AutoSize = true;
            this.nrTopoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrTopoLabel.Text = "● Nr TOPO";
            // 
            // proprietarLabel
            // 
            this.proprietarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.proprietarLabel.AutoSize = true;
            this.proprietarLabel.BackColor = System.Drawing.Color.Transparent;
            this.proprietarLabel.ForeColor = System.Drawing.Color.Black;
            this.proprietarLabel.Location = new System.Drawing.Point(326, 106);
            this.proprietarLabel.Name = "proprietarLabel";
            this.proprietarLabel.TabIndex = 68;
            this.proprietarLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.proprietarLabel.AutoSize = true;
            this.proprietarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.proprietarLabel.Text = "● Proprietar";

            // 
            // backgroundImageLogo
            // 
            this.backgroundImageLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundImageLogo.Image = ((System.Drawing.Image)(resources.GetObject("backgroundImageLogo.Image")));
            this.backgroundImageLogo.Location = new System.Drawing.Point(378, 12);
            this.backgroundImageLogo.Margin = new System.Windows.Forms.Padding(0);
            this.backgroundImageLogo.Name = "backgroundImageLogo";
            this.backgroundImageLogo.Size = new System.Drawing.Size(400, 400);
            this.backgroundImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundImageLogo.TabIndex = 70;
            this.backgroundImageLogo.TabStop = false;
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
            this.tableLayoutPanel5.Controls.Add(this.noteProprietarLabel, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.idLabel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ieLabel2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.sectorLabel3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tipInscriereLabel2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.cnpLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.defunctLabel, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.adresaProprietarLabel, 2, 1);
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
            this.tableLayoutPanel4.Controls.Add(this.idLabel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.sectorLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tipInscriereLabel, 2, 0);
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
            this.Controls.Add(this.raportContentLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanelConstructii);
            this.Controls.Add(this.tableLayoutPanelParcele);
            this.Controls.Add(this.backgroundImageLogo);
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
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageLogo)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label raportContentLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.Label tipInscriereLabel;
        private System.Windows.Forms.Label noteProprietarLabel;
        private System.Windows.Forms.Label ieLabel;
        private System.Windows.Forms.Label sarciniLabel;
        private System.Windows.Forms.Label sectorLabel2;
        private System.Windows.Forms.Label idLabel2;
        private System.Windows.Forms.Label idLabel3;
        private System.Windows.Forms.Label sectorLabel3;
        private System.Windows.Forms.Label tipInscriereLabel2;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.Label defunctLabel;
        private System.Windows.Forms.Label adresaProprietarLabel;
        private System.Windows.Forms.Label idLabel4;
        private System.Windows.Forms.Label nrConstructieLabel;
        private System.Windows.Forms.Label sectorLabel4;
        private System.Windows.Forms.Label ieLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label tipIdLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button raportProprietariBtn;
        private System.Windows.Forms.Button raportSarciniBtn;
        private System.Windows.Forms.Button raportConstructiiBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button raportParcelaBtn;
        private System.Windows.Forms.Button raportTipInscrieriBtn;
        private System.Windows.Forms.Label sectorLabel5;
        private System.Windows.Forms.Label idLabel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label sectorLabel6;
        private System.Windows.Forms.Label ieLabel3;
        private System.Windows.Forms.Label nrCadLabel;
        private System.Windows.Forms.Label nrCfLabel;
        private System.Windows.Forms.Label nrParcelaLabel;
        private System.Windows.Forms.Label nrTarlaLabel;
        private System.Windows.Forms.Label nrTitluLabel;
        private System.Windows.Forms.Label diferentaSuprafeteLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label suprafataActeLabel;
        private System.Windows.Forms.Label noteConstructiiLabel;
        private System.Windows.Forms.Label nrEtajeLabel;
        private System.Windows.Forms.Label suprafataActeLabel2;
        private System.Windows.Forms.Label suprafataMasurataLabel;
        private System.Windows.Forms.Label areActeLabel;
        private System.Windows.Forms.Label idLabel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConstructii;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParcele;
        private System.Windows.Forms.Label suprafataMasurataLabel2;
        private System.Windows.Forms.Label nrTopoLabel;
        private System.Windows.Forms.Label categorieFolosintaLabel;
        private System.Windows.Forms.Label suprafataActeLabel3;
        private System.Windows.Forms.Label noteImobilLabel;
        private System.Windows.Forms.Label imprejmuitLabel;
        private System.Windows.Forms.Label tipTerenLabel;
        private System.Windows.Forms.PictureBox backgroundImageLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label noteProprietarLabel1;
        private System.Windows.Forms.Label noteParcelaLabel2;
        private System.Windows.Forms.Label proprietarLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button caleFisiereCgxmlBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}
