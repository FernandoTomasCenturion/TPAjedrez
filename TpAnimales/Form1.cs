using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpAnimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void leon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon();
            MessageBox.Show(leon.ToString());
        }

        private void conejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo();
            MessageBox.Show(conejo.ToString());
        }

        private void loro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro();
            MessageBox.Show(loro.ToString());
        }
    }
}
