using System;
using System.IO;

namespace Pomodoro
{
    class FilePomodoro
    {

        #region Properties
        private static string DocumentPath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); }
        }

        private static string FileDirectory
        {
            get { return DocumentPath + @"\Pomodoro\Files"; }
        }

        public static string TodayDate
        {
            get { return DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString("00") + "-" + DateTime.Now.Day.ToString("00"); }
        }
        #endregion

        #region Methods
        public static void CheckFiles()
        {
            if (!Directory.Exists(FileDirectory))
            {
                Directory.CreateDirectory(FileDirectory);
            }
        }

        public static void WriteToday()
        {
            StreamWriter writer = new StreamWriter(Path.Combine(FileDirectory, TodayDate));
            string data = Pomodoro.WorkInterval.ToString() + " - " + Pomodoro.ShortBreakInterval.ToString() + " - " + Pomodoro.LongBreakInterval.ToString() + " - " + Pomodoro.LongBreakAfter.ToString() + " - " + Pomodoro.Target.ToString()+ " - " + Pomodoro.ComplatedWorksCount.ToString() + " - " + Pomodoro.EndBreakCount.ToString();
            writer.WriteLine(data);
            writer.Close();
        }

        public static string read(string fileName)
        {
            StreamReader reader = new StreamReader(@"Files\" + fileName);
            string line;
            while ((line = reader.ReadLine()) != null)
            {

            }
            return "";
        }
        #endregion
    }
}
