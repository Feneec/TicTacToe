using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormMenu : Form
    {
        public bool isRestart;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormGame frmGame = new FormGame();
            frmGame.Show();
        }
    }
}
