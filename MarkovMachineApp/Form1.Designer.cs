namespace MarkovMachineApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Instructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word_textbox = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.delay_upDown = new System.Windows.Forms.NumericUpDown();
            this.load_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.file_textbox = new System.Windows.Forms.TextBox();
            this.copyword_textbox = new System.Windows.Forms.TextBox();
            this.copyword_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.last_instr_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.pause_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mark_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_upDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Instructions});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(250, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Instructions
            // 
            this.Instructions.HeaderText = "Instructions";
            this.Instructions.Name = "Instructions";
            this.Instructions.Width = 200;
            // 
            // word_textbox
            // 
            this.word_textbox.Location = new System.Drawing.Point(268, 46);
            this.word_textbox.Name = "word_textbox";
            this.word_textbox.Size = new System.Drawing.Size(225, 20);
            this.word_textbox.TabIndex = 1;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(418, 98);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // history
            // 
            this.history.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(544, 12);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(244, 420);
            this.history.TabIndex = 3;
            // 
            // delay_upDown
            // 
            this.delay_upDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delay_upDown.Location = new System.Drawing.Point(268, 72);
            this.delay_upDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.delay_upDown.Name = "delay_upDown";
            this.delay_upDown.Size = new System.Drawing.Size(225, 20);
            this.delay_upDown.TabIndex = 4;
            this.delay_upDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(358, 380);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 5;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(268, 380);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // file_textbox
            // 
            this.file_textbox.Location = new System.Drawing.Point(268, 354);
            this.file_textbox.Name = "file_textbox";
            this.file_textbox.Size = new System.Drawing.Size(165, 20);
            this.file_textbox.TabIndex = 7;
            this.file_textbox.Text = "markov.txt";
            // 
            // copyword_textbox
            // 
            this.copyword_textbox.Location = new System.Drawing.Point(268, 12);
            this.copyword_textbox.Name = "copyword_textbox";
            this.copyword_textbox.Size = new System.Drawing.Size(180, 20);
            this.copyword_textbox.TabIndex = 8;
            // 
            // copyword_btn
            // 
            this.copyword_btn.Location = new System.Drawing.Point(454, 9);
            this.copyword_btn.Name = "copyword_btn";
            this.copyword_btn.Size = new System.Drawing.Size(39, 23);
            this.copyword_btn.TabIndex = 9;
            this.copyword_btn.Text = ">";
            this.copyword_btn.UseVisualStyleBackColor = true;
            this.copyword_btn.Click += new System.EventHandler(this.copyword_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lbl,
            this.progressbar,
            this.last_instr_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
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
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(337, 98);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 11;
            this.pause_btn.Text = "Pause";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(268, 98);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(63, 23);
            this.stop_btn.TabIndex = 12;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mark_check
            // 
            this.mark_check.AutoSize = true;
            this.mark_check.Location = new System.Drawing.Point(268, 127);
            this.mark_check.Name = "mark_check";
            this.mark_check.Size = new System.Drawing.Size(50, 17);
            this.mark_check.TabIndex = 15;
            this.mark_check.Text = "Mark";
            this.mark_check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mark_check);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.copyword_btn);
            this.Controls.Add(this.copyword_textbox);
            this.Controls.Add(this.file_textbox);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.delay_upDown);
            this.Controls.Add(this.history);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.word_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Markov 3000";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_upDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox word_textbox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructions;
        private System.Windows.Forms.NumericUpDown delay_upDown;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox file_textbox;
        private System.Windows.Forms.TextBox copyword_textbox;
        private System.Windows.Forms.Button copyword_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_lbl;
        private System.Windows.Forms.ToolStripStatusLabel last_instr_lbl;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox mark_check;
    }
}

