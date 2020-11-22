namespace WindowsFormsApp1
{
    partial class ClickingMapForm
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
            this.MapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MapButton
            // 
            this.MapButton.BackColor = System.Drawing.Color.Transparent;
            this.MapButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapButton.Location = new System.Drawing.Point(0, 0);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(206, 206);
            this.MapButton.TabIndex = 0;
            this.MapButton.UseVisualStyleBackColor = false;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // ClickingMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(206, 206);
            this.Controls.Add(this.MapButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(52, 92);
            this.Name = "ClickingMapForm";
            this.Opacity = 0.01D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClickingMapForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MapButton;
    }
}