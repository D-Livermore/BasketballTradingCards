using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasketballTradingCards
{
    public partial class Form1 : Form
    {
        public List<Player> Players { get; set; }

        public Form1()
        {
            InitializeComponent();

            Players = new List<Player>
            {
                new Player { Name = "LeBron James", Team = "Los Angeles Lakers", PhotoPath = "Images/LeBron.jpg", PointsPerGame = 27, AssistsPerGame = 7, ReboundsPerGame = 8, FieldGoalPercentage = 50.4, FreeThrowPercentage = 73.4 },
                new Player { Name = "Stephen Curry", Team = "Golden State Warriors", PhotoPath = "Images/Curry.jpg", PointsPerGame = 30, AssistsPerGame = 6, ReboundsPerGame = 5, FieldGoalPercentage = 47.7, FreeThrowPercentage = 91.6 },
                new Player { Name = "Giannis Antetokounmpo", Team = "Milwaukee Bucks", PhotoPath = "Images/Giannis.jpg", PointsPerGame = 29, AssistsPerGame = 5, ReboundsPerGame = 12, FieldGoalPercentage = 57.8, FreeThrowPercentage = 68.3 },
                new Player { Name = "Kevin Durant", Team = "Phoenix Suns", PhotoPath = "Images/Kevin.jpg", PointsPerGame = 26.5, AssistsPerGame = 5.5, ReboundsPerGame = 7, FieldGoalPercentage = 53.7, FreeThrowPercentage = 88.3 },
                new Player { Name = "Luka Doncic", Team = "Dallas Mavericks", PhotoPath = "Images/Luka.jpg", PointsPerGame = 34.3, AssistsPerGame = 8.1, ReboundsPerGame = 8.9, FieldGoalPercentage = 49.3, FreeThrowPercentage = 75.0 },
                new Player { Name = "Joel Embiid", Team = "Philadelphia 76ers", PhotoPath = "Images/Joel.jpg", PointsPerGame = 33.0, AssistsPerGame = 4.2, ReboundsPerGame = 10.2, FieldGoalPercentage = 54.7, FreeThrowPercentage = 85.0 },
                new Player { Name = "Kawhi Leonard", Team = "Los Angeles Clippers", PhotoPath = "Images/Kawhi.jpg", PointsPerGame = 26.0, AssistsPerGame = 5.0, ReboundsPerGame = 7.0, FieldGoalPercentage = 49.2, FreeThrowPercentage = 87.0 },
                new Player { Name = "Nikola Jokic", Team = "Denver Nuggets", PhotoPath = "Images/Nikola.jpg", PointsPerGame = 24.8, AssistsPerGame = 10.0, ReboundsPerGame = 11.6, FieldGoalPercentage = 58.3, FreeThrowPercentage = 83.0 },
                new Player { Name = "Jimmy Butler", Team = "Miami Heat", PhotoPath = "Images/Jimmy.jpg", PointsPerGame = 22.8, AssistsPerGame = 5.1, ReboundsPerGame = 5.9, FieldGoalPercentage = 47.0, FreeThrowPercentage = 87.5 },
                new Player { Name = "Trae Young", Team = "Atlanta Hawks", PhotoPath = "Images/Trae.jpg", PointsPerGame = 27.2, AssistsPerGame = 9.1, ReboundsPerGame = 3.9, FieldGoalPercentage = 43.7, FreeThrowPercentage = 88.1 }
            };

            PopulatePlayersList();

            listBoxPlayers.DataSource = Players;
            listBoxPlayers.DisplayMember = "Name";

            listBoxPlayers.SelectedIndexChanged += ListBoxPlayers_SelectedIndexChanged;
            pictureBoxPlayerPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ListBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex >= 0)
            {
                Player selectedPlayer = listBoxPlayers.SelectedItem as Player;

                if (selectedPlayer != null)
                {
                    // Display the player's photo 
                    pictureBoxPlayerPhoto.ImageLocation = selectedPlayer.PhotoPath;

                    // Display the player's name and team 
                    labelPlayerName.Text = $"Name: {selectedPlayer.Name}";
                    labelPlayerTeam.Text = $"Team: {selectedPlayer.Team}";

                    // Display the player's stats 
                    labelPlayerStats.Text = $"PPG: {selectedPlayer.PointsPerGame}\n" +
                                            $"APG: {selectedPlayer.AssistsPerGame}\n" +
                                            $"RPG: {selectedPlayer.ReboundsPerGame}\n" +
                                            $"FG%: {selectedPlayer.FieldGoalPercentage}%\n" +
                                            $"FT%: {selectedPlayer.FreeThrowPercentage}%";
                }
            }
        }

        private void PopulatePlayersList()
        {
                foreach (var player in Players)
            {
                listBoxPlayers.Items.Add(player.Name);
            }
        }

        
        public class Player
        {
            public string Name { get; set; }
            public string Team { get; set; }
            public string PhotoPath { get; set; } 
            public double PointsPerGame { get; set; }
            public double AssistsPerGame { get; set; }
            public double ReboundsPerGame { get; set; }
            public double FieldGoalPercentage { get; set; }
            public double FreeThrowPercentage { get; set; }
        }
    }
}
