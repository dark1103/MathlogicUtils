using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfRegistersMachine
{
    public partial class Form1 : Form
    {
        public struct Instruction
        {
            public string Type { get; set; }
            public int? Arg1 { get; set; }
            public int? Arg2 { get; set; }
            public int? Arg3 { get; set; }

            public Instruction(string type, int? arg1, int? arg2, int? arg3)
            {
                Type = type;
                Arg1 = arg1;
                Arg2 = arg2;
                Arg3 = arg3;
            }

        }

        private int Current = -1;
        private bool stop = false;
        private bool pause = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            List<Instruction> instr = new List<Instruction>();
            for (int i = 0; i < table_instructions.RowCount - 1; i++)
            {
                string command = table_instructions[0, i].Value?.ToString().ToUpper();
                int? arg1 = string.IsNullOrWhiteSpace(table_instructions[1, i].Value?.ToString()) ? (int?)null : int.Parse(table_instructions[1, i].Value?.ToString());
                int? arg2 = string.IsNullOrWhiteSpace(table_instructions[2, i].Value?.ToString()) ? (int?)null : int.Parse(table_instructions[2, i].Value?.ToString());
                int? arg3 = string.IsNullOrWhiteSpace(table_instructions[3, i].Value?.ToString()) ? (int?)null : int.Parse(table_instructions[3, i].Value?.ToString());
                instr.Add(new Instruction(command, arg1, arg2, arg3));
            }
            run_program(instr);
        }

        private void run_program(List<Instruction> instr)
        {
            if (Current != -1)
            {
                return;
            }
            history.Items.Clear();

            new Task(() =>
            {
                Current = 1;
                stop = false;
                pause = false;
                try
                {
                    while (Current - 1 < instr.Count)
                    {
                        while (pause && !stop)
                        {
                            Thread.Sleep((int)num_delay.Value);
                        }
                        if (stop)
                        {
                            break;
                        }

                        this.Invoke(new Action(() =>
                        {
                            table_instructions.ClearSelection();
                            table_instructions.Rows[Current - 1].Selected = true;
                            string instructionToStr = InstructionToStr(Current - 1);
                            if (!string.IsNullOrWhiteSpace(instructionToStr))
                            {
                                history.Items.Insert(0, Current + ": " + instructionToStr);
                            }
                            Instruction ins = instr[Current++ - 1];

                            status_lbl.Text = "Running";
                            switch (ins.Type)
                            {
                                case "Z":
                                    SetReg(ins.Arg1.Value, 0);
                                    break;
                                case "S":
                                    SetReg(ins.Arg1.Value, GetReg(ins.Arg1.Value) + 1);
                                    break;
                                case "T":
                                    SetReg(ins.Arg2.Value, GetReg(ins.Arg1.Value));
                                    break;
                                case "J":
                                    if (GetReg(ins.Arg1.Value) == GetReg(ins.Arg2.Value))
                                    {
                                        Current = ins.Arg3.Value;
                                    }
                                    break;
                            }

                            if (progressbar.Value >= progressbar.Maximum)
                            {
                                progressbar.Value = 0;
                            }
                            else
                            {
                                progressbar.Value += 33;
                            }
                        }));
                        Thread.Sleep((int)num_delay.Value);
                    }
                    this.Invoke(new Action(() =>
                    {
                        progressbar.Value = 0;
                        status_lbl.Text = stop ? "Stopped" : "Finished";
                    }));
                }
                catch (Exception e)
                {
                    this.Invoke(new Action(() =>
                    {
                        progressbar.Value = 0;
                        status_lbl.Text = "Error";
                    }));
                    MessageBox.Show(e.Message, e.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Current = -1;

            }).Start();
        }

        private int GetReg(int num)
        {
            num--;
            while (table_registers.RowCount - 2 < num)
            {
                table_registers.Rows.Add(new object[] { 0 });
            }

            return table_registers[0, num].Value == null ? 0 : int.Parse(table_registers[0, num].Value?.ToString());
        }

        private void SetReg(int num, int value)
        {
            num--;
            while (table_registers.RowCount - 2 < num)
            {
                table_registers.Rows.Add(new object[] { 0 });
            }

            table_registers[0, num].Value = value;
        }

        private void table_instructions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView grid = (DataGridView) sender;
            for (int i = 0; i < grid.RowCount - 1; i++)
            {
                grid.Rows[i].HeaderCell.Value = (i+1).ToString();
            }
        }

        private void table_instructions_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            for (int i = 0; i < grid.RowCount - 1; i++)
            {
                grid.Rows[i].HeaderCell.Value = (i+1).ToString();
            }
        }

        private string InstructionToStr(int i)
        {
            string command = table_instructions[0, i].Value?.ToString().ToUpper();
            int? arg1 = string.IsNullOrWhiteSpace(table_instructions[1, i].Value?.ToString()) ? (int?)null : int.Parse(table_instructions[1, i].Value?.ToString());
            int? arg2 = string.IsNullOrWhiteSpace(table_instructions[2, i].Value?.ToString()) ? (int?)null : int.Parse(table_instructions[2, i].Value?.ToString());
            int? arg3 = string.IsNullOrWhiteSpace(table_instructions[3, i].Value?.ToString()) ? (int?)null : int.Parse(table_instructions[3, i].Value?.ToString());
            string line = command;
            if (arg1.HasValue)
            {
                line += "(" + arg1.Value;
                if (arg2.HasValue)
                {
                    line += ", " + arg2.Value;
                    if (arg3.HasValue)
                    {
                        line += ", " + arg3.Value;
                    }
                }

                line += ")";
            }

            return line;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();
                for (int i = 0; i < table_instructions.RowCount - 1; i++)
                {
                    lines.Add(InstructionToStr(i));
                }
                File.WriteAllLines(file_textbox.Text, lines);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, ee.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(file_textbox.Text);

                table_instructions.RowCount = lines.Length + 1;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] splt = lines[i].Split(new[] { "(", ")", " ", "," }, StringSplitOptions.RemoveEmptyEntries);
                    if (splt.Length > 0)
                    {
                        table_instructions[0, i].Value = splt[0];
                        for (int j = 1; j < 4; j++)
                        {
                            if (splt.Length > j)
                            {
                                table_instructions[j, i].Value = int.Parse(splt[j]);
                            }
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, ee.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (table_instructions.SelectedCells.Count != 0)
            {
                int selected = table_instructions.SelectedCells[0].RowIndex;
                table_instructions.RowCount++;
                for (int i = table_instructions.RowCount - 2; i >= selected + 1; i--)
                {
                    table_instructions[0, i].Value = table_instructions[0, i - 1].Value;
                    table_instructions[1, i].Value = table_instructions[1, i - 1].Value;
                    table_instructions[2, i].Value = table_instructions[2, i - 1].Value;
                    table_instructions[3, i].Value = table_instructions[3, i - 1].Value;
                }

                table_instructions[0, selected].Value = "";
                table_instructions[1, selected].Value = "";
                table_instructions[2, selected].Value = "";
                table_instructions[3, selected].Value = "";

                for (int i = 0; i < table_instructions.RowCount - 1; i++)
                {
                    if (table_instructions[0, i].Value?.ToString().ToUpper() == "J")
                    {
                        int val;
                        if (int.TryParse(table_instructions[3, i].Value?.ToString(), out val))
                        {
                            if (val >= selected)
                            {
                                table_instructions[3, i].Value = val + 1;
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (table_instructions.SelectedCells.Count != 0 && table_instructions.SelectedCells[0].RowIndex < table_instructions.RowCount - 1)
            {
                int selected = table_instructions.SelectedCells[0].RowIndex;
                table_instructions.Rows.RemoveAt(selected);
                for (int i = 0; i < table_instructions.RowCount - 1; i++)
                {
                    if (table_instructions[0, i].Value?.ToString().ToUpper() == "J")
                    {
                        int val;
                        if (int.TryParse(table_instructions[3, i].Value?.ToString(), out val))
                        {
                            if (val >= selected)
                            {
                                table_instructions[3, i].Value = val - 1;
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();
                for (int i = 0; i < table_registers.RowCount - 1; i++)
                {
                    lines.Add(table_registers[0, i].Value?.ToString() ?? "");
                }
                File.WriteAllLines("data.txt", lines);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, ee.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("data.txt");
                table_registers.RowCount = lines.Length + 1;
                for (int i = 0; i < lines.Length; i++)
                {
                    table_registers[0, i].Value = lines[i];
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, ee.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private string GetRowCommand(int row)
        {
            return table_instructions[0, row].Value?.ToString().ToUpper();
        }

        private int? GetRowArg(int row, int arg)
        {
            int val;
            if (int.TryParse(table_instructions[arg, row].Value?.ToString(), out val))
            {
                return val;
            }

            return null;
        }

        private void ResetColor()
        {
            for (int i = 0; i < table_instructions.RowCount; i++)
            {
                table_instructions.Rows[i].DefaultCellStyle.BackColor = table_instructions.DefaultCellStyle.BackColor;
            }
        }

        private void table_instructions_SelectionChanged(object sender, EventArgs e)
        {
            ResetColor();
            if (table_instructions.SelectedCells.Count > 0)
            {
                int index = table_instructions.SelectedCells[0].RowIndex;
                if (GetRowCommand(index) == "J" )
                {
                    int? target = GetRowArg(index, 3);
                    if (target.HasValue && target < table_instructions.RowCount)
                    {
                        table_instructions.Rows[target.Value-1].DefaultCellStyle.BackColor = Color.Lime;
                    }
                }
            }
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            pause = true;
        }
    }
}
