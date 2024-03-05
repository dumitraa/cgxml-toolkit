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
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Minimize Window
        private void button8_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            CustomControl00.BringToFront();
            CustomControl11.SendToBack();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            CustomControl11.BringToFront();
            CustomControl00.SendToBack();
        }
    }
}
