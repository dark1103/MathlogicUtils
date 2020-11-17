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
using TuringMachine;

namespace TuringMachineApp
{
    public partial class Form1 : Form
    {
        private Machine<string, string> machine;
        private bool pause = false;
        public Form1()
        {
            InitializeComponent();

            dataGridView_data.MultiSelect = false;

            dataGridView_states.RowCount = 4;
            for (int i = 0; i < dataGridView_states.RowCount - 1; i++)
            {
                dataGridView_states[0, i].Value = "q" + i.ToString();
            }

            dataGridView_data.RowCount = 4;
            for (int i = 0; i < dataGridView_data.RowCount - 1; i++)
            {
                dataGridView_data[0, i].Value = i.ToString();
            }

            textBox_startState.Text = "q0";
            textBox_endState.Text = "q" + (dataGridView_states.RowCount - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> text = MachineToText();
            text[1] = textBox_symbols.Text;
            MachineFromText(text.ToArray());

            // HashSet<string> data_items = new HashSet<string>(textBox_symbols.Text.Split(' '));
            //
            // dataGrid_instuctions.ColumnCount = data_items.Count;
            // dataGrid_instuctions.RowCount = dataGridView_states.RowCount - 1;

            // var data_items_array = data_items.OrderBy(x => x).ToArray();
            //
            // for (int i = 0; i < data_items_array.Length; i++)
            // {
            //     dataGrid_instuctions.Columns[i].HeaderCell.Value = data_items_array[i];
            //     dataGrid_instuctions.Columns[i].Name = data_items_array[i];
            // }
            //
            // for (int i = 0; i < dataGridView_states.RowCount - 1; i++)
            // {
            //     dataGrid_instuctions.Rows[i].HeaderCell.Value = dataGridView_states[0, i].Value.ToString();
            // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, Instruction<string, string>>> instr = new Dictionary<string, Dictionary<string, Instruction<string, string>>>();

            HashSet<string> symbols = new HashSet<string>(textBox_symbols.Text.Split(' '));



            for (int i = 0; i < dataGrid_instuctions.RowCount; i++)
            {
                var state = dataGrid_instuctions.Rows[i].HeaderCell.Value.ToString();
                instr.Add(state, new Dictionary<string, Instruction<string, string>>());
                for (int j = 0; j < dataGrid_instuctions.ColumnCount; j++)
                {
                    var val = dataGrid_instuctions.Columns[j].HeaderCell.Value.ToString();

                    var cellStr = dataGrid_instuctions[j, i].Value;

                    Instruction<string, string> ins = new Instruction<string, string>();

                    if (cellStr != null)
                    {
                        string[] strings = cellStr.ToString().Split(' ');

                        foreach (string s in strings)
                        {
                            if (s == "L")
                            {
                                ins.ReaderStep = -1;
                            }
                            else if (s == "R")
                            {
                                ins.ReaderStep = 1;
                            }
                            else if (symbols.Contains(s))
                            {
                                ins.NewValue = s;
                            }
                            else
                            {
                                ins.NewState = s;
                            }
                        }
                    }

                    instr[state].Add(val, ins);
                }
            }

            machine = new Machine<string, string>(textBox_startState.Text, textBox_endState.Text, instr)
            {
                DefaultValue = "_"
            };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Run();
        }

        public void Run()
        {
            history.Items.Clear();

            int w = 0;

            LinkedList<string> values = new LinkedList<string>();
            LinkedListNode<string> current = null;

            for (int i = 0; i < dataGridView_data.RowCount - 1; i++)
            {
                values.AddLast(dataGridView_data[0, i].Value.ToString());
                if ((int)numericUpDown_current.Value == i)
                {
                    current = values.Last;
                }
            }

            Task.Run(() =>
            {
                try
                {
                    while (pause)
                    {
                        Thread.Sleep(100);
                    }

                    machine?.Execute(values, current, x =>
                    {
                        while (pause)
                        {
                            Thread.Sleep(100);
                        }
                        int delay = 0;
                        this.Invoke(new Action(() =>
                        {
                            int k = 0;
                            dataGridView_data.RowCount = x.Data.Count + 1;

                            foreach (string s in x.Data)
                            {
                                dataGridView_data[0, k++].Value = s;
                            }

                            var c = x.Current;

                            int l = 0;
                            while (c.Previous != null)
                            {
                                l++;
                                c = c.Previous;
                            }

                            dataGridView_data.ClearSelection();
                            dataGridView_data.CurrentCell = dataGridView_data[0, l];


                            label_state.Text = x.State;
                            label_value.Text = x.Current.Value;
                            counter.Text = (++w).ToString();

                            delay = (int)numericUpDown_delay.Value;

                            history.Items.Insert(0, $"{x.State} {x.Current.Value}");
                        }));
                        Thread.Sleep(delay);
                    });
                }
                catch (DataException ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show(ex.Message);
                    }));
                }

            });

        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            pause = true;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            pause = false;
        }

        private void button_saveData_Click(object sender, EventArgs e)
        {
            List<string> data_items = new List<string>();
            for (int i = 0; i < dataGridView_data.RowCount - 1; i++)
            {
                data_items.Add(dataGridView_data[0, i].Value.ToString());
            }
            File.WriteAllText("data.txt", string.Join(" ", data_items));
        }

        private void button_loadData_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllText("data.txt").Split(' ');
            dataGridView_data.RowCount = data.Length + 1;
            for (var i = 0; i < data.Length; i++)
            {
                dataGridView_data[0, i].Value = data[i];
            }
        }

        private List<string> MachineToText()
        {
            List<string> lines = new List<string>();

            lines.Add(textBox_startState.Text + ";" + textBox_endState.Text);

            lines.Add(textBox_symbols.Text);

            {
                List<string> state_items = new List<string>();
                for (int i = 0; i < dataGridView_states.RowCount - 1; i++)
                {
                    state_items.Add(dataGridView_states[0, i].Value.ToString());
                }

                lines.Add(string.Join(" ", state_items));
            }

            for (int i = 0; i < dataGrid_instuctions.RowCount; i++)
            {
                for (int j = 0; j < dataGrid_instuctions.ColumnCount; j++)
                {
                    var data = dataGrid_instuctions[j, i].Value;
                    if (data != "" && data != null)
                    {
                        lines.Add(dataGrid_instuctions.Rows[i].HeaderCell.Value + " " + dataGrid_instuctions.Columns[j].HeaderCell.Value + "->" + data);
                    }
                }
            }

            return lines;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(textBox_filename.Text, MachineToText());
        }

        private void MachineFromText(string[] lines)
        {
            string[] start_end_states = lines[0].Split(';');
            textBox_startState.Text = start_end_states[0];
            textBox_endState.Text = start_end_states[1];


            textBox_symbols.Text = lines[1];
            string[] states = lines[2].Split(' ');

            dataGridView_states.RowCount = states.Length + 1;
            for (var i = 0; i < states.Length; i++)
            {
                dataGridView_states[0, i].Value = states[i];
            }

            HashSet<string> data_items = new HashSet<string>(textBox_symbols.Text.Split(' '));

            Dictionary<string, int> rowsDictionary = new Dictionary<string, int>();

            {
                dataGrid_instuctions.ColumnCount = data_items.Count;
                dataGrid_instuctions.RowCount = dataGridView_states.RowCount - 1;

                var data_items_array = data_items.OrderBy(x => x).ToArray();

                for (int i = 0; i < data_items_array.Length; i++)
                {
                    dataGrid_instuctions.Columns[i].HeaderCell.Value = data_items_array[i];
                    dataGrid_instuctions.Columns[i].Name = data_items_array[i];
                }

                for (int i = 0; i < dataGridView_states.RowCount - 1; i++)
                {
                    dataGrid_instuctions.Rows[i].HeaderCell.Value = dataGridView_states[0, i].Value.ToString();
                    rowsDictionary.Add(dataGridView_states[0, i].Value.ToString(), i);
                }
            }

            foreach (string s in lines.Skip(3))
            {
                string[] row = s.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string[] coords = row[0].Split(' ');

                dataGrid_instuctions[coords[1], rowsDictionary[coords[0]]].Value = row[1] == "None" ? null : row[1];
            }
        }


        public void LoadFromFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            MachineFromText(lines);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile(textBox_filename.Text);
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var renameForm = new RenameForm();

            if (renameForm.ShowDialog() == DialogResult.OK)
            {
                string from = renameForm.From;
                string to = renameForm.To;

                for (int i = 0; i < dataGrid_instuctions.RowCount; i++)
                {
                    dataGrid_instuctions.Rows[i].HeaderCell.Value = dataGrid_instuctions.Rows[i].HeaderCell.Value?.ToString().Replace(from, to);
                    for (int j = 0; j < dataGrid_instuctions.ColumnCount; j++)
                    {
                        dataGrid_instuctions[j, i].Value = dataGrid_instuctions[j, i].Value?.ToString().Replace(from, to);
                    }
                }

                for (int j = 0; j < dataGridView_states.RowCount; j++)
                {
                    dataGridView_states[0, j].Value = dataGridView_states[0, j].Value?.ToString().Replace(from, to);
                }
                for (int j = 0; j < dataGridView_data.RowCount; j++)
                {
                    dataGridView_data[0, j].Value = dataGridView_data[0, j].Value?.ToString().Replace(from, to);
                }

                textBox_symbols.Text = textBox_symbols.Text.Replace(from, to);
                textBox_startState.Text = textBox_startState.Text.Replace(from, to);
                textBox_endState.Text = textBox_endState.Text.Replace(from, to);
            }
        }

        private void runManyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
