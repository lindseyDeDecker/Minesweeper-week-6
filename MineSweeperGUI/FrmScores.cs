using Microsoft.VisualBasic.ApplicationServices;
using MineSweeperGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace MineSweeperGUI
{
    public partial class FrmScores : Form
    {
        GameStat gameStat;
        BindingSource bindingSource = new BindingSource();
        public static List<GameStat> statList = new List<GameStat>();

        //setting all the properties of this new instance of a game stat and then adding it to the list.
        public FrmScores(string name, int score, double duration)
        {
            InitializeComponent();
            gameStat = new GameStat();
            gameStat.name = name;
            gameStat.score = score;
            gameStat.date = DateTime.Now;
            gameStat.id = statList.Count + 1;
            gameStat.duration = duration;
            statList.Add(gameStat);
        }

        private void FrmScores_Load(object sender, EventArgs e)
        {

            

            bindingSource.DataSource = statList;
            dgvScores.DataSource = bindingSource;

            using (StreamReader reader = new StreamReader("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\scores.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) !=null)
                {
                    var values = line.Split("|");
                    var stat = new GameStat()
                    {
                        id = int.Parse(values[0]),
                        name = values[1],
                        score = int.Parse(values[2]),
                        date = DateTime.Parse(values[3]),
                        duration = double.Parse(values[4])
                    };
                    statList.Add(stat);

                    //checking to see if that stat already exists before adding it
                    if(!statList.Any(existingStat => existingStat.id == stat.id))
                    {
                        statList.Add(stat);
                    }
                }
            }
            SortByScore();
            SettingAveragePoints();
            SettingAverageTime();
        }
        //updating the file to include any new instance of game stat
        private void UpdateFile()
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\kydec\\Desktop\\Lindsey School\\CST - 250\\Week 1\\Milestone 1\\MineSweeperGUI\\scores.txt"))
            {
                foreach (var stat in statList)
                {
                    string line = $"{stat.id}|{stat.name}|{stat.score}|{stat.date}|{stat.duration}";
                    writer.WriteLine(line);
                }
            }
            SettingAveragePoints();
            SettingAverageTime();

        }
        //sorting the loaded game stats alphabetically by first name
        private void SortByName()
        {
            statList = statList.OrderBy(stat => stat.name).ToList();
            bindingSource.DataSource = statList;
        }
        //save click that then calls updatefile to update the file with any new data
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFile();
        }
        
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortByName();
        }
        //closed out the gamestat data form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvScores.DataSource = null;
            this.Close();
        }
        //button click that sorts the data by first name
        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortByName();
        }
        //Method to sort the data by score
        private void SortByScore()
        {
            statList = statList.OrderByDescending(stat => stat.score).ToList();
            bindingSource.DataSource = statList;
        }
        //button click that sorts the data by score
        private void byScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortByScore();
        }
        //button click that sorts the data by date of game play
        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statList = statList.OrderByDescending(stat => stat.date).ToList();
            bindingSource.DataSource = statList;
        }
        //Sets the average time a player spent on the game according the the displayed list
        private void SettingAverageTime()
        {
           if (statList.Any())
            {
                double averageTime = statList.Average(stat => stat.duration);
                lblAvgTime.Text = $"{averageTime:F2}";
            }
        }
        //sets the average points earned according to the list
        private void SettingAveragePoints()
        {
            if (statList.Any())
            {
                double averagePoints = statList.Average(stat => stat.score);
                lblAvgPoints.Text = $"{averagePoints:F2}";
            }
        }
    }
}

