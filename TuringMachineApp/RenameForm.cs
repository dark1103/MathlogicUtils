using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachineApp
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void RenameForm_Load(object sender, EventArgs e)
        {

        }

        public string From => textBox1.Text;
        public string To => textBox2.Text;
    }
}
