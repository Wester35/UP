using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void x0Box_Enter(object sender, EventArgs e)
        {
            if (x0Box.Text == "X0")
            {
                x0Box.Text = "";
                x0Box.ForeColor = Color.Black;
            }
        }

        private void x0Box_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(x0Box.Text))
            {
                x0Box.Text = "X0";
                x0Box.ForeColor = Color.Gray;
            }
        }

        private void y0Box_Enter(object sender, EventArgs e)
        {
            if (y0Box.Text == "Y0")
            {
                y0Box.Text = "";
                y0Box.ForeColor = Color.Black;
            }
        }

        private void y0Box_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(y0Box.Text))
            {
                y0Box.Text = "Y0";
                y0Box.ForeColor = Color.Gray;
            }
        }

        private void rBox_Enter(object sender, EventArgs e)
        {
            if (rBox.Text == "R")
            {
                rBox.Text = "";
                rBox.ForeColor = Color.Black;
            }
        }

        private void rBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rBox.Text))
            {
                rBox.Text = "R";
                rBox.ForeColor = Color.Gray;
            }
        }

        private void cBox_Enter(object sender, EventArgs e)
        {
            if (cBox.Text == "C")
            {
                cBox.Text = "";
                cBox.ForeColor = Color.Black;
            }
        }

        private void cBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBox.Text))
            {
                cBox.Text = "C";
                cBox.ForeColor = Color.Gray;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            x0Box.Text = "X0";
            x0Box.ForeColor = Color.Gray;
            y0Box.Text = "Y0";
            y0Box.ForeColor = Color.Gray;
            rBox.Text = "R";
            rBox.ForeColor = Color.Gray;
            cBox.Text = "C";
            cBox.ForeColor = Color.Gray;
            x0Box.Enter += x0Box_Enter;
            x0Box.Leave += x0Box_Leave;
            y0Box.Enter += y0Box_Enter;
            y0Box.Leave += y0Box_Leave;
            rBox.Enter += rBox_Enter;
            rBox.Leave += rBox_Leave;
            cBox.Enter += cBox_Enter;
            cBox.Leave += cBox_Leave;
        }
    }
}
