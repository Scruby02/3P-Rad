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
        String PlayerTurn = "X";
        String PreviousPlayerTurn = "";
        private void ButtonText()
        {
            if (PlayerTurn == "X")
            {
                PressedButton.Text = "X";
                PressedButton.Enabled = false;
                PlayerTurn = "O";
                PreviousPlayerTurn = "X";
            }
            else if (PlayerTurn == "O")
            {
                PressedButton.Text = "O";
                PressedButton.Enabled = false;
                PlayerTurn = "X";
                PreviousPlayerTurn = "O";
            }
            Check_Winner();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            PressedButton = ClickedButton;
            ButtonText();
        }
        private void Check_Winner()
        {
            if ((B11.Text == PreviousPlayerTurn && B12.Text == PreviousPlayerTurn && B13.Text == PreviousPlayerTurn) || (B11.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B33.Text == PreviousPlayerTurn) || (B11.Text == PreviousPlayerTurn && B21.Text == PreviousPlayerTurn && B31.Text == PreviousPlayerTurn) || (B12.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B32.Text == PreviousPlayerTurn) || (B13.Text == PreviousPlayerTurn && B23.Text == PreviousPlayerTurn && B33.Text == PreviousPlayerTurn) || (B21.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B23.Text == PreviousPlayerTurn) || (B31.Text == PreviousPlayerTurn && B32.Text == PreviousPlayerTurn && B33.Text == PreviousPlayerTurn) || (B13.Text == PreviousPlayerTurn && B22.Text == PreviousPlayerTurn && B31.Text == PreviousPlayerTurn))
            {
                MessageBox.Show(PreviousPlayerTurn + " Has Won!");
                B31.Text = ""; B32.Text = ""; B33.Text = ""; B21.Text = ""; B22.Text = ""; B23.Text = ""; B11.Text = ""; B12.Text = ""; B13.Text = "";
                B31.Enabled = true; B32.Enabled = true; B33.Enabled = true; B21.Enabled = true; B22.Enabled = true; B23.Enabled = true; B11.Enabled = true; B12.Enabled = true; B13.Enabled = true;
                PlayerTurn = "X";
                if (PreviousPlayerTurn == "X")
                {
                    int X = Convert.ToInt16(XScore.Text);
                    XScore.Text = Convert.ToString(X + 1);
                }
                if (PreviousPlayerTurn == "O")
                {
                    int O = Convert.ToInt16(OScore.Text);
                    OScore.Text = Convert.ToString(O + 1);
                }
            }
        }
    }
}