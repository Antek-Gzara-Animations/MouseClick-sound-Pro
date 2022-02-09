using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick_sound_ProVersion
{
    public partial class HelpForm : Form
    {
        public HelpForm(string applicationVesrion)
        {
            InitializeComponent();
            label1.Text = applicationVesrion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
