using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustomEventArgs;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Panel[] panels;
        DataArgs data;

        public delegate DataArgs NewGameEventHandler(object source, NewGameArgs args);
        public event NewGameEventHandler NewGameButtonClicked;

        public delegate string[] PrintInventoryEventHandler(object source, DataArgs data);
        public event PrintInventoryEventHandler PrintInventoryRequest;

        public delegate string PrintMapEventHandler(object source, DataArgs args);
        public event PrintMapEventHandler PrintMapRequest;

        public void ShowPanel(Panel panel)
        {
            foreach (Panel elem in panels)
            {
                if (elem == panel) elem.Show();
                else elem.Hide();
            }
        }

        public void PrintMap(string map)
        {
            foreach (char elem in map)
            {
                if (elem == 'A')
                {
                    GameMapRichText.SelectionBackColor = Color.Blue;
                    GameMapRichText.SelectedText = "  ";
                }
                else if (elem == 'T')
                {
                    GameMapRichText.SelectionBackColor = Color.Green;
                    GameMapRichText.SelectedText = "  ";
                }
                else if (elem == 'G')
                {
                    GameMapRichText.SelectionBackColor = Color.LightGreen;
                    GameMapRichText.SelectedText = "  ";
                }
                else 
                {
                    GameMapRichText.SelectedText = Environment.NewLine;
                }
            }
        }
        public async void OnNewGameButtonClicked(int option)
        {
            if (NewGameButtonClicked != null)
            {
                this.data = NewGameButtonClicked(this, new NewGameArgs() { gameoption = option });
                string result = PrintMapRequest(this, data);

                Task task = new Task(() => PrintMap(result));
                GameMapRichText.Hide();
                task.Start();
                await task;
                GameMapRichText.Show();
                LoadingMapLabel.Hide();
            }
        }
        public void OnAskForInventory()
        {
            if(PrintInventoryRequest != null)
            {
                string[] result = PrintInventoryRequest(this, this.data);
                FertilizerLabel2.Text = result[0];
                IrrigationLabel2.Text = result[1];
                AnimalFoodLabel2.Text = result[2];
                AnimalWaterLabel2.Text = result[3];
                FungicideLabel2.Text = result[4];
                HerbicideLabel2.Text = result[5];
                PesticideLabel2.Text = result[6];
                VaccineLabel2.Text = result[7];
                
                
            //CurrentMoneyLabel2.Text = map.currentmoney;
            

            }
        }

        //-----------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            panels = new Panel[] { Title, NewGame, Game,
                AdminGranja, AdminProd, Market, BuildingMarket};
        }
        



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TitleNewGameButton_Click(object sender, EventArgs e)
        {
            ShowPanel(NewGame);
        }

        private void NewGameBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Title);
        }

        private async void NewGameDefaultButton_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => {
                ShowPanel(Game);
                LoadingMapLabel.Show();
            });
            task.Start();
            await task;
            OnNewGameButtonClicked(0);
        }

        
        private async void NewGameRiverButton_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => {
                ShowPanel(Game);
                LoadingMapLabel.Show();
            });
            task.Start();
            await task;
            OnNewGameButtonClicked(1);
        }

        private async void NewGameLakeButton_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => {
                LoadingMapLabel.Show();
                ShowPanel(Game);
                });
            task.Start();
            await task;
            OnNewGameButtonClicked(2);
        }

        private async void NewGameBothButton_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => {
                LoadingMapLabel.Show();
                ShowPanel(Game);
            });
            task.Start();
            await task;
            OnNewGameButtonClicked(3);
        }

        private void MapLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void MainOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_AdminGranja_Click(object sender, EventArgs e)
        {
            OnAskForInventory();
            ShowPanel(AdminGranja);
        }

        private void bt_IrMercado_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
        }

        private void bt_PassTurn_Click(object sender, EventArgs e)
        {

        }

        private void bt_GrabarPartida_Click(object sender, EventArgs e)
        {

        }

        private void bt_back_AdminGranja_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
        }

        private void bt_AdminProd_Click(object sender, EventArgs e)
        {
            ShowPanel(AdminProd);
        }

        private void bt_AdminAlmac_Click(object sender, EventArgs e)
        {

        }

        private void bt_back_Market_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
        }

        private void bt_BuildingMarket_Click(object sender, EventArgs e)
        {
            ShowPanel(BuildingMarket);
        }

        private void bt_back_BuildingMarket_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
        }

        private void bt_back_AdminProd_Click(object sender, EventArgs e)
        {
            OnAskForInventory();
            ShowPanel(AdminGranja);
        }
    }
}
