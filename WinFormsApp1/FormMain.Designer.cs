﻿
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
            this.GroupScheduleCopying = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListBoxScheduleCopying = new System.Windows.Forms.ListBox();
            this.ButtonRemoveSchedule = new System.Windows.Forms.Button();
            this.ButtonChangeSchedule = new System.Windows.Forms.Button();
            this.ButtonAddSchedule = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GroupCurrentSettings = new System.Windows.Forms.GroupBox();
            this.ListBoxCurrentSettings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTips = new System.Windows.Forms.Label();
            this.LabelCopyingInProgress = new System.Windows.Forms.Label();
            this.GroupCopyingProcess = new System.Windows.Forms.GroupBox();
            this.ButtonCancelCopying = new System.Windows.Forms.Button();
            this.GroupAutoCopying = new System.Windows.Forms.GroupBox();
            this.ButtonAutoCopyingSettings = new System.Windows.Forms.Button();
            this.ButtonAutoCopyingApply = new System.Windows.Forms.Button();
            this.RadioButtonNever = new System.Windows.Forms.RadioButton();
            this.RadioButtonOnceAWeek = new System.Windows.Forms.RadioButton();
            this.RadioButtonOnceInThreeDays = new System.Windows.Forms.RadioButton();
            this.RadioButtonEveryDay = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GroupScheduleCopying.SuspendLayout();
            this.GroupCurrentSettings.SuspendLayout();
            this.GroupCopyingProcess.SuspendLayout();
            this.GroupAutoCopying.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(713, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // GroupScheduleCopying
            // 
            this.GroupScheduleCopying.BackColor = System.Drawing.SystemColors.Control;
            this.GroupScheduleCopying.Controls.Add(this.button1);
            this.GroupScheduleCopying.Controls.Add(this.ListBoxScheduleCopying);
            this.GroupScheduleCopying.Controls.Add(this.ButtonRemoveSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonChangeSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonAddSchedule);
            this.GroupScheduleCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupScheduleCopying.Location = new System.Drawing.Point(12, 30);
            this.GroupScheduleCopying.Name = "GroupScheduleCopying";
            this.GroupScheduleCopying.Size = new System.Drawing.Size(444, 205);
            this.GroupScheduleCopying.TabIndex = 2;
            this.GroupScheduleCopying.TabStop = false;
            this.GroupScheduleCopying.Text = "Запланировать копирование";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(337, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Копировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListBoxScheduleCopying
            // 
            this.ListBoxScheduleCopying.FormattingEnabled = true;
            this.ListBoxScheduleCopying.ItemHeight = 19;
            this.ListBoxScheduleCopying.Location = new System.Drawing.Point(6, 56);
            this.ListBoxScheduleCopying.Name = "ListBoxScheduleCopying";
            this.ListBoxScheduleCopying.Size = new System.Drawing.Size(434, 137);
            this.ListBoxScheduleCopying.TabIndex = 3;
            // 
            // ButtonRemoveSchedule
            // 
            this.ButtonRemoveSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRemoveSchedule.Location = new System.Drawing.Point(228, 22);
            this.ButtonRemoveSchedule.Name = "ButtonRemoveSchedule";
            this.ButtonRemoveSchedule.Size = new System.Drawing.Size(99, 28);
            this.ButtonRemoveSchedule.TabIndex = 2;
            this.ButtonRemoveSchedule.Text = "Удалить";
            this.ButtonRemoveSchedule.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeSchedule
            // 
            this.ButtonChangeSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonChangeSchedule.Location = new System.Drawing.Point(118, 23);
            this.ButtonChangeSchedule.Name = "ButtonChangeSchedule";
            this.ButtonChangeSchedule.Size = new System.Drawing.Size(99, 28);
            this.ButtonChangeSchedule.TabIndex = 1;
            this.ButtonChangeSchedule.Text = "Изменить";
            this.ButtonChangeSchedule.UseVisualStyleBackColor = true;
            // 
            // ButtonAddSchedule
            // 
            this.ButtonAddSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddSchedule.Location = new System.Drawing.Point(8, 23);
            this.ButtonAddSchedule.Name = "ButtonAddSchedule";
            this.ButtonAddSchedule.Size = new System.Drawing.Size(99, 28);
            this.ButtonAddSchedule.TabIndex = 0;
            this.ButtonAddSchedule.Text = "Добавить";
            this.ButtonAddSchedule.UseVisualStyleBackColor = true;
            this.ButtonAddSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(199, 26);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // GroupCurrentSettings
            // 
            this.GroupCurrentSettings.Controls.Add(this.ListBoxCurrentSettings);
            this.GroupCurrentSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCurrentSettings.Location = new System.Drawing.Point(348, 252);
            this.GroupCurrentSettings.Name = "GroupCurrentSettings";
            this.GroupCurrentSettings.Size = new System.Drawing.Size(357, 235);
            this.GroupCurrentSettings.TabIndex = 4;
            this.GroupCurrentSettings.TabStop = false;
            this.GroupCurrentSettings.Text = "Текущие настройки";
            // 
            // ListBoxCurrentSettings
            // 
            this.ListBoxCurrentSettings.FormattingEnabled = true;
            this.ListBoxCurrentSettings.HorizontalScrollbar = true;
            this.ListBoxCurrentSettings.ItemHeight = 19;
            this.ListBoxCurrentSettings.Location = new System.Drawing.Point(6, 20);
            this.ListBoxCurrentSettings.Name = "ListBoxCurrentSettings";
            this.ListBoxCurrentSettings.Size = new System.Drawing.Size(339, 213);
            this.ListBoxCurrentSettings.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 2);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(714, 2);
            this.label2.TabIndex = 5;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(478, 30);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(227, 205);
            this.LabelTips.TabIndex = 6;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
            // 
            // LabelCopyingInProgress
            // 
            this.LabelCopyingInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCopyingInProgress.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelCopyingInProgress.ForeColor = System.Drawing.Color.Red;
            this.LabelCopyingInProgress.Location = new System.Drawing.Point(6, 82);
            this.LabelCopyingInProgress.Name = "LabelCopyingInProgress";
            this.LabelCopyingInProgress.Size = new System.Drawing.Size(301, 23);
            this.LabelCopyingInProgress.TabIndex = 6;
            this.LabelCopyingInProgress.Text = "Идёт копирование, дождитесь окончания";
            this.LabelCopyingInProgress.Visible = false;
            // 
            // GroupCopyingProcess
            // 
            this.GroupCopyingProcess.Controls.Add(this.ButtonCancelCopying);
            this.GroupCopyingProcess.Controls.Add(this.LabelCopyingInProgress);
            this.GroupCopyingProcess.Controls.Add(this.progressBar1);
            this.GroupCopyingProcess.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCopyingProcess.Location = new System.Drawing.Point(13, 379);
            this.GroupCopyingProcess.Name = "GroupCopyingProcess";
            this.GroupCopyingProcess.Size = new System.Drawing.Size(313, 108);
            this.GroupCopyingProcess.TabIndex = 8;
            this.GroupCopyingProcess.TabStop = false;
            this.GroupCopyingProcess.Text = "Процесс копирования";
            // 
            // ButtonCancelCopying
            // 
            this.ButtonCancelCopying.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancelCopying.Location = new System.Drawing.Point(207, 41);
            this.ButtonCancelCopying.Name = "ButtonCancelCopying";
            this.ButtonCancelCopying.Size = new System.Drawing.Size(99, 28);
            this.ButtonCancelCopying.TabIndex = 4;
            this.ButtonCancelCopying.Text = "Отмена";
            this.ButtonCancelCopying.UseVisualStyleBackColor = true;
            this.ButtonCancelCopying.Visible = false;
            // 
            // GroupAutoCopying
            // 
            this.GroupAutoCopying.Controls.Add(this.ButtonAutoCopyingSettings);
            this.GroupAutoCopying.Controls.Add(this.ButtonAutoCopyingApply);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonNever);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonOnceAWeek);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonOnceInThreeDays);
            this.GroupAutoCopying.Controls.Add(this.RadioButtonEveryDay);
            this.GroupAutoCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAutoCopying.Location = new System.Drawing.Point(18, 252);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Size = new System.Drawing.Size(302, 121);
            this.GroupAutoCopying.TabIndex = 13;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Автоматическое копирование";
            // 
            // ButtonAutoCopyingSettings
            // 
            this.ButtonAutoCopyingSettings.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingSettings.Location = new System.Drawing.Point(7, 81);
            this.ButtonAutoCopyingSettings.Name = "ButtonAutoCopyingSettings";
            this.ButtonAutoCopyingSettings.Size = new System.Drawing.Size(99, 28);
            this.ButtonAutoCopyingSettings.TabIndex = 6;
            this.ButtonAutoCopyingSettings.Text = "Настройки";
            this.ButtonAutoCopyingSettings.UseVisualStyleBackColor = true;
            // 
            // ButtonAutoCopyingApply
            // 
            this.ButtonAutoCopyingApply.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingApply.Location = new System.Drawing.Point(169, 81);
            this.ButtonAutoCopyingApply.Name = "ButtonAutoCopyingApply";
            this.ButtonAutoCopyingApply.Size = new System.Drawing.Size(99, 28);
            this.ButtonAutoCopyingApply.TabIndex = 4;
            this.ButtonAutoCopyingApply.Text = "Принять";
            this.ButtonAutoCopyingApply.UseVisualStyleBackColor = true;
            this.ButtonAutoCopyingApply.Click += new System.EventHandler(this.button7_Click);
            // 
            // RadioButtonNever
            // 
            this.RadioButtonNever.AutoSize = true;
            this.RadioButtonNever.Location = new System.Drawing.Point(169, 52);
            this.RadioButtonNever.Name = "RadioButtonNever";
            this.RadioButtonNever.Size = new System.Drawing.Size(84, 23);
            this.RadioButtonNever.TabIndex = 5;
            this.RadioButtonNever.TabStop = true;
            this.RadioButtonNever.Text = "Никогда";
            this.RadioButtonNever.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOnceAWeek
            // 
            this.RadioButtonOnceAWeek.AutoSize = true;
            this.RadioButtonOnceAWeek.Location = new System.Drawing.Point(7, 52);
            this.RadioButtonOnceAWeek.Name = "RadioButtonOnceAWeek";
            this.RadioButtonOnceAWeek.Size = new System.Drawing.Size(116, 23);
            this.RadioButtonOnceAWeek.TabIndex = 2;
            this.RadioButtonOnceAWeek.TabStop = true;
            this.RadioButtonOnceAWeek.Text = "Раз в неделю";
            this.RadioButtonOnceAWeek.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOnceInThreeDays
            // 
            this.RadioButtonOnceInThreeDays.AutoSize = true;
            this.RadioButtonOnceInThreeDays.Location = new System.Drawing.Point(169, 23);
            this.RadioButtonOnceInThreeDays.Name = "RadioButtonOnceInThreeDays";
            this.RadioButtonOnceInThreeDays.Size = new System.Drawing.Size(118, 23);
            this.RadioButtonOnceInThreeDays.TabIndex = 1;
            this.RadioButtonOnceInThreeDays.TabStop = true;
            this.RadioButtonOnceInThreeDays.Text = "Раз в три дня";
            this.RadioButtonOnceInThreeDays.UseVisualStyleBackColor = true;
            // 
            // RadioButtonEveryDay
            // 
            this.RadioButtonEveryDay.AutoSize = true;
            this.RadioButtonEveryDay.Location = new System.Drawing.Point(6, 23);
            this.RadioButtonEveryDay.Name = "RadioButtonEveryDay";
            this.RadioButtonEveryDay.Size = new System.Drawing.Size(117, 23);
            this.RadioButtonEveryDay.TabIndex = 0;
            this.RadioButtonEveryDay.TabStop = true;
            this.RadioButtonEveryDay.Text = "Каждый день";
            this.RadioButtonEveryDay.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(831, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            this.label9.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(462, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 212);
            this.label3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(332, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 244);
            this.label6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(340, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 244);
            this.label7.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(470, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 212);
            this.label4.TabIndex = 20;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 489);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GroupAutoCopying);
            this.Controls.Add(this.GroupCopyingProcess);
            this.Controls.Add(this.LabelTips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupCurrentSettings);
            this.Controls.Add(this.GroupScheduleCopying);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupScheduleCopying.ResumeLayout(false);
            this.GroupCurrentSettings.ResumeLayout(false);
            this.GroupCopyingProcess.ResumeLayout(false);
            this.GroupAutoCopying.ResumeLayout(false);
            this.GroupAutoCopying.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupScheduleCopying;
        private System.Windows.Forms.ListBox ListBoxScheduleCopying;
        private System.Windows.Forms.Button ButtonRemoveSchedule;
        private System.Windows.Forms.Button ButtonChangeSchedule;
        private System.Windows.Forms.Button ButtonAddSchedule;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox GroupCurrentSettings;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBoxCurrentSettings;
        private System.Windows.Forms.Label LabelTips;
        private System.Windows.Forms.Label LabelCopyingInProgress;
        private System.Windows.Forms.GroupBox GroupCopyingProcess;
        private System.Windows.Forms.Button ButtonCancelCopying;
        private System.Windows.Forms.GroupBox GroupAutoCopying;
        private System.Windows.Forms.RadioButton RadioButtonOnceAWeek;
        private System.Windows.Forms.RadioButton RadioButtonOnceInThreeDays;
        private System.Windows.Forms.RadioButton RadioButtonEveryDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonAutoCopyingApply;
        private System.Windows.Forms.RadioButton RadioButtonNever;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button ButtonAutoCopyingSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

