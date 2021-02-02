using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHeroRace.RaceModule
{
    public abstract class Punter
    {
        public int Cash;

        public bool Busted;

        public Bet MyBet;

        public Label MyLabel;

        public RadioButton MyRadioButton;

        public string Name;

        public bool Winner;

        public Label MyText;
    }
}
