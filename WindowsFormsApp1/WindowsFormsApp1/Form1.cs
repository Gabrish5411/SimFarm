using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TitleNewGameButton_Click(object sender, EventArgs e)
        {
            Title.Hide();
            NewGame.Show();
        }

        private void NewGameBackButton_Click(object sender, EventArgs e)
        {
            NewGame.Hide();
            Title.Show();
        }

        private void NewGameDefaultButton_Click(object sender, EventArgs e)
        {
            Map map = new Map(0);
        }

        private void NewGameRiverButton_Click(object sender, EventArgs e)
        {
            Map map = new Map(1);
        }

        private void NewGameLakeButton_Click(object sender, EventArgs e)
        {
            Map map = new Map(2);
        }

        private void NewGameBothButton_Click(object sender, EventArgs e)
        {
            Map map = new Map(3);
        }
    }
}
