using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Resolvers;

namespace WindowsFormsPracticeAssignment
{
    
    public partial class Form1 : Form

    {
        List<BaseballPlayer> baseballplayers = new List<BaseballPlayer>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string team = tbTeam.Text;
            string city = tbCity.Text;
            int average = int.Parse(tbAverage.Text);
            string position = tbPosition.Text;

            BaseballPlayer player = new BaseballPlayer(name, team, city, average, position);
            baseballplayers.Add(player);
            DisplayPlayer(baseballplayers);
        }
        public void DisplayPlayer(List<BaseballPlayer> baseballplayers)
        {
            rtbDisplay.Text = "";
            
            foreach (BaseballPlayer player in baseballplayers)
            {
                string displayMessage = $"Player Name: {player.Name}" + $"\nTeam: {player.Team}" + $"\nCity: {player.City}" + $"\nAverage: {player.Average}" + $"\nPosition: {player.Position}";

                rtbDisplay.Text += displayMessage;
            }
        }

        //How to use int, and what does two buttons mean
    }
}
