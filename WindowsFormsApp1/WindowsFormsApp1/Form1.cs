﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustomEventArgs;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Game game; //Esta linea no deberia ir para evitar dependencia 
        //(Al igual que las lineas que usan game en este Form1.cs)
        //Pero como aun nose como poner el mapa por ahora dejemoslo asi


        Panel[] panels;
        public delegate Game NewGameEventHandler(object source, NewGameArgs args);
        public event NewGameEventHandler NewGameButtonClicked;

        public void ShowPanel(Panel panel)
        {
            foreach (Panel elem in panels)
            {
                if (elem == panel) elem.Show();
                else elem.Hide();
            }
        }


        public Form1()
        {
            InitializeComponent();
            panels = new Panel[] { Title, NewGame, Game,
                AdminGranja, AdminProd, Market, BuildingMarket };
        }
        
        public void OnNewGameButtonClicked(int option)
        {
            if (NewGameButtonClicked != null)
            {
                game = NewGameButtonClicked(this, new NewGameArgs() { gameoption = option });
                GameMapLabel.Text = Convert.ToString(game.current_turn); //Reemplazar esta linea para mostrar el mapa de alguna forma
            }
            
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
            OnNewGameButtonClicked(0);
            ShowPanel(Game);
        }

        private void NewGameRiverButton_Click(object sender, EventArgs e)
        {
            OnNewGameButtonClicked(1);
            ShowPanel(Game);
        }

        private void NewGameLakeButton_Click(object sender, EventArgs e)
        {
            OnNewGameButtonClicked(2);
            ShowPanel(Game);
        }

        private void NewGameBothButton_Click(object sender, EventArgs e)
        {
            OnNewGameButtonClicked(3);
            ShowPanel(Game);
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
            FertilizerLabel2.Text = Convert.ToString(game.GetPlayer().fertilizer.GetUses());
            IrrigationLabel2.Text = Convert.ToString(game.GetPlayer().irrigation.GetUses());
            AnimalFoodLabel2.Text = Convert.ToString(game.GetPlayer().animalFood.GetUses());
            AnimalWaterLabel2.Text = Convert.ToString(game.GetPlayer().animalWater.GetUses());
            FungicideLabel2.Text = Convert.ToString(game.GetPlayer().fungicide.GetUses());
            HerbicideLabel2.Text = Convert.ToString(game.GetPlayer().herbicide.GetUses());
            PesticideLabel2.Text = Convert.ToString(game.GetPlayer().pesticide.GetUses());
            VaccineLabel2.Text = Convert.ToString(game.GetPlayer().vaccine.GetUses());
            ShowPanel(AdminGranja);
            //CurrentMoneyLabel2.Text = map.currentmoney;
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
            FertilizerLabel2.Text = Convert.ToString(game.GetPlayer().fertilizer.GetUses());
            IrrigationLabel2.Text = Convert.ToString(game.GetPlayer().irrigation.GetUses());
            AnimalFoodLabel2.Text = Convert.ToString(game.GetPlayer().animalFood.GetUses());
            AnimalWaterLabel2.Text = Convert.ToString(game.GetPlayer().animalWater.GetUses());
            FungicideLabel2.Text = Convert.ToString(game.GetPlayer().fungicide.GetUses());
            HerbicideLabel2.Text = Convert.ToString(game.GetPlayer().herbicide.GetUses());
            PesticideLabel2.Text = Convert.ToString(game.GetPlayer().pesticide.GetUses());
            VaccineLabel2.Text = Convert.ToString(game.GetPlayer().vaccine.GetUses());
            ShowPanel(AdminGranja);
        }
    }
}
