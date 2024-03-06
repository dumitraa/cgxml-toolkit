using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitatiCGXML
{
    public partial class DoneMsgBox : Form
    {
        public DoneMsgBox()
        {
            InitializeComponent();
        }

        public DoneMsgBox (string title, string description)
        {
            InitializeComponent();
        }
        /// <summary>
        /// Butonu 3 / X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeDialogBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Drag
        /// </summary>
        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
