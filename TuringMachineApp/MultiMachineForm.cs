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
    public partial class MultiMachineForm : Form
    {
        private readonly Form1 _parent;

        public MultiMachineForm(Form1 parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            List<string> machines = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                machines.Add(dataGridView1[0, i].Value.ToString());
            }

            foreach (string machine in machines)
            {
                _parent.LoadFromFile(machine);
            }
        }
    }
}
