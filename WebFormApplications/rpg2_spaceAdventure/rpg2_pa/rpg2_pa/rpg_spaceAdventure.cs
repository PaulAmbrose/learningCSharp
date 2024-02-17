using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg2_pa
{
    public partial class rpg_spaceAdventure : Form
    {
        private Player _player1;

        public rpg_spaceAdventure()
        {
            InitializeComponent();
            _player1 = new Player("start", new List<string> { "code1", "code2", "code3" }, 100, 100);
        }
    }
}


