namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Panel();
            this.TitleNewGameButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Panel();
            this.NewGameDefaultButton = new System.Windows.Forms.Button();
            this.NewGameBothButton = new System.Windows.Forms.Button();
            this.NewGameLakeButton = new System.Windows.Forms.Button();
            this.NewGameRiverButton = new System.Windows.Forms.Button();
            this.NewGameBackButton = new System.Windows.Forms.Button();
            this.NewGamePanelLabel = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Panel();
            this.GameMap = new System.Windows.Forms.Panel();
            this.MapLabel = new System.Windows.Forms.Label();
            this.MainOptions = new System.Windows.Forms.Panel();
            this.bt_GrabarPartida = new System.Windows.Forms.Button();
            this.bt_PassTurn = new System.Windows.Forms.Button();
            this.bt_IrMercado = new System.Windows.Forms.Button();
            this.bt_AdminGranja = new System.Windows.Forms.Button();
            this.lb_selectopt_MO = new System.Windows.Forms.Label();
            this.AdminGranja = new System.Windows.Forms.Panel();
            this.lb_selectopt_AG = new System.Windows.Forms.Label();
            this.bt_AdminProd = new System.Windows.Forms.Button();
            this.bt_AdminAlmac = new System.Windows.Forms.Button();
            this.AdminProd = new System.Windows.Forms.Panel();
            this.lb_selectopt_AP = new System.Windows.Forms.Label();
            this.bt_AddWorF = new System.Windows.Forms.Button();
            this.bt_ApplyHeal = new System.Windows.Forms.Button();
            this.bt_ObtainFinished = new System.Windows.Forms.Button();
            this.Market = new System.Windows.Forms.Panel();
            this.lb_selectopt_MK = new System.Windows.Forms.Label();
            this.bt_BuildingMarket = new System.Windows.Forms.Button();
            this.bt_ConsumableMarket = new System.Windows.Forms.Button();
            this.bt_PropertyMarket = new System.Windows.Forms.Button();
            this.bt_SeedRecords = new System.Windows.Forms.Button();
            this.BuildingMarket = new System.Windows.Forms.Panel();
            this.lb_selectopt_BMK = new System.Windows.Forms.Label();
            this.bt_BuyField = new System.Windows.Forms.Button();
            this.bt_BuyCattle = new System.Windows.Forms.Button();
            this.bt_BuyStorage = new System.Windows.Forms.Button();
            this.bt_SellDestroyBuilding = new System.Windows.Forms.Button();
            this.bt_back_AdminGranja = new System.Windows.Forms.Button();
            this.bt_back_AdminProd = new System.Windows.Forms.Button();
            this.bt_back_BuildingMarket = new System.Windows.Forms.Button();
            this.bt_back_Market = new System.Windows.Forms.Button();
            this.Title.SuspendLayout();
            this.NewGame.SuspendLayout();
            this.Game.SuspendLayout();
            this.GameMap.SuspendLayout();
            this.MainOptions.SuspendLayout();
            this.AdminGranja.SuspendLayout();
            this.AdminProd.SuspendLayout();
            this.Market.SuspendLayout();
            this.BuildingMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Controls.Add(this.TitleNewGameButton);
            this.Title.Controls.Add(this.TitleLabel);
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(643, 418);
            this.Title.TabIndex = 0;
            // 
            // TitleNewGameButton
            // 
            this.TitleNewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TitleNewGameButton.Location = new System.Drawing.Point(272, 190);
            this.TitleNewGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleNewGameButton.Name = "TitleNewGameButton";
            this.TitleNewGameButton.Size = new System.Drawing.Size(129, 33);
            this.TitleNewGameButton.TabIndex = 1;
            this.TitleNewGameButton.Text = "New Game";
            this.TitleNewGameButton.UseVisualStyleBackColor = true;
            this.TitleNewGameButton.Click += new System.EventHandler(this.TitleNewGameButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleLabel.Location = new System.Drawing.Point(265, 98);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(123, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "SimFarm";
            // 
            // NewGame
            // 
            this.NewGame.Controls.Add(this.NewGameDefaultButton);
            this.NewGame.Controls.Add(this.NewGameBothButton);
            this.NewGame.Controls.Add(this.NewGameLakeButton);
            this.NewGame.Controls.Add(this.NewGameRiverButton);
            this.NewGame.Controls.Add(this.NewGameBackButton);
            this.NewGame.Controls.Add(this.NewGamePanelLabel);
            this.NewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGame.Location = new System.Drawing.Point(0, 0);
            this.NewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(643, 418);
            this.NewGame.TabIndex = 2;
            // 
            // NewGameDefaultButton
            // 
            this.NewGameDefaultButton.Location = new System.Drawing.Point(256, 138);
            this.NewGameDefaultButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGameDefaultButton.Name = "NewGameDefaultButton";
            this.NewGameDefaultButton.Size = new System.Drawing.Size(131, 27);
            this.NewGameDefaultButton.TabIndex = 1;
            this.NewGameDefaultButton.Text = "Default";
            this.NewGameDefaultButton.UseVisualStyleBackColor = true;
            this.NewGameDefaultButton.Click += new System.EventHandler(this.NewGameDefaultButton_Click);
            // 
            // NewGameBothButton
            // 
            this.NewGameBothButton.Location = new System.Drawing.Point(256, 300);
            this.NewGameBothButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGameBothButton.Name = "NewGameBothButton";
            this.NewGameBothButton.Size = new System.Drawing.Size(131, 27);
            this.NewGameBothButton.TabIndex = 4;
            this.NewGameBothButton.Text = "River and Lake";
            this.NewGameBothButton.UseVisualStyleBackColor = true;
            this.NewGameBothButton.Click += new System.EventHandler(this.NewGameBothButton_Click);
            // 
            // NewGameLakeButton
            // 
            this.NewGameLakeButton.Location = new System.Drawing.Point(256, 249);
            this.NewGameLakeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGameLakeButton.Name = "NewGameLakeButton";
            this.NewGameLakeButton.Size = new System.Drawing.Size(131, 27);
            this.NewGameLakeButton.TabIndex = 3;
            this.NewGameLakeButton.Text = "Lake";
            this.NewGameLakeButton.UseVisualStyleBackColor = true;
            this.NewGameLakeButton.Click += new System.EventHandler(this.NewGameLakeButton_Click);
            // 
            // NewGameRiverButton
            // 
            this.NewGameRiverButton.Location = new System.Drawing.Point(256, 196);
            this.NewGameRiverButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGameRiverButton.Name = "NewGameRiverButton";
            this.NewGameRiverButton.Size = new System.Drawing.Size(131, 27);
            this.NewGameRiverButton.TabIndex = 2;
            this.NewGameRiverButton.Text = "River";
            this.NewGameRiverButton.UseVisualStyleBackColor = true;
            this.NewGameRiverButton.Click += new System.EventHandler(this.NewGameRiverButton_Click);
            // 
            // NewGameBackButton
            // 
            this.NewGameBackButton.Location = new System.Drawing.Point(4, 4);
            this.NewGameBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGameBackButton.Name = "NewGameBackButton";
            this.NewGameBackButton.Size = new System.Drawing.Size(79, 25);
            this.NewGameBackButton.TabIndex = 5;
            this.NewGameBackButton.Text = "Back";
            this.NewGameBackButton.UseVisualStyleBackColor = true;
            this.NewGameBackButton.Click += new System.EventHandler(this.NewGameBackButton_Click);
            // 
            // NewGamePanelLabel
            // 
            this.NewGamePanelLabel.AutoSize = true;
            this.NewGamePanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewGamePanelLabel.Location = new System.Drawing.Point(196, 69);
            this.NewGamePanelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewGamePanelLabel.Name = "NewGamePanelLabel";
            this.NewGamePanelLabel.Size = new System.Drawing.Size(236, 29);
            this.NewGamePanelLabel.TabIndex = 0;
            this.NewGamePanelLabel.Text = "Select a type of map:";
            // 
            // Game
            // 
            this.Game.Controls.Add(this.GameMap);
            this.Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game.Location = new System.Drawing.Point(0, 0);
            this.Game.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(643, 418);
            this.Game.TabIndex = 3;
            // 
            // GameMap
            // 
            this.GameMap.Controls.Add(this.MapLabel);
            this.GameMap.Location = new System.Drawing.Point(0, 0);
            this.GameMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameMap.Name = "GameMap";
            this.GameMap.Size = new System.Drawing.Size(456, 418);
            this.GameMap.TabIndex = 0;
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MapLabel.Location = new System.Drawing.Point(49, 32);
            this.MapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(53, 20);
            this.MapLabel.TabIndex = 0;
            this.MapLabel.Text = "label1";
            this.MapLabel.Click += new System.EventHandler(this.MapLabel_Click);
            // 
            // MainOptions
            // 
            this.MainOptions.Controls.Add(this.bt_GrabarPartida);
            this.MainOptions.Controls.Add(this.bt_PassTurn);
            this.MainOptions.Controls.Add(this.bt_IrMercado);
            this.MainOptions.Controls.Add(this.bt_AdminGranja);
            this.MainOptions.Controls.Add(this.lb_selectopt_MO);
            this.MainOptions.Location = new System.Drawing.Point(0, 0);
            this.MainOptions.Name = "MainOptions";
            this.MainOptions.Size = new System.Drawing.Size(284, 418);
            this.MainOptions.TabIndex = 3;
            // 
            // bt_GrabarPartida
            // 
            this.bt_GrabarPartida.Location = new System.Drawing.Point(42, 319);
            this.bt_GrabarPartida.Name = "bt_GrabarPartida";
            this.bt_GrabarPartida.Size = new System.Drawing.Size(168, 46);
            this.bt_GrabarPartida.TabIndex = 4;
            this.bt_GrabarPartida.Text = "Grabar la Partida";
            this.bt_GrabarPartida.UseVisualStyleBackColor = true;
            this.bt_GrabarPartida.Click += new System.EventHandler(this.bt_GrabarPartida_Click);
            // 
            // bt_PassTurn
            // 
            this.bt_PassTurn.Location = new System.Drawing.Point(42, 258);
            this.bt_PassTurn.Name = "bt_PassTurn";
            this.bt_PassTurn.Size = new System.Drawing.Size(168, 46);
            this.bt_PassTurn.TabIndex = 3;
            this.bt_PassTurn.Text = "Pasar de Turno";
            this.bt_PassTurn.UseVisualStyleBackColor = true;
            this.bt_PassTurn.Click += new System.EventHandler(this.bt_PassTurn_Click);
            // 
            // bt_IrMercado
            // 
            this.bt_IrMercado.Location = new System.Drawing.Point(42, 196);
            this.bt_IrMercado.Name = "bt_IrMercado";
            this.bt_IrMercado.Size = new System.Drawing.Size(168, 46);
            this.bt_IrMercado.TabIndex = 2;
            this.bt_IrMercado.Text = "Ir al Mercado";
            this.bt_IrMercado.UseVisualStyleBackColor = true;
            this.bt_IrMercado.Click += new System.EventHandler(this.bt_IrMercado_Click);
            // 
            // bt_AdminGranja
            // 
            this.bt_AdminGranja.Location = new System.Drawing.Point(42, 138);
            this.bt_AdminGranja.Name = "bt_AdminGranja";
            this.bt_AdminGranja.Size = new System.Drawing.Size(168, 46);
            this.bt_AdminGranja.TabIndex = 1;
            this.bt_AdminGranja.Text = "Administrar Granja";
            this.bt_AdminGranja.UseVisualStyleBackColor = true;
            this.bt_AdminGranja.Click += new System.EventHandler(this.bt_AdminGranja_Click);
            // 
            // lb_selectopt_MO
            // 
            this.lb_selectopt_MO.AutoSize = true;
            this.lb_selectopt_MO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_selectopt_MO.Location = new System.Drawing.Point(37, 69);
            this.lb_selectopt_MO.Name = "lb_selectopt_MO";
            this.lb_selectopt_MO.Size = new System.Drawing.Size(216, 25);
            this.lb_selectopt_MO.TabIndex = 0;
            this.lb_selectopt_MO.Text = "Selecciona una opción:";
            // 
            // AdminGranja
            // 
            this.AdminGranja.Controls.Add(this.bt_back_AdminGranja);
            this.AdminGranja.Controls.Add(this.bt_AdminAlmac);
            this.AdminGranja.Controls.Add(this.bt_AdminProd);
            this.AdminGranja.Controls.Add(this.lb_selectopt_AG);
            this.AdminGranja.Location = new System.Drawing.Point(0, 0);
            this.AdminGranja.Name = "AdminGranja";
            this.AdminGranja.Size = new System.Drawing.Size(283, 418);
            this.AdminGranja.TabIndex = 2;
            // 
            // lb_selectopt_AG
            // 
            this.lb_selectopt_AG.AutoSize = true;
            this.lb_selectopt_AG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_selectopt_AG.Location = new System.Drawing.Point(47, 69);
            this.lb_selectopt_AG.Name = "lb_selectopt_AG";
            this.lb_selectopt_AG.Size = new System.Drawing.Size(216, 25);
            this.lb_selectopt_AG.TabIndex = 0;
            this.lb_selectopt_AG.Text = "Selecciona una opción:";
            // 
            // bt_AdminProd
            // 
            this.bt_AdminProd.Location = new System.Drawing.Point(52, 138);
            this.bt_AdminProd.Name = "bt_AdminProd";
            this.bt_AdminProd.Size = new System.Drawing.Size(131, 43);
            this.bt_AdminProd.TabIndex = 1;
            this.bt_AdminProd.Text = "Administrar Producción";
            this.bt_AdminProd.UseVisualStyleBackColor = true;
            this.bt_AdminProd.Click += new System.EventHandler(this.bt_AdminProd_Click);
            // 
            // bt_AdminAlmac
            // 
            this.bt_AdminAlmac.Location = new System.Drawing.Point(52, 199);
            this.bt_AdminAlmac.Name = "bt_AdminAlmac";
            this.bt_AdminAlmac.Size = new System.Drawing.Size(131, 43);
            this.bt_AdminAlmac.TabIndex = 2;
            this.bt_AdminAlmac.Text = "Administrar Almacentamiento";
            this.bt_AdminAlmac.UseVisualStyleBackColor = true;
            this.bt_AdminAlmac.Click += new System.EventHandler(this.bt_AdminAlmac_Click);
            // 
            // AdminProd
            // 
            this.AdminProd.Controls.Add(this.bt_back_AdminProd);
            this.AdminProd.Controls.Add(this.bt_ObtainFinished);
            this.AdminProd.Controls.Add(this.bt_ApplyHeal);
            this.AdminProd.Controls.Add(this.bt_AddWorF);
            this.AdminProd.Controls.Add(this.lb_selectopt_AP);
            this.AdminProd.Location = new System.Drawing.Point(0, 0);
            this.AdminProd.Name = "AdminProd";
            this.AdminProd.Size = new System.Drawing.Size(283, 418);
            this.AdminProd.TabIndex = 2;
            // 
            // lb_selectopt_AP
            // 
            this.lb_selectopt_AP.AutoSize = true;
            this.lb_selectopt_AP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_selectopt_AP.Location = new System.Drawing.Point(12, 69);
            this.lb_selectopt_AP.Name = "lb_selectopt_AP";
            this.lb_selectopt_AP.Size = new System.Drawing.Size(216, 25);
            this.lb_selectopt_AP.TabIndex = 0;
            this.lb_selectopt_AP.Text = "Selecciona una opción:";
            // 
            // bt_AddWorF
            // 
            this.bt_AddWorF.Location = new System.Drawing.Point(42, 138);
            this.bt_AddWorF.Name = "bt_AddWorF";
            this.bt_AddWorF.Size = new System.Drawing.Size(141, 46);
            this.bt_AddWorF.TabIndex = 1;
            this.bt_AddWorF.Text = "Agregar Agua o Comida";
            this.bt_AddWorF.UseVisualStyleBackColor = true;
            // 
            // bt_ApplyHeal
            // 
            this.bt_ApplyHeal.Location = new System.Drawing.Point(42, 206);
            this.bt_ApplyHeal.Name = "bt_ApplyHeal";
            this.bt_ApplyHeal.Size = new System.Drawing.Size(141, 46);
            this.bt_ApplyHeal.TabIndex = 2;
            this.bt_ApplyHeal.Text = "Aplicar Cura";
            this.bt_ApplyHeal.UseVisualStyleBackColor = true;
            // 
            // bt_ObtainFinished
            // 
            this.bt_ObtainFinished.Location = new System.Drawing.Point(42, 281);
            this.bt_ObtainFinished.Name = "bt_ObtainFinished";
            this.bt_ObtainFinished.Size = new System.Drawing.Size(141, 46);
            this.bt_ObtainFinished.TabIndex = 3;
            this.bt_ObtainFinished.Text = "Obtener Producto Terminado";
            this.bt_ObtainFinished.UseVisualStyleBackColor = true;
            // 
            // Market
            // 
            this.Market.Controls.Add(this.bt_back_Market);
            this.Market.Controls.Add(this.bt_SeedRecords);
            this.Market.Controls.Add(this.bt_PropertyMarket);
            this.Market.Controls.Add(this.bt_ConsumableMarket);
            this.Market.Controls.Add(this.bt_BuildingMarket);
            this.Market.Controls.Add(this.lb_selectopt_MK);
            this.Market.Location = new System.Drawing.Point(0, 0);
            this.Market.Name = "Market";
            this.Market.Size = new System.Drawing.Size(284, 418);
            this.Market.TabIndex = 2;
            // 
            // lb_selectopt_MK
            // 
            this.lb_selectopt_MK.AutoSize = true;
            this.lb_selectopt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_selectopt_MK.Location = new System.Drawing.Point(22, 52);
            this.lb_selectopt_MK.Name = "lb_selectopt_MK";
            this.lb_selectopt_MK.Size = new System.Drawing.Size(216, 25);
            this.lb_selectopt_MK.TabIndex = 0;
            this.lb_selectopt_MK.Text = "Selecciona una opción:";
            // 
            // bt_BuildingMarket
            // 
            this.bt_BuildingMarket.Location = new System.Drawing.Point(27, 123);
            this.bt_BuildingMarket.Name = "bt_BuildingMarket";
            this.bt_BuildingMarket.Size = new System.Drawing.Size(146, 42);
            this.bt_BuildingMarket.TabIndex = 1;
            this.bt_BuildingMarket.Text = "Mercado de Edificaciones";
            this.bt_BuildingMarket.UseVisualStyleBackColor = true;
            this.bt_BuildingMarket.Click += new System.EventHandler(this.bt_BuildingMarket_Click);
            // 
            // bt_ConsumableMarket
            // 
            this.bt_ConsumableMarket.Location = new System.Drawing.Point(27, 181);
            this.bt_ConsumableMarket.Name = "bt_ConsumableMarket";
            this.bt_ConsumableMarket.Size = new System.Drawing.Size(146, 42);
            this.bt_ConsumableMarket.TabIndex = 2;
            this.bt_ConsumableMarket.Text = "Mercado de Consumibles";
            this.bt_ConsumableMarket.UseVisualStyleBackColor = true;
            // 
            // bt_PropertyMarket
            // 
            this.bt_PropertyMarket.Location = new System.Drawing.Point(27, 241);
            this.bt_PropertyMarket.Name = "bt_PropertyMarket";
            this.bt_PropertyMarket.Size = new System.Drawing.Size(146, 42);
            this.bt_PropertyMarket.TabIndex = 3;
            this.bt_PropertyMarket.Text = "Mercado de Propiedades";
            this.bt_PropertyMarket.UseVisualStyleBackColor = true;
            // 
            // bt_SeedRecords
            // 
            this.bt_SeedRecords.Location = new System.Drawing.Point(27, 300);
            this.bt_SeedRecords.Name = "bt_SeedRecords";
            this.bt_SeedRecords.Size = new System.Drawing.Size(146, 65);
            this.bt_SeedRecords.TabIndex = 4;
            this.bt_SeedRecords.Text = "Revisar precios históricos por Semilla";
            this.bt_SeedRecords.UseVisualStyleBackColor = true;
            // 
            // BuildingMarket
            // 
            this.BuildingMarket.Controls.Add(this.bt_back_BuildingMarket);
            this.BuildingMarket.Controls.Add(this.bt_SellDestroyBuilding);
            this.BuildingMarket.Controls.Add(this.bt_BuyStorage);
            this.BuildingMarket.Controls.Add(this.bt_BuyCattle);
            this.BuildingMarket.Controls.Add(this.bt_BuyField);
            this.BuildingMarket.Controls.Add(this.lb_selectopt_BMK);
            this.BuildingMarket.Location = new System.Drawing.Point(0, 0);
            this.BuildingMarket.Name = "BuildingMarket";
            this.BuildingMarket.Size = new System.Drawing.Size(283, 418);
            this.BuildingMarket.TabIndex = 2;
            // 
            // lb_selectopt_BMK
            // 
            this.lb_selectopt_BMK.AutoSize = true;
            this.lb_selectopt_BMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_selectopt_BMK.Location = new System.Drawing.Point(12, 52);
            this.lb_selectopt_BMK.Name = "lb_selectopt_BMK";
            this.lb_selectopt_BMK.Size = new System.Drawing.Size(216, 25);
            this.lb_selectopt_BMK.TabIndex = 0;
            this.lb_selectopt_BMK.Text = "Seleccione una opción:";
            // 
            // bt_BuyField
            // 
            this.bt_BuyField.Location = new System.Drawing.Point(27, 109);
            this.bt_BuyField.Name = "bt_BuyField";
            this.bt_BuyField.Size = new System.Drawing.Size(146, 45);
            this.bt_BuyField.TabIndex = 1;
            this.bt_BuyField.Text = "Comprar Plantación";
            this.bt_BuyField.UseVisualStyleBackColor = true;
            // 
            // bt_BuyCattle
            // 
            this.bt_BuyCattle.Location = new System.Drawing.Point(27, 171);
            this.bt_BuyCattle.Name = "bt_BuyCattle";
            this.bt_BuyCattle.Size = new System.Drawing.Size(146, 45);
            this.bt_BuyCattle.TabIndex = 2;
            this.bt_BuyCattle.Text = "Comprar Ganado";
            this.bt_BuyCattle.UseVisualStyleBackColor = true;
            // 
            // bt_BuyStorage
            // 
            this.bt_BuyStorage.Location = new System.Drawing.Point(27, 238);
            this.bt_BuyStorage.Name = "bt_BuyStorage";
            this.bt_BuyStorage.Size = new System.Drawing.Size(146, 45);
            this.bt_BuyStorage.TabIndex = 3;
            this.bt_BuyStorage.Text = "Comprar Almacenamiento";
            this.bt_BuyStorage.UseVisualStyleBackColor = true;
            // 
            // bt_SellDestroyBuilding
            // 
            this.bt_SellDestroyBuilding.Location = new System.Drawing.Point(27, 300);
            this.bt_SellDestroyBuilding.Name = "bt_SellDestroyBuilding";
            this.bt_SellDestroyBuilding.Size = new System.Drawing.Size(146, 45);
            this.bt_SellDestroyBuilding.TabIndex = 4;
            this.bt_SellDestroyBuilding.Text = "Vender/Destruir Edificio";
            this.bt_SellDestroyBuilding.UseVisualStyleBackColor = true;
            // 
            // bt_back_AdminGranja
            // 
            this.bt_back_AdminGranja.Location = new System.Drawing.Point(0, 0);
            this.bt_back_AdminGranja.Name = "bt_back_AdminGranja";
            this.bt_back_AdminGranja.Size = new System.Drawing.Size(64, 29);
            this.bt_back_AdminGranja.TabIndex = 3;
            this.bt_back_AdminGranja.Text = "back";
            this.bt_back_AdminGranja.UseVisualStyleBackColor = true;
            this.bt_back_AdminGranja.Click += new System.EventHandler(this.bt_back_AdminGranja_Click);
            // 
            // bt_back_AdminProd
            // 
            this.bt_back_AdminProd.Location = new System.Drawing.Point(0, 0);
            this.bt_back_AdminProd.Name = "bt_back_AdminProd";
            this.bt_back_AdminProd.Size = new System.Drawing.Size(64, 29);
            this.bt_back_AdminProd.TabIndex = 4;
            this.bt_back_AdminProd.Text = "back";
            this.bt_back_AdminProd.UseVisualStyleBackColor = true;
            this.bt_back_AdminProd.Click += new System.EventHandler(this.bt_back_AdminProd_Click);
            // 
            // bt_back_BuildingMarket
            // 
            this.bt_back_BuildingMarket.Location = new System.Drawing.Point(0, 0);
            this.bt_back_BuildingMarket.Name = "bt_back_BuildingMarket";
            this.bt_back_BuildingMarket.Size = new System.Drawing.Size(64, 29);
            this.bt_back_BuildingMarket.TabIndex = 5;
            this.bt_back_BuildingMarket.Text = "back";
            this.bt_back_BuildingMarket.UseVisualStyleBackColor = true;
            this.bt_back_BuildingMarket.Click += new System.EventHandler(this.bt_back_BuildingMarket_Click);
            // 
            // bt_back_Market
            // 
            this.bt_back_Market.Location = new System.Drawing.Point(0, 0);
            this.bt_back_Market.Name = "bt_back_Market";
            this.bt_back_Market.Size = new System.Drawing.Size(64, 29);
            this.bt_back_Market.TabIndex = 5;
            this.bt_back_Market.Text = "back";
            this.bt_back_Market.UseVisualStyleBackColor = true;
            this.bt_back_Market.Click += new System.EventHandler(this.bt_back_Market_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 418);
            this.Controls.Add(this.MainOptions);
            this.Controls.Add(this.AdminProd);
            this.Controls.Add(this.BuildingMarket);
            this.Controls.Add(this.Market);
            this.Controls.Add(this.AdminGranja);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.NewGame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.NewGame.ResumeLayout(false);
            this.NewGame.PerformLayout();
            this.Game.ResumeLayout(false);
            this.GameMap.ResumeLayout(false);
            this.GameMap.PerformLayout();
            this.MainOptions.ResumeLayout(false);
            this.MainOptions.PerformLayout();
            this.AdminGranja.ResumeLayout(false);
            this.AdminGranja.PerformLayout();
            this.AdminProd.ResumeLayout(false);
            this.AdminProd.PerformLayout();
            this.Market.ResumeLayout(false);
            this.Market.PerformLayout();
            this.BuildingMarket.ResumeLayout(false);
            this.BuildingMarket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Button TitleNewGameButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel NewGame;
        private System.Windows.Forms.Label NewGamePanelLabel;
        private System.Windows.Forms.Button NewGameDefaultButton;
        private System.Windows.Forms.Button NewGameBothButton;
        private System.Windows.Forms.Button NewGameLakeButton;
        private System.Windows.Forms.Button NewGameRiverButton;
        private System.Windows.Forms.Button NewGameBackButton;
        private System.Windows.Forms.Panel Game;
        private System.Windows.Forms.Panel GameMap;
        private System.Windows.Forms.Label MapLabel;
        private System.Windows.Forms.Panel MainOptions;
        private System.Windows.Forms.Button bt_GrabarPartida;
        private System.Windows.Forms.Button bt_PassTurn;
        private System.Windows.Forms.Button bt_IrMercado;
        private System.Windows.Forms.Button bt_AdminGranja;
        private System.Windows.Forms.Label lb_selectopt_MO;
        private System.Windows.Forms.Panel AdminGranja;
        private System.Windows.Forms.Button bt_AdminAlmac;
        private System.Windows.Forms.Button bt_AdminProd;
        private System.Windows.Forms.Label lb_selectopt_AG;
        private System.Windows.Forms.Panel AdminProd;
        private System.Windows.Forms.Button bt_ObtainFinished;
        private System.Windows.Forms.Button bt_ApplyHeal;
        private System.Windows.Forms.Button bt_AddWorF;
        private System.Windows.Forms.Label lb_selectopt_AP;
        private System.Windows.Forms.Panel Market;
        private System.Windows.Forms.Button bt_SeedRecords;
        private System.Windows.Forms.Button bt_PropertyMarket;
        private System.Windows.Forms.Button bt_ConsumableMarket;
        private System.Windows.Forms.Button bt_BuildingMarket;
        private System.Windows.Forms.Label lb_selectopt_MK;
        private System.Windows.Forms.Panel BuildingMarket;
        private System.Windows.Forms.Button bt_BuyStorage;
        private System.Windows.Forms.Button bt_BuyCattle;
        private System.Windows.Forms.Button bt_BuyField;
        private System.Windows.Forms.Label lb_selectopt_BMK;
        private System.Windows.Forms.Button bt_SellDestroyBuilding;
        private System.Windows.Forms.Button bt_back_AdminGranja;
        private System.Windows.Forms.Button bt_back_AdminProd;
        private System.Windows.Forms.Button bt_back_Market;
        private System.Windows.Forms.Button bt_back_BuildingMarket;
    }
}

