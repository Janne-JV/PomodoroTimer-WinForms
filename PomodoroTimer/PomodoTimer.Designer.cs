namespace PomodoroTimer
{
    partial class FrmTimer
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
            this.components = new System.ComponentModel.Container();
            this.LblTimer = new System.Windows.Forms.Label();
            this.WorkTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnStartReset = new System.Windows.Forms.Button();
            this.LblCycles = new System.Windows.Forms.Label();
            this.ClbTasks = new System.Windows.Forms.CheckedListBox();
            this.TxbAddTask = new System.Windows.Forms.TextBox();
            this.LblTasks = new System.Windows.Forms.Label();
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.BtnRemoveTask = new System.Windows.Forms.Button();
            this.BtnClearList = new System.Windows.Forms.Button();
            this.BreakTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnEditTask = new System.Windows.Forms.Button();
            this.TxbEditTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.Location = new System.Drawing.Point(9, 9);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(345, 136);
            this.LblTimer.TabIndex = 0;
            this.LblTimer.Text = "00:00";
            // 
            // WorkTimer
            // 
            this.WorkTimer.Interval = 1000;
            this.WorkTimer.Tick += new System.EventHandler(this.WorkTimer_Tick);
            // 
            // BtnStartReset
            // 
            this.BtnStartReset.BackColor = System.Drawing.Color.Red;
            this.BtnStartReset.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartReset.Location = new System.Drawing.Point(32, 177);
            this.BtnStartReset.Name = "BtnStartReset";
            this.BtnStartReset.Size = new System.Drawing.Size(285, 72);
            this.BtnStartReset.TabIndex = 2;
            this.BtnStartReset.Text = "Start";
            this.BtnStartReset.UseVisualStyleBackColor = false;
            this.BtnStartReset.Click += new System.EventHandler(this.BtnStartReset_Click);
            // 
            // LblCycles
            // 
            this.LblCycles.AutoSize = true;
            this.LblCycles.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCycles.Location = new System.Drawing.Point(27, 145);
            this.LblCycles.Name = "LblCycles";
            this.LblCycles.Size = new System.Drawing.Size(116, 29);
            this.LblCycles.TabIndex = 3;
            this.LblCycles.Text = "Cycles: 0";
            // 
            // ClbTasks
            // 
            this.ClbTasks.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClbTasks.FormattingEnabled = true;
            this.ClbTasks.Location = new System.Drawing.Point(360, 39);
            this.ClbTasks.Name = "ClbTasks";
            this.ClbTasks.Size = new System.Drawing.Size(428, 334);
            this.ClbTasks.TabIndex = 4;
            // 
            // TxbAddTask
            // 
            this.TxbAddTask.Location = new System.Drawing.Point(463, 377);
            this.TxbAddTask.Name = "TxbAddTask";
            this.TxbAddTask.Size = new System.Drawing.Size(325, 20);
            this.TxbAddTask.TabIndex = 5;
            // 
            // LblTasks
            // 
            this.LblTasks.AutoSize = true;
            this.LblTasks.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTasks.Location = new System.Drawing.Point(356, 14);
            this.LblTasks.Name = "LblTasks";
            this.LblTasks.Size = new System.Drawing.Size(66, 22);
            this.LblTasks.TabIndex = 7;
            this.LblTasks.Text = "Tasks";
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.Location = new System.Drawing.Point(360, 375);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(97, 23);
            this.BtnAddTask.TabIndex = 8;
            this.BtnAddTask.Text = "Add Task";
            this.BtnAddTask.UseVisualStyleBackColor = true;
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // BtnRemoveTask
            // 
            this.BtnRemoveTask.Location = new System.Drawing.Point(660, 9);
            this.BtnRemoveTask.Name = "BtnRemoveTask";
            this.BtnRemoveTask.Size = new System.Drawing.Size(82, 23);
            this.BtnRemoveTask.TabIndex = 9;
            this.BtnRemoveTask.Text = "Remove Task";
            this.BtnRemoveTask.UseVisualStyleBackColor = true;
            this.BtnRemoveTask.Click += new System.EventHandler(this.BtnRemoveTask_Click);
            // 
            // BtnClearList
            // 
            this.BtnClearList.Location = new System.Drawing.Point(748, 9);
            this.BtnClearList.Name = "BtnClearList";
            this.BtnClearList.Size = new System.Drawing.Size(40, 23);
            this.BtnClearList.TabIndex = 10;
            this.BtnClearList.Text = "Clear";
            this.BtnClearList.UseVisualStyleBackColor = true;
            this.BtnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // BreakTimer
            // 
            this.BreakTimer.Interval = 1000;
            this.BreakTimer.Tick += new System.EventHandler(this.BreakTimer_Tick);
            // 
            // BtnEditTask
            // 
            this.BtnEditTask.Location = new System.Drawing.Point(429, 9);
            this.BtnEditTask.Name = "BtnEditTask";
            this.BtnEditTask.Size = new System.Drawing.Size(75, 23);
            this.BtnEditTask.TabIndex = 11;
            this.BtnEditTask.Text = "Edit Task";
            this.BtnEditTask.UseVisualStyleBackColor = true;
            this.BtnEditTask.Click += new System.EventHandler(this.BtnEditTask_Click);
            // 
            // TxbEditTask
            // 
            this.TxbEditTask.Location = new System.Drawing.Point(510, 11);
            this.TxbEditTask.Name = "TxbEditTask";
            this.TxbEditTask.Size = new System.Drawing.Size(144, 20);
            this.TxbEditTask.TabIndex = 12;
            // 
            // FrmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.TxbEditTask);
            this.Controls.Add(this.BtnEditTask);
            this.Controls.Add(this.BtnClearList);
            this.Controls.Add(this.BtnRemoveTask);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.LblTasks);
            this.Controls.Add(this.TxbAddTask);
            this.Controls.Add(this.ClbTasks);
            this.Controls.Add(this.LblCycles);
            this.Controls.Add(this.BtnStartReset);
            this.Controls.Add(this.LblTimer);
            this.Name = "FrmTimer";
            this.Text = "Pomodoro Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Timer WorkTimer;
        private System.Windows.Forms.Button BtnStartReset;
        private System.Windows.Forms.Label LblCycles;
        private System.Windows.Forms.CheckedListBox ClbTasks;
        private System.Windows.Forms.TextBox TxbAddTask;
        private System.Windows.Forms.Label LblTasks;
        private System.Windows.Forms.Button BtnAddTask;
        private System.Windows.Forms.Button BtnRemoveTask;
        private System.Windows.Forms.Button BtnClearList;
        private System.Windows.Forms.Timer BreakTimer;
        private System.Windows.Forms.Button BtnEditTask;
        private System.Windows.Forms.TextBox TxbEditTask;
    }
}

