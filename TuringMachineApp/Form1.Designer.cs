namespace TuringMachineApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid_instuctions = new System.Windows.Forms.DataGridView();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_states = new System.Windows.Forms.DataGridView();
            this.States = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_startState = new System.Windows.Forms.TextBox();
            this.textBox_endState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_current = new System.Windows.Forms.NumericUpDown();
            this.textBox_symbols = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.numericUpDown_delay = new System.Windows.Forms.NumericUpDown();
            this.button_loadData = new System.Windows.Forms.Button();
            this.button_saveData = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.counter = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_value = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runManyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_instuctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_states)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_current)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_delay)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_instuctions
            // 
            this.dataGrid_instuctions.AllowUserToAddRows = false;
            this.dataGrid_instuctions.AllowUserToDeleteRows = false;
            this.dataGrid_instuctions.AllowUserToOrderColumns = true;
            this.dataGrid_instuctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_instuctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_instuctions.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_instuctions.Name = "dataGrid_instuctions";
            this.dataGrid_instuctions.RowHeadersWidth = 60;
            this.dataGrid_instuctions.Size = new System.Drawing.Size(890, 535);
            this.dataGrid_instuctions.TabIndex = 0;
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data});
            this.dataGridView_data.Location = new System.Drawing.Point(13, 12);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.Size = new System.Drawing.Size(145, 327);
            this.dataGridView_data.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // dataGridView_states
            // 
            this.dataGridView_states.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_states.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.States});
            this.dataGridView_states.Location = new System.Drawing.Point(164, 12);
            this.dataGridView_states.Name = "dataGridView_states";
            this.dataGridView_states.Size = new System.Drawing.Size(145, 327);
            this.dataGridView_states.TabIndex = 2;
            // 
            // States
            // 
            this.States.HeaderText = "States";
            this.States.Name = "States";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create Machine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_startState
            // 
            this.textBox_startState.Location = new System.Drawing.Point(84, 10);
            this.textBox_startState.Name = "textBox_startState";
            this.textBox_startState.Size = new System.Drawing.Size(100, 20);
            this.textBox_startState.TabIndex = 5;
            // 
            // textBox_endState
            // 
            this.textBox_endState.Location = new System.Drawing.Point(84, 36);
            this.textBox_endState.Name = "textBox_endState";
            this.textBox_endState.Size = new System.Drawing.Size(100, 20);
            this.textBox_endState.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "End State";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Execute";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "StartPos";
            // 
            // numericUpDown_current
            // 
            this.numericUpDown_current.Location = new System.Drawing.Point(84, 63);
            this.numericUpDown_current.Name = "numericUpDown_current";
            this.numericUpDown_current.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_current.TabIndex = 13;
            // 
            // textBox_symbols
            // 
            this.textBox_symbols.Location = new System.Drawing.Point(230, 349);
            this.textBox_symbols.Name = "textBox_symbols";
            this.textBox_symbols.Size = new System.Drawing.Size(230, 20);
            this.textBox_symbols.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Symbols";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_loadData);
            this.splitContainer1.Panel2.Controls.Add(this.button_saveData);
            this.splitContainer1.Panel2.Controls.Add(this.history);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_data);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_states);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_symbols);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 704);
            this.splitContainer1.SplitterDistance = 890;
            this.splitContainer1.TabIndex = 21;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGrid_instuctions);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_stop);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_filename);
            this.splitContainer2.Panel2.Controls.Add(this.button_play);
            this.splitContainer2.Panel2.Controls.Add(this.button_pause);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDown_delay);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_startState);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDown_current);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_endState);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(890, 704);
            this.splitContainer2.SplitterDistance = 535;
            this.splitContainer2.TabIndex = 16;
            // 
            // textBox_filename
            // 
            this.textBox_filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_filename.Location = new System.Drawing.Point(700, 15);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(142, 20);
            this.textBox_filename.TabIndex = 19;
            this.textBox_filename.Text = "machine.txt";
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(752, 76);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(46, 23);
            this.button_play.TabIndex = 18;
            this.button_play.Text = "play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(700, 76);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(46, 23);
            this.button_pause.TabIndex = 17;
            this.button_pause.Text = "pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // numericUpDown_delay
            // 
            this.numericUpDown_delay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_delay.Location = new System.Drawing.Point(700, 105);
            this.numericUpDown_delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_delay.Name = "numericUpDown_delay";
            this.numericUpDown_delay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_delay.TabIndex = 16;
            this.numericUpDown_delay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button_loadData
            // 
            this.button_loadData.Location = new System.Drawing.Point(13, 378);
            this.button_loadData.Name = "button_loadData";
            this.button_loadData.Size = new System.Drawing.Size(59, 23);
            this.button_loadData.TabIndex = 23;
            this.button_loadData.Text = "load";
            this.button_loadData.UseVisualStyleBackColor = true;
            this.button_loadData.Click += new System.EventHandler(this.button_loadData_Click);
            // 
            // button_saveData
            // 
            this.button_saveData.Location = new System.Drawing.Point(13, 349);
            this.button_saveData.Name = "button_saveData";
            this.button_saveData.Size = new System.Drawing.Size(59, 23);
            this.button_saveData.TabIndex = 22;
            this.button_saveData.Text = "save";
            this.button_saveData.UseVisualStyleBackColor = true;
            this.button_saveData.Click += new System.EventHandler(this.button_saveData_Click);
            // 
            // history
            // 
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(315, 12);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(168, 329);
            this.history.TabIndex = 21;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.counter,
            this.toolStripStatusLabel1,
            this.label_state,
            this.toolStripStatusLabel2,
            this.label_value});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // counter
            // 
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(13, 17);
            this.counter.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "state";
            // 
            // label_state
            // 
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(12, 17);
            this.label_state.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel2.Text = "value";
            // 
            // label_value
            // 
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(12, 17);
            this.label_value.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runManyToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runManyToolStripMenuItem
            // 
            this.runManyToolStripMenuItem.Name = "runManyToolStripMenuItem";
            this.runManyToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.runManyToolStripMenuItem.Text = "Run many";
            this.runManyToolStripMenuItem.Click += new System.EventHandler(this.runManyToolStripMenuItem_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(804, 76);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(46, 23);
            this.btn_stop.TabIndex = 20;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_instuctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_states)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_current)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_delay)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_instuctions;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridView dataGridView_states;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn States;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_startState;
        private System.Windows.Forms.TextBox textBox_endState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_current;
        private System.Windows.Forms.TextBox textBox_symbols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel counter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel label_state;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel label_value;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.NumericUpDown numericUpDown_delay;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_saveData;
        private System.Windows.Forms.Button button_loadData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runManyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Button btn_stop;
    }
}

