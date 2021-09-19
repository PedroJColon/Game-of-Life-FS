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
    public partial class CustomizeUniverse : Form
    {

        public int MillSeconds
        {
            get
            {
                return (int)MillSecondTime.Value;
            }
            set
            {
                MillSecondTime.Value = value;
            }
        }
        public int UniverseHeight
        {
            get
            {
                return (int)HeightUniverse.Value;
            }
            set
            {
                HeightUniverse.Value = value;
            }
        }
        public int UniverseWidth
        {
            get
            {
                return (int)WidthUniverse.Value;
            }
            set
            {
                WidthUniverse.Value = value;
            }
        }

        public CustomizeUniverse()
        {
            InitializeComponent();

            HeightUniverse.Value = Properties.Settings.Default.UniverseHeight;
            WidthUniverse.Value = Properties.Settings.Default.UniverseWidth;
            MillSecondTime.Value = Properties.Settings.Default.TimeInterval;
        }

        private void CustomizeUniverse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.UniverseHeight = UniverseHeight;
            Properties.Settings.Default.UniverseWidth = UniverseWidth;
            Properties.Settings.Default.TimeInterval = MillSeconds;
        }
    }
}
