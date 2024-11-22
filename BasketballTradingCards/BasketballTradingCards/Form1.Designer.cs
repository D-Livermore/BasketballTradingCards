namespace BasketballTradingCards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPlayers = new ListBox();
            labelPlayerName = new Label();
            labelPlayerTeam = new Label();
            labelPlayerStats = new Label();
            pictureBoxPlayerPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerPhoto).BeginInit();
            SuspendLayout();
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.Location = new Point(56, 89);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(211, 484);
            listBoxPlayers.TabIndex = 0;
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Location = new Point(403, 33);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(0, 20);
            labelPlayerName.TabIndex = 1;
            // 
            // labelPlayerTeam
            // 
            labelPlayerTeam.AutoSize = true;
            labelPlayerTeam.Location = new Point(403, 66);
            labelPlayerTeam.Name = "labelPlayerTeam";
            labelPlayerTeam.Size = new Size(0, 20);
            labelPlayerTeam.TabIndex = 2;
            // 
            // labelPlayerStats
            // 
            labelPlayerStats.AutoSize = true;
            labelPlayerStats.Location = new Point(482, 576);
            labelPlayerStats.Name = "labelPlayerStats";
            labelPlayerStats.Size = new Size(0, 20);
            labelPlayerStats.TabIndex = 3;
            // 
            // pictureBoxPlayerPhoto
            // 
            pictureBoxPlayerPhoto.Location = new Point(330, 89);
            pictureBoxPlayerPhoto.Name = "pictureBoxPlayerPhoto";
            pictureBoxPlayerPhoto.Size = new Size(374, 484);
            pictureBoxPlayerPhoto.TabIndex = 4;
            pictureBoxPlayerPhoto.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 773);
            Controls.Add(pictureBoxPlayerPhoto);
            Controls.Add(labelPlayerStats);
            Controls.Add(labelPlayerTeam);
            Controls.Add(labelPlayerName);
            Controls.Add(listBoxPlayers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPlayers;


        private Label labelPlayerName;
        private Label labelPlayerTeam;
        private Label labelPlayerStats;
        private PictureBox pictureBoxPlayerPhoto;
    }
}
