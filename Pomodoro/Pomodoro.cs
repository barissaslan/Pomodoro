
using Pomodoro.Properties;

namespace Pomodoro
{
    class Pomodoro
    {

        #region Settings

        public static int WorkInterval
        {
            get { return Settings.Default.WorkInterval; }
            set
            {
                Settings.Default.WorkInterval = value;
                Settings.Default.Save();
            }
        }

        public static int ShortBreakInterval
        {
            get { return Settings.Default.ShortBreakInterval; }
            set
            {
                Settings.Default.ShortBreakInterval = value;
                Settings.Default.Save();
            }
        }

        public static int LongBreakInterval
        {
            get { return Settings.Default.LongBreakInterval; }
            set
            {
                Settings.Default.LongBreakInterval = value;
                Settings.Default.Save();
            }
        }

        public static int LongBreakAfter
        {
            get { return Settings.Default.LongBreakAfter; }
            set
            {
                Settings.Default.LongBreakAfter = value;
                Settings.Default.Save();
            }
        }

        public static int Target
        {
            get { return Settings.Default.Target; }
            set
            {
                Settings.Default.Target = value;
                Settings.Default.Save();
            }
        }

        public static int WorkComplatedSoundIndex
        {
            get { return Settings.Default.WorkComplatedSoundIndex; }
            set
            {
                Settings.Default.WorkComplatedSoundIndex = value;
                Settings.Default.Save();
            }
        }

        public static int EndBreakSoundIndex
        {
            get { return Settings.Default.EndBreakSoundIndex; }
            set
            {
                Settings.Default.EndBreakSoundIndex = value;
                Settings.Default.Save();
            }
        }

        public static bool AutoStart
        {
            get { return Settings.Default.AutoStart; }
            set
            {
                Settings.Default.AutoStart = value;
                Settings.Default.Save();
            }
        }

        #endregion

        #region Temprary Values
        public static int ComplatedWorksCount
        {
            get { return Settings.Default.ComplatedWorksCount; }
            set
            {
                Settings.Default.ComplatedWorksCount = value;
                Settings.Default.Save();
            }
        }

        public static int EndBreakCount
        {
            get { return Settings.Default.EndBreakCount; }
            set
            {
                Settings.Default.EndBreakCount = value;
                Settings.Default.Save();
            }
        }
        #endregion

        #region Recording Values
        public static int TotalPomodoroCount
        {
            get { return Settings.Default.TotalPomodoroCount; }
            set
            {
                Settings.Default.TotalPomodoroCount = value;
                Settings.Default.Save();
            }
        }

        private static int totalWorkTime;
        public static int TotalWorkTime
        {
            get { return totalWorkTime; }
            set { totalWorkTime = value; }
        }

        private static int totalBreakTime;
        public static int TotalBreakTime
        {
            get { return totalBreakTime; }
            set { totalBreakTime = value; }
        }
        #endregion
    }
}
