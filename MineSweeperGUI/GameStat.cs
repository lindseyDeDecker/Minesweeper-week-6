using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperGUI
{
    //creating a class of game stats to be able to store and then display game stats within another class.
    public class GameStat
    {
        public int score { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public double duration { get; set; }
        //initializeing the properties of a game stat
        public GameStat()
        {
            score = 0;
            id = 0;
            name = "";
            date = DateTime.Now;
            duration = 0;
        }
    }
}
