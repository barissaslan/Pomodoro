using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.IO;
using WMPLib;

namespace Pomodoro
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        bool flag; // for dont play sound on form_load by the selectedIndexChanged_Event

        private void frmSettings_Load(object sender, EventArgs e)
        {
            getRes(new CultureInfo(mainForm.CultureInfo));

            for (int i = 0; i < mainForm.soundFiles.Length; i++)
            {
                mainForm.soundNames[i] = Path.GetFileNameWithoutExtension(mainForm.soundFiles[i]);
                cmbWorkSounds.Items.Add(mainForm.soundNames[i]);
                cmbBreakSounds.Items.Add(mainForm.soundNames[i]);
            }

            nmrWork.Value = Pomodoro.WorkInterval;
            nmrShortBreak.Value = Pomodoro.ShortBreakInterval;
            nmrLongBreak.Value = Pomodoro.LongBreakInterval;
            nmrLongAfter.Value = Pomodoro.LongBreakAfter;
            nmrTarget.Value = Pomodoro.Target;
            flag = false;
            cmbWorkSounds.SelectedIndex = Pomodoro.WorkComplatedSoundIndex;
            cmbBreakSounds.SelectedIndex = Pomodoro.EndBreakSoundIndex;
            flag = true;
            toogleAutoStart.Toggled = Pomodoro.AutoStart;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            nmrWork.Value = 25;
            nmrShortBreak.Value = 5;
            nmrLongBreak.Value = 20;
            nmrLongAfter.Value = 4;
            nmrTarget.Value = 8;
            flag = false;
            cmbWorkSounds.SelectedIndex = 0;
            cmbBreakSounds.SelectedIndex = 0;
            flag = true;
            toogleAutoStart.Toggled = false;
        }

        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("Pomodoro");
            ResourceManager rm = new ResourceManager("Pomodoro.Languages.lang", a);

            // Settings Form
            this.Text = rm.GetString("settings", ci);
            lblWork.Text = rm.GetString("lblWork", ci);
            lblShortBreak.Text = rm.GetString("lblShortBreak", ci);
            lblLongBreak.Text = rm.GetString("lblLongBreak", ci);
            btnOK.Text = rm.GetString("btnOK", ci);
            btnCancel.Text = rm.GetString("btnCancel", ci);
        }

        private void cmbSounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (flag)
            {
                playSound(cmb.SelectedIndex);
            }
        }

        private async void playSound(int soundIndex)
        {
            WindowsMediaPlayer sound = new WindowsMediaPlayer();
            sound.URL = mainForm.soundFiles[soundIndex];
            sound.controls.play();
            await Task.Delay(2000);
            sound.close();
        }


    }
}
