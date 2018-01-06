using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Topdeck {
    class Card {
        String Name { get; set; } = "";
        String Description { get; set; } = "";


        int Wins { get; set; }
        int Losses { get; set; }

        //List of tuples <Wins, Losses> ordered by turn. 
        List<Tuple<int, int>> StatsPerTurn = new List<Tuple<int, int>>(0);

        public double Winrate {
            get { if(Losses > 0)
                    return (double)Wins / Losses;
                else if(Wins > 0)
                    return 100;
                else
                    return 0;
                }
            private set { }
        }


        public void AddLoss(int turn) {
            if(StatsPerTurn.Capacity<turn)
                StatsPerTurn.Capacity = turn;
        }

        public List<double> GetWinratePerTurn() {
            List<double> results = new List<double>(StatsPerTurn.Count);
            for(int i = 0; i < StatsPerTurn.Count; i++) {
                results[i] = (double)StatsPerTurn[i].Item1 / StatsPerTurn[i].Item2;
            }

            return results;
        }
    }
}
