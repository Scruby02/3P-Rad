using System;
using System.Windows.Forms;

namespace _3PåRad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button PressedButton;
        string PlayerTurn = "X";
        string PreviousPlayerTurn = "";

        private void ButtonText()
        {
            if (PlayerTurn == "X")
            {
                PressedButton.Text = "X";
                PressedButton.Enabled = false;
                PlayerTurn = "O";
                PreviousPlayerTurn = "X";
                Check_Winner();
            }
            else if (PlayerTurn == "O")
            {
                PressedButton.Text = "O";
                PressedButton.Enabled = false;
                PlayerTurn = "X";
                PreviousPlayerTurn = "O";
                Check_Winner();
            } 
        }
        private void B11_Click(object sender, EventArgs e)
        {   PressedButton = B11;
            ButtonText();                                }
        private void B12_Click(object sender, EventArgs e)
        {   PressedButton = B12;
            ButtonText();                                }
        private void B13_Click(object sender, EventArgs e)
        {   PressedButton = B13;
            ButtonText();                                }
        private void B21_Click(object sender, EventArgs e)
        {   PressedButton = B21;
            ButtonText();                                }
        private void B22_Click(object sender, EventArgs e)
        {   PressedButton = B22;
            ButtonText();                                }
        private void B23_Click(object sender, EventArgs e)
        {   PressedButton = B23;
            ButtonText();                                }
        private void B31_Click(object sender, EventArgs e)
        {   PressedButton = B31;
            ButtonText();                                }
        private void B32_Click(object sender, EventArgs e)
        {   PressedButton = B32;
            ButtonText();                                }
        private void B33_Click(object sender, EventArgs e)
        {   PressedButton = B33;
            ButtonText();                                }
        private void Check_Winner()
        {
            if ((B11.Text == PreviousPlayerTurn && B12.Text == PreviousPlayerTurn && B13.Text == PreviousPlayerTurn) || (B11.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B33.Text == PreviousPlayerTurn) || (B11.Text == PreviousPlayerTurn && B21.Text == PreviousPlayerTurn && B31.Text == PreviousPlayerTurn) || (B12.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B32.Text == PreviousPlayerTurn) || (B13.Text == PreviousPlayerTurn && B23.Text == PreviousPlayerTurn && B33.Text == PreviousPlayerTurn) || (B21.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B23.Text == PreviousPlayerTurn) || (B31.Text == PreviousPlayerTurn && B32.Text == PreviousPlayerTurn && B33.Text == PreviousPlayerTurn) || (B13.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B31.Text == PreviousPlayerTurn))
            {
                MessageBox.Show(PreviousPlayerTurn + " Has Won!");
                B31.Text = ""; B32.Text = ""; B33.Text = ""; B21.Text = ""; B22.Text = ""; B23.Text = ""; B11.Text = ""; B12.Text = ""; B13.Text = "";
                B31.Enabled = true; B32.Enabled = true; B33.Enabled = true; B21.Enabled = true; B22.Enabled = true; B23.Enabled = true; B11.Enabled = true; B12.Enabled = true; B13.Enabled = true;
                PlayerTurn = "X";
            }
        }
    }
}
