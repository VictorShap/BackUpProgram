
namespace WinFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.GroupAutoCopying = new System.Windows.Forms.GroupBox();
            this.ButtonAutoCopyingApply = new System.Windows.Forms.Button();
            this.ButtonAutoCopyingSettings = new System.Windows.Forms.Button();
            this.RadioButtonOnceAWeek = new System.Windows.Forms.RadioButton();
            this.RadioButtonOnceInThreeDays = new System.Windows.Forms.RadioButton();
            this.RadioButtonEveryDay = new System.Windows.Forms.RadioButton();
            this.RadioButtonNever = new System.Windows.Forms.RadioButton();
            this.GroupCopyingProcess = new System.Windows.Forms.GroupBox();
            this.LabelCopyingInProgress = new System.Windows.Forms.Label();
            this.ButtonCancelCopying = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GroupScheduleCopying = new System.Windows.Forms.GroupBox();
            this.ListBoxScheduleCopying = new System.Windows.Forms.ListBox();
            this.ButtonAddSchedule = new System.Windows.Forms.Button();
            this.ButtonChangeSchedule = new System.Windows.Forms.Button();
            this.ButtonRemoveSchedule = new System.Windows.Forms.Button();
            this.ButtonCopyFiles = new System.Windows.Forms.Button();
            this.GroupCurrentSettings = new System.Windows.Forms.GroupBox();
            this.ListBoxCurrentSettings = new System.Windows.Forms.ListBox();
            this.LabelTips = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Panel.SuspendLayout();
            this.GroupAutoCopying.SuspendLayout();
            this.GroupCopyingProcess.SuspendLayout();
            this.GroupScheduleCopying.SuspendLayout();
            this.GroupCurrentSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // настройкиToolStripMenuItem
            // 
            resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.GroupAutoCopying);
            this.Panel.Controls.Add(this.GroupCopyingProcess);
            this.Panel.Controls.Add(this.GroupScheduleCopying);
            resources.ApplyResources(this.Panel, "Panel");
            this.Panel.Name = "Panel";
            this.Panel.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // GroupAutoCopying
            // 
            this.GroupAutoCopying.Controls.Add(this.ButtonAutoCopyingApply);
            this.GroupAutoCopying.Controls.Add(this.ButtonAutoCopyingSettings);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonOnceAWeek);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonOnceInThreeDays);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonEveryDay);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonNever);
            resources.ApplyResources(this.GroupAutoCopying, "GroupAutoCopying");
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonAutoCopyingApply
            // 
            resources.ApplyResources(this.ButtonAutoCopyingApply, "ButtonAutoCopyingApply");
            this.ButtonAutoCopyingApply.Name = "ButtonAutoCopyingApply";
            this.ButtonAutoCopyingApply.UseVisualStyleBackColor = true;
            this.ButtonAutoCopyingApply.Click += new System.EventHandler(this.ButtonAutoCopyingApply_Click);
            this.ButtonAutoCopyingApply.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonAutoCopyingSettings
            // 
            resources.ApplyResources(this.ButtonAutoCopyingSettings, "ButtonAutoCopyingSettings");
            this.ButtonAutoCopyingSettings.Name = "ButtonAutoCopyingSettings";
            this.ButtonAutoCopyingSettings.UseVisualStyleBackColor = true;
            this.ButtonAutoCopyingSettings.Click += new System.EventHandler(this.ButtonAutoCopyingSettings_Click);
            this.ButtonAutoCopyingSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonOnceAWeek
            // 
            resources.ApplyResources(this.RadioButtonOnceAWeek, "RadioButtonOnceAWeek");
            this.RadioButtonOnceAWeek.Name = "RadioButtonOnceAWeek";
            this.RadioButtonOnceAWeek.TabStop = true;
            this.RadioButtonOnceAWeek.UseVisualStyleBackColor = true;
            this.RadioButtonOnceAWeek.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonOnceInThreeDays
            // 
            resources.ApplyResources(this.RadioButtonOnceInThreeDays, "RadioButtonOnceInThreeDays");
            this.RadioButtonOnceInThreeDays.Name = "RadioButtonOnceInThreeDays";
            this.RadioButtonOnceInThreeDays.TabStop = true;
            this.RadioButtonOnceInThreeDays.UseVisualStyleBackColor = true;
            this.RadioButtonOnceInThreeDays.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonEveryDay
            // 
            resources.ApplyResources(this.RadioButtonEveryDay, "RadioButtonEveryDay");
            this.RadioButtonEveryDay.Name = "RadioButtonEveryDay";
            this.RadioButtonEveryDay.TabStop = true;
            this.RadioButtonEveryDay.UseVisualStyleBackColor = true;
            this.RadioButtonEveryDay.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonNever
            // 
            resources.ApplyResources(this.RadioButtonNever, "RadioButtonNever");
            this.RadioButtonNever.Name = "RadioButtonNever";
            this.RadioButtonNever.TabStop = true;
            this.RadioButtonNever.UseVisualStyleBackColor = true;
            this.RadioButtonNever.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // GroupCopyingProcess
            // 
            this.GroupCopyingProcess.Controls.Add(this.LabelCopyingInProgress);
            this.GroupCopyingProcess.Controls.Add(this.ButtonCancelCopying);
            this.GroupCopyingProcess.Controls.Add(this.progressBar1);
            resources.ApplyResources(this.GroupCopyingProcess, "GroupCopyingProcess");
            this.GroupCopyingProcess.Name = "GroupCopyingProcess";
            this.GroupCopyingProcess.TabStop = false;
            this.GroupCopyingProcess.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelCopyingInProgress
            // 
            this.LabelCopyingInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.LabelCopyingInProgress, "LabelCopyingInProgress");
            this.LabelCopyingInProgress.ForeColor = System.Drawing.Color.Red;
            this.LabelCopyingInProgress.Name = "LabelCopyingInProgress";
            // 
            // ButtonCancelCopying
            // 
            resources.ApplyResources(this.ButtonCancelCopying, "ButtonCancelCopying");
            this.ButtonCancelCopying.Name = "ButtonCancelCopying";
            this.ButtonCancelCopying.UseVisualStyleBackColor = true;
            this.ButtonCancelCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // GroupScheduleCopying
            // 
            this.GroupScheduleCopying.BackColor = System.Drawing.SystemColors.Control;
            this.GroupScheduleCopying.Controls.Add(this.ListBoxScheduleCopying);
            this.GroupScheduleCopying.Controls.Add(this.ButtonAddSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonChangeSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonRemoveSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonCopyFiles);
            resources.ApplyResources(this.GroupScheduleCopying, "GroupScheduleCopying");
            this.GroupScheduleCopying.Name = "GroupScheduleCopying";
            this.GroupScheduleCopying.TabStop = false;
            this.GroupScheduleCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxScheduleCopying
            // 
            this.ListBoxScheduleCopying.FormattingEnabled = true;
            resources.ApplyResources(this.ListBoxScheduleCopying, "ListBoxScheduleCopying");
            this.ListBoxScheduleCopying.Name = "ListBoxScheduleCopying";
            this.ListBoxScheduleCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonAddSchedule
            // 
            resources.ApplyResources(this.ButtonAddSchedule, "ButtonAddSchedule");
            this.ButtonAddSchedule.Name = "ButtonAddSchedule";
            this.ButtonAddSchedule.UseVisualStyleBackColor = true;
            this.ButtonAddSchedule.Click += new System.EventHandler(this.ButtonAddScheduleButton1_Click);
            this.ButtonAddSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChangeSchedule
            // 
            resources.ApplyResources(this.ButtonChangeSchedule, "ButtonChangeSchedule");
            this.ButtonChangeSchedule.Name = "ButtonChangeSchedule";
            this.ButtonChangeSchedule.UseVisualStyleBackColor = true;
            this.ButtonChangeSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonRemoveSchedule
            // 
            resources.ApplyResources(this.ButtonRemoveSchedule, "ButtonRemoveSchedule");
            this.ButtonRemoveSchedule.Name = "ButtonRemoveSchedule";
            this.ButtonRemoveSchedule.UseVisualStyleBackColor = true;
            this.ButtonRemoveSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonCopyFiles
            // 
            resources.ApplyResources(this.ButtonCopyFiles, "ButtonCopyFiles");
            this.ButtonCopyFiles.Name = "ButtonCopyFiles";
            this.ButtonCopyFiles.UseVisualStyleBackColor = true;
            this.ButtonCopyFiles.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // GroupCurrentSettings
            // 
            this.GroupCurrentSettings.Controls.Add(this.ListBoxCurrentSettings);
            resources.ApplyResources(this.GroupCurrentSettings, "GroupCurrentSettings");
            this.GroupCurrentSettings.Name = "GroupCurrentSettings";
            this.GroupCurrentSettings.TabStop = false;
            this.GroupCurrentSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxCurrentSettings
            // 
            this.ListBoxCurrentSettings.FormattingEnabled = true;
            resources.ApplyResources(this.ListBoxCurrentSettings, "ListBoxCurrentSettings");
            this.ListBoxCurrentSettings.Name = "ListBoxCurrentSettings";
            this.ListBoxCurrentSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.LabelTips, "LabelTips");
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupCurrentSettings);
            this.Controls.Add(this.LabelTips);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.GroupAutoCopying.ResumeLayout(false);
            this.GroupAutoCopying.PerformLayout();
            this.GroupCopyingProcess.ResumeLayout(false);
            this.GroupScheduleCopying.ResumeLayout(false);
            this.GroupCurrentSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.GroupBox GroupCurrentSettings;
        private System.Windows.Forms.ListBox ListBoxCurrentSettings;
        private System.Windows.Forms.GroupBox GroupAutoCopying;
        private System.Windows.Forms.Button ButtonAutoCopyingSettings;
        private System.Windows.Forms.Button ButtonAutoCopyingApply;
        private System.Windows.Forms.RadioButton RadioButtonNever;
        private System.Windows.Forms.RadioButton RadioButtonOnceAWeek;
        private System.Windows.Forms.RadioButton RadioButtonOnceInThreeDays;
        private System.Windows.Forms.RadioButton RadioButtonEveryDay;
        private System.Windows.Forms.GroupBox GroupCopyingProcess;
        private System.Windows.Forms.Button ButtonCancelCopying;
        private System.Windows.Forms.Label LabelCopyingInProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox GroupScheduleCopying;
        private System.Windows.Forms.ListBox ListBoxScheduleCopying;
        private System.Windows.Forms.Button ButtonAddSchedule;
        private System.Windows.Forms.Button ButtonChangeSchedule;
        private System.Windows.Forms.Button ButtonRemoveSchedule;
        private System.Windows.Forms.Button ButtonCopyFiles;
        private System.Windows.Forms.Label LabelTips;
    }
}

