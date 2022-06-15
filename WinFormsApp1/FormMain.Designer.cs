
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
            this.ListBoxScheduleCopying = new System.Windows.Forms.ListBox();
            this.ButtonAddSchedule = new System.Windows.Forms.Button();
            this.ButtonChangeSchedule = new System.Windows.Forms.Button();
            this.ButtonRemoveSchedule = new System.Windows.Forms.Button();
            this.ButtonCopyFiles = new System.Windows.Forms.Button();
            this.PanelForButtonsScheduleCopying = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupCurrentSettings = new System.Windows.Forms.GroupBox();
            this.ListBoxCurrentSettings = new System.Windows.Forms.ListBox();
            this.GroupAutoCopying = new System.Windows.Forms.GroupBox();
            this.ButtonAutoCopyingSettings = new System.Windows.Forms.Button();
            this.ButtonAutoCopyingApply = new System.Windows.Forms.Button();
            this.RadioButtonNever = new System.Windows.Forms.RadioButton();
            this.RadioButtonOnceAWeek = new System.Windows.Forms.RadioButton();
            this.RadioButtonOnceInThreeDays = new System.Windows.Forms.RadioButton();
            this.RadioButtonEveryDay = new System.Windows.Forms.RadioButton();
            this.GroupCopyingProcess = new System.Windows.Forms.GroupBox();
            this.ButtonCancelCopying = new System.Windows.Forms.Button();
            this.LabelCopyingInProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTips = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GroupScheduleCopying.SuspendLayout();
            this.PanelForButtonsScheduleCopying.SuspendLayout();
            this.GroupCurrentSettings.SuspendLayout();
            this.GroupAutoCopying.SuspendLayout();
            this.GroupCopyingProcess.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(835, 34);
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
            this.GroupScheduleCopying.Controls.Add(this.ListBoxScheduleCopying);
            this.GroupScheduleCopying.Controls.Add(this.ButtonAddSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonChangeSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonRemoveSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonCopyFiles);
            this.GroupScheduleCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupScheduleCopying.Location = new System.Drawing.Point(4, 0);
            this.GroupScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupScheduleCopying.Name = "GroupScheduleCopying";
            this.GroupScheduleCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupScheduleCopying.Size = new System.Drawing.Size(507, 199);
            this.GroupScheduleCopying.TabIndex = 2;
            this.GroupScheduleCopying.TabStop = false;
            this.GroupScheduleCopying.Text = "Запланировать копирование";
            this.GroupScheduleCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxScheduleCopying
            // 
            this.ListBoxScheduleCopying.FormattingEnabled = true;
            this.ListBoxScheduleCopying.ItemHeight = 23;
            this.ListBoxScheduleCopying.Location = new System.Drawing.Point(6, 95);
            this.ListBoxScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxScheduleCopying.Name = "ListBoxScheduleCopying";
            this.ListBoxScheduleCopying.Size = new System.Drawing.Size(495, 96);
            this.ListBoxScheduleCopying.TabIndex = 3;
            this.ListBoxScheduleCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonAddSchedule
            // 
            this.ButtonAddSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddSchedule.Location = new System.Drawing.Point(20, 41);
            this.ButtonAddSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddSchedule.Name = "ButtonAddSchedule";
            this.ButtonAddSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonAddSchedule.TabIndex = 0;
            this.ButtonAddSchedule.Text = "Добавить";
            this.ButtonAddSchedule.UseVisualStyleBackColor = true;
            this.ButtonAddSchedule.Click += new System.EventHandler(this.button1_Click);
            this.ButtonAddSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChangeSchedule
            // 
            this.ButtonChangeSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonChangeSchedule.Location = new System.Drawing.Point(139, 41);
            this.ButtonChangeSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChangeSchedule.Name = "ButtonChangeSchedule";
            this.ButtonChangeSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonChangeSchedule.TabIndex = 1;
            this.ButtonChangeSchedule.Text = "Изменить";
            this.ButtonChangeSchedule.UseVisualStyleBackColor = true;
            this.ButtonChangeSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonRemoveSchedule
            // 
            this.ButtonRemoveSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRemoveSchedule.Location = new System.Drawing.Point(258, 41);
            this.ButtonRemoveSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonRemoveSchedule.Name = "ButtonRemoveSchedule";
            this.ButtonRemoveSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonRemoveSchedule.TabIndex = 2;
            this.ButtonRemoveSchedule.Text = "Удалить";
            this.ButtonRemoveSchedule.UseVisualStyleBackColor = true;
            this.ButtonRemoveSchedule.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonCopyFiles
            // 
            this.ButtonCopyFiles.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCopyFiles.Location = new System.Drawing.Point(377, 41);
            this.ButtonCopyFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCopyFiles.Name = "ButtonCopyFiles";
            this.ButtonCopyFiles.Size = new System.Drawing.Size(113, 37);
            this.ButtonCopyFiles.TabIndex = 4;
            this.ButtonCopyFiles.Text = "Копировать";
            this.ButtonCopyFiles.UseVisualStyleBackColor = true;
            this.ButtonCopyFiles.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // PanelForButtonsScheduleCopying
            // 
            this.PanelForButtonsScheduleCopying.BackColor = System.Drawing.Color.Transparent;
            this.PanelForButtonsScheduleCopying.Controls.Add(this.label7);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.label4);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.label6);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.GroupCurrentSettings);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.GroupAutoCopying);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.GroupCopyingProcess);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.label3);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.label2);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.label1);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.GroupScheduleCopying);
            this.PanelForButtonsScheduleCopying.Controls.Add(this.LabelTips);
            this.PanelForButtonsScheduleCopying.Location = new System.Drawing.Point(0, 31);
            this.PanelForButtonsScheduleCopying.Name = "PanelForButtonsScheduleCopying";
            this.PanelForButtonsScheduleCopying.Size = new System.Drawing.Size(835, 579);
            this.PanelForButtonsScheduleCopying.TabIndex = 5;
            this.PanelForButtonsScheduleCopying.MouseHover += new System.EventHandler(this.PanelForButtonsScheduleCopying_MouseHover);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(415, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 400);
            this.label7.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(526, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 211);
            this.label4.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(407, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 400);
            this.label6.TabIndex = 18;
            // 
            // GroupCurrentSettings
            // 
            this.GroupCurrentSettings.Controls.Add(this.ListBoxCurrentSettings);
            this.GroupCurrentSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCurrentSettings.Location = new System.Drawing.Point(426, 230);
            this.GroupCurrentSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Name = "GroupCurrentSettings";
            this.GroupCurrentSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Size = new System.Drawing.Size(408, 313);
            this.GroupCurrentSettings.TabIndex = 4;
            this.GroupCurrentSettings.TabStop = false;
            this.GroupCurrentSettings.Text = "Текущие настройки";
            this.GroupCurrentSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.ListBoxCurrentSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.GroupAutoCopying.Location = new System.Drawing.Point(10, 230);
            this.GroupAutoCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Size = new System.Drawing.Size(391, 161);
            this.GroupAutoCopying.TabIndex = 13;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Регулярное копирование";
            this.GroupAutoCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.ButtonAutoCopyingSettings.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.ButtonAutoCopyingApply.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.RadioButtonNever.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.RadioButtonOnceAWeek.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.RadioButtonOnceInThreeDays.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.RadioButtonEveryDay.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // GroupCopyingProcess
            // 
            this.GroupCopyingProcess.Controls.Add(this.ButtonCancelCopying);
            this.GroupCopyingProcess.Controls.Add(this.LabelCopyingInProgress);
            this.GroupCopyingProcess.Controls.Add(this.progressBar1);
            this.GroupCopyingProcess.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCopyingProcess.Location = new System.Drawing.Point(9, 400);
            this.GroupCopyingProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCopyingProcess.Name = "GroupCopyingProcess";
            this.GroupCopyingProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCopyingProcess.Size = new System.Drawing.Size(400, 175);
            this.GroupCopyingProcess.TabIndex = 8;
            this.GroupCopyingProcess.TabStop = false;
            this.GroupCopyingProcess.Text = "Процесс копирования";
            this.GroupCopyingProcess.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
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
            this.ButtonCancelCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelCopyingInProgress
            // 
            this.LabelCopyingInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCopyingInProgress.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelCopyingInProgress.ForeColor = System.Drawing.Color.Red;
            this.LabelCopyingInProgress.Location = new System.Drawing.Point(-2, 96);
            this.LabelCopyingInProgress.Name = "LabelCopyingInProgress";
            this.LabelCopyingInProgress.Size = new System.Drawing.Size(394, 70);
            this.LabelCopyingInProgress.TabIndex = 6;
            this.LabelCopyingInProgress.Text = "Идёт копирование, дождитесь окончания";
            this.LabelCopyingInProgress.Visible = false;
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
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(517, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 211);
            this.label3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-1, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(840, 3);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-1, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 3);
            this.label1.TabIndex = 2;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(534, 3);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(290, 201);
            this.LabelTips.TabIndex = 6;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
            this.LabelTips.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(950, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            this.label9.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 556);
            this.Controls.Add(this.PanelForButtonsScheduleCopying);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupScheduleCopying.ResumeLayout(false);
            this.PanelForButtonsScheduleCopying.ResumeLayout(false);
            this.GroupCurrentSettings.ResumeLayout(false);
            this.GroupAutoCopying.ResumeLayout(false);
            this.GroupAutoCopying.PerformLayout();
            this.GroupCopyingProcess.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PanelForButtonsScheduleCopying;
    }
}

