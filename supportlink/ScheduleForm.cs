using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supportlink
{
    public partial class ScheduleForm : Form
    {
        private DateTime scheduledTime;
        private string selectedAction = "";
        public ScheduleForm()
        {

            InitializeComponent();
            comboRepeat.Items.AddRange(new[] { "Daily", "Weekly", "Monthly" });

            // Hoặc nếu muốn thêm mặc định:
            comboRepeat.SelectedIndex = 0;
            int y = 20;
            foreach (RadioButton rb in new[] { radioShutdown, radioRestart, radioLogoff, radioSleep, radioLock, radioCloseApps })
            {
                rb.Location = new Point(10, y);
                rb.AutoSize = true;
                y += 22;
            }
        }
        private void BtnStartTask_Click(object sender, EventArgs e)
        {
            // Determine selected action
            if (radioShutdown.Checked) selectedAction = "shutdown";
            else if (radioRestart.Checked) selectedAction = "restart";
            else if (radioLogoff.Checked) selectedAction = "logoff";
            else if (radioSleep.Checked) selectedAction = "sleep";
            else if (radioLock.Checked) selectedAction = "lock";
            else if (radioCloseApps.Checked) selectedAction = "closeapps";
            else
            {
                MessageBox.Show("Please select an action.");
                return;
            }

            // Determine schedule time
            if (radioNow.Checked)
            {
                ExecuteTask();
                return;
            }
            else if (radioAfter.Checked)
            {
                int hours = (int)numHour.Value;
                int minutes = (int)numMinute.Value;
                scheduledTime = DateTime.Now.AddHours(hours).AddMinutes(minutes);
            }
            else if (radioRepeat.Checked)
            {
                scheduledTime = timePicker.Value;
                // Repeat logic can be enhanced later
            }
            else
            {
                MessageBox.Show("Please select schedule mode.");
                return;
            }

            labelStatus.Text = $"Scheduled {selectedAction} at {scheduledTime}";
            taskTimer.Interval = 1000; // check every second
            taskTimer.Tick += TaskTimer_Tick;
            taskTimer.Start();
        }

        private void TaskTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= scheduledTime)
            {
                taskTimer.Stop();
                ExecuteTask();
            }
        }

        private void ExecuteTask()
        {
            labelStatus.Text = $"Executing {selectedAction}...";

            switch (selectedAction)
            {
                case "shutdown":
                    Process.Start("shutdown", "/s /t 0");
                    break;
                case "restart":
                    Process.Start("shutdown", "/r /t 0");
                    break;
                case "logoff":
                    Process.Start("shutdown", "/l");
                    break;
                case "sleep":
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                case "lock":
                    LockWorkStation();
                    break;
                case "closeapps":
                    CloseAllApplications();
                    break;
            }
        }

        private void BtnCancelTask_Click(object sender, EventArgs e)
        {
            taskTimer.Stop();
            labelStatus.Text = "Task cancelled.";
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void LockWorkStation();

        private void CloseAllApplications()
        {
            foreach (var proc in Process.GetProcesses())
            {
                try
                {
                    if (!string.IsNullOrEmpty(proc.MainWindowTitle) && proc.ProcessName != "explorer" && proc.Id != Process.GetCurrentProcess().Id)
                    {
                        proc.CloseMainWindow();
                    }
                }
                catch { }
            }
        }
    }

}
