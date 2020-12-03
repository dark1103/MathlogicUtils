namespace InfRegistersMachine
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
            this.table_instructions = new System.Windows.Forms.DataGridView();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arg2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arg3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_run = new System.Windows.Forms.Button();
            this.table_registers = new System.Windows.Forms.DataGridView();
            this.Registers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_delay = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.last_instr_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.file_textbox = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.pause_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_instructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_registers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_instructions
            // 
            this.table_instructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.table_instructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_instructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Arg1,
            this.Arg2,
            this.Arg3});
            this.table_instructions.Location = new System.Drawing.Point(12, 12);
            this.table_instructions.Name = "table_instructions";
            this.table_instructions.RowHeadersWidth = 50;
            this.table_instructions.Size = new System.Drawing.Size(248, 419);
            this.table_instructions.TabIndex = 0;
            this.table_instructions.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_instructions_RowsAdded);
            this.table_instructions.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_instructions_RowsRemoved);
            this.table_instructions.SelectionChanged += new System.EventHandler(this.table_instructions_SelectionChanged);
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.Width = 40;
            // 
            // Arg1
            // 
            this.Arg1.HeaderText = "Arg1";
            this.Arg1.Name = "Arg1";
            this.Arg1.Width = 40;
            // 
            // Arg2
            // 
            this.Arg2.HeaderText = "Arg2";
            this.Arg2.Name = "Arg2";
            this.Arg2.Width = 40;
            // 
            // Arg3
            // 
            this.Arg3.HeaderText = "Arg3";
            this.Arg3.Name = "Arg3";
            this.Arg3.Width = 40;
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.Location = new System.Drawing.Point(844, 376);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // table_registers
            // 
            this.table_registers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.table_registers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_registers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registers});
            this.table_registers.Location = new System.Drawing.Point(450, 12);
            this.table_registers.Name = "table_registers";
            this.table_registers.RowHeadersWidth = 50;
            this.table_registers.Size = new System.Drawing.Size(156, 419);
            this.table_registers.TabIndex = 2;
            this.table_registers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.table_instructions_RowsAdded);
            this.table_registers.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.table_instructions_RowsRemoved);
            // 
            // Registers
            // 
            this.Registers.HeaderText = "Registers";
            this.Registers.Name = "Registers";
            // 
            // num_delay
            // 
            this.num_delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.num_delay.Location = new System.Drawing.Point(766, 379);
            this.num_delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_delay.Name = "num_delay";
            this.num_delay.Size = new System.Drawing.Size(72, 20);
            this.num_delay.TabIndex = 3;
            this.num_delay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lbl,
            this.progressbar,
            this.last_instr_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(931, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_lbl
            // 
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(51, 17);
            this.status_lbl.Text = "Stopped";
            // 
            // progressbar
            // 
            this.progressbar.Maximum = 99;
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            // 
            // last_instr_lbl
            // 
            this.last_instr_lbl.Name = "last_instr_lbl";
            this.last_instr_lbl.Size = new System.Drawing.Size(0, 17);
            // 
            // file_textbox
            // 
            this.file_textbox.Location = new System.Drawing.Point(266, 378);
            this.file_textbox.Name = "file_textbox";
            this.file_textbox.Size = new System.Drawing.Size(165, 20);
            this.file_textbox.TabIndex = 14;
            this.file_textbox.Text = "inf_reg.txt";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(266, 404);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(356, 404);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 12;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_btn.Location = new System.Drawing.Point(844, 402);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 19;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // history
            // 
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(706, 12);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(213, 355);
            this.history.TabIndex = 20;
            // 
            // pause_btn
            // 
            this.pause_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pause_btn.Location = new System.Drawing.Point(766, 402);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 21;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 456);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.history);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.file_textbox);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.num_delay);
            this.Controls.Add(this.table_registers);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.table_instructions);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table_instructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_registers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_delay)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_instructions;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.DataGridView table_registers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registers;
        private System.Windows.Forms.NumericUpDown num_delay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripStatusLabel last_instr_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arg3;
        private System.Windows.Forms.TextBox file_textbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Button pause_btn;
    }
}

