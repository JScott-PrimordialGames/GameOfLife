using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
    public partial class ColorControl : Form
    {
        public Color newGridColor;
        public Color newBackgroundColor;
        public Color newCellColor;

        public ColorControl()
        {
            InitializeComponent();
        }

        //update grid color
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                newGridColor = dlg.Color;
                lbl_gridColor.Text = "Grid Color: " + newCellColor.ToString();
            }
            dlg.Dispose();
        }

        //update background color
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                newBackgroundColor = dlg.Color;
                lbl_BackgroundColor.Text = "Background Color: " + newBackgroundColor.ToString();
            }
            dlg.Dispose();
        }

        //update cell color
        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                newCellColor = dlg.Color;
                lbl_CellColor.Text = " Cell Color: " + newCellColor.ToString();
            }
            dlg.Dispose();
        }
    }
}
