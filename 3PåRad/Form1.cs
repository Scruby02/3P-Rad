using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3PåRad
{
    public partial class Form1 : Form
    {
        Button PressedButton;
        Boolean XTurn = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonText()
        {
            if (XTurn == true)
            {
                XTurn = false;
                PressedButton.Text = "X";
            }
            else if (XTurn == false)
            {
                XTurn = true;
                PressedButton.Text = "O";
            }
            PressedButton.Enabled = false;
        }

        private void B11_Click(object sender, EventArgs e)
        {
            PressedButton = B11;
            ButtonText();
        }

        private void B12_Click(object sender, EventArgs e)
        {
            PressedButton = B12;
            ButtonText();
        }

        private void B13_Click(object sender, EventArgs e)
        {
            PressedButton = B13;
            ButtonText();
        }

        private void B21_Click(object sender, EventArgs e)
        {
            PressedButton = B21;
            ButtonText();
        }

        private void B22_Click(object sender, EventArgs e)
        {
            PressedButton = B22;
            ButtonText();
        }

        private void B23_Click(object sender, EventArgs e)
        {
            PressedButton = B23;
            ButtonText();
        }

        private void B31_Click(object sender, EventArgs e)
        {
            PressedButton = B31;
            ButtonText();
        }

        private void B32_Click(object sender, EventArgs e)
        {
            PressedButton = B32;
            ButtonText();
        }

        private void B33_Click(object sender, EventArgs e)
        {
            PressedButton = B33;
            ButtonText();
        }
    }
}
