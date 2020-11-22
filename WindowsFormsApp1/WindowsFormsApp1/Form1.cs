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
        ClickingMapForm clickingForm;
        Panel[] panels;
        Panel[] gamepanels;
        
        DataArgs data;
        private Point lastpos;

        public delegate DataArgs NewGameEventHandler(object source, NewGameArgs args);
        public event NewGameEventHandler NewGameButtonClicked;

        public delegate string[] PrintInventoryEventHandler(object source, DataArgs data);
        public event PrintInventoryEventHandler PrintInventoryRequest;

        public delegate string PrintMapEventHandler(object source, DataArgs args);
        public event PrintMapEventHandler PrintMapRequest;

        public delegate void AddOneEventHandler(object source, DataArgs data, string ConsName);
        public event AddOneEventHandler AddingOne;

        public delegate string[] PrintHistoricEventHandler(object source, DataArgs data);
        public event PrintHistoricEventHandler PrintHistoric;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lastpos = this.Location;
            
        }
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            clickingForm.Location = new Point(clickingForm.Location.X + this.Left -lastpos.X,
                clickingForm.Location.Y + this.Top - lastpos.Y);
            
            lastpos = this.Location;
        }
        public void ShowPanel(Panel panel)
        {
            foreach (Panel elem in panels)
            {
                if (elem == panel) elem.Show();
                else elem.Hide();
            }
        }

        public void ShowGame(Panel panel)
        {
            foreach (Panel elem in gamepanels)
            {
                if (elem == panel) elem.Show();
                else elem.Hide();
            }
        }

        private void TerrainSelectionItems(string option)
        {
            if (option.ToLower() == "show")
            {
                SelectedTerrainLabel1.Show();
                SelectedTerrainLabel2.Show();
                clickingForm.Show();
                TerrainGetButton.Show();

            }
            else
            {
                SelectedTerrainLabel1.Hide();
                SelectedTerrainLabel2.Hide();
                clickingForm.Hide();
                TerrainGetButton.Hide();
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
        public void OnNewGameButtonClicked(int option)
        {
            if (NewGameButtonClicked != null)
            {
                this.data = NewGameButtonClicked(this, new NewGameArgs() { gameoption = option });
                string result = PrintMapRequest(this, data);

                PrintMap(result);
                GameMapRichText.Hide();
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
        public void OnAddingOne(string ConsName)
        { 
                AddingOne(this, this.data, ConsName);
        }

        public void OnHistoric(int option)
        {
            string[] result = PrintHistoric(this, this.data);
            lb_AllHistoric.Text = result[option]; //0:tomates  1:papas    2:arroz
        }

        //-----------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            panels = new Panel[] { Title, NewGame, Game,
                AdminGranja, AdminProd, Market, BuildingMarket, PropertyMarket, 
                ConsumableMarket, FoodMarket, MedicineMarket, HistoricPrices};
            gamepanels = new Panel[] { MainOptions, PropertyPanel, VerifyMap, BuyFarmPanel,
                BuyCattlePanel};
            


            clickingForm = new ClickingMapForm();
            clickingForm.TopMost = true;
            
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

        private void NewGameDefaultButton_Click(object sender, EventArgs e)
        {
            
            ShowPanel(Game);
            ShowGame(VerifyMap);
            LoadingMapLabel.Show();
            OnNewGameButtonClicked(0);
        }

        
        private void NewGameRiverButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(VerifyMap);
            LoadingMapLabel.Show();
            OnNewGameButtonClicked(1);
        }

        private void NewGameLakeButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(VerifyMap);
            LoadingMapLabel.Show();
            OnNewGameButtonClicked(2);
        }

        private void NewGameBothButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(VerifyMap);
            LoadingMapLabel.Show();
            OnNewGameButtonClicked(3);
        }

        private void MapLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            ShowGame(MainOptions);
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
            ShowGame(MainOptions);
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

        private void SelectFollowingSeeds_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void bt_SeedRecords_click(object sender, EventArgs e)
        {
            ShowPanel(HistoricPrices);
        }

        private void bt_back_SeedRecords_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
        }

        private void bt_SelectNewMap_Click(object sender, EventArgs e)
        {
            GameMapRichText.Clear();
            ShowPanel(NewGame);
        }

        private void bt_back_to_Market_panel_from_Consumables_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
        }

        private void bt_ConsumableMarket_Click(object sender, EventArgs e)
        {
            ShowPanel(ConsumableMarket);
        }

        private void bt_back_to_Market_panel_fromProperty_click(object sender, EventArgs e)
        {
            ShowPanel(Market);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowPanel(ConsumableMarket);
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Title_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            ShowPanel(ConsumableMarket);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            ShowPanel(FoodMarket);
        }

        private void bt_BuyFood_Click(object sender, EventArgs e)
        {
            ShowPanel(FoodMarket);
        }

        private void bt_BuyMedicine_Click(object sender, EventArgs e)
        {
            ShowPanel(MedicineMarket);
        }

        private void bt_back_ConsumableMarket_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
        }

        private void bt_BuyFertilizer_Click(object sender, EventArgs e)
        {
            OnAddingOne("fertilizer");
        }

        private void bt_BuyIrrigation_Click(object sender, EventArgs e)
        {
            OnAddingOne("irrigation");
        }

        private void bt_BuyAnimalFood_Click(object sender, EventArgs e)
        {
            OnAddingOne("animalFood");
        }

        private void bt_BuyAnimalWater_Click(object sender, EventArgs e)
        {
            OnAddingOne("animalWater");
        }

        private void bt_BuyHerbicide_Click(object sender, EventArgs e)
        {
            OnAddingOne("herbicide");
        }

        private void bt_BuyPesticide_Click(object sender, EventArgs e)
        {
            OnAddingOne("pesticide");
        }

        private void bt_BuyFungicide_Click(object sender, EventArgs e)
        {
            OnAddingOne("fungicide");
        }

        private void bt_BuyVaccine_Click(object sender, EventArgs e)
        {
            OnAddingOne("vaccine");
        }

        private void HistoricPriceTomato_Click(object sender, EventArgs e)
        {
            OnHistoric(0);
        }

        private void HistoricPricePotato_Click(object sender, EventArgs e)
        {
            OnHistoric(1);
        }

        private void HistoricPriceRice_Click(object sender, EventArgs e)
        {
            OnHistoric(2);
        }

        private void bt_PropertyMarket_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(PropertyPanel);
            TerrainSelectionItems("Show");
        }

        private void bt_AcceptMap_Click(object sender, EventArgs e)
        {
            ShowGame(MainOptions);
        }

        private void TerrainGetButton_Click(object sender, EventArgs e)
        {
            SelectedTerrainLabel2.Text = ClickingMapForm.terrain;
        }

        private void PropertyBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
            TerrainSelectionItems("");
        }

        private void bt_BuyField_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(BuyFarmPanel);
            TerrainSelectionItems("Show");
        }

        private void BuyFarmBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
            TerrainSelectionItems("");
        }

        private void bt_BuyCattle_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(BuyCattlePanel);
            TerrainSelectionItems("Show");
        }

        private void BuyCattleBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
            TerrainSelectionItems("");
        }
    }
}
