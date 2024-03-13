using System;
using System.Drawing;
using System.Windows.Forms;

namespace UtilitatiCGXML
{
    public class CustomHelpControl : UserControl
    {
        private Button btnRapoarteCGXML;
        private Button btnAltele;
        private Panel panelContent;
        private RichTextBox helpTextRapoarteCGXML;
        private RichTextBox helpTextAltele;

        public CustomHelpControl()
        {
            InitializeHelpControl();
        }

        private void InitializeHelpControl()
        {
            // Initialize buttons
            btnRapoarteCGXML = new Button { Text = "Rapoarte CGXML", 
                                            AutoSize = true, 
                                            FlatStyle = FlatStyle.Flat, 
                                            BackColor = System.Drawing.Color.Transparent,
                                            FlatAppearance = { BorderSize = 0 },
                                            ForeColor = System.Drawing.Color.Black };

            btnAltele = new Button { Text = "Altele", 
                                    AutoSize = true, 
                                    FlatStyle = FlatStyle.Flat, 
                                    BackColor = System.Drawing.Color.Transparent,
                                    FlatAppearance = { BorderSize = 0 },
                                    ForeColor = System.Drawing.Color.Black };

            btnRapoarteCGXML.Click += new EventHandler(btnRapoarteCGXML_Click);
            btnAltele.Click += new EventHandler(btnAltele_Click);

            // Add hover effects
            btnRapoarteCGXML.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237);
                thisButton.ForeColor = System.Drawing.Color.White;
            };
            btnRapoarteCGXML.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                if (helpTextRapoarteCGXML.Visible)
                {
                    thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237);
                    thisButton.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    thisButton.BackColor = System.Drawing.Color.Transparent;
                    thisButton.ForeColor = System.Drawing.Color.Black;
                }
            };

                                // Add hover effects
            btnAltele.MouseEnter += (sender, e) =>
            {
                var thisButton = (Button)sender;
                thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237);
                thisButton.ForeColor = System.Drawing.Color.White;
            };
            btnAltele.MouseLeave += (sender, e) =>
            {
                var thisButton = (Button)sender;
                if (helpTextAltele.Visible)
                {
                    thisButton.BackColor = System.Drawing.Color.FromArgb(0, 130, 237);
                    thisButton.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    thisButton.BackColor = System.Drawing.Color.Transparent;
                    thisButton.ForeColor = System.Drawing.Color.Black;
                }
            };



            // Initialize panel for content
            panelContent = new Panel { Dock = DockStyle.Fill };

            // Initialize RichTextBoxes for content
            helpTextRapoarteCGXML = new RichTextBox();
            helpTextAltele = new RichTextBox();
            ConfigureRichTextBox(helpTextRapoarteCGXML, true);
            ConfigureRichTextBox(helpTextAltele, false);
    
            helpTextAltele.Visible = false; // Initially hide Altele content

            // Add RichTextBoxes to the content panel
            panelContent.Controls.Add(helpTextRapoarteCGXML);
            panelContent.Controls.Add(helpTextAltele);

            // Create a flow panel for buttons to ensure they are placed next to each other
            FlowLayoutPanel panelButtons = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true };
            panelButtons.Controls.Add(btnRapoarteCGXML);
            panelButtons.Controls.Add(btnAltele);

            // Add buttons and content panel to the UserControl
            Controls.Add(panelContent);
            Controls.Add(panelButtons);

            btnRapoarteCGXML.PerformClick(); // Simulate a click to initialize the view
        }

        private void btnRapoarteCGXML_Click(object sender, EventArgs e)
        {
            helpTextRapoarteCGXML.BringToFront();
            helpTextRapoarteCGXML.Visible = true;
            helpTextAltele.Visible = false;
            ApplyButtonActiveStyle(btnRapoarteCGXML);
            ApplyButtonInactiveStyle(btnAltele);
        }

        private void btnAltele_Click(object sender, EventArgs e)
        {
            helpTextAltele.BringToFront();
            helpTextAltele.Visible = true;
            helpTextRapoarteCGXML.Visible = false;
            ApplyButtonActiveStyle(btnAltele);
            ApplyButtonInactiveStyle(btnRapoarteCGXML);
        }

private void ConfigureRichTextBox(RichTextBox richTextBox, bool isRapoarte = true)
{
    richTextBox.Dock = DockStyle.Fill;
    richTextBox.ReadOnly = true;
    richTextBox.BackColor = Color.FromArgb(240, 250, 255);
    richTextBox.Font = new Font("Segoe UI", 10);
    richTextBox.Size = new Size(500, 500);

    string rtfContent = "";

    if (!isRapoarte) 
    {
        rtfContent = @"{\rtf1\ansi\ansicpg1252\deff0{\fonttbl{\f0\fcharset0 Segoe UI;}}"
                    + @"{\colortbl ;\red0\green130\blue237;}"
                    + @"\cf1\b <Copiere \u537?i arhivare fi\u537?iere CGXML>: \b0\cf0 Dup\u259? ce dai click pe acest buton, se va deschide o fereastr\u259?.\line "
                    + @"\tab \b Pasul 1.\b0  \i''Introduce\u539?i numerele cadastrale (separate de un spa\u539?iu)''\i0: \cf0\line\tab\tab • Aici se introduc numerele cadastrale dorite pentru copiere \u537?i arhivare.\line\tab\tab • Numerele cadastrale se scriu F\u258?R\u258? extensia '.cgxml' \u537?i pot fi copiate dintr-un tabel CSV\line "
                    + @"\tab \b Pasul 2.\b0  \i ''Introduce\u539?i numele fi\u537?ierului ZIP (op\u539?ional)''\i0: \cf0\line\tab\tab • Aici se introduce numele dorit pentru fi\u537?ierul ZIP.\line\tab\tab • Dac\u259? nu se introduce nimic, fi\u537?ierul ZIP va fi numit automat 'CGXML.zip'\line "
                    + @"\tab \b Pasul 3.  <Continu\u259?>\b0: \cf0\line\tab\tab • Aici se selecteaz\u259? dosarul cu fi\u537?ierele CGXML, apoi se selecteaz\u259? dosarul unde se va face copierea \u537?i arhivarea\line "
                    + @"\tab \b Pasul 4.\b0  Urm\u259?re\u537?te bara de progres: \cf0\line\tab\tab • A\u537?tepta\u539?i p\u226?n\u259? c\u226?nd bara de progres se umple complet.\line\tab\tab • Dup\u259? ce bara de progres se umple complet, se va deschide o fereastr\u259? cu un mesaj de confirmare\line "
                    + @"\tab \b Pasul 5.\b0  \u206;nchide fereastra: \cf0\line\tab\tab • Dup\u259? ce dai click pe butonul 'X' din dreapta sus, fereastra se va \u206;nchide \u537?i vei reveni la fereastra principal\u259?\line "
                    + @"\line "
                    + @"\cf1\b Op\u539?iuni conversie CGXML \u206;n SHP:\b0\cf0\line "
                    + @"\tab \b Pasul 1.\b0  Alege setul/urile de date dorite:\cf0\line\tab\tab • Mai \u206?nt\u226?i trebuie s\u259? selectezi dac\u259? vrei ca conversia s\u259? includ\u259? imobile, construc\u539?ii sau ambele\line "
                    + @"\tab \b Pasul 2.  <\u206;ncepe conversia>\b0: \cf0\line\tab\tab • Apas\u259? pe acest buton pentru a alege folder-ul unde se afl\u259? CGXML-urile\line "
                    + @"\tab \b Pasul 3.\b0  A\u537?teapt\u259?:\line\tab\tab • Dup\u259? ce conversia va fi gata, folder-ul cu cgxml-urile convertite se va deschide.\line}";
    } 
    else
    {
         rtfContent = @"{\rtf1\ansi\ansicpg1252\deff0{\fonttbl{\f0\fcharset0 Segoe UI;}}"
                    + @"{\colortbl ;\red0\green130\blue237;}"
                    + @"\cf1\b Generare Rapoarte CGXML: \b0\cf0\line "
                    + @"\tab \b Pasul 1.  <Alege Dosar CGXML>\b0:\line\tab\tab • Pentru a putea genera rapoartele dorite, TREBUIE s\u259? alegi un dosar cu fi\u537?ierele CGXML.\line "
                    + @"\tab \b Pasul 2.\b0  Alege Raportul dorit:\line\tab\tab • Dup\u259? ce ai ales dosarul, po\u539?i alege raportul dorit din lista de rapoarte disponibile.\line}";
    }

    richTextBox.Rtf = rtfContent;
}


        private void ApplyButtonInactiveStyle(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Black;
        }

        private void ApplyButtonActiveStyle(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 130, 237);
            btn.ForeColor = Color.Black;
        }
    }
}