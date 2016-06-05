namespace Pomodoro
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblToday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPlayPause = new System.Windows.Forms.Panel();
            this.cpsBar = new CircularProgressBar.CircularProgressBar();
            this.rdBreak = new System.Windows.Forms.RadioButton();
            this.rdWork = new System.Windows.Forms.RadioButton();
            this.tabControl = new iTalk.iTalk_TabControl();
            this.tabToday = new System.Windows.Forms.TabPage();
            this.tabToDoList = new System.Windows.Forms.TabPage();
            this.workSet = new System.Windows.Forms.GroupBox();
            this.toolStripToDoList = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.contextPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPause = new System.Windows.Forms.ToolStripMenuItem();
            this.contextReset = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAboutPomodoro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPlay = new System.Windows.Forms.ToolStripButton();
            this.toolPause = new System.Windows.Forms.ToolStripButton();
            this.toolReset = new System.Windows.Forms.ToolStripButton();
            this.toolSettings = new System.Windows.Forms.ToolStripButton();
            this.btnTr = new System.Windows.Forms.ToolStripButton();
            this.btnEn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.mainContext.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabToDoList.SuspendLayout();
            this.workSet.SuspendLayout();
            this.toolStripToDoList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainContext
            // 
            this.mainContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextPlay,
            this.contextPause,
            this.contextReset,
            this.toolStripSeparator1,
            this.contextSettings});
            this.mainContext.Name = "contextMenuStrip1";
            resources.ApplyResources(this.mainContext, "mainContext");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPlay,
            this.menuPause,
            this.menuReset,
            this.toolStripSeparator4,
            this.menuSettings});
            this.menu.Name = "menu";
            resources.ApplyResources(this.menu, "menu");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator2,
            this.toolAboutPomodoro});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.Color.LightGray;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPlay,
            this.toolPause,
            this.toolReset,
            this.toolStripSeparator3,
            this.toolSave,
            this.toolSettings,
            this.btnTr,
            this.btnEn});
            resources.ApplyResources(this.toolStripMain, "toolStripMain");
            this.toolStripMain.Name = "toolStripMain";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // lblToday
            // 
            resources.ApplyResources(this.lblToday, "lblToday");
            this.lblToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.lblToday.Name = "lblToday";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.label1.Name = "label1";
            // 
            // panelPlayPause
            // 
            resources.ApplyResources(this.panelPlayPause, "panelPlayPause");
            this.panelPlayPause.Name = "panelPlayPause";
            // 
            // cpsBar
            // 
            resources.ApplyResources(this.cpsBar, "cpsBar");
            this.cpsBar.AnimationFunction = ((WinFormAnimation.Functions.Function)(resources.GetObject("cpsBar.AnimationFunction")));
            this.cpsBar.AnimationSpeed = 500;
            this.cpsBar.BackColor = System.Drawing.SystemColors.Control;
            this.cpsBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.cpsBar.InnerColor = System.Drawing.SystemColors.Control;
            this.cpsBar.InnerMargin = 0;
            this.cpsBar.InnerWidth = -1;
            this.cpsBar.MarqueeAnimationSpeed = 2000;
            this.cpsBar.Maximum = 360;
            this.cpsBar.Name = "cpsBar";
            this.cpsBar.OuterColor = System.Drawing.Color.Silver;
            this.cpsBar.OuterMargin = -10;
            this.cpsBar.OuterWidth = 10;
            this.cpsBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.cpsBar.ProgressWidth = 10;
            this.cpsBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpsBar.StartAngle = 270;
            this.cpsBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpsBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpsBar.SubscriptText = "";
            this.cpsBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpsBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpsBar.SuperscriptText = "";
            this.cpsBar.TextMargin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.cpsBar.Value = 1;
            // 
            // rdBreak
            // 
            resources.ApplyResources(this.rdBreak, "rdBreak");
            this.rdBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(186)))));
            this.rdBreak.Name = "rdBreak";
            this.rdBreak.UseVisualStyleBackColor = true;
            this.rdBreak.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtons_MouseClick);
            // 
            // rdWork
            // 
            resources.ApplyResources(this.rdWork, "rdWork");
            this.rdWork.Checked = true;
            this.rdWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.rdWork.Name = "rdWork";
            this.rdWork.TabStop = true;
            this.rdWork.UseVisualStyleBackColor = true;
            this.rdWork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtons_MouseClick);
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabToday);
            this.tabControl.Controls.Add(this.tabToDoList);
            this.tabControl.Controls.Add(this.tabCharts);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabToday
            // 
            resources.ApplyResources(this.tabToday, "tabToday");
            this.tabToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabToday.Name = "tabToday";
            // 
            // tabToDoList
            // 
            this.tabToDoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabToDoList.Controls.Add(this.workSet);
            resources.ApplyResources(this.tabToDoList, "tabToDoList");
            this.tabToDoList.Name = "tabToDoList";
            // 
            // workSet
            // 
            this.workSet.BackColor = System.Drawing.Color.White;
            this.workSet.Controls.Add(this.toolStripToDoList);
            this.workSet.Controls.Add(this.panel2);
            this.workSet.Controls.Add(this.panel1);
            resources.ApplyResources(this.workSet, "workSet");
            this.workSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.workSet.Name = "workSet";
            this.workSet.TabStop = false;
            // 
            // toolStripToDoList
            // 
            this.toolStripToDoList.BackColor = System.Drawing.Color.LightGray;
            this.toolStripToDoList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            resources.ApplyResources(this.toolStripToDoList, "toolStripToDoList");
            this.toolStripToDoList.Name = "toolStripToDoList";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Name = "panel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabCharts
            // 
            this.tabCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            resources.ApplyResources(this.tabCharts, "tabCharts");
            this.tabCharts.Name = "tabCharts";
            // 
            // contextPlay
            // 
            this.contextPlay.Image = global::Pomodoro.Properties.Resources.play;
            this.contextPlay.Name = "contextPlay";
            resources.ApplyResources(this.contextPlay, "contextPlay");
            this.contextPlay.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // contextPause
            // 
            resources.ApplyResources(this.contextPause, "contextPause");
            this.contextPause.Image = global::Pomodoro.Properties.Resources.pause;
            this.contextPause.Name = "contextPause";
            this.contextPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // contextReset
            // 
            this.contextReset.Image = global::Pomodoro.Properties.Resources.reset;
            this.contextReset.Name = "contextReset";
            resources.ApplyResources(this.contextReset, "contextReset");
            this.contextReset.Click += new System.EventHandler(this.reset_Click);
            // 
            // contextSettings
            // 
            this.contextSettings.Image = global::Pomodoro.Properties.Resources.settingsico;
            this.contextSettings.Name = "contextSettings";
            resources.ApplyResources(this.contextSettings, "contextSettings");
            this.contextSettings.Click += new System.EventHandler(this.settings_Click);
            // 
            // menuPlay
            // 
            this.menuPlay.Image = global::Pomodoro.Properties.Resources.play;
            this.menuPlay.Name = "menuPlay";
            resources.ApplyResources(this.menuPlay, "menuPlay");
            this.menuPlay.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // menuPause
            // 
            resources.ApplyResources(this.menuPause, "menuPause");
            this.menuPause.Image = global::Pomodoro.Properties.Resources.pause;
            this.menuPause.Name = "menuPause";
            this.menuPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // menuReset
            // 
            this.menuReset.Image = global::Pomodoro.Properties.Resources.reset;
            this.menuReset.Name = "menuReset";
            resources.ApplyResources(this.menuReset, "menuReset");
            this.menuReset.Click += new System.EventHandler(this.reset_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.Image = global::Pomodoro.Properties.Resources.settingsico;
            this.menuSettings.Name = "menuSettings";
            resources.ApplyResources(this.menuSettings, "menuSettings");
            this.menuSettings.Click += new System.EventHandler(this.settings_Click);
            // 
            // toolAboutPomodoro
            // 
            this.toolAboutPomodoro.Image = global::Pomodoro.Properties.Resources.pomodoro;
            this.toolAboutPomodoro.Name = "toolAboutPomodoro";
            resources.ApplyResources(this.toolAboutPomodoro, "toolAboutPomodoro");
            this.toolAboutPomodoro.Click += new System.EventHandler(this.toolAboutPomodoro_Click);
            // 
            // toolPlay
            // 
            resources.ApplyResources(this.toolPlay, "toolPlay");
            this.toolPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPlay.Image = global::Pomodoro.Properties.Resources.play;
            this.toolPlay.Name = "toolPlay";
            this.toolPlay.Tag = "";
            this.toolPlay.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // toolPause
            // 
            this.toolPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolPause, "toolPause");
            this.toolPause.Image = global::Pomodoro.Properties.Resources.pause;
            this.toolPause.Name = "toolPause";
            this.toolPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // toolReset
            // 
            this.toolReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolReset.Image = global::Pomodoro.Properties.Resources.reset;
            this.toolReset.Name = "toolReset";
            resources.ApplyResources(this.toolReset, "toolReset");
            this.toolReset.Click += new System.EventHandler(this.reset_Click);
            // 
            // toolSettings
            // 
            this.toolSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSettings.Image = global::Pomodoro.Properties.Resources.settingsico;
            this.toolSettings.Name = "toolSettings";
            resources.ApplyResources(this.toolSettings, "toolSettings");
            this.toolSettings.Click += new System.EventHandler(this.settings_Click);
            // 
            // btnTr
            // 
            this.btnTr.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTr.Image = global::Pomodoro.Properties.Resources.tr;
            resources.ApplyResources(this.btnTr, "btnTr");
            this.btnTr.Name = "btnTr";
            this.btnTr.Click += new System.EventHandler(this.btnTr_Click);
            // 
            // btnEn
            // 
            this.btnEn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEn.Image = global::Pomodoro.Properties.Resources.en;
            resources.ApplyResources(this.btnEn, "btnEn");
            this.btnEn.Name = "btnEn";
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Pomodoro.Properties.Resources.complate;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Pomodoro.Properties.Resources.cancel;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Pomodoro.Properties.Resources.reset;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pomodoro.Properties.Resources.cancel;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pomodoro.Properties.Resources.complate;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::Pomodoro.Properties.Resources.save;
            resources.ApplyResources(this.toolSave, "toolSave");
            this.toolSave.Name = "toolSave";
            this.toolSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.mainContext;
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPlayPause);
            this.Controls.Add(this.cpsBar);
            this.Controls.Add(this.rdBreak);
            this.Controls.Add(this.rdWork);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainContext.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabToDoList.ResumeLayout(false);
            this.workSet.ResumeLayout(false);
            this.workSet.PerformLayout();
            this.toolStripToDoList.ResumeLayout(false);
            this.toolStripToDoList.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip mainContext;
        private System.Windows.Forms.ToolStripMenuItem contextPlay;
        private System.Windows.Forms.ToolStripMenuItem contextPause;
        private System.Windows.Forms.ToolStripMenuItem contextSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextReset;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolReset;
        private System.Windows.Forms.ToolStripButton toolPlay;
        private System.Windows.Forms.ToolStripButton toolPause;
        private System.Windows.Forms.ToolStripButton toolSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem menuPlay;
        private System.Windows.Forms.ToolStripMenuItem menuPause;
        private System.Windows.Forms.ToolStripMenuItem menuReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripButton btnTr;
        private System.Windows.Forms.ToolStripButton btnEn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolAboutPomodoro;
        private iTalk.iTalk_TabControl tabControl;
        private System.Windows.Forms.TabPage tabToday;
        private System.Windows.Forms.TabPage tabToDoList;
        private System.Windows.Forms.GroupBox workSet;
        private System.Windows.Forms.ToolStrip toolStripToDoList;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage tabCharts;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPlayPause;
        private CircularProgressBar.CircularProgressBar cpsBar;
        private System.Windows.Forms.RadioButton rdBreak;
        private System.Windows.Forms.RadioButton rdWork;
        private System.Windows.Forms.ToolStripButton toolSave;
    }
}

