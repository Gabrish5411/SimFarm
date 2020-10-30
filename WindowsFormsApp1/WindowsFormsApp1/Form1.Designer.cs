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
            this.Title.SuspendLayout();
            this.NewGame.SuspendLayout();
            this.Game.SuspendLayout();
            this.GameMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Controls.Add(this.TitleNewGameButton);
            this.Title.Controls.Add(this.TitleLabel);
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(482, 340);
            this.Title.TabIndex = 0;
            // 
            // TitleNewGameButton
            // 
            this.TitleNewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TitleNewGameButton.Location = new System.Drawing.Point(204, 154);
            this.TitleNewGameButton.Name = "TitleNewGameButton";
            this.TitleNewGameButton.Size = new System.Drawing.Size(97, 27);
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
            this.TitleLabel.Location = new System.Drawing.Point(199, 80);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(102, 26);
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
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(482, 340);
            this.NewGame.TabIndex = 2;
            // 
            // NewGameDefaultButton
            // 
            this.NewGameDefaultButton.Location = new System.Drawing.Point(192, 112);
            this.NewGameDefaultButton.Name = "NewGameDefaultButton";
            this.NewGameDefaultButton.Size = new System.Drawing.Size(98, 22);
            this.NewGameDefaultButton.TabIndex = 1;
            this.NewGameDefaultButton.Text = "Default";
            this.NewGameDefaultButton.UseVisualStyleBackColor = true;
            this.NewGameDefaultButton.Click += new System.EventHandler(this.NewGameDefaultButton_Click);
            // 
            // NewGameBothButton
            // 
            this.NewGameBothButton.Location = new System.Drawing.Point(192, 244);
            this.NewGameBothButton.Name = "NewGameBothButton";
            this.NewGameBothButton.Size = new System.Drawing.Size(98, 22);
            this.NewGameBothButton.TabIndex = 4;
            this.NewGameBothButton.Text = "River and Lake";
            this.NewGameBothButton.UseVisualStyleBackColor = true;
            this.NewGameBothButton.Click += new System.EventHandler(this.NewGameBothButton_Click);
            // 
            // NewGameLakeButton
            // 
            this.NewGameLakeButton.Location = new System.Drawing.Point(192, 202);
            this.NewGameLakeButton.Name = "NewGameLakeButton";
            this.NewGameLakeButton.Size = new System.Drawing.Size(98, 22);
            this.NewGameLakeButton.TabIndex = 3;
            this.NewGameLakeButton.Text = "Lake";
            this.NewGameLakeButton.UseVisualStyleBackColor = true;
            this.NewGameLakeButton.Click += new System.EventHandler(this.NewGameLakeButton_Click);
            // 
            // NewGameRiverButton
            // 
            this.NewGameRiverButton.Location = new System.Drawing.Point(192, 159);
            this.NewGameRiverButton.Name = "NewGameRiverButton";
            this.NewGameRiverButton.Size = new System.Drawing.Size(98, 22);
            this.NewGameRiverButton.TabIndex = 2;
            this.NewGameRiverButton.Text = "River";
            this.NewGameRiverButton.UseVisualStyleBackColor = true;
            this.NewGameRiverButton.Click += new System.EventHandler(this.NewGameRiverButton_Click);
            // 
            // NewGameBackButton
            // 
            this.NewGameBackButton.Location = new System.Drawing.Point(3, 3);
            this.NewGameBackButton.Name = "NewGameBackButton";
            this.NewGameBackButton.Size = new System.Drawing.Size(59, 20);
            this.NewGameBackButton.TabIndex = 5;
            this.NewGameBackButton.Text = "Back";
            this.NewGameBackButton.UseVisualStyleBackColor = true;
            this.NewGameBackButton.Click += new System.EventHandler(this.NewGameBackButton_Click);
            // 
            // NewGamePanelLabel
            // 
            this.NewGamePanelLabel.AutoSize = true;
            this.NewGamePanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewGamePanelLabel.Location = new System.Drawing.Point(147, 56);
            this.NewGamePanelLabel.Name = "NewGamePanelLabel";
            this.NewGamePanelLabel.Size = new System.Drawing.Size(184, 24);
            this.NewGamePanelLabel.TabIndex = 0;
            this.NewGamePanelLabel.Text = "Select a type of map:";
            // 
            // Game
            // 
            this.Game.Controls.Add(this.GameMap);
            this.Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game.Location = new System.Drawing.Point(0, 0);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(482, 340);
            this.Game.TabIndex = 3;
            // 
            // GameMap
            // 
            this.GameMap.Controls.Add(this.MapLabel);
            this.GameMap.Location = new System.Drawing.Point(0, 0);
            this.GameMap.Name = "GameMap";
            this.GameMap.Size = new System.Drawing.Size(342, 340);
            this.GameMap.TabIndex = 0;
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MapLabel.Location = new System.Drawing.Point(37, 26);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(46, 17);
            this.MapLabel.TabIndex = 0;
            this.MapLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 340);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            this.NewGame.ResumeLayout(false);
            this.NewGame.PerformLayout();
            this.Game.ResumeLayout(false);
            this.GameMap.ResumeLayout(false);
            this.GameMap.PerformLayout();
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
    }
}

