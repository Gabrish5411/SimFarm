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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        ClickingMapForm clickingForm;
        Panel[] panels;
        Panel[] gamepanels;

        FieldArgs field;
        BuildingArgs building;
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

        public delegate void OnSaveGameEventHandler(object source, DataArgs data);
        public event OnSaveGameEventHandler SavingGame;

        public delegate object OnLoadGameEventHandler(object source, EventArgs e);
        public event OnLoadGameEventHandler LoadingGame;

        public delegate bool OnBuyTerrainEventHandler(object source, DataArgs data, int selection, string tileType);
        public event OnBuyTerrainEventHandler BuyTerrain;

        public delegate bool OnBuyFarmEventHandler(object source, DataArgs data, int selection, string buildingType, string tileType);
        public event OnBuyFarmEventHandler BuyFarm;

        public delegate bool OnBuyCattleEventHandler(object source, DataArgs data, int selection, string buildingType, string tileType);
        public event OnBuyCattleEventHandler BuyCattle;

        public delegate bool OnBuyStorageEventHandler(object source, DataArgs data, int selection, string tileType);
        public event OnBuyStorageEventHandler BuyStorage;

        public delegate List<string> OnAskForBuildingEventHandler(object source, DataArgs data, int selection);
        public event OnAskForBuildingEventHandler AskForBuilding;

        public delegate void OnApplyStuffEventHandler(object source, DataArgs data, string stuff, string option, int selection);
        public event OnApplyStuffEventHandler ApplyStuff;

        public delegate void OnGetFinishedProduct(object source, DataArgs data, int selection);
        public event OnGetFinishedProduct GetFinishedProduct;

        public delegate void OnCheatCode(object source, DataArgs data, string code);
        public event OnCheatCode GetCheatCode;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lastpos = this.Location;
            ShowPanel(Title);
            
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
                ClickingMapForm.terrain = "";
                SelectedTerrainLabel2.Text = "Ninguno";
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
                    GameMapRichText.SelectedText = "~~";
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
                else if (elem == 'C') 
                {
                    GameMapRichText.SelectionBackColor = Color.SaddleBrown;
                    GameMapRichText.SelectedText = "  ";
                }
                else if (elem == 'F')
                {
                    GameMapRichText.SelectionBackColor = Color.Orchid;
                    GameMapRichText.SelectedText = "  ";
                }
                else if (elem == 'S')
                {
                    GameMapRichText.SelectionBackColor = Color.DarkGray;
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
            lb_Wallet_num.Text = Convert.ToString(data.game.GetPlayer().Current_money);
        }

        public void OnHistoric(int option)
        {
            string[] result = PrintHistoric(this, this.data);
            tB_AllHistoric.Text = result[option]; //0:tomates  1:papas    2:arroz
        }

        public void OnSaveGame()
        {
            SavingGame(this, this.data);
        }
        public void OnLoadGame()
        {
            data = LoadingGame(this, new EventArgs()) as DataArgs;
            
        }

        public bool OnBuyTerrain(int selection, string tileType)
        {
            bool ok = BuyTerrain(this, this.data, selection, tileType);
            lb_Wallet_num.Text = Convert.ToString(data.game.GetPlayer().Current_money);
            return ok;
        }

        //-----------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            panels = new Panel[] { Title, NewGame, Game,
                AdminGranja, AdminProd, AdminAlmacen, Market, BuildingMarket, PropertyMarket, 
                ConsumableMarket, FoodMarket, MedicineMarket, HistoricPrices};
            gamepanels = new Panel[] { MainOptions, PropertyPanel, VerifyMap, BuyFarmPanel,
                BuyCattlePanel, BuyStoragePanel, SelectProductionBuildingPanel, SelectStoragePanel};
            clickingForm = new ClickingMapForm();
            clickingForm.TopMost = true;
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
            data.game.UpdateGame();
            lb_turn_num.Text = Convert.ToString(data.game.current_turn);
        }

        private void bt_GrabarPartida_Click(object sender, EventArgs e)
        {
            OnSaveGame();
            MessageBox.Show("¡Tu partida se ha guardado con exito!", "Mensaje");

        }

        private void bt_back_AdminGranja_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(MainOptions);
        }

        private void bt_AdminProd_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(SelectProductionBuildingPanel);
            TerrainSelectionItems("Show");
        }

        private void bt_AdminAlmac_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(SelectStoragePanel);
            TerrainSelectionItems("Show");
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

        private void BuyStorageBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Market);
            TerrainSelectionItems("");
        }

        private void bt_BuyStorage_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
            ShowGame(BuyStoragePanel);
            TerrainSelectionItems("Show");
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            OnLoadGame();
            ShowPanel(Game);
            ShowGame(MainOptions);
            string result = PrintMapRequest(sender, data);
            PrintMap(result);
            GameMapRichText.Hide();
            GameMapRichText.Show();
            LoadingMapLabel.Hide();
        }

        private void BuyCattleButton_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            string tileType = "Cattle";
            string option = comboBoxCattle.Text;
            bool ok = BuyCattle(sender, data, selection, option, tileType);
            if (ok)
            {
                GameMapRichText.Clear();
                string result = PrintMapRequest(this, data);
                PrintMap(result);
                ShowGame(MainOptions);
                TerrainSelectionItems("");
            }
            
        }

        private void BuyFarmButton_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            string tileType = "Field";
            string buildingOption = comboBoxFarm.Text;
            bool ok = BuyFarm(sender, data, selection, buildingOption, tileType);
            if (ok)
            {
                GameMapRichText.Clear();
                string result = PrintMapRequest(this, data);
                PrintMap(result);
                ShowGame(MainOptions);
                TerrainSelectionItems("");
            }
            
        }

        private void BuyStorageButton_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            string tileType = "Storage";
            bool ok = BuyStorage(sender, data, selection, tileType);
            if (ok)
            {
                GameMapRichText.Clear();
                string result = PrintMapRequest(this, data);
                PrintMap(result);
                ShowGame(MainOptions);
                TerrainSelectionItems("");
            }
            
        }

        private void BuyTerrainButton_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            string tileType = "G";
            bool ok = OnBuyTerrain(selection, tileType);
            if (ok)
            {
                GameMapRichText.Clear();
                string result = PrintMapRequest(this, data);
                PrintMap(result);
                ShowGame(MainOptions);
                TerrainSelectionItems("");
            }
            
        }

        private void SelectProductionBuildingBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(AdminGranja);
            TerrainSelectionItems("");
        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (!data.game.Map.terrains[Convert.ToInt32(ClickingMapForm.terrain) - 1].Get_bought())
            {
                MessageBox.Show("Este terreno no es parte de tu granja", "Hay un error!");
            }
            else if (data.game.Map.terrains[Convert.ToInt32(ClickingMapForm.terrain) - 1].Get_Building() != null)
            {
                if (data.game.Map.terrains[Convert.ToInt32(ClickingMapForm.terrain) - 1].Get_Building().Get_type() != "strg")
                {
                    TerrainSelectionItems("");
                    List<string> list = AskForBuilding(this, data, Convert.ToInt32(ClickingMapForm.terrain));
                    if (list[0][0] == 'P')
                    {
                        WormsLabel1.Show();
                        UndergrowthLabel1.Show();
                        WormsLabel1.Text = list[6];
                        UndergrowthLabel1.Text = list[7];
                    }
                    else if (list[0][0] == 'G')
                    {
                        WormsLabel1.Hide();
                        UndergrowthLabel1.Hide();
                    }
                    BuildingTypeLabel1.Text = list[0];
                    RipenessLabel1.Text = list[1];
                    HealthLabel1.Text = list[2];
                    WaterLabel1.Text = list[3];
                    FoodLabel1.Text = list[4];
                    IllnessLabel1.Text = list[5];

                    ShowPanel(AdminProd);
                    
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un terreno que tenga plantación o ganado", "Hay un error!");
                }
                
            }
            else
            {
                MessageBox.Show("Este terreno no tiene ningún edificio", "Hay un error!");
            }
            
        }

        private void SelectStorageBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(AdminGranja);
            TerrainSelectionItems("");
        }

        private void SelectStorageButton_Click(object sender, EventArgs e)
        {
            if (!data.game.Map.terrains[Convert.ToInt32(ClickingMapForm.terrain) - 1].Get_bought())
            {
                MessageBox.Show("Este terreno no es parte de tu granja", "Hay un error!");
            }
            else if (data.game.Map.terrains[Convert.ToInt32(ClickingMapForm.terrain) - 1].Get_Building() != null)
            {
                if (data.game.Map.terrains[Convert.ToInt32(ClickingMapForm.terrain) - 1].Get_Building().Get_type() == "strg")
                {
                    TerrainSelectionItems("");
                    List<string> list = AskForBuilding(this, data, Convert.ToInt32(ClickingMapForm.terrain));
                    SelectedStorageLabel1.Text = list[0];
                    SelectedStorageLabel2.Text = list[1];
                    ShowPanel(AdminAlmacen);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un terreno que tenga un almacen", "Hay un error!");
                }
            
            }
            else
            {
                MessageBox.Show("Este terreno no tiene ningún edificio", "Hay un error!");
            }
        }

        private void AdminStorageBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(AdminGranja);
        }

        private void bt_AddWorF_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            string option = combo_ApplyWoF.Text;
            ApplyStuff(this, data, "WoF", option, selection); 
        }

        private void bt_ApplyHeal_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            string option = combo_ApplyMedicine.Text;
            ApplyStuff(this, data, "Meds", option, selection); 
        }

        private void bt_ObtainFinished_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            GetFinishedProduct(this, data, selection);

        }

        private void bt_WoF_BuynUse_Click(object sender, EventArgs e)
        {
            int selection = Convert.ToInt32(ClickingMapForm.terrain);
            
            if (data.game.GetPlayer().Current_money > 5000)
            {
                string option = combo_ApplyWoF.Text;
                OnAddingOne(option.ToLower());
                ApplyStuff(this, data, "WoF", option, selection);
                MessageBox.Show("Comprado y Aplicado!", "Informacion");
            }

        }

        private void bt_Meds_BuynUse_Click(object sender, EventArgs e)
        {
            if (data.game.GetPlayer().Current_money > 5000)
            {
                string option = combo_ApplyMedicine.Text;
                OnAddingOne(option.ToLower());
                ApplyStuff(this, data, "Meds", option, Convert.ToInt32(ClickingMapForm.terrain));
                MessageBox.Show("Comprado y Aplicado!", "Informacion");
            }
        }

        private void bt_CheatCode_Click(object sender, EventArgs e)
        {
            ShowPanel(CheatCode);
        }

        private void bt_CheatCodeBackButton_Click(object sender, EventArgs e)
        {
            ShowPanel(Game);
        }

        private void bt_CheatCodeResetTextButton_Click(object sender, EventArgs e)
        {
            add_cheat_text_RichTextBox.Clear();
        }

        private void bt_CheatCodeSelectTextButton_Click(object sender, EventArgs e)
        {
            string code = add_cheat_text_RichTextBox.Text;
            GetCheatCode(this, data, code);

        }
    }
}
