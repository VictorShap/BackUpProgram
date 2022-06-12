
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
            this.ButtonCopyFiles = new System.Windows.Forms.Button();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(815, 34);
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
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 28);
            this.toolStripMenuItem1.Text = "Копирование";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuCopy_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 28);
            this.toolStripMenuItem2.Text = "Программа";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // GroupScheduleCopying
            // 
            this.GroupScheduleCopying.BackColor = System.Drawing.SystemColors.Control;
            this.GroupScheduleCopying.Controls.Add(this.ButtonCopyFiles);
            this.GroupScheduleCopying.Controls.Add(this.ListBoxScheduleCopying);
            this.GroupScheduleCopying.Controls.Add(this.ButtonRemoveSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonChangeSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonAddSchedule);
            this.GroupScheduleCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupScheduleCopying.Location = new System.Drawing.Point(14, 40);
            this.GroupScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupScheduleCopying.Name = "GroupScheduleCopying";
            this.GroupScheduleCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupScheduleCopying.Size = new System.Drawing.Size(508, 199);
            this.GroupScheduleCopying.TabIndex = 2;
            this.GroupScheduleCopying.TabStop = false;
            this.GroupScheduleCopying.Text = "Запланировать копирование";
            // 
            // ButtonCopyFiles
            // 
            this.ButtonCopyFiles.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCopyFiles.Location = new System.Drawing.Point(373, 25);
            this.ButtonCopyFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCopyFiles.Name = "ButtonCopyFiles";
            this.ButtonCopyFiles.Size = new System.Drawing.Size(113, 37);
            this.ButtonCopyFiles.TabIndex = 4;
            this.ButtonCopyFiles.Text = "Копировать";
            this.ButtonCopyFiles.UseVisualStyleBackColor = true;
            this.ButtonCopyFiles.MouseLeave += new System.EventHandler(this.ButtonAddSchedule_MouseLeave);
            this.ButtonCopyFiles.MouseHover += new System.EventHandler(this.ButtonAddSchedule_MouseHover);
            // 
            // ListBoxScheduleCopying
            // 
            this.ListBoxScheduleCopying.FormattingEnabled = true;
            this.ListBoxScheduleCopying.ItemHeight = 23;
            this.ListBoxScheduleCopying.Location = new System.Drawing.Point(7, 80);
            this.ListBoxScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxScheduleCopying.Name = "ListBoxScheduleCopying";
            this.ListBoxScheduleCopying.Size = new System.Drawing.Size(495, 119);
            this.ListBoxScheduleCopying.TabIndex = 3;
            // 
            // ButtonRemoveSchedule
            // 
            this.ButtonRemoveSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRemoveSchedule.Location = new System.Drawing.Point(254, 25);
            this.ButtonRemoveSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonRemoveSchedule.Name = "ButtonRemoveSchedule";
            this.ButtonRemoveSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonRemoveSchedule.TabIndex = 2;
            this.ButtonRemoveSchedule.Text = "Удалить";
            this.ButtonRemoveSchedule.UseVisualStyleBackColor = true;
            this.ButtonRemoveSchedule.MouseLeave += new System.EventHandler(this.ButtonAddSchedule_MouseLeave);
            this.ButtonRemoveSchedule.MouseHover += new System.EventHandler(this.ButtonAddSchedule_MouseHover);
            // 
            // ButtonChangeSchedule
            // 
            this.ButtonChangeSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonChangeSchedule.Location = new System.Drawing.Point(135, 25);
            this.ButtonChangeSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChangeSchedule.Name = "ButtonChangeSchedule";
            this.ButtonChangeSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonChangeSchedule.TabIndex = 1;
            this.ButtonChangeSchedule.Text = "Изменить";
            this.ButtonChangeSchedule.UseVisualStyleBackColor = true;
            this.ButtonChangeSchedule.MouseLeave += new System.EventHandler(this.ButtonAddSchedule_MouseLeave);
            this.ButtonChangeSchedule.MouseHover += new System.EventHandler(this.ButtonAddSchedule_MouseHover);
            // 
            // ButtonAddSchedule
            // 
            this.ButtonAddSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddSchedule.Location = new System.Drawing.Point(16, 25);
            this.ButtonAddSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddSchedule.Name = "ButtonAddSchedule";
            this.ButtonAddSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonAddSchedule.TabIndex = 0;
            this.ButtonAddSchedule.Text = "Добавить";
            this.ButtonAddSchedule.UseVisualStyleBackColor = true;
            this.ButtonAddSchedule.Click += new System.EventHandler(this.button1_Click);
            this.ButtonAddSchedule.MouseLeave += new System.EventHandler(this.ButtonAddSchedule_MouseLeave);
            this.ButtonAddSchedule.MouseHover += new System.EventHandler(this.ButtonAddSchedule_MouseHover);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 57);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(227, 35);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // GroupCurrentSettings
            // 
            this.GroupCurrentSettings.Controls.Add(this.ListBoxCurrentSettings);
            this.GroupCurrentSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCurrentSettings.Location = new System.Drawing.Point(398, 260);
            this.GroupCurrentSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Name = "GroupCurrentSettings";
            this.GroupCurrentSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Size = new System.Drawing.Size(408, 313);
            this.GroupCurrentSettings.TabIndex = 4;
            this.GroupCurrentSettings.TabStop = false;
            this.GroupCurrentSettings.Text = "Текущие настройки";
            // 
            // ListBoxCurrentSettings
            // 
            this.ListBoxCurrentSettings.FormattingEnabled = true;
            this.ListBoxCurrentSettings.HorizontalScrollbar = true;
            this.ListBoxCurrentSettings.ItemHeight = 23;
            this.ListBoxCurrentSettings.Location = new System.Drawing.Point(7, 27);
            this.ListBoxCurrentSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxCurrentSettings.Name = "ListBoxCurrentSettings";
            this.ListBoxCurrentSettings.Size = new System.Drawing.Size(387, 257);
            this.ListBoxCurrentSettings.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 3);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(816, 3);
            this.label2.TabIndex = 5;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(546, 33);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(259, 206);
            this.LabelTips.TabIndex = 6;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
            // 
            // LabelCopyingInProgress
            // 
            this.LabelCopyingInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCopyingInProgress.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelCopyingInProgress.ForeColor = System.Drawing.Color.Red;
            this.LabelCopyingInProgress.Location = new System.Drawing.Point(7, 109);
            this.LabelCopyingInProgress.Name = "LabelCopyingInProgress";
            this.LabelCopyingInProgress.Size = new System.Drawing.Size(344, 30);
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
            this.GroupCopyingProcess.Location = new System.Drawing.Point(14, 431);
            this.GroupCopyingProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCopyingProcess.Name = "GroupCopyingProcess";
            this.GroupCopyingProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCopyingProcess.Size = new System.Drawing.Size(358, 144);
            this.GroupCopyingProcess.TabIndex = 8;
            this.GroupCopyingProcess.TabStop = false;
            this.GroupCopyingProcess.Text = "Процесс копирования";
            // 
            // ButtonCancelCopying
            // 
            this.ButtonCancelCopying.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancelCopying.Location = new System.Drawing.Point(237, 55);
            this.ButtonCancelCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancelCopying.Name = "ButtonCancelCopying";
            this.ButtonCancelCopying.Size = new System.Drawing.Size(113, 37);
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
            this.GroupAutoCopying.Location = new System.Drawing.Point(15, 262);
            this.GroupAutoCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Size = new System.Drawing.Size(345, 161);
            this.GroupAutoCopying.TabIndex = 13;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Автоматическое копирование";
            // 
            // ButtonAutoCopyingSettings
            // 
            this.ButtonAutoCopyingSettings.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingSettings.Location = new System.Drawing.Point(8, 108);
            this.ButtonAutoCopyingSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAutoCopyingSettings.Name = "ButtonAutoCopyingSettings";
            this.ButtonAutoCopyingSettings.Size = new System.Drawing.Size(113, 37);
            this.ButtonAutoCopyingSettings.TabIndex = 6;
            this.ButtonAutoCopyingSettings.Text = "Настройки";
            this.ButtonAutoCopyingSettings.UseVisualStyleBackColor = true;
            this.ButtonAutoCopyingSettings.Click += new System.EventHandler(this.ButtonAutoCopyingSettings_Click);
            // 
            // ButtonAutoCopyingApply
            // 
            this.ButtonAutoCopyingApply.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingApply.Location = new System.Drawing.Point(193, 108);
            this.ButtonAutoCopyingApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAutoCopyingApply.Name = "ButtonAutoCopyingApply";
            this.ButtonAutoCopyingApply.Size = new System.Drawing.Size(113, 37);
            this.ButtonAutoCopyingApply.TabIndex = 4;
            this.ButtonAutoCopyingApply.Text = "Принять";
            this.ButtonAutoCopyingApply.UseVisualStyleBackColor = true;
            this.ButtonAutoCopyingApply.Click += new System.EventHandler(this.button7_Click);
            // 
            // RadioButtonNever
            // 
            this.RadioButtonNever.AutoSize = true;
            this.RadioButtonNever.Location = new System.Drawing.Point(193, 69);
            this.RadioButtonNever.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButtonNever.Name = "RadioButtonNever";
            this.RadioButtonNever.Size = new System.Drawing.Size(107, 28);
            this.RadioButtonNever.TabIndex = 5;
            this.RadioButtonNever.TabStop = true;
            this.RadioButtonNever.Text = "Никогда";
            this.RadioButtonNever.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOnceAWeek
            // 
            this.RadioButtonOnceAWeek.AutoSize = true;
            this.RadioButtonOnceAWeek.Location = new System.Drawing.Point(8, 69);
            this.RadioButtonOnceAWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButtonOnceAWeek.Name = "RadioButtonOnceAWeek";
            this.RadioButtonOnceAWeek.Size = new System.Drawing.Size(148, 28);
            this.RadioButtonOnceAWeek.TabIndex = 2;
            this.RadioButtonOnceAWeek.TabStop = true;
            this.RadioButtonOnceAWeek.Text = "Раз в неделю";
            this.RadioButtonOnceAWeek.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOnceInThreeDays
            // 
            this.RadioButtonOnceInThreeDays.AutoSize = true;
            this.RadioButtonOnceInThreeDays.Location = new System.Drawing.Point(193, 31);
            this.RadioButtonOnceInThreeDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButtonOnceInThreeDays.Name = "RadioButtonOnceInThreeDays";
            this.RadioButtonOnceInThreeDays.Size = new System.Drawing.Size(153, 28);
            this.RadioButtonOnceInThreeDays.TabIndex = 1;
            this.RadioButtonOnceInThreeDays.TabStop = true;
            this.RadioButtonOnceInThreeDays.Text = "Раз в три дня";
            this.RadioButtonOnceInThreeDays.UseVisualStyleBackColor = true;
            // 
            // RadioButtonEveryDay
            // 
            this.RadioButtonEveryDay.AutoSize = true;
            this.RadioButtonEveryDay.Location = new System.Drawing.Point(7, 31);
            this.RadioButtonEveryDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButtonEveryDay.Name = "RadioButtonEveryDay";
            this.RadioButtonEveryDay.Size = new System.Drawing.Size(152, 28);
            this.RadioButtonEveryDay.TabIndex = 0;
            this.RadioButtonEveryDay.TabStop = true;
            this.RadioButtonEveryDay.Text = "Каждый день";
            this.RadioButtonEveryDay.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(950, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            this.label9.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(528, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 211);
            this.label3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(379, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 327);
            this.label6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(389, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 327);
            this.label7.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(537, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 211);
            this.label4.TabIndex = 20;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 573);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
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
        private System.Windows.Forms.Button ButtonCopyFiles;
    }
}

