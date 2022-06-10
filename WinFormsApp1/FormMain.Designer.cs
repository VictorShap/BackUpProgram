
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
            this.ButtonRemoveSchedule = new System.Windows.Forms.Button();
            this.ButtonChangeSchedule = new System.Windows.Forms.Button();
            this.ButtonAddSchedule = new System.Windows.Forms.Button();
            this.GroupArbitraryCopying = new System.Windows.Forms.GroupBox();
            this.ChosenFolderToCopyStatus = new System.Windows.Forms.Label();
            this.ChosenTargetFolderStatus = new System.Windows.Forms.Label();
            this.ButtonChooseTargetFolder = new System.Windows.Forms.Button();
            this.LabelChooseTargetFolder = new System.Windows.Forms.Label();
            this.ButtonChooseFolderToCopy = new System.Windows.Forms.Button();
            this.ButtonArbitraryCopying = new System.Windows.Forms.Button();
            this.LabelChooseFolderToCopy = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GroupCurrentSettings = new System.Windows.Forms.GroupBox();
            this.ListBoxCurrentSettings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTips = new System.Windows.Forms.Label();
            this.LabelCopyingInProgress = new System.Windows.Forms.Label();
            this.GroupCopyingProcess = new System.Windows.Forms.GroupBox();
            this.ButtonCancelCopying = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupAutoCopying = new System.Windows.Forms.GroupBox();
            this.ButtonAutoCopyingSettings = new System.Windows.Forms.Button();
            this.ButtonAutoCopyingApply = new System.Windows.Forms.Button();
            this.RadioButtonNever = new System.Windows.Forms.RadioButton();
            this.RadioButtonOnceAWeek = new System.Windows.Forms.RadioButton();
            this.RadioButtonOnceInThreeDays = new System.Windows.Forms.RadioButton();
            this.RadioButtonEveryDay = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GroupScheduleCopying.SuspendLayout();
            this.GroupArbitraryCopying.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(911, 34);
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
            this.GroupScheduleCopying.Controls.Add(this.ListBoxScheduleCopying);
            this.GroupScheduleCopying.Controls.Add(this.ButtonRemoveSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonChangeSchedule);
            this.GroupScheduleCopying.Controls.Add(this.ButtonAddSchedule);
            this.GroupScheduleCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupScheduleCopying.Location = new System.Drawing.Point(399, 312);
            this.GroupScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupScheduleCopying.Name = "GroupScheduleCopying";
            this.GroupScheduleCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupScheduleCopying.Size = new System.Drawing.Size(507, 341);
            this.GroupScheduleCopying.TabIndex = 2;
            this.GroupScheduleCopying.TabStop = false;
            this.GroupScheduleCopying.Text = "Запланировать копирование";
            // 
            // ListBoxScheduleCopying
            // 
            this.ListBoxScheduleCopying.FormattingEnabled = true;
            this.ListBoxScheduleCopying.ItemHeight = 23;
            this.ListBoxScheduleCopying.Location = new System.Drawing.Point(7, 75);
            this.ListBoxScheduleCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxScheduleCopying.Name = "ListBoxScheduleCopying";
            this.ListBoxScheduleCopying.Size = new System.Drawing.Size(495, 257);
            this.ListBoxScheduleCopying.TabIndex = 3;
            // 
            // ButtonRemoveSchedule
            // 
            this.ButtonRemoveSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonRemoveSchedule.Location = new System.Drawing.Point(335, 29);
            this.ButtonRemoveSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonRemoveSchedule.Name = "ButtonRemoveSchedule";
            this.ButtonRemoveSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonRemoveSchedule.TabIndex = 2;
            this.ButtonRemoveSchedule.Text = "Удалить";
            this.ButtonRemoveSchedule.UseVisualStyleBackColor = true;
            // 
            // ButtonChangeSchedule
            // 
            this.ButtonChangeSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonChangeSchedule.Location = new System.Drawing.Point(200, 29);
            this.ButtonChangeSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChangeSchedule.Name = "ButtonChangeSchedule";
            this.ButtonChangeSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonChangeSchedule.TabIndex = 1;
            this.ButtonChangeSchedule.Text = "Изменить";
            this.ButtonChangeSchedule.UseVisualStyleBackColor = true;
            // 
            // ButtonAddSchedule
            // 
            this.ButtonAddSchedule.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddSchedule.Location = new System.Drawing.Point(65, 29);
            this.ButtonAddSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddSchedule.Name = "ButtonAddSchedule";
            this.ButtonAddSchedule.Size = new System.Drawing.Size(113, 37);
            this.ButtonAddSchedule.TabIndex = 0;
            this.ButtonAddSchedule.Text = "Добавить";
            this.ButtonAddSchedule.UseVisualStyleBackColor = true;
            this.ButtonAddSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupArbitraryCopying
            // 
            this.GroupArbitraryCopying.Controls.Add(this.ChosenFolderToCopyStatus);
            this.GroupArbitraryCopying.Controls.Add(this.ChosenTargetFolderStatus);
            this.GroupArbitraryCopying.Controls.Add(this.ButtonChooseTargetFolder);
            this.GroupArbitraryCopying.Controls.Add(this.LabelChooseTargetFolder);
            this.GroupArbitraryCopying.Controls.Add(this.ButtonChooseFolderToCopy);
            this.GroupArbitraryCopying.Controls.Add(this.ButtonArbitraryCopying);
            this.GroupArbitraryCopying.Controls.Add(this.LabelChooseFolderToCopy);
            this.GroupArbitraryCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupArbitraryCopying.Location = new System.Drawing.Point(14, 34);
            this.GroupArbitraryCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupArbitraryCopying.Name = "GroupArbitraryCopying";
            this.GroupArbitraryCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupArbitraryCopying.Size = new System.Drawing.Size(296, 274);
            this.GroupArbitraryCopying.TabIndex = 3;
            this.GroupArbitraryCopying.TabStop = false;
            this.GroupArbitraryCopying.Text = "Произвольное копирование";
            // 
            // ChosenFolderToCopyStatus
            // 
            this.ChosenFolderToCopyStatus.AutoSize = true;
            this.ChosenFolderToCopyStatus.Location = new System.Drawing.Point(6, 95);
            this.ChosenFolderToCopyStatus.Name = "ChosenFolderToCopyStatus";
            this.ChosenFolderToCopyStatus.Size = new System.Drawing.Size(116, 24);
            this.ChosenFolderToCopyStatus.TabIndex = 21;
            this.ChosenFolderToCopyStatus.Text = "Не выбрано";
            // 
            // ChosenTargetFolderStatus
            // 
            this.ChosenTargetFolderStatus.AutoSize = true;
            this.ChosenTargetFolderStatus.Location = new System.Drawing.Point(6, 187);
            this.ChosenTargetFolderStatus.Name = "ChosenTargetFolderStatus";
            this.ChosenTargetFolderStatus.Size = new System.Drawing.Size(116, 24);
            this.ChosenTargetFolderStatus.TabIndex = 20;
            this.ChosenTargetFolderStatus.Text = "Не выбрано";
            // 
            // ButtonChooseTargetFolder
            // 
            this.ButtonChooseTargetFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseTargetFolder.Location = new System.Drawing.Point(202, 148);
            this.ButtonChooseTargetFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChooseTargetFolder.Name = "ButtonChooseTargetFolder";
            this.ButtonChooseTargetFolder.Size = new System.Drawing.Size(83, 31);
            this.ButtonChooseTargetFolder.TabIndex = 19;
            this.ButtonChooseTargetFolder.Text = "добавить";
            this.ButtonChooseTargetFolder.UseVisualStyleBackColor = true;
            this.ButtonChooseTargetFolder.Click += new System.EventHandler(this.ButtonChooseTargetFolderClick);
            // 
            // LabelChooseTargetFolder
            // 
            this.LabelChooseTargetFolder.Location = new System.Drawing.Point(7, 130);
            this.LabelChooseTargetFolder.Name = "LabelChooseTargetFolder";
            this.LabelChooseTargetFolder.Size = new System.Drawing.Size(278, 49);
            this.LabelChooseTargetFolder.TabIndex = 17;
            this.LabelChooseTargetFolder.Text = "Укажите директорию \r\nназначения";
            // 
            // ButtonChooseFolderToCopy
            // 
            this.ButtonChooseFolderToCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseFolderToCopy.Location = new System.Drawing.Point(202, 45);
            this.ButtonChooseFolderToCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChooseFolderToCopy.Name = "ButtonChooseFolderToCopy";
            this.ButtonChooseFolderToCopy.Size = new System.Drawing.Size(83, 31);
            this.ButtonChooseFolderToCopy.TabIndex = 18;
            this.ButtonChooseFolderToCopy.Text = "добавить";
            this.ButtonChooseFolderToCopy.UseVisualStyleBackColor = true;
            this.ButtonChooseFolderToCopy.Click += new System.EventHandler(this.ButtonChooseFolderToCopyClick);
            // 
            // ButtonArbitraryCopying
            // 
            this.ButtonArbitraryCopying.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonArbitraryCopying.Location = new System.Drawing.Point(177, 223);
            this.ButtonArbitraryCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonArbitraryCopying.Name = "ButtonArbitraryCopying";
            this.ButtonArbitraryCopying.Size = new System.Drawing.Size(115, 37);
            this.ButtonArbitraryCopying.TabIndex = 4;
            this.ButtonArbitraryCopying.Text = "Копировать";
            this.ButtonArbitraryCopying.UseVisualStyleBackColor = true;
            this.ButtonArbitraryCopying.Click += new System.EventHandler(this.ButtonArbitraryCopying_Click);
            // 
            // LabelChooseFolderToCopy
            // 
            this.LabelChooseFolderToCopy.Location = new System.Drawing.Point(7, 35);
            this.LabelChooseFolderToCopy.Name = "LabelChooseFolderToCopy";
            this.LabelChooseFolderToCopy.Size = new System.Drawing.Size(266, 51);
            this.LabelChooseFolderToCopy.TabIndex = 16;
            this.LabelChooseFolderToCopy.Text = "Укажите основную \r\nдиректорию/файл";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 111);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 31);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // GroupCurrentSettings
            // 
            this.GroupCurrentSettings.Controls.Add(this.ListBoxCurrentSettings);
            this.GroupCurrentSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCurrentSettings.Location = new System.Drawing.Point(615, 34);
            this.GroupCurrentSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Name = "GroupCurrentSettings";
            this.GroupCurrentSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCurrentSettings.Size = new System.Drawing.Size(299, 274);
            this.GroupCurrentSettings.TabIndex = 4;
            this.GroupCurrentSettings.TabStop = false;
            this.GroupCurrentSettings.Text = "Текущие настройки";
            // 
            // ListBoxCurrentSettings
            // 
            this.ListBoxCurrentSettings.FormattingEnabled = true;
            this.ListBoxCurrentSettings.HorizontalScrollbar = true;
            this.ListBoxCurrentSettings.ItemHeight = 23;
            this.ListBoxCurrentSettings.Location = new System.Drawing.Point(7, 29);
            this.ListBoxCurrentSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxCurrentSettings.Name = "ListBoxCurrentSettings";
            this.ListBoxCurrentSettings.Size = new System.Drawing.Size(277, 188);
            this.ListBoxCurrentSettings.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 3);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(914, 3);
            this.label2.TabIndex = 5;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(14, 326);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(358, 162);
            this.LabelTips.TabIndex = 6;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация";
            // 
            // LabelCopyingInProgress
            // 
            this.LabelCopyingInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCopyingInProgress.Font = new System.Drawing.Font("Sitka Text", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelCopyingInProgress.ForeColor = System.Drawing.Color.Red;
            this.LabelCopyingInProgress.Location = new System.Drawing.Point(7, 75);
            this.LabelCopyingInProgress.Name = "LabelCopyingInProgress";
            this.LabelCopyingInProgress.Size = new System.Drawing.Size(344, 30);
            this.LabelCopyingInProgress.TabIndex = 6;
            this.LabelCopyingInProgress.Text = "Идёт копирование, дождитесь окончания";
            this.LabelCopyingInProgress.Visible = false;
            // 
            // GroupCopyingProcess
            // 
            this.GroupCopyingProcess.Controls.Add(this.ButtonCancelCopying);
            this.GroupCopyingProcess.Controls.Add(this.progressBar1);
            this.GroupCopyingProcess.Controls.Add(this.LabelCopyingInProgress);
            this.GroupCopyingProcess.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupCopyingProcess.Location = new System.Drawing.Point(14, 492);
            this.GroupCopyingProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCopyingProcess.Name = "GroupCopyingProcess";
            this.GroupCopyingProcess.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupCopyingProcess.Size = new System.Drawing.Size(358, 149);
            this.GroupCopyingProcess.TabIndex = 8;
            this.GroupCopyingProcess.TabStop = false;
            this.GroupCopyingProcess.Text = "Процесс копирования";
            // 
            // ButtonCancelCopying
            // 
            this.ButtonCancelCopying.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancelCopying.Location = new System.Drawing.Point(238, 31);
            this.ButtonCancelCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancelCopying.Name = "ButtonCancelCopying";
            this.ButtonCancelCopying.Size = new System.Drawing.Size(113, 37);
            this.ButtonCancelCopying.TabIndex = 4;
            this.ButtonCancelCopying.Text = "Отмена";
            this.ButtonCancelCopying.UseVisualStyleBackColor = true;
            this.ButtonCancelCopying.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(596, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 280);
            this.label5.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(316, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 282);
            this.label8.TabIndex = 12;
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
            this.GroupAutoCopying.Location = new System.Drawing.Point(335, 36);
            this.GroupAutoCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Size = new System.Drawing.Size(256, 272);
            this.GroupAutoCopying.TabIndex = 13;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Автоматическое копирование";
            // 
            // ButtonAutoCopyingSettings
            // 
            this.ButtonAutoCopyingSettings.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingSettings.Location = new System.Drawing.Point(7, 188);
            this.ButtonAutoCopyingSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAutoCopyingSettings.Name = "ButtonAutoCopyingSettings";
            this.ButtonAutoCopyingSettings.Size = new System.Drawing.Size(113, 37);
            this.ButtonAutoCopyingSettings.TabIndex = 6;
            this.ButtonAutoCopyingSettings.Text = "Настройки";
            this.ButtonAutoCopyingSettings.UseVisualStyleBackColor = true;
            // 
            // ButtonAutoCopyingApply
            // 
            this.ButtonAutoCopyingApply.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAutoCopyingApply.Location = new System.Drawing.Point(142, 188);
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
            this.RadioButtonNever.Location = new System.Drawing.Point(7, 147);
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
            this.RadioButtonOnceAWeek.Location = new System.Drawing.Point(8, 108);
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
            this.RadioButtonOnceInThreeDays.Location = new System.Drawing.Point(7, 69);
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
            this.label9.Location = new System.Drawing.Point(378, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            this.label9.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(378, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 352);
            this.label10.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 641);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GroupAutoCopying);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GroupCopyingProcess);
            this.Controls.Add(this.LabelTips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupCurrentSettings);
            this.Controls.Add(this.GroupArbitraryCopying);
            this.Controls.Add(this.GroupScheduleCopying);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupScheduleCopying.ResumeLayout(false);
            this.GroupArbitraryCopying.ResumeLayout(false);
            this.GroupArbitraryCopying.PerformLayout();
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
        private System.Windows.Forms.GroupBox GroupArbitraryCopying;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ButtonArbitraryCopying;
        private System.Windows.Forms.GroupBox GroupCurrentSettings;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBoxCurrentSettings;
        private System.Windows.Forms.Label LabelTips;
        private System.Windows.Forms.Label LabelCopyingInProgress;
        private System.Windows.Forms.GroupBox GroupCopyingProcess;
        private System.Windows.Forms.Button ButtonCancelCopying;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GroupAutoCopying;
        private System.Windows.Forms.RadioButton RadioButtonOnceAWeek;
        private System.Windows.Forms.RadioButton RadioButtonOnceInThreeDays;
        private System.Windows.Forms.RadioButton RadioButtonEveryDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButtonAutoCopyingApply;
        private System.Windows.Forms.RadioButton RadioButtonNever;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button ButtonAutoCopyingSettings;
        private System.Windows.Forms.Label LabelChooseTargetFolder;
        private System.Windows.Forms.Label LabelChooseFolderToCopy;
        private System.Windows.Forms.Button ButtonChooseTargetFolder;
        private System.Windows.Forms.Button ButtonChooseFolderToCopy;
        private System.Windows.Forms.Label ChosenTargetFolderStatus;
        private System.Windows.Forms.Label ChosenFolderToCopyStatus;
    }
}

