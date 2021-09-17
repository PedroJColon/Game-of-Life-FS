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
        public CustomizeUniverse()
        {
            InitializeComponent();
        }

        public int millSeconds
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
        public int universeHeight
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
        public int universeWidth
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
    }
}
