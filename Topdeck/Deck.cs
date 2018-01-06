using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topdeck {
    class Deck {
        int deckSize = 0;
        Card[] deck;

        int Wins { get; set; }
        int Losses { get; set; }
        public double Winrate { get { return (double)Wins / Losses; } private set { } }

        public Deck(int deckSize) {
            this.deckSize = deckSize;
            deck = new Card[deckSize];
        }
    }
}
