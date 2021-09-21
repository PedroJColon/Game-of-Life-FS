using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class RandomizeUniverse : Form
    {
        public int SeedNum
        {
            get
            {
                return (int)SeedValue.Value;
            }
            set
            {
                SeedValue.Value = value;
            }
        }
        
        public RandomizeUniverse()
        {
            InitializeComponent();
            SeedValue.Value = Properties.Settings.Default.SeedRandomValue;
        }

        private void RandomizeUniverse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.SeedRandomValue = SeedNum;
        }
    }
}
