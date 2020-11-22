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
    public partial class ClickingMapForm : Form
    {
        public static string terrain = "";
        public ClickingMapForm()
        {
            InitializeComponent();
        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            int x = (int)Math.Floor((Cursor.Position.X - this.Left) / 20.5)+1;
            int y = (int)Math.Floor((Cursor.Position.Y - this.Top) / 20.5);
            terrain = Convert.ToString(10*y+x);
        }
    }
}
