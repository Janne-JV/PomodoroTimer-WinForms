using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer.Classes
{
    public static class TimerHelper
    {
        public static int Minute;
        public static int Second;
        public static int Cycles;

        public static void RemoveFromComponent()
        {
            if (Second > 0)
            {
                Second--;
            }
            else if (Second == 0)
            {
                Minute--;
                Second = 59;
            }
        }

        public static void SetBreakTime()
        {
            if (Cycles == 4)
            {
                Minute = 15;
            }
            else if (Cycles == 8)
            {
                Minute = 30;
            }
            else
            {
                Minute = 5;
            }
        }

        public static void ChangeNameOfSelectedItem(CheckedListBox tasks, TextBox value)
        {
            var index = tasks.SelectedIndex;
            if (tasks.SelectedIndex != -1)
            {
                tasks.Items[index] = value.Text;
                tasks.ClearSelected();
            }
        }
    }
}
