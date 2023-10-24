using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
            Classes.TimerHelper.Minute = 25;
            Classes.TimerHelper.Second = 0;
        }

        private void BtnStartReset_Click(object sender, EventArgs e)
        {
            if (BtnStartReset.Text == "Start")
            {
                Classes.TimerHelper.RemoveFromComponent();
                WorkTimer.Start();
                BackColor = Color.Red;
                BtnStartReset.BackColor = Color.White;
                var workStartNotify = new SoundPlayer(@"c:\Windows\Media\Windows Hardware Insert.wav");
                workStartNotify.Play();
                BtnStartReset.Text = "Reset";
            }
            else
            {
                WorkTimer.Stop();
                BreakTimer.Stop();
                BackColor = Color.White;
                BtnStartReset.BackColor = Color.Red;
                Classes.TimerHelper.Minute = 25;
                Classes.TimerHelper.Second = 0;
                LblTimer.Text = $"{Classes.TimerHelper.Minute}:{Classes.TimerHelper.Second}";
                BtnStartReset.Text = "Start";
            }
        }

        private void WorkTimer_Tick(object sender, EventArgs e)
        {
            LblTimer.Text = $"{Classes.TimerHelper.Minute}:{Classes.TimerHelper.Second}";

            if (Classes.TimerHelper.Minute > 0 | Classes.TimerHelper.Second > 0)
            {
                Classes.TimerHelper.RemoveFromComponent();
            }
            else //if (Classes.Timer.Minute == 0 & Classes.Timer.Second == 0)
            {
                Classes.TimerHelper.SetBreakTime();
                BackColor = Color.Green;
                BreakTimer.Start();
                var workStartNotify = new SoundPlayer(@"c:\Windows\Media\Windows Hardware Remove.wav");
                workStartNotify.Play();
                WorkTimer.Stop();
            }
        }

        private void BreakTimer_Tick(object sender, EventArgs e)
        {
            LblTimer.Text = $"{Classes.TimerHelper.Minute}:{Classes.TimerHelper.Second}";

            if (Classes.TimerHelper.Minute > 0 | Classes.TimerHelper.Second > 0)
            {
                Classes.TimerHelper.RemoveFromComponent();
            }
            else //if (Classes.Timer.Minute == 0 & Classes.Timer.Second == 0)
            {
                Classes.TimerHelper.Cycles++;
                LblCycles.Text = $"Cycles: {Classes.TimerHelper.Cycles}";
                BackColor = Color.Red;
                Classes.TimerHelper.Minute = 25;
                WorkTimer.Start();
                var workStartNotify = new SoundPlayer(@"c:\Windows\Media\Windows Hardware Insert.wav");
                workStartNotify.Play();
                BreakTimer.Stop();
            }
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            ClbTasks.Items.Add(TxbAddTask.Text);
            TxbAddTask.Clear();
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            Classes.TimerHelper.ChangeNameOfSelectedItem(ClbTasks, TxbEditTask);
            TxbAddTask.Clear();
        }

        private void BtnRemoveTask_Click(object sender, EventArgs e)
        {
            try
            {
                ClbTasks.Items.RemoveAt(ClbTasks.SelectedIndex);
            }
            catch (Exception err)
            {
                MessageBox.Show("No item has been selected!");
            }
            
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            ClbTasks.Items.Clear();
        }
    }
}