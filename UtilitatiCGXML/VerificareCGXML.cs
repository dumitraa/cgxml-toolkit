using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Web;

namespace UtilitatiCGXML
{
    public partial class VerificareCGXML : Form
    {
        public VerificareCGXML()
        {
            InitializeComponent();
            /*
            XDocument coordinates = XDocument.Load(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\County.xml"));

            foreach (var coordinate in coordinates.Descendants("County"))
            {
                string Judete = coordinate.Element("NAME").Value;
            }
            */
        }

        #region settings
        private CConfigMng oConfigMng = new CConfigMng();

        private void UtilitatiCGXML_Load(object sender, EventArgs e)
        {
            // Load configuration
            oConfigMng.LoadConfig();
            if (oConfigMng.Config.StartPos.X != 0 || oConfigMng.Config.StartPos.Y != 0)
            {
                Location = oConfigMng.Config.StartPos;
                Size = oConfigMng.Config.StartSize;
            }

        }

        private void UtilitatiCGXML_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save configuration
            oConfigMng.Config.StartPos = Location;
            oConfigMng.Config.StartSize = Size;
            oConfigMng.SaveConfig();
        }
        #endregion

        //Close Window
        private void closeWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Minimize Window
        private void minimizeWindowBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        //Drag Event
        Point lastPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void helpTabBtn_Click(object sender, EventArgs e)
        {
            CustomHelpControl.BringToFront();
            CustomControl00.SendToBack();
            CustomControl11.SendToBack();

            // Set active tab style
            helpTabBtn.BackColor = System.Drawing.Color.FromArgb(153, 204, 255); // Lighter blue for active state
            helpTabBtn.ForeColor = System.Drawing.Color.Black; // You may adjust if needed

            // Reset other tab to default style
            rapoarteCgxmlTabBtn.BackColor = System.Drawing.Color.Transparent;
            rapoarteCgxmlTabBtn.ForeColor = System.Drawing.Color.Black;

            alteleTabBtn.BackColor = System.Drawing.Color.Transparent;
            alteleTabBtn.ForeColor = System.Drawing.Color.Black;
        }
        private void rapoarteCgxmlTabBtn_Click(object sender, EventArgs e)
        {
            CustomControl00.BringToFront();
            CustomControl11.SendToBack();
            CustomHelpControl.SendToBack();

            // Set active tab style
            rapoarteCgxmlTabBtn.BackColor = System.Drawing.Color.FromArgb(153, 204, 255); // Lighter blue for active state
            rapoarteCgxmlTabBtn.ForeColor = System.Drawing.Color.Black; // You may adjust if needed

            // Reset other tab to default style
            alteleTabBtn.BackColor = System.Drawing.Color.Transparent;
            alteleTabBtn.ForeColor = System.Drawing.Color.Black;

            helpTabBtn.BackColor = System.Drawing.Color.Transparent;
            helpTabBtn.ForeColor = System.Drawing.Color.Black;
        }

        private void alteleTabBtn_Click(object sender, EventArgs e)
        {
            CustomControl11.BringToFront();
            CustomControl00.SendToBack();
            CustomHelpControl.SendToBack();

            // Set active tab style
            alteleTabBtn.BackColor = System.Drawing.Color.FromArgb(153, 204, 255); // Lighter blue for active state
            alteleTabBtn.ForeColor = System.Drawing.Color.Black; // You may adjust if needed

            // Reset other tab to default style
            rapoarteCgxmlTabBtn.BackColor = System.Drawing.Color.Transparent;
            rapoarteCgxmlTabBtn.ForeColor = System.Drawing.Color.Black;

            helpTabBtn.BackColor = System.Drawing.Color.Transparent;
            helpTabBtn.ForeColor = System.Drawing.Color.Black;
        }

    }
}
