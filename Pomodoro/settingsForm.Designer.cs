namespace Pomodoro
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.cmbWorkSounds = new System.Windows.Forms.ComboBox();
            this.cmbBreakSounds = new System.Windows.Forms.ComboBox();
            this.btnCancel = new iTalk.iTalk_Button_1();
            this.btnOK = new iTalk.iTalk_Button_1();
            this.toogleAutoStart = new iTalk.iTalk_Toggle();
            this.nmrTarget = new iTalk.iTalk_NumericUpDown();
            this.nmrLongAfter = new iTalk.iTalk_NumericUpDown();
            this.nmrLongBreak = new iTalk.iTalk_NumericUpDown();
            this.nmrShortBreak = new iTalk.iTalk_NumericUpDown();
            this.nmrWork = new iTalk.iTalk_NumericUpDown();
            this.iTalk_Label9 = new iTalk.iTalk_Label();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.lblTarget = new iTalk.iTalk_Label();
            this.lblLongAfter = new iTalk.iTalk_Label();
            this.iTalk_Label8 = new iTalk.iTalk_Label();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.lblLongBreak = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.lblShortBreak = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.lblWork = new iTalk.iTalk_Label();
            this.iTalk_Separator6 = new iTalk.iTalk_Separator();
            this.iTalk_Separator7 = new iTalk.iTalk_Separator();
            this.iTalk_Separator4 = new iTalk.iTalk_Separator();
            this.iTalk_Separator3 = new iTalk.iTalk_Separator();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.iTalk_Separator5 = new iTalk.iTalk_Separator();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.btnDefault = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // cmbWorkSounds
            // 
            this.cmbWorkSounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkSounds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbWorkSounds.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbWorkSounds.FormattingEnabled = true;
            this.cmbWorkSounds.Location = new System.Drawing.Point(200, 201);
            this.cmbWorkSounds.Name = "cmbWorkSounds";
            this.cmbWorkSounds.Size = new System.Drawing.Size(143, 23);
            this.cmbWorkSounds.TabIndex = 24;
            this.cmbWorkSounds.TabStop = false;
            this.cmbWorkSounds.SelectedIndexChanged += new System.EventHandler(this.cmbSounds_SelectedIndexChanged);
            // 
            // cmbBreakSounds
            // 
            this.cmbBreakSounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreakSounds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBreakSounds.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbBreakSounds.FormattingEnabled = true;
            this.cmbBreakSounds.Location = new System.Drawing.Point(200, 236);
            this.cmbBreakSounds.Name = "cmbBreakSounds";
            this.cmbBreakSounds.Size = new System.Drawing.Size(143, 23);
            this.cmbBreakSounds.TabIndex = 24;
            this.cmbBreakSounds.TabStop = false;
            this.cmbBreakSounds.SelectedIndexChanged += new System.EventHandler(this.cmbSounds_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Image = null;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(143, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 40);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Image = null;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(12, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 40);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // toogleAutoStart
            // 
            this.toogleAutoStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toogleAutoStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toogleAutoStart.Location = new System.Drawing.Point(302, 267);
            this.toogleAutoStart.Name = "toogleAutoStart";
            this.toogleAutoStart.Size = new System.Drawing.Size(41, 23);
            this.toogleAutoStart.TabIndex = 22;
            this.toogleAutoStart.Toggled = false;
            this.toogleAutoStart.Type = iTalk.iTalk_Toggle._Type.YesNo;
            // 
            // nmrTarget
            // 
            this.nmrTarget.BackColor = System.Drawing.Color.Transparent;
            this.nmrTarget.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.nmrTarget.ForeColor = System.Drawing.Color.Black;
            this.nmrTarget.Location = new System.Drawing.Point(273, 151);
            this.nmrTarget.Maximum = 40;
            this.nmrTarget.Minimum = 0;
            this.nmrTarget.MinimumSize = new System.Drawing.Size(62, 28);
            this.nmrTarget.Name = "nmrTarget";
            this.nmrTarget.Size = new System.Drawing.Size(70, 28);
            this.nmrTarget.TabIndex = 21;
            this.nmrTarget.Text = "iTalk_NumericUpDown1";
            this.nmrTarget.TextAlignment = iTalk.iTalk_NumericUpDown._TextAlignment.Near;
            this.nmrTarget.Value = 8;
            // 
            // nmrLongAfter
            // 
            this.nmrLongAfter.BackColor = System.Drawing.Color.Transparent;
            this.nmrLongAfter.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.nmrLongAfter.ForeColor = System.Drawing.Color.Black;
            this.nmrLongAfter.Location = new System.Drawing.Point(273, 117);
            this.nmrLongAfter.Maximum = 20;
            this.nmrLongAfter.Minimum = 0;
            this.nmrLongAfter.MinimumSize = new System.Drawing.Size(62, 28);
            this.nmrLongAfter.Name = "nmrLongAfter";
            this.nmrLongAfter.Size = new System.Drawing.Size(70, 28);
            this.nmrLongAfter.TabIndex = 21;
            this.nmrLongAfter.Text = "iTalk_NumericUpDown1";
            this.nmrLongAfter.TextAlignment = iTalk.iTalk_NumericUpDown._TextAlignment.Near;
            this.nmrLongAfter.Value = 4;
            // 
            // nmrLongBreak
            // 
            this.nmrLongBreak.BackColor = System.Drawing.Color.Transparent;
            this.nmrLongBreak.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.nmrLongBreak.ForeColor = System.Drawing.Color.Black;
            this.nmrLongBreak.Location = new System.Drawing.Point(273, 82);
            this.nmrLongBreak.Maximum = 30;
            this.nmrLongBreak.Minimum = 15;
            this.nmrLongBreak.MinimumSize = new System.Drawing.Size(62, 28);
            this.nmrLongBreak.Name = "nmrLongBreak";
            this.nmrLongBreak.Size = new System.Drawing.Size(70, 28);
            this.nmrLongBreak.TabIndex = 21;
            this.nmrLongBreak.Text = "iTalk_NumericUpDown1";
            this.nmrLongBreak.TextAlignment = iTalk.iTalk_NumericUpDown._TextAlignment.Near;
            this.nmrLongBreak.Value = 15;
            // 
            // nmrShortBreak
            // 
            this.nmrShortBreak.BackColor = System.Drawing.Color.Transparent;
            this.nmrShortBreak.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.nmrShortBreak.ForeColor = System.Drawing.Color.Black;
            this.nmrShortBreak.Location = new System.Drawing.Point(273, 47);
            this.nmrShortBreak.Maximum = 15;
            this.nmrShortBreak.Minimum = 5;
            this.nmrShortBreak.MinimumSize = new System.Drawing.Size(62, 28);
            this.nmrShortBreak.Name = "nmrShortBreak";
            this.nmrShortBreak.Size = new System.Drawing.Size(70, 28);
            this.nmrShortBreak.TabIndex = 21;
            this.nmrShortBreak.Text = "iTalk_NumericUpDown1";
            this.nmrShortBreak.TextAlignment = iTalk.iTalk_NumericUpDown._TextAlignment.Near;
            this.nmrShortBreak.Value = 5;
            // 
            // nmrWork
            // 
            this.nmrWork.BackColor = System.Drawing.Color.Transparent;
            this.nmrWork.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.nmrWork.ForeColor = System.Drawing.Color.Black;
            this.nmrWork.Location = new System.Drawing.Point(273, 12);
            this.nmrWork.Maximum = 60;
            this.nmrWork.Minimum = 25;
            this.nmrWork.MinimumSize = new System.Drawing.Size(62, 28);
            this.nmrWork.Name = "nmrWork";
            this.nmrWork.Size = new System.Drawing.Size(70, 28);
            this.nmrWork.TabIndex = 21;
            this.nmrWork.Text = "iTalk_NumericUpDown1";
            this.nmrWork.TextAlignment = iTalk.iTalk_NumericUpDown._TextAlignment.Near;
            this.nmrWork.Value = 25;
            // 
            // iTalk_Label9
            // 
            this.iTalk_Label9.AutoSize = true;
            this.iTalk_Label9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Label9.Location = new System.Drawing.Point(15, 271);
            this.iTalk_Label9.Name = "iTalk_Label9";
            this.iTalk_Label9.Size = new System.Drawing.Size(122, 19);
            this.iTalk_Label9.TabIndex = 19;
            this.iTalk_Label9.Text = "Auto-Start Timer";
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Label7.Location = new System.Drawing.Point(15, 240);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(122, 19);
            this.iTalk_Label7.TabIndex = 19;
            this.iTalk_Label7.Text = "End Break Sound";
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Label6.Location = new System.Drawing.Point(15, 205);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(174, 19);
            this.iTalk_Label6.TabIndex = 19;
            this.iTalk_Label6.Text = "Work Complated Sound ";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.BackColor = System.Drawing.Color.Transparent;
            this.lblTarget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTarget.Location = new System.Drawing.Point(15, 161);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(52, 19);
            this.lblTarget.TabIndex = 19;
            this.lblTarget.Text = "Target";
            // 
            // lblLongAfter
            // 
            this.lblLongAfter.AutoSize = true;
            this.lblLongAfter.BackColor = System.Drawing.Color.Transparent;
            this.lblLongAfter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLongAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLongAfter.Location = new System.Drawing.Point(15, 126);
            this.lblLongAfter.Name = "lblLongAfter";
            this.lblLongAfter.Size = new System.Drawing.Size(123, 19);
            this.lblLongAfter.TabIndex = 19;
            this.lblLongAfter.Text = "Long Break After";
            // 
            // iTalk_Label8
            // 
            this.iTalk_Label8.AutoSize = true;
            this.iTalk_Label8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Label8.Location = new System.Drawing.Point(349, 177);
            this.iTalk_Label8.Name = "iTalk_Label8";
            this.iTalk_Label8.Size = new System.Drawing.Size(61, 19);
            this.iTalk_Label8.TabIndex = 19;
            this.iTalk_Label8.Text = "per day";
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(349, 159);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(61, 19);
            this.iTalk_Label5.TabIndex = 19;
            this.iTalk_Label5.Text = "interval";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(349, 126);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(61, 19);
            this.iTalk_Label4.TabIndex = 19;
            this.iTalk_Label4.Text = "interval";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(349, 91);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(61, 19);
            this.iTalk_Label3.TabIndex = 19;
            this.iTalk_Label3.Text = "minutes";
            // 
            // lblLongBreak
            // 
            this.lblLongBreak.AutoSize = true;
            this.lblLongBreak.BackColor = System.Drawing.Color.Transparent;
            this.lblLongBreak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLongBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.lblLongBreak.Location = new System.Drawing.Point(15, 91);
            this.lblLongBreak.Name = "lblLongBreak";
            this.lblLongBreak.Size = new System.Drawing.Size(85, 19);
            this.lblLongBreak.TabIndex = 19;
            this.lblLongBreak.Text = "Long Break";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(186)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(349, 56);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(61, 19);
            this.iTalk_Label2.TabIndex = 19;
            this.iTalk_Label2.Text = "minutes";
            // 
            // lblShortBreak
            // 
            this.lblShortBreak.AutoSize = true;
            this.lblShortBreak.BackColor = System.Drawing.Color.Transparent;
            this.lblShortBreak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblShortBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(166)))), ((int)(((byte)(186)))));
            this.lblShortBreak.Location = new System.Drawing.Point(15, 56);
            this.lblShortBreak.Name = "lblShortBreak";
            this.lblShortBreak.Size = new System.Drawing.Size(88, 19);
            this.lblShortBreak.TabIndex = 19;
            this.lblShortBreak.Text = "Short Break";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(349, 21);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(61, 19);
            this.iTalk_Label1.TabIndex = 19;
            this.iTalk_Label1.Text = "minutes";
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.BackColor = System.Drawing.Color.Transparent;
            this.lblWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(77)))));
            this.lblWork.Location = new System.Drawing.Point(15, 21);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(102, 19);
            this.lblWork.TabIndex = 19;
            this.lblWork.Text = "Work Interval";
            // 
            // iTalk_Separator6
            // 
            this.iTalk_Separator6.Location = new System.Drawing.Point(12, 178);
            this.iTalk_Separator6.Name = "iTalk_Separator6";
            this.iTalk_Separator6.Size = new System.Drawing.Size(331, 10);
            this.iTalk_Separator6.TabIndex = 18;
            this.iTalk_Separator6.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator7
            // 
            this.iTalk_Separator7.Location = new System.Drawing.Point(12, 258);
            this.iTalk_Separator7.Name = "iTalk_Separator7";
            this.iTalk_Separator7.Size = new System.Drawing.Size(332, 10);
            this.iTalk_Separator7.TabIndex = 18;
            this.iTalk_Separator7.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator4
            // 
            this.iTalk_Separator4.Location = new System.Drawing.Point(12, 223);
            this.iTalk_Separator4.Name = "iTalk_Separator4";
            this.iTalk_Separator4.Size = new System.Drawing.Size(332, 10);
            this.iTalk_Separator4.TabIndex = 18;
            this.iTalk_Separator4.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator3
            // 
            this.iTalk_Separator3.Location = new System.Drawing.Point(12, 143);
            this.iTalk_Separator3.Name = "iTalk_Separator3";
            this.iTalk_Separator3.Size = new System.Drawing.Size(331, 10);
            this.iTalk_Separator3.TabIndex = 18;
            this.iTalk_Separator3.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.Location = new System.Drawing.Point(12, 108);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(331, 10);
            this.iTalk_Separator2.TabIndex = 18;
            this.iTalk_Separator2.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator5
            // 
            this.iTalk_Separator5.Location = new System.Drawing.Point(12, 73);
            this.iTalk_Separator5.Name = "iTalk_Separator5";
            this.iTalk_Separator5.Size = new System.Drawing.Size(331, 10);
            this.iTalk_Separator5.TabIndex = 18;
            this.iTalk_Separator5.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(15, 38);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(331, 10);
            this.iTalk_Separator1.TabIndex = 18;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnDefault.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDefault.Image = null;
            this.btnDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefault.Location = new System.Drawing.Point(274, 309);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(72, 40);
            this.btnDefault.TabIndex = 23;
            this.btnDefault.Text = "Default";
            this.btnDefault.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 359);
            this.Controls.Add(this.cmbBreakSounds);
            this.Controls.Add(this.cmbWorkSounds);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.toogleAutoStart);
            this.Controls.Add(this.nmrTarget);
            this.Controls.Add(this.nmrLongAfter);
            this.Controls.Add(this.nmrLongBreak);
            this.Controls.Add(this.nmrShortBreak);
            this.Controls.Add(this.nmrWork);
            this.Controls.Add(this.iTalk_Label9);
            this.Controls.Add(this.iTalk_Label7);
            this.Controls.Add(this.iTalk_Label6);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblLongAfter);
            this.Controls.Add(this.iTalk_Label8);
            this.Controls.Add(this.iTalk_Label5);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.lblLongBreak);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.lblShortBreak);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.iTalk_Separator6);
            this.Controls.Add(this.iTalk_Separator7);
            this.Controls.Add(this.iTalk_Separator4);
            this.Controls.Add(this.iTalk_Separator3);
            this.Controls.Add(this.iTalk_Separator2);
            this.Controls.Add(this.iTalk_Separator5);
            this.Controls.Add(this.iTalk_Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Separator iTalk_Separator1;
        private iTalk.iTalk_Separator iTalk_Separator5;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private iTalk.iTalk_Separator iTalk_Separator3;
        private iTalk.iTalk_Separator iTalk_Separator4;
        private iTalk.iTalk_Separator iTalk_Separator6;
        private iTalk.iTalk_Separator iTalk_Separator7;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Label iTalk_Label7;
        private iTalk.iTalk_Label lblLongAfter;
        private iTalk.iTalk_Label lblTarget;
        private iTalk.iTalk_Label iTalk_Label9;
        public iTalk.iTalk_NumericUpDown nmrWork;
        public iTalk.iTalk_NumericUpDown nmrShortBreak;
        public iTalk.iTalk_NumericUpDown nmrLongBreak;
        private iTalk.iTalk_Label lblWork;
        private iTalk.iTalk_Label lblShortBreak;
        private iTalk.iTalk_Label lblLongBreak;
        private iTalk.iTalk_Button_1 btnOK;
        private iTalk.iTalk_Button_1 btnCancel;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Label iTalk_Label5;
        public iTalk.iTalk_Toggle toogleAutoStart;
        public iTalk.iTalk_NumericUpDown nmrLongAfter;
        public iTalk.iTalk_NumericUpDown nmrTarget;
        public System.Windows.Forms.ComboBox cmbWorkSounds;
        public System.Windows.Forms.ComboBox cmbBreakSounds;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_Button_1 btnDefault;
    }
}