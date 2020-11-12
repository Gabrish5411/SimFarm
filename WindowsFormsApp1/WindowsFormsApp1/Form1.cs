﻿using System;
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
            MainOptions.Hide();
            AdminGranja.Show();
        }

        private void bt_IrMercado_Click(object sender, EventArgs e)
        {
            MainOptions.Hide();
            Market.Show();
        }

        private void bt_PassTurn_Click(object sender, EventArgs e)
        {

        }

        private void bt_GrabarPartida_Click(object sender, EventArgs e)
        {

        }

        private void bt_back_AdminGranja_Click(object sender, EventArgs e)
        {
            AdminGranja.Hide();
            MainOptions.Show();
        }

        private void bt_AdminProd_Click(object sender, EventArgs e)
        {
            AdminGranja.Hide();
            AdminProd.Show();
        }

        private void bt_AdminAlmac_Click(object sender, EventArgs e)
        {

        }

        private void bt_back_Market_Click(object sender, EventArgs e)
        {
            Market.Hide();
            MainOptions.Show();
        }

        private void bt_BuildingMarket_Click(object sender, EventArgs e)
        {
            Market.Hide();
            BuildingMarket.Show();
        }

        private void bt_back_BuildingMarket_Click(object sender, EventArgs e)
        {
            BuildingMarket.Hide();
            Market.Show();
        }

        private void bt_back_AdminProd_Click(object sender, EventArgs e)
        {
            AdminProd.Hide();
            AdminGranja.Show();
        }
    }
}
