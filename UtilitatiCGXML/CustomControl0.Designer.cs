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
            this.ieLabel5 = new System.Windows.Forms.Label();
            this.tipActLabel = new System.Windows.Forms.Label();
            this.nrActLabel = new System.Windows.Forms.Label();
            this.dataActLabel = new System.Windows.Forms.Label();
            this.emitentActLabel = new System.Windows.Forms.Label();
            this.noteInscriereLabel = new System.Windows.Forms.Label();
            this.noteActLabel = new System.Windows.Forms.Label();
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
            this.ieLabel4 = new System.Windows.Forms.Label();
            this.destinatieConstructieLabel = new System.Windows.Forms.Label();
            this.areGeometrieLabel = new System.Windows.Forms.Label();
            this.nrCadLabel = new System.Windows.Forms.Label();
            this.nrCfLabel = new System.Windows.Forms.Label();
            this.nrTarlaParcelaLabel = new System.Windows.Forms.Label();
            this.nrTarlaLabel = new System.Windows.Forms.Label();
            this.nrTitluLabel = new System.Windows.Forms.Label();
            this.diferentaSuprafeteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanelSarcini = new System.Windows.Forms.TableLayoutPanel();
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
            this.suprafataParcelaLabel = new System.Windows.Forms.Label();
            this.suprafataMasurataLabel2 = new System.Windows.Forms.Label();
            this.nrTopoLabel = new System.Windows.Forms.Label();
            this.proprietarLabel = new System.Windows.Forms.Label();
            this.proprietarLabel2 = new System.Windows.Forms.Label();
            this.backgroundImageLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelProprietari = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInscrieri = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanelSarcini.SuspendLayout();
            this.tableLayoutPanelConstructii.SuspendLayout();
            this.tableLayoutPanelParcele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageLogo)).BeginInit();
            this.tableLayoutPanelProprietari.SuspendLayout();
            this.tableLayoutPanelInscrieri.SuspendLayout();
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
            // ieLabel5
            //
            this.ieLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ieLabel5.AutoSize = true;
            this.ieLabel5.BackColor = System.Drawing.Color.Transparent;
            this.ieLabel5.ForeColor = System.Drawing.Color.Black;
            this.ieLabel5.Location = new System.Drawing.Point(326, 31);
            this.ieLabel5.Name = "ieLabel5";
            this.ieLabel5.TabIndex = 51;
            this.ieLabel5.TextAlign = ContentAlignment.MiddleLeft;
            this.ieLabel5.AutoSize = true;
            this.ieLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.ieLabel5.Text = "● IE";
            //
            // tipActLabel
            // 
            this.tipActLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tipActLabel.AutoSize = true;
            this.tipActLabel.BackColor = System.Drawing.Color.Transparent;
            this.tipActLabel.ForeColor = System.Drawing.Color.Black;
            this.tipActLabel.Location = new System.Drawing.Point(486, 31);
            this.tipActLabel.Name = "tipActLabel";
            this.tipActLabel.TabIndex = 51;
            this.tipActLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.tipActLabel.AutoSize = true;
            this.tipActLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.tipActLabel.Text = "● Tip Act";
            //
            // nrActLabel
            //
            this.nrActLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrActLabel.AutoSize = true;
            this.nrActLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrActLabel.ForeColor = System.Drawing.Color.Black;
            this.nrActLabel.Location = new System.Drawing.Point(6, 31);
            this.nrActLabel.Name = "nrActLabel";
            this.nrActLabel.TabIndex = 51;
            this.nrActLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrActLabel.AutoSize = true;
            this.nrActLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrActLabel.Text = "● Nr Act";
            //
            // dataActLabel
            //
            this.dataActLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataActLabel.AutoSize = true;
            this.dataActLabel.BackColor = System.Drawing.Color.Transparent;
            this.dataActLabel.ForeColor = System.Drawing.Color.Black;
            this.dataActLabel.Location = new System.Drawing.Point(166, 31);
            this.dataActLabel.Name = "dataActLabel";
            this.dataActLabel.TabIndex = 51;
            this.dataActLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.dataActLabel.AutoSize = true;
            this.dataActLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.dataActLabel.Text = "● Data Act";
            // 
            // emitentActLabel
            //
            this.emitentActLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emitentActLabel.AutoSize = true;
            this.emitentActLabel.BackColor = System.Drawing.Color.Transparent;
            this.emitentActLabel.ForeColor = System.Drawing.Color.Black;
            this.emitentActLabel.Location = new System.Drawing.Point(326, 31);
            this.emitentActLabel.Name = "emitentActLabel";
            this.emitentActLabel.TabIndex = 51;
            this.emitentActLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.emitentActLabel.AutoSize = true;
            this.emitentActLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.emitentActLabel.Text = "● Emitent Act";
            //
            // noteInscriereLabel
            //
            this.noteInscriereLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteInscriereLabel.AutoSize = true;
            this.noteInscriereLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteInscriereLabel.ForeColor = System.Drawing.Color.Black;
            this.noteInscriereLabel.Location = new System.Drawing.Point(6, 180);
            this.noteInscriereLabel.Name = "noteInscriereLabel";
            this.noteInscriereLabel.TabIndex = 51;
            this.noteInscriereLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.noteInscriereLabel.AutoSize = true;
            this.noteInscriereLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.noteInscriereLabel.Text = "● Note Inscriere";
            //
            // noteActLabel
            //
            this.noteActLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteActLabel.AutoSize = true;
            this.noteActLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteActLabel.ForeColor = System.Drawing.Color.Black;
            this.noteActLabel.Location = new System.Drawing.Point(6, 180);
            this.noteActLabel.Name = "noteActLabel";
            this.noteActLabel.TabIndex = 51;
            this.noteActLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.noteActLabel.AutoSize = true;
            this.noteActLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.noteActLabel.Text = "● Note Act";
            //
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

            this.panel1.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Lighter blue that's easier on the eyes
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Paint += new PaintEventHandler(panel1_Paint);
            this.panel1.Padding = new System.Windows.Forms.Padding(10); // Adds padding inside the panel
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.caleFisiereCgxmlBtn);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 480);
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
            // caleFisiereCgxmlBtn GroupBox
            // 
            CustomGroupBox caleFisiereCgxmlGroupBox = new CustomGroupBox();
            caleFisiereCgxmlGroupBox.Text = "1. Cale Fisiere CGXML"; // Set the title for the group box
            caleFisiereCgxmlGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            caleFisiereCgxmlGroupBox.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            caleFisiereCgxmlGroupBox.ForeColor = System.Drawing.Color.Black;
            caleFisiereCgxmlGroupBox.BorderColor = System.Drawing.Color.FromArgb(0, 130, 237);
            caleFisiereCgxmlGroupBox.Location = new System.Drawing.Point(10, 30); // Position it accordingly on the form
            caleFisiereCgxmlGroupBox.Size = new System.Drawing.Size(200, 70); // Set the appropriate size
            caleFisiereCgxmlGroupBox.Margin = new System.Windows.Forms.Padding(0);
            caleFisiereCgxmlGroupBox.Padding = new System.Windows.Forms.Padding(10); // Padding inside the group box
            this.Controls.Add(caleFisiereCgxmlGroupBox); // Add the group box to the form's controls

            this.caleFisiereCgxmlBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.caleFisiereCgxmlBtn.FlatAppearance.BorderSize = 0;
            this.caleFisiereCgxmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caleFisiereCgxmlBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caleFisiereCgxmlBtn.ForeColor = System.Drawing.Color.White;
            this.caleFisiereCgxmlBtn.Location = new System.Drawing.Point(1, 20);
            this.caleFisiereCgxmlBtn.Margin = new System.Windows.Forms.Padding(0);
            this.caleFisiereCgxmlBtn.Name = "caleFisiereCgxmlBtn";
            this.caleFisiereCgxmlBtn.Size = new System.Drawing.Size(198, 40);
            this.caleFisiereCgxmlBtn.TabIndex = 9;
            this.caleFisiereCgxmlBtn.Text = " Alege Dosar CGXML";
            this.caleFisiereCgxmlBtn.UseVisualStyleBackColor = false;
            this.caleFisiereCgxmlBtn.Click += new System.EventHandler(this.caleFisiereCgxmlBtn_Click);
            this.caleFisiereCgxmlBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.caleFisiereCgxmlBtn.ForeColor = System.Drawing.Color.Black;
            this.caleFisiereCgxmlBtn.FlatStyle = FlatStyle.Flat;
            this.caleFisiereCgxmlBtn.FlatAppearance.BorderSize = 0;

            this.caleFisiereCgxmlBtn.Image = Image.FromFile("C:\\Users\\USER\\Documents\\scripts\\cgxml-toolkit\\UtilitatiCGXML\\Resources\\folder.png"); // Ensure the path is correct
            this.caleFisiereCgxmlBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.caleFisiereCgxmlBtn.ImageAlign = ContentAlignment.MiddleRight;

            ToolTip caleFisiereToolTip = new ToolTip();
            caleFisiereToolTip.SetToolTip(this.caleFisiereCgxmlBtn, "Selectează dosarul care conține fișierele CGXML pentru a începe generarea rapoartelor");


            // Add hover effects
            this.caleFisiereCgxmlBtn.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Blue background on hover
                thisButton.ForeColor = System.Drawing.Color.White; // White text on hover for contrast
            };
            this.caleFisiereCgxmlBtn.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Revert to transparent
                thisButton.ForeColor = System.Drawing.Color.Black; // Revert to original text color
            };
            
            caleFisiereCgxmlGroupBox.Controls.Add(this.caleFisiereCgxmlBtn);
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
            // this.button6.Size = new System.Drawing.Size(220, 40);
            // this.button6.TabIndex = 5;
            // this.button6.Text = " "; // raport 10%
            // this.button6.UseVisualStyleBackColor = false;
            // this.button6.Click += new System.EventHandler(this.button6_Click);
            // this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);

            //
            // rapoarte groupbox
            //
            CustomGroupBox rapoarteGroupBox = new CustomGroupBox();
            rapoarteGroupBox.Text = "2. Generare rapoarte XLS"; // Set the title for the group box
            rapoarteGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rapoarteGroupBox.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            rapoarteGroupBox.ForeColor = System.Drawing.Color.Black;
            rapoarteGroupBox.BorderColor = System.Drawing.Color.FromArgb(0, 130, 237);
            rapoarteGroupBox.Location = new System.Drawing.Point(10, 130); // Position it accordingly on the form
            rapoarteGroupBox.Size = new System.Drawing.Size(200, 240); // Set the appropriate size
            rapoarteGroupBox.Margin = new System.Windows.Forms.Padding(0);
            rapoarteGroupBox.Padding = new System.Windows.Forms.Padding(10); // Padding inside the group box
            this.Controls.Add(rapoarteGroupBox); // Add the group box to the form's controls
            // 
            // raportProprietariBtn
            // 
            this.raportProprietariBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportProprietariBtn.FlatAppearance.BorderSize = 0;
            this.raportProprietariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportProprietariBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportProprietariBtn.Location = new System.Drawing.Point(1, 100);
            this.raportProprietariBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportProprietariBtn.Name = "raportProprietariBtn";
            this.raportProprietariBtn.Size = new System.Drawing.Size(198, 40);
            this.raportProprietariBtn.TabIndex = 2;
            this.raportProprietariBtn.Text = "Proprietari";
            this.raportProprietariBtn.UseVisualStyleBackColor = false;
            this.raportProprietariBtn.Click += new System.EventHandler(this.raportProprietariBtn_Click);
            this.raportProprietariBtn.MouseHover += new System.EventHandler(this.raportProprietariBtn_MouseHover);
            this.raportProprietariBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.raportProprietariBtn.ForeColor = System.Drawing.Color.Black;
            this.raportProprietariBtn.FlatStyle = FlatStyle.Flat;
            this.raportProprietariBtn.FlatAppearance.BorderSize = 0;

            // Add hover effects
            this.raportProprietariBtn.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Blue background on hover
                thisButton.ForeColor = System.Drawing.Color.White; // White text on hover for contrast
            };
            this.raportProprietariBtn.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Revert to transparent
                thisButton.ForeColor = System.Drawing.Color.Black; // Revert to original text color
            };
            // 
            // raportSarciniBtn
            // 
            this.raportSarciniBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportSarciniBtn.FlatAppearance.BorderSize = 0;
            this.raportSarciniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportSarciniBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportSarciniBtn.ForeColor = System.Drawing.Color.White;
            this.raportSarciniBtn.Location = new System.Drawing.Point(1, 140);
            this.raportSarciniBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportSarciniBtn.Name = "raportSarciniBtn";
            this.raportSarciniBtn.Size = new System.Drawing.Size(198, 40);
            this.raportSarciniBtn.TabIndex = 4;
            this.raportSarciniBtn.Text = "Sarcini";
            this.raportSarciniBtn.UseVisualStyleBackColor = false;
            this.raportSarciniBtn.Click += new System.EventHandler(this.raportSarciniBtn_Click);
            this.raportSarciniBtn.MouseHover += new System.EventHandler(this.raportSarciniBtn_MouseHover);
            this.raportSarciniBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.raportSarciniBtn.ForeColor = System.Drawing.Color.Black;
            this.raportSarciniBtn.FlatStyle = FlatStyle.Flat;
            this.raportSarciniBtn.FlatAppearance.BorderSize = 0;

            // Add hover effects
            this.raportSarciniBtn.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Blue background on hover
                thisButton.ForeColor = System.Drawing.Color.White; // White text on hover for contrast
            };
            this.raportSarciniBtn.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Revert to transparent
                thisButton.ForeColor = System.Drawing.Color.Black; // Revert to original text color
            };
            
            // raportConstructiiBtn
            // 
            this.raportConstructiiBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportConstructiiBtn.FlatAppearance.BorderSize = 0;
            this.raportConstructiiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportConstructiiBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportConstructiiBtn.ForeColor = System.Drawing.Color.White;
            this.raportConstructiiBtn.Location = new System.Drawing.Point(1, 60);
            this.raportConstructiiBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportConstructiiBtn.Name = "raportConstructiiBtn";
            this.raportConstructiiBtn.Size = new System.Drawing.Size(198, 40);
            this.raportConstructiiBtn.TabIndex = 0;
            this.raportConstructiiBtn.Text = "Constructii";
            this.raportConstructiiBtn.UseVisualStyleBackColor = false;
            this.raportConstructiiBtn.Click += new System.EventHandler(this.raportConstructiiBtn_Click);
            this.raportConstructiiBtn.MouseHover += new System.EventHandler(this.raportConstructiiBtn_MouseHover);
            this.raportConstructiiBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.raportConstructiiBtn.ForeColor = System.Drawing.Color.Black;
            this.raportConstructiiBtn.FlatStyle = FlatStyle.Flat;
            this.raportConstructiiBtn.FlatAppearance.BorderSize = 0;

            // Add hover effects
            this.raportConstructiiBtn.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Blue background on hover
                thisButton.ForeColor = System.Drawing.Color.White; // White text on hover for contrast
            };
            this.raportConstructiiBtn.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Revert to transparent
                thisButton.ForeColor = System.Drawing.Color.Black; // Revert to original text color
            };
            // 
            // raportParcelaBtn
            // 
            this.raportParcelaBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportParcelaBtn.FlatAppearance.BorderSize = 0;
            this.raportParcelaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportParcelaBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportParcelaBtn.ForeColor = System.Drawing.Color.White;
            this.raportParcelaBtn.Location = new System.Drawing.Point(1, 20);
            this.raportParcelaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportParcelaBtn.Name = "raportParcelaBtn";
            this.raportParcelaBtn.Size = new System.Drawing.Size(198, 40);
            this.raportParcelaBtn.TabIndex = 1;
            this.raportParcelaBtn.Text = "Parcele";
            this.raportParcelaBtn.UseVisualStyleBackColor = false;
            this.raportParcelaBtn.Click += new System.EventHandler(this.raportParcelaBtn_Click);
            this.raportParcelaBtn.MouseHover += new System.EventHandler(this.raportParcelaBtn_MouseHover);
            this.raportParcelaBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.raportParcelaBtn.ForeColor = System.Drawing.Color.Black;
            this.raportParcelaBtn.FlatStyle = FlatStyle.Flat;
            this.raportParcelaBtn.FlatAppearance.BorderSize = 0;

            // Add hover effects
            this.raportParcelaBtn.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Blue background on hover
                thisButton.ForeColor = System.Drawing.Color.White; // White text on hover for contrast
            };
            this.raportParcelaBtn.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Revert to transparent
                thisButton.ForeColor = System.Drawing.Color.Black; // Revert to original text color
            };
            // 
            // raportTipInscrieriBtn
            // 
            this.raportTipInscrieriBtn.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Material Design Blue
            this.raportTipInscrieriBtn.FlatAppearance.BorderSize = 0;
            this.raportTipInscrieriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raportTipInscrieriBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F,  System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raportTipInscrieriBtn.ForeColor = System.Drawing.Color.White;
            this.raportTipInscrieriBtn.Location = new System.Drawing.Point(1, 180);
            this.raportTipInscrieriBtn.Margin = new System.Windows.Forms.Padding(0);
            this.raportTipInscrieriBtn.Name = "raportTipInscrieriBtn";
            this.raportTipInscrieriBtn.Size = new System.Drawing.Size(198, 40);
            this.raportTipInscrieriBtn.TabIndex = 3;
            this.raportTipInscrieriBtn.Text = "Inscrieri";
            this.raportTipInscrieriBtn.UseVisualStyleBackColor = false;
            this.raportTipInscrieriBtn.Click += new System.EventHandler(this.raportTipInscrieriBtn_Click);
            this.raportTipInscrieriBtn.MouseHover += new System.EventHandler(this.raportTipInscrieriBtn_MouseHover);
            this.raportTipInscrieriBtn.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.raportTipInscrieriBtn.ForeColor = System.Drawing.Color.Black;
            this.raportTipInscrieriBtn.FlatStyle = FlatStyle.Flat;
            this.raportTipInscrieriBtn.FlatAppearance.BorderSize = 0;

            // Add hover effects
            this.raportTipInscrieriBtn.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237); // Blue background on hover
                thisButton.ForeColor = System.Drawing.Color.White; // White text on hover for contrast
            };
            this.raportTipInscrieriBtn.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(227, 242, 253); // Revert to transparent
                thisButton.ForeColor = System.Drawing.Color.Black; // Revert to original text color
            };

            rapoarteGroupBox.Controls.Add(this.raportParcelaBtn);
            rapoarteGroupBox.Controls.Add(this.raportConstructiiBtn);
            rapoarteGroupBox.Controls.Add(this.raportProprietariBtn);
            rapoarteGroupBox.Controls.Add(this.raportSarciniBtn);
            rapoarteGroupBox.Controls.Add(this.raportTipInscrieriBtn);
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
            // ieLabel4
            // 
            this.ieLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ieLabel4.AutoSize = true;
            this.ieLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ieLabel4.ForeColor = System.Drawing.Color.Black;
            this.ieLabel4.Location = new System.Drawing.Point(326, 32);
            this.ieLabel4.Name = "ieLabel4";
            this.ieLabel4.TabIndex = 56;
            this.ieLabel4.TextAlign = ContentAlignment.MiddleLeft;
            this.ieLabel4.AutoSize = true;
            this.ieLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.ieLabel4.Text = "● IE";
            //
            // destinatieConstructieLabel
            //
            this.destinatieConstructieLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.destinatieConstructieLabel.AutoSize = true;
            this.destinatieConstructieLabel.BackColor = System.Drawing.Color.Transparent;
            this.destinatieConstructieLabel.ForeColor = System.Drawing.Color.Black;
            this.destinatieConstructieLabel.Location = new System.Drawing.Point(6, 106);
            this.destinatieConstructieLabel.Name = "destinatieConstructieLabel";
            this.destinatieConstructieLabel.TabIndex = 56;
            this.destinatieConstructieLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.destinatieConstructieLabel.AutoSize = true;
            this.destinatieConstructieLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.destinatieConstructieLabel.Text = "● Destinatie Constructie";
            //
            // areGeometrieLabel
            //
            this.areGeometrieLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.areGeometrieLabel.AutoSize = true;
            this.areGeometrieLabel.BackColor = System.Drawing.Color.Transparent;
            this.areGeometrieLabel.ForeColor = System.Drawing.Color.Black;
            this.areGeometrieLabel.Location = new System.Drawing.Point(486, 32);
            this.areGeometrieLabel.Name = "areGeometrieLabel";
            this.areGeometrieLabel.TabIndex = 51;
            this.areGeometrieLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.areGeometrieLabel.AutoSize = true;
            this.areGeometrieLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.areGeometrieLabel.Text = "● Are Geometrie?";
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
            // nrTarlaParcelaLabel
            // 
            this.nrTarlaParcelaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nrTarlaParcelaLabel.AutoSize = true;
            this.nrTarlaParcelaLabel.BackColor = System.Drawing.Color.Transparent;
            this.nrTarlaParcelaLabel.ForeColor = System.Drawing.Color.Black;
            this.nrTarlaParcelaLabel.Location = new System.Drawing.Point(6, 254);
            this.nrTarlaParcelaLabel.Name = "nrTarlaParcelaLabel";
            this.nrTarlaParcelaLabel.TabIndex = 59;
            this.nrTarlaParcelaLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.nrTarlaParcelaLabel.AutoSize = true;
            this.nrTarlaParcelaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.nrTarlaParcelaLabel.Text = "● Nr Tarla + Parcelă";
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
            // tableLayoutPanelSarcini
            // 
            this.tableLayoutPanelSarcini.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelSarcini.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSarcini.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanelSarcini.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanelSarcini.ColumnCount = 4;
            this.tableLayoutPanelSarcini.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSarcini.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSarcini.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSarcini.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSarcini.Controls.Add(this.idLabel3, 0, 0);
            this.tableLayoutPanelSarcini.Controls.Add(this.sectorLabel2, 1, 0);
            this.tableLayoutPanelSarcini.Controls.Add(this.ieLabel, 2, 0);
            this.tableLayoutPanelSarcini.Controls.Add(this.sarciniLabel, 3, 0);
            this.tableLayoutPanelSarcini.Location = new System.Drawing.Point(218, 174);
            this.tableLayoutPanelSarcini.Name = "tableLayoutPanelSarcini";
            this.tableLayoutPanelSarcini.RowCount = 1;
            this.tableLayoutPanelSarcini.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSarcini.Size = new System.Drawing.Size(645, 150);
            this.tableLayoutPanelSarcini.TabIndex = 75;
            this.tableLayoutPanelSarcini.Visible = false;
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
            this.tableLayoutPanelConstructii.Controls.Add(this.idLabel6, 0, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.sectorLabel5, 1, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.ieLabel4, 2, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.destinatieConstructieLabel, 3, 0);
            this.tableLayoutPanelConstructii.Controls.Add(this.nrConstructieLabel, 0, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.areActeLabel, 2, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.suprafataMasurataLabel, 1, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.nrEtajeLabel, 3, 1);
            this.tableLayoutPanelConstructii.Controls.Add(this.suprafataActeLabel2, 0, 2);
            this.tableLayoutPanelConstructii.Controls.Add(this.proprietarLabel, 1, 2);
            this.tableLayoutPanelConstructii.Controls.Add(this.noteConstructiiLabel, 0, 2);
            this.tableLayoutPanelConstructii.Location = new System.Drawing.Point(218, 174);
            this.tableLayoutPanelConstructii.Name = "tableLayoutPanelConstructii";
            this.tableLayoutPanelConstructii.RowCount = 3;
            this.tableLayoutPanelConstructii.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanelParcele.Controls.Add(this.idLabel5, 0, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.sectorLabel6, 1, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.ieLabel3, 2, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.areGeometrieLabel, 3, 0);
            this.tableLayoutPanelParcele.Controls.Add(this.nrCadLabel, 0, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.nrCfLabel, 1, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.nrTopoLabel, 2, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.proprietarLabel, 3, 1);
            this.tableLayoutPanelParcele.Controls.Add(this.suprafataMasurataLabel2, 0, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.suprafataActeLabel, 1, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.diferentaSuprafeteLabel, 2, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.nrTitluLabel, 3, 2);
            this.tableLayoutPanelParcele.Controls.Add(this.nrTarlaParcelaLabel, 0, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.suprafataParcelaLabel, 1, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.categorieFolosintaLabel, 2, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.imprejmuitLabel, 3, 3);
            this.tableLayoutPanelParcele.Controls.Add(this.tipTerenLabel, 0, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.noteImobilLabel, 1, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.noteParcelaLabel2, 2, 4);
            this.tableLayoutPanelParcele.Controls.Add(this.noteProprietarLabel1, 3, 4);
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
            // suprafataParcelaLabel
            // 
            this.suprafataParcelaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suprafataParcelaLabel.AutoSize = true;
            this.suprafataParcelaLabel.BackColor = System.Drawing.Color.Transparent;
            this.suprafataParcelaLabel.ForeColor = System.Drawing.Color.Black;
            this.suprafataParcelaLabel.Location = new System.Drawing.Point(166, 254);
            this.suprafataParcelaLabel.Name = "suprafataParcelaLabel";
            this.suprafataParcelaLabel.TabIndex = 66;
            this.suprafataParcelaLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.suprafataParcelaLabel.AutoSize = true;
            this.suprafataParcelaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.suprafataParcelaLabel.Text = "● Suprafata Parcela";
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
            // proprietarLabel2
            // 
            this.proprietarLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.proprietarLabel2.AutoSize = true;
            this.proprietarLabel2.BackColor = System.Drawing.Color.Transparent;
            this.proprietarLabel2.ForeColor = System.Drawing.Color.Black;
            this.proprietarLabel2.Location = new System.Drawing.Point(326, 106);
            this.proprietarLabel2.Name = "proprietarLabel2";
            this.proprietarLabel2.TabIndex = 68;
            this.proprietarLabel2.TextAlign = ContentAlignment.MiddleLeft;
            this.proprietarLabel2.AutoSize = true;
            this.proprietarLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.proprietarLabel2.Text = "● Proprietar";
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
            // tableLayoutPanelProprietari
            // 
            this.tableLayoutPanelProprietari.AutoSize = true;
            this.tableLayoutPanelProprietari.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelProprietari.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelProprietari.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanelProprietari.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanelProprietari.ColumnCount = 4;
            this.tableLayoutPanelProprietari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelProprietari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelProprietari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelProprietari.Controls.Add(this.idLabel2, 0, 0);
            this.tableLayoutPanelProprietari.Controls.Add(this.sectorLabel3, 1, 0);
            this.tableLayoutPanelProprietari.Controls.Add(this.ieLabel2, 2, 0);
            this.tableLayoutPanelProprietari.Controls.Add(this.proprietarLabel2, 3, 0);
            this.tableLayoutPanelProprietari.Controls.Add(this.cnpLabel, 0, 1);
            this.tableLayoutPanelProprietari.Controls.Add(this.defunctLabel, 1, 1);
            this.tableLayoutPanelProprietari.Controls.Add(this.adresaProprietarLabel, 2, 1);
            this.tableLayoutPanelProprietari.Controls.Add(this.noteProprietarLabel, 3, 1);
            this.tableLayoutPanelProprietari.Location = new System.Drawing.Point(218, 125);
            this.tableLayoutPanelProprietari.Name = "tableLayoutPanelProprietari";
            this.tableLayoutPanelProprietari.RowCount = 2;
            this.tableLayoutPanelProprietari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelProprietari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelProprietari.Size = new System.Drawing.Size(645, 225);
            this.tableLayoutPanelProprietari.TabIndex = 77;
            this.tableLayoutPanelProprietari.Visible = false;
            // 
            // tableLayoutPanelInscrieri
            // 
            this.tableLayoutPanelInscrieri.AutoSize = true;
            this.tableLayoutPanelInscrieri.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelInscrieri.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelInscrieri.Padding = new Padding(20);
            foreach (Control c in this.tableLayoutPanelInscrieri.Controls)
            {
                c.Margin = new Padding(10);
            }
            this.tableLayoutPanelInscrieri.ColumnCount = 4;
            this.tableLayoutPanelInscrieri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInscrieri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInscrieri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInscrieri.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInscrieri.Controls.Add(this.idLabel4, 0, 0);
            this.tableLayoutPanelInscrieri.Controls.Add(this.sectorLabel, 1, 0);
            this.tableLayoutPanelInscrieri.Controls.Add(this.ieLabel5, 2, 0);
            this.tableLayoutPanelInscrieri.Controls.Add(this.tipInscriereLabel, 3, 0);
            this.tableLayoutPanelInscrieri.Controls.Add(this.tipActLabel, 0, 1);
            this.tableLayoutPanelInscrieri.Controls.Add(this.nrActLabel, 1, 1);  
            this.tableLayoutPanelInscrieri.Controls.Add(this.dataActLabel, 2, 1);
            this.tableLayoutPanelInscrieri.Controls.Add(this.emitentActLabel, 3, 1);
            this.tableLayoutPanelInscrieri.Controls.Add(this.noteInscriereLabel, 0, 2);
            this.tableLayoutPanelInscrieri.Controls.Add(this.noteActLabel, 1, 2);
            this.tableLayoutPanelInscrieri.Location = new System.Drawing.Point(218, 174);
            this.tableLayoutPanelInscrieri.Name = "tableLayoutPanelInscrieri";
            this.tableLayoutPanelInscrieri.RowCount = 3;
            this.tableLayoutPanelInscrieri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInscrieri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInscrieri.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInscrieri.Size = new System.Drawing.Size(645, 150);
            this.tableLayoutPanelInscrieri.TabIndex = 76;

            this.tableLayoutPanelInscrieri.Visible = false;
            // 
            // CustomControl0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.raportContentLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanelSarcini);
            this.Controls.Add(this.tableLayoutPanelConstructii);
            this.Controls.Add(this.tableLayoutPanelParcele);
            this.Controls.Add(this.backgroundImageLogo);
            this.Controls.Add(this.tableLayoutPanelProprietari);
            this.Controls.Add(this.tableLayoutPanelInscrieri);
            this.Name = "CustomControl0";
            this.Size = new System.Drawing.Size(865, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanelSarcini.ResumeLayout(false);
            this.tableLayoutPanelSarcini.PerformLayout();
            this.tableLayoutPanelConstructii.ResumeLayout(false);
            this.tableLayoutPanelConstructii.PerformLayout();
            this.tableLayoutPanelParcele.ResumeLayout(false);
            this.tableLayoutPanelParcele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImageLogo)).EndInit();
            this.tableLayoutPanelProprietari.ResumeLayout(false);
            this.tableLayoutPanelProprietari.PerformLayout();
            this.tableLayoutPanelInscrieri.ResumeLayout(false);
            this.tableLayoutPanelInscrieri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label raportContentLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.Label tipInscriereLabel;
        private System.Windows.Forms.Label ieLabel5;
        private System.Windows.Forms.Label tipActLabel;
        private System.Windows.Forms.Label nrActLabel;
        private System.Windows.Forms.Label dataActLabel;
        private System.Windows.Forms.Label emitentActLabel;
        private System.Windows.Forms.Label noteInscriereLabel;
        private System.Windows.Forms.Label noteActLabel;
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
        private System.Windows.Forms.Label ieLabel4;
        private System.Windows.Forms.Label destinatieConstructieLabel;
        private System.Windows.Forms.Label areGeometrieLabel;
        private System.Windows.Forms.Label nrCadLabel;
        private System.Windows.Forms.Label nrCfLabel;
        private System.Windows.Forms.Label nrTarlaParcelaLabel;
        private System.Windows.Forms.Label nrTarlaLabel;
        private System.Windows.Forms.Label nrTitluLabel;
        private System.Windows.Forms.Label diferentaSuprafeteLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSarcini;
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
        private System.Windows.Forms.Label suprafataParcelaLabel;
        private System.Windows.Forms.Label noteImobilLabel;
        private System.Windows.Forms.Label imprejmuitLabel;
        private System.Windows.Forms.Label tipTerenLabel;
        private System.Windows.Forms.PictureBox backgroundImageLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProprietari;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInscrieri;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label noteProprietarLabel1;
        private System.Windows.Forms.Label noteParcelaLabel2;
        private System.Windows.Forms.Label proprietarLabel;
        private System.Windows.Forms.Label proprietarLabel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button caleFisiereCgxmlBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}
