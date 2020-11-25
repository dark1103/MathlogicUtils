using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakarovMachine;

namespace MarkovMachineApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool running = false;
        private bool paused = false;
        private bool stopped = false;

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (running)
            {
                paused = false;
                status_lbl.Text = "Running";
                return;
            }

            List<Instruction> instructions = new List<Instruction>();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string row = dataGridView1[0, i].Value?.ToString() ?? "";
                string[] str = row.Split(' ');
                if (str.Length < 2)
                {
                    MessageBox.Show("Bad instruction: " + row, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                instructions.Add(new Instruction(str[0], str[1],str.Length == 3 && str[2] == "*"));
            }
            
            history.Items.Clear();
            status_lbl.Text = "Running";
            paused = false;
            stopped = false;
            running = true;
            new Task(() =>
            {
                Markov markov = new Markov(instructions);
                try
                {
                    markov.Execute(word_textbox.Text, m =>
                    {
                        int delay = 0;

                        this.Invoke(new Action(() =>
                        {
                            word_textbox.Text = m.Word;
                            delay = (int)delay_upDown.Value;
                            history.Items.Insert(0, m.LastInstruction + ": " + m.Word);
                            last_instr_lbl.Text = m.LastInstruction.ToString();

                            if (progressbar.Value == progressbar.Maximum)
                            {
                                progressbar.Value = 0;
                            }
                            else
                            {
                                progressbar.Value += 33;
                            }

                          
                        }));

                        Thread.Sleep(delay);

                        while (paused && !stopped)
                        {
                            Thread.Sleep(delay);
                        }

                        if (stopped)
                        {
                            m.Stop();
                        }
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                this.Invoke(new Action(() =>
                {
                    running = false;
                    status_lbl.Text = "Stopped";
                    progressbar.Value = 0;
                }));
            }).Start();
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                list.Add(dataGridView1[0, i].Value?.ToString() ?? "");
            }
            File.WriteAllLines(file_textbox.Text, list);
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(file_textbox.Text);
                dataGridView1.RowCount = lines.Length + 1;
                for (var i = 0; i < lines.Length; i++)
                {
                    dataGridView1[0, i].Value = lines[i];
                }
            }
            catch(Exception) { }

        }

        private void copyword_btn_Click(object sender, EventArgs e)
        {
            word_textbox.Text = copyword_textbox.Text;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount -1; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            status_lbl.Text = "Paused";
            paused = true;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stopped = true;
        }
    }
}
