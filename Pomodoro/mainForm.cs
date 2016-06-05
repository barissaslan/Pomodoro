/*
 * author: Barış Aslan
 * mail  : aslannbaris@gmail.com
 *
 *
 * Work RGB        : 231, 90 , 77
 * Short Break RGB : 100, 166, 186
 * Long Break RGB  : 15 , 108, 138
 * 
 * Pomodoro Complated RGB : 255, 192, 192
 * 
 * Not1: totalTime silinecek!
 * Not2: Pomodoro.RecordingProperty'ler kullanıma girecek
 * Not3: Bellek Kullanımı!!
 * Not4: UpdateTodayDesign yeniden yapılandırılacak.
 */

#region Imports
using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Pomodoro.Properties;
using WMPLib;
using System.IO;
#endregion

namespace Pomodoro
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        RoundButton btnPlayPause = new RoundButton(50, 50);
        private bool paused;
        private IntervalType intervalType;
        private MediaType mediaType;
        public static string CultureInfo
        {
            get { return Settings.Default.CurrentCulture; }
            set
            {
                Settings.Default.CurrentCulture = value;
                Settings.Default.Save();
            }
        }

        private DateTime endDate, startDate, pauseDate;
        private TimeSpan totalTime, remainingTime;
        public TimeSpan CurrentInterval
        {
            get
            {
                if (intervalType == IntervalType.Work)
                    return TimeSpan.FromMinutes(Pomodoro.WorkInterval);
                else if (intervalType == IntervalType.ShortBreak)
                    return TimeSpan.FromMinutes(Pomodoro.ShortBreakInterval);
                else
                    return TimeSpan.FromMinutes(Pomodoro.LongBreakInterval);
            }
        }

        #region Strings
        // message strings for converting to another language
        private string done, messageTitle, message;
        #endregion
        #region Colors
        public Color WorkColor
        {
            get { return Color.FromArgb(231, 90, 77); }
        }
        public Color ShortBreakColor
        {
            get { return Color.FromArgb(100, 166, 186); }
        }
        public Color LongBreakColor
        {
            get { return Color.FromArgb(15, 108, 138); }
        }
        #endregion

        #region Sound Fields
        WindowsMediaPlayer sound;
        public static string[] sourceSoundFiles = new string[50];
        public static string[] soundFiles = new string[50];
        public static string[] soundNames = new string[50];
        #endregion
        #region Sound Properties
        public static string SourceDirectory
        {
            get { return Environment.CurrentDirectory + @"\Sounds"; }
        }
        public static string DocumentPath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); }
        }
        public static string SoundDirectory
        {
            get { return DocumentPath + @"\Pomodoro\Sounds"; }
        }
        #endregion
        #region Sound Methods
        private async void playSound(int soundIndex)
        {
            sound = new WindowsMediaPlayer();
            sound.URL = soundFiles[soundIndex];
            sound.controls.play();
            await Task.Delay(2000);
            sound.close();
        }
        public static void updateSounds()
        {
            if (!Directory.Exists(SoundDirectory))
            {
                Directory.CreateDirectory(SoundDirectory);
                sourceSoundFiles = Directory.GetFiles(SourceDirectory, "*.mp3");
                foreach (string soundPath in sourceSoundFiles)
                {
                    string soundName = Path.GetFileName(soundPath);
                    File.Copy(soundPath, Path.Combine(SoundDirectory, soundName));
                }
            }

            soundFiles = Directory.GetFiles(SoundDirectory, "*.mp3");
        }
        #endregion

        void showValues()
        {
            MessageBox.Show("ComplatedWorkCount: " + Pomodoro.ComplatedWorksCount +
             "\nEndBreakCount     : " + Pomodoro.EndBreakCount +
           "\nTotalPomodoroCount: " + Pomodoro.TotalPomodoroCount);

        }
        #region Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            FilePomodoro.CheckFiles();

            //Pomodoro.ComplatedWorksCount = 0;
            //Pomodoro.EndBreakCount = 0;
            //Pomodoro.TotalPomodoroCount = 0;
            showValues();
            //Application.Exit();

            btnPlayPause.Click += new EventHandler(PlayPause_Click);
            panelPlayPause.Controls.Add(btnPlayPause);
            this.AcceptButton = btnPlayPause;

            getRes(new CultureInfo(CultureInfo));

            intervalType = IntervalType.Work;
            mediaType = MediaType.Play;

            // Values clearing if current day is diffrent from last record
            if (!String.Equals(DateTime.Today.ToShortDateString(), Settings.Default.CurrentDate))
            {
                Pomodoro.ComplatedWorksCount = 0;
                Pomodoro.EndBreakCount = 0;

                Settings.Default.CurrentDate = DateTime.Today.ToShortDateString();
                Settings.Default.Save();
            }
            else
            {
                if (Pomodoro.ComplatedWorksCount > Pomodoro.EndBreakCount)
                    changeIntervalType();
            }

            cpsBar.Value = 0;
            cpsBar.Text = CurrentInterval.ToString(@"mm\:ss");

            updateSounds();
            updateTheme();
            updateTodayDesign();
        }
        #endregion

        #region Click Events
        private void PlayPause_Click(object sender, EventArgs e)
        {
            if (Settings.Default.isStarted == false)
            {
                Settings.Default.StartDate = DateTime.Now.ToShortDateString();
                Settings.Default.isStarted = true;
                Settings.Default.Save();
            }


            if (mediaType == MediaType.Play &&
                paused == false) // Default Play Click
            {
                // Time calculating
                startDate = DateTime.UtcNow;
                endDate = startDate.AddMinutes(CurrentInterval.Minutes);
                totalTime = CurrentInterval;
                totalTime = TimeSpan.Parse("00:00:03");
                endDate = startDate.AddSeconds(3);

                cpsBar.AnimationSpeed = 500;
                timer.Enabled = true;
            }
            else if (mediaType == MediaType.Play &&
                paused == true)  // Paused Play Click
            {
                TimeSpan waitingTime = DateTime.UtcNow - pauseDate;
                endDate = endDate.AddSeconds(waitingTime.TotalSeconds);
                paused = false;
                timer.Enabled = true;
            }
            else // Pause Button Click
            {
                pauseDate = DateTime.UtcNow;
                paused = true;
                timer.Enabled = false;
            }

            changMediaType();
            setToolEnable(false);
            updateTheme();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                Pomodoro.WorkInterval = settings.nmrWork.Value;
                Pomodoro.ShortBreakInterval = settings.nmrShortBreak.Value;
                Pomodoro.LongBreakInterval = settings.nmrLongBreak.Value;
                Pomodoro.LongBreakAfter = settings.nmrLongAfter.Value;
                Pomodoro.Target = settings.nmrTarget.Value;
                Pomodoro.WorkComplatedSoundIndex = settings.cmbWorkSounds.SelectedIndex;
                Pomodoro.EndBreakSoundIndex = settings.cmbBreakSounds.SelectedIndex;
                Pomodoro.AutoStart = settings.toogleAutoStart.Toggled;
                updateTodayDesign();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FilePomodoro.WriteToday();

        }
        #endregion
        #region Timer
        private async void timer_Tick(object sender, EventArgs e)
        {
            remainingTime = endDate - DateTime.UtcNow;
            int angle = (int)(360.0 * (remainingTime.TotalSeconds / totalTime.TotalSeconds));

            if (remainingTime > TimeSpan.FromSeconds(1))
            {
                cpsBar.Text = remainingTime.ToString(@"mm\:ss");
                cpsBar.Value = angle;
                await Task.Delay(1000);
                cpsBar.AnimationSpeed = 0;
            }
            else
            {
                timer.Enabled = false;

                if (intervalType == IntervalType.Work)
                {
                    playSound(Pomodoro.WorkComplatedSoundIndex);
                    Pomodoro.ComplatedWorksCount++;
                }
                else
                {
                    playSound(Pomodoro.EndBreakSoundIndex);
                    Pomodoro.EndBreakCount++;
                    Pomodoro.TotalPomodoroCount++;
                }

                showValues();

                FilePomodoro.WriteToday();

                cpsBar.Text = done;
                changeIntervalType();
                changMediaType();
                setToolEnable(true);
                updateTheme();
                updateTodayDesign();
                cpsBar.Value = 0;
                this.WindowState = this.WindowState;


                if (Pomodoro.AutoStart == true)
                {
                    PlayPause_Click(sender, e);
                }

                //Pomodoro.WorkTime += Pomodoro.WorkInterval;
                //Pomodoro.TotalWorkTime += Pomodoro.WorkInterval;
            }
        }
        #endregion
        #region Methods
        private void updateTheme()
        {
            Bitmap image;
            if (intervalType == IntervalType.Work)
            {
                image = (mediaType == MediaType.Pause) ? Resources.pause : Resources.play;

                toolPlay.Image = Resources.play;
                toolPause.Image = Resources.pause;
                toolReset.Image = Resources.reset;

                contextPlay.Image = Resources.play;
                contextPause.Image = Resources.pause;
                contextReset.Image = Resources.reset;

                menuPlay.Image = Resources.play;
                menuPause.Image = Resources.pause;
                menuReset.Image = Resources.reset;

                cpsBar.ProgressColor = WorkColor;
                cpsBar.ForeColor = WorkColor;
                rdWork.Checked = true;
            }
            else if (intervalType == IntervalType.ShortBreak)
            {
                image = (mediaType == MediaType.Pause) ? Resources.pause2 : Resources.play2;

                toolPlay.Image = Resources.play2;
                toolPause.Image = Resources.pause2;
                toolReset.Image = Resources.reset2;

                contextPlay.Image = Resources.play2;
                contextPause.Image = Resources.pause2;
                contextReset.Image = Resources.reset2;

                menuPlay.Image = Resources.play2;
                menuPause.Image = Resources.pause2;
                menuReset.Image = Resources.reset2;

                cpsBar.ProgressColor = ShortBreakColor;
                cpsBar.ForeColor = ShortBreakColor;
                rdBreak.Checked = true;
            }
            else
            {
                image = (mediaType == MediaType.Pause) ? Resources.pause3 : Resources.play3;

                toolPlay.Image = Resources.play3;
                toolPause.Image = Resources.pause3;
                toolReset.Image = Resources.reset3;

                contextPlay.Image = Resources.play3;
                contextPause.Image = Resources.pause3;
                contextReset.Image = Resources.reset3;

                menuPlay.Image = Resources.play3;
                menuPause.Image = Resources.pause3;
                menuReset.Image = Resources.reset3;

                cpsBar.ProgressColor = LongBreakColor;
                cpsBar.ForeColor = LongBreakColor;
                rdBreak.Checked = true;
            }

            btnPlayPause.setImage(image);
        }

        private void changeIntervalType()
        {
            if (intervalType == IntervalType.Work)
            {
                if (Pomodoro.ComplatedWorksCount > 0 && (Pomodoro.ComplatedWorksCount % Pomodoro.LongBreakAfter) == 0)
                {
                    intervalType = IntervalType.LongBreak;
                }
                else
                {
                    intervalType = IntervalType.ShortBreak;
                }
            }
            else
            {
                intervalType = IntervalType.Work;
            }
        }

        private void changMediaType()
        {
            mediaType = (mediaType == MediaType.Play) ?
                MediaType.Pause : MediaType.Play;
        }

        private void updateTodayDesign()
        {
            tabToday.Controls.Clear();
            int x = 3, y = 3;
            int inc = 68;
            for (int i = 1; i <= Pomodoro.Target; i++)
            {
                GroupBox gb = new GroupBox();
                setGroupBoxProperty(gb, "Pomodoro " + i, new Point(x, y));
                if (i <= Pomodoro.EndBreakCount)
                {
                    gb.BackColor = Color.FromArgb(255, 192, 192);
                }

                Bitmap img1 = (i <= Pomodoro.ComplatedWorksCount) ? Resources.complate : Resources.cancel;
                PictureBox pc1 = new PictureBox();
                setPictureBoxProperty(pc1, img1, new Point(11, 19));
                gb.Controls.Add(pc1);

                Bitmap img2 = (i <= Pomodoro.EndBreakCount) ? Resources.complate : Resources.cancel;
                PictureBox pc2 = new PictureBox();
                setPictureBoxProperty(pc2, img2, new Point(11, 40));
                gb.Controls.Add(pc2);

                Label lbl1 = new Label();
                setLabelProperty(lbl1, "Work", new Point(32, 19), WorkColor);
                gb.Controls.Add(lbl1);

                Label lbl2 = new Label();
                string text = Pomodoro.WorkInterval.ToString("00") + ":00";
                setLabelProperty(lbl2, text, new Point(153, 19), WorkColor);
                gb.Controls.Add(lbl2);

                Label lbl3 = new Label();
                string txt1 = (i % Pomodoro.LongBreakAfter == 0) ? "Long Break" : "Short Break";
                Color color = (i % Pomodoro.LongBreakAfter == 0) ? LongBreakColor : ShortBreakColor;
                setLabelProperty(lbl3, txt1, new Point(32, 40), color);
                gb.Controls.Add(lbl3);

                Label lbl4 = new Label();
                string text2 = (i % Pomodoro.LongBreakAfter == 0) ? Pomodoro.LongBreakInterval.ToString("00") + ":00" : Pomodoro.ShortBreakInterval.ToString("00") + ":00";
                setLabelProperty(lbl4, text2, new Point(153, 40), color);
                gb.Controls.Add(lbl4);

                tabToday.Controls.Add(gb);
                y += inc;
            }
            lblToday.Text = Pomodoro.Target.ToString() + " / " + Pomodoro.EndBreakCount.ToString();
        }

        private void resetValues()
        {
            timer.Enabled = false;

            cpsBar.Text = CurrentInterval.ToString(@"mm\:ss");
            cpsBar.AnimationSpeed = 500;
            cpsBar.Value = 0;

            setToolEnable(true);
            paused = false;
            mediaType = MediaType.Play;
            updateTheme();
        }

        private void setToolEnable(bool isPlay)
        {
            toolPlay.Enabled = isPlay;
            toolPause.Enabled = !isPlay;

            contextPlay.Enabled = isPlay;
            contextPause.Enabled = !isPlay;

            menuPlay.Enabled = isPlay;
            menuPause.Enabled = !isPlay;
        }
        #endregion
        #region Control's Properties Methods
        private void setGroupBoxProperty(Control control, string text, Point point)
        {
            control.Text = text;
            control.Location = point;
            control.ForeColor = WorkColor;
            control.Size = new Size(316, 65);
            control.Anchor = (AnchorStyles)13;
            control.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void setLabelProperty(Control control, string text, Point point, Color color)
        {
            control.Text = text;
            control.ForeColor = color;
            control.Location = point;
            control.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void setPictureBoxProperty(PictureBox control, Bitmap image, Point location)
        {
            control.Size = new Size(15, 15);
            control.SizeMode = PictureBoxSizeMode.StretchImage;
            control.Image = image;
            control.Location = location;
        }
        #endregion
        #region Reset Click
        private void reset_Click(object sender, EventArgs e)
        {
            resetValues();
        }
        #endregion
        #region RadioButtons MouseClick
        private void radioButtons_MouseClick(object sender, MouseEventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if (intervalType.ToString().Contains(rd.Text)) return;

            DialogResult result = MessageBox.Show(message, messageTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                changeIntervalType();
                resetValues();
            }
            else
            {
                if (rdBreak.Checked) rdWork.Checked = true;
                else rdBreak.Checked = true;
            }
        }
        #endregion
        #region Help
        private void toolAboutPomodoro_Click(object sender, EventArgs e)
        {
            informationForm frm = new informationForm();
            frm.ShowDialog();
        }


        #endregion
        #region Language
        private void btnEn_Click(object sender, EventArgs e)
        {
            CultureInfo = "en-US";
            getRes(new CultureInfo(CultureInfo));
        }

        private void btnTr_Click(object sender, EventArgs e)
        {
            CultureInfo = "tr-TR";
            getRes(new CultureInfo(CultureInfo));
        }
        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("Pomodoro");
            ResourceManager rm = new ResourceManager("Pomodoro.Languages.lang", a);
            rdWork.Text = rm.GetString("rdWork", ci);
            rdBreak.Text = rm.GetString("rdBreak", ci);

            menu.Text = rm.GetString("menu", ci);
            menuPlay.Text = rm.GetString("play", ci);
            menuPause.Text = rm.GetString("pause", ci);
            menuReset.Text = rm.GetString("reset", ci);
            menuSettings.Text = rm.GetString("settings", ci);

            toolPlay.ToolTipText = rm.GetString("play", ci);
            toolPause.ToolTipText = rm.GetString("pause", ci);
            toolReset.ToolTipText = rm.GetString("reset", ci);
            toolSettings.ToolTipText = rm.GetString("settings", ci);

            btnEn.ToolTipText = rm.GetString("langEn", ci);
            btnTr.ToolTipText = rm.GetString("langTr", ci);
            workSet.Text = rm.GetString("workSet", ci);
            done = rm.GetString("done", ci);

            // MessageBox
            message = rm.GetString("mbMsg", ci);
            messageTitle = rm.GetString("mbTittle", ci);
        }
        #endregion
        #region Enums
        private enum IntervalType
        {
            Work,
            ShortBreak,
            LongBreak
        }
        private enum MediaType
        {
            Play,
            Pause
        }
        #endregion
    }
}
