using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormGame : Form
    {
        private byte turnCount = 0;
        private bool turn = true;
        public FormGame()
        {
            InitializeComponent();
        }

        void Restart()
        {
            foreach (Control b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.Text = "";
            }

            turnCount = 0;
            turn = true;
        }

        void ButtonRestart_Click(object sender, EventArgs e)
        {
            panelWinner.Visible = false;
            Restart();
        }

        void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                btn.Text = turn == true ? "X" : "O";

                btn.Enabled = false;
                turnCount++;
                Check();
                turn = !turn;

            }
            catch { }
        }
        public void Check()
        {
            bool _winner = false;

            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "") { _winner = true; }
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && b4.Text != "") { _winner = true; }
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && b7.Text != "") { _winner = true; }
            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && b1.Text != "") { _winner = true; }
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && b2.Text != "") { _winner = true; }
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && b3.Text != "") { _winner = true; }
            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && b1.Text != "") { _winner = true; }
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && b3.Text != "") { _winner = true; }

            string win;

            if (_winner)
            {
                win = turn == true ? "Победили X!" : "Победили O!";

                Winner(win);
            } else if (turnCount == 9)
            {
                win = "Ничья!";

                Winner(win);
            }
        }

        void Winner(string text)
        {
            panelWinner.Visible = true;
            labelWinner.Text = text;
        }
    }
}
