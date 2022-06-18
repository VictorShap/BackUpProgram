
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelForButtonsScheduleCopying = new System.Windows.Forms.Panel();
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
            this.PanelForButtonsScheduleCopying.SuspendLayout();
            this.GroupAutoCopying.SuspendLayout();
            this.GroupCopyingProcess.SuspendLayout();
            this.GroupScheduleCopying.SuspendLayout();
            this.GroupCurrentSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseHover += new System.EventHandler(this.PanelForButtonsScheduleCopying_MouseHover);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem1.Text = "Копирование";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuCopy_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem2.Text = "Программа";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(831, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            this.label9.TabIndex = 14;
            // 
            // PanelForButtonsScheduleCopying
            // 
            this.PanelForButtonsScheduleCopying.BackColor = System.Drawing.Color.Transparent;
            this.PanelForButtonsScheduleCopying.Controls.Add(this.GroupAutoCopying);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.GroupCopyingProcess);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.GroupScheduleCopying);
            this.PanelForButtonsScheduleCopying.Location = new System.Drawing.Point(0, 26);
            this.PanelForButtonsScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelForButtonsScheduleCopying.Name = "PanelForButtonsScheduleCopying";
            this.PanelForButtonsScheduleCopying.Size = new System.Drawing.Size(934, 371);
            this.PanelForButtonsScheduleCopying.TabIndex = 5;
            this.PanelForButtonsScheduleCopying.MouseHover += new System.EventHandler(this.PanelForButtonsScheduleCopying_MouseHover);
            // 
            // GroupAutoCopying
            // 
            this.GroupAutoCopying.Controls.Add(this.ButtonAutoCopyingApply);
            this.GroupAutoCopying.Controls.Add(this.ButtonAutoCopyingSettings);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonOnceAWeek);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonOnceInThreeDays);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonEveryDay);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonNever);
            this.GroupAutoCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAutoCopying.Location = new System.Drawing.Point(10, 250);
            this.GroupAutoCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Size = new System.Drawing.Size(503, 118);
            this.GroupAutoCopying.TabIndex = 13;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Регулярное копирование";
            this.GroupAutoCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonAutoCopyingApply
            // 
            this.ButtonAutoCopyingApply.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingApply.Location = new System.Drawing.Point(388, 77);
            this.ButtonAutoCopyingApply.Name = "ButtonAutoCopyingApply";
            this.ButtonAutoCopyingApply.Size = new System.Drawing.Size(99, 28);
            this.ButtonAutoCopyingApply.TabIndex = 4;
            this.ButtonAutoCopyingApply.Text = "Принять";
            this.ButtonAutoCopyingApply.UseVisualStyleBackColor = true;
            this.ButtonAutoCopyingApply.Click += new System.EventHandler(this.ButtonAutoCopyingApply_Click);
            this.ButtonAutoCopyingApply.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonAutoCopyingSettings
            // 
            this.ButtonAutoCopyingSettings.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingSettings.Location = new System.Drawing.Point(6, 77);
            this.ButtonAutoCopyingSettings.Name = "ButtonAutoCopyingSettings";
            this.ButtonAutoCopyingSettings.Size = new System.Drawing.Size(99, 28);
            this.ButtonAutoCopyingSettings.TabIndex = 6;
            this.ButtonAutoCopyingSettings.Text = "Настройки";
            this.ButtonAutoCopyingSettings.UseVisualStyleBackColor = true;
            this.ButtonAutoCopyingSettings.Click += new System.EventHandler(this.ButtonAutoCopyingSettings_Click);
            this.ButtonAutoCopyingSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonOnceAWeek
            // 
            this.RadioButtonOnceAWeek.AutoSize = true;
            this.RadioButtonOnceAWeek.Location = new System.Drawing.Point(267, 33);
            this.RadioButtonOnceAWeek.Name = "RadioButtonOnceAWeek";
            this.RadioButtonOnceAWeek.Size = new System.Drawing.Size(116, 23);
            this.RadioButtonOnceAWeek.TabIndex = 2;
            this.RadioButtonOnceAWeek.TabStop = true;
            this.RadioButtonOnceAWeek.Text = "Раз в неделю";
            this.RadioButtonOnceAWeek.UseVisualStyleBackColor = true;
            this.RadioButtonOnceAWeek.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonOnceInThreeDays
            // 
            this.RadioButtonOnceInThreeDays.AutoSize = true;
            this.RadioButtonOnceInThreeDays.Location = new System.Drawing.Point(135, 34);
            this.RadioButtonOnceInThreeDays.Name = "RadioButtonOnceInThreeDays";
            this.RadioButtonOnceInThreeDays.Size = new System.Drawing.Size(118, 23);
            this.RadioButtonOnceInThreeDays.TabIndex = 1;
            this.RadioButtonOnceInThreeDays.TabStop = true;
            this.RadioButtonOnceInThreeDays.Text = "Раз в три дня";
            this.RadioButtonOnceInThreeDays.UseVisualStyleBackColor = true;
            this.RadioButtonOnceInThreeDays.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonEveryDay
            // 
            this.RadioButtonEveryDay.AutoSize = true;
            this.RadioButtonEveryDay.Location = new System.Drawing.Point(6, 33);
            this.RadioButtonEveryDay.Name = "RadioButtonEveryDay";
            this.RadioButtonEveryDay.Size = new System.Drawing.Size(117, 23);
            this.RadioButtonEveryDay.TabIndex = 0;
            this.RadioButtonEveryDay.TabStop = true;
            this.RadioButtonEveryDay.Text = "Каждый день";
            this.RadioButtonEveryDay.UseVisualStyleBackColor = true;
            this.RadioButtonEveryDay.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // RadioButtonNever
            // 
            this.RadioButtonNever.AutoSize = true;
            this.RadioButtonNever.Location = new System.Drawing.Point(396, 34);
            this.RadioButtonNever.Name = "RadioButtonNever";
            this.RadioButtonNever.Size = new System.Drawing.Size(84, 23);
            this.RadioButtonNever.TabIndex = 5;
            this.RadioButtonNever.TabStop = true;
            this.RadioButtonNever.Text = "Никогда";
            this.RadioButtonNever.UseVisualStyleBackColor = true;
            this.RadioButtonNever.CheckedChanged += new System.EventHandler(this.RadioButtonNever_CheckedChanged);
            this.RadioButtonNever.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // GroupCopyingProcess
            // 
            this.GroupCopyingProcess.Controls.Add(this.LabelCopyingInProgress);
            this.GroupCopyingProcess.Controls.Add(this.ButtonCancelCopying);
            this.GroupCopyingProcess.Controls.Add(this.progressBar1);
            this.GroupCopyingProcess.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCopyingProcess.Location = new System.Drawing.Point(519, 250);
            this.GroupCopyingProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCopyingProcess.Name = "GroupCopyingProcess";
            this.GroupCopyingProcess.Size = new System.Drawing.Size(408, 118);
            this.GroupCopyingProcess.TabIndex = 8;
            this.GroupCopyingProcess.TabStop = false;
            this.GroupCopyingProcess.Text = "Процесс копирования";
            this.GroupCopyingProcess.Enter += new System.EventHandler(this.GroupCopyingProcess_Enter);
            this.GroupCopyingProcess.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelCopyingInProgress
            // 
            this.LabelCopyingInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCopyingInProgress.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelCopyingInProgress.ForeColor = System.Drawing.Color.Red;
            this.LabelCopyingInProgress.Location = new System.Drawing.Point(6, 61);
            this.LabelCopyingInProgress.Name = "LabelCopyingInProgress";
            this.LabelCopyingInProgress.Size = new System.Drawing.Size(396, 45);
            this.LabelCopyingInProgress.TabIndex = 6;
            this.LabelCopyingInProgress.Text = "На данный момент ничего не копируется";
            this.LabelCopyingInProgress.Click += new System.EventHandler(this.LabelCopyingInProgress_Click);
            // 
            // ButtonCancelCopying
            // 
            this.ButtonCancelCopying.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancelCopying.Location = new System.Drawing.Point(284, 22);
            this.ButtonCancelCopying.Name = "ButtonCancelCopying";
            this.ButtonCancelCopying.Size = new System.Drawing.Size(118, 28);
            this.ButtonCancelCopying.TabIndex = 4;
            this.ButtonCancelCopying.Text = "Отмена";
            this.ButtonCancelCopying.UseVisualStyleBackColor = true;
            this.ButtonCancelCopying.Visible = false;
            this.ButtonCancelCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 23);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 26);
            this.progressBar1.TabIndex = 5;
            // 
            // GroupScheduleCopying
            // 
            this.GroupScheduleCopying.BackColor = System.Drawing.SystemColors.Control;
            this.GroupScheduleCopying.Controls.Add(this.ListBoxScheduleCopying);
            this.GroupScheduleCopying.Controls.Add(this.ButtonAddSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonChangeSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonRemoveSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonCopyFiles);
            this.GroupScheduleCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupScheduleCopying.Location = new System.Drawing.Point(4, 0);
            this.GroupScheduleCopying.Name = "GroupScheduleCopying";
            this.GroupScheduleCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupScheduleCopying.Size = new System.Drawing.Size(509, 243);
            this.GroupScheduleCopying.TabIndex = 2;
            this.GroupScheduleCopying.TabStop = false;
            this.GroupScheduleCopying.Text = "Запланировать копирование";
            this.GroupScheduleCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxScheduleCopying
            // 
            this.ListBoxScheduleCopying.FormattingEnabled = true;
            this.ListBoxScheduleCopying.ItemHeight = 19;
            this.ListBoxScheduleCopying.Location = new System.Drawing.Point(6, 60);
            this.ListBoxScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxScheduleCopying.Name = "ListBoxScheduleCopying";
            this.ListBoxScheduleCopying.Size = new System.Drawing.Size(498, 175);
            this.ListBoxScheduleCopying.TabIndex = 3;
            this.ListBoxScheduleCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonAddSchedule
            // 
            this.ButtonAddSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddSchedule.Location = new System.Drawing.Point(29, 31);
            this.ButtonAddSchedule.Name = "ButtonAddSchedule";
            this.ButtonAddSchedule.Size = new System.Drawing.Size(99, 28);
            this.ButtonAddSchedule.TabIndex = 0;
            this.ButtonAddSchedule.Text = "Добавить";
            this.ButtonAddSchedule.UseVisualStyleBackColor = true;
            this.ButtonAddSchedule.Click += new System.EventHandler(this.button1_Click);
            this.ButtonAddSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChangeSchedule
            // 
            this.ButtonChangeSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonChangeSchedule.Location = new System.Drawing.Point(144, 31);
            this.ButtonChangeSchedule.Name = "ButtonChangeSchedule";
            this.ButtonChangeSchedule.Size = new System.Drawing.Size(99, 28);
            this.ButtonChangeSchedule.TabIndex = 1;
            this.ButtonChangeSchedule.Text = "Изменить";
            this.ButtonChangeSchedule.UseVisualStyleBackColor = true;
            this.ButtonChangeSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonRemoveSchedule
            // 
            this.ButtonRemoveSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRemoveSchedule.Location = new System.Drawing.Point(261, 31);
            this.ButtonRemoveSchedule.Name = "ButtonRemoveSchedule";
            this.ButtonRemoveSchedule.Size = new System.Drawing.Size(99, 28);
            this.ButtonRemoveSchedule.TabIndex = 2;
            this.ButtonRemoveSchedule.Text = "Удалить";
            this.ButtonRemoveSchedule.UseVisualStyleBackColor = true;
            this.ButtonRemoveSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonCopyFiles
            // 
            this.ButtonCopyFiles.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCopyFiles.Location = new System.Drawing.Point(381, 31);
            this.ButtonCopyFiles.Name = "ButtonCopyFiles";
            this.ButtonCopyFiles.Size = new System.Drawing.Size(99, 28);
            this.ButtonCopyFiles.TabIndex = 4;
            this.ButtonCopyFiles.Text = "Копировать";
            this.ButtonCopyFiles.UseVisualStyleBackColor = true;
            this.ButtonCopyFiles.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // GroupCurrentSettings
            // 
            this.GroupCurrentSettings.Controls.Add(this.ListBoxCurrentSettings);
            this.GroupCurrentSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCurrentSettings.Location = new System.Drawing.Point(519, 26);
            this.GroupCurrentSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Name = "GroupCurrentSettings";
            this.GroupCurrentSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Size = new System.Drawing.Size(408, 243);
            this.GroupCurrentSettings.TabIndex = 4;
            this.GroupCurrentSettings.TabStop = false;
            this.GroupCurrentSettings.Text = "Текущие настройки";
            this.GroupCurrentSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxCurrentSettings
            // 
            this.ListBoxCurrentSettings.FormattingEnabled = true;
            this.ListBoxCurrentSettings.HorizontalScrollbar = true;
            this.ListBoxCurrentSettings.ItemHeight = 19;
            this.ListBoxCurrentSettings.Location = new System.Drawing.Point(7, 21);
            this.ListBoxCurrentSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxCurrentSettings.Name = "ListBoxCurrentSettings";
            this.ListBoxCurrentSettings.Size = new System.Drawing.Size(395, 213);
            this.ListBoxCurrentSettings.TabIndex = 4;
            this.ListBoxCurrentSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(934, 26);
            this.LabelTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(182, 373);
            this.LabelTips.TabIndex = 29;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков - и тут отобразится подробная информация.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 400);
            this.Controls.Add(this.GroupCurrentSettings);
            this.Controls.Add(this.LabelTips);
            this.Controls.Add(this.PanelForButtonsScheduleCopying);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelForButtonsScheduleCopying.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel PanelForButtonsScheduleCopying;
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

