﻿
namespace WinFormsApp1
{
    partial class FormCopyingSettings
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
            this.GroupAutoCopying = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxDirectoriesResult = new System.Windows.Forms.ListBox();
            this.TextBoxDaysToCopy = new System.Windows.Forms.TextBox();
            this.LabelTargetDirectory = new System.Windows.Forms.Label();
            this.LabelDaysToCopy = new System.Windows.Forms.Label();
            this.LabelDirectoryToCopy = new System.Windows.Forms.Label();
            this.ButtonChooseTargetDirectory = new System.Windows.Forms.Button();
            this.TextBoxTypeExtension = new System.Windows.Forms.TextBox();
            this.ButtonChooseDirectoryToCopy = new System.Windows.Forms.Button();
            this.LabelTypeExtension = new System.Windows.Forms.Label();
            this.CheckBoxCopyAllTheFiles = new System.Windows.Forms.CheckBox();
            this.LabelTips = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupAdditionalSettings = new System.Windows.Forms.GroupBox();
            this.checkBox4StartCopyingAgain = new System.Windows.Forms.CheckBox();
            this.checkBox3PermissionToStopCopy = new System.Windows.Forms.CheckBox();
            this.checkBox2ShutDownProgram = new System.Windows.Forms.CheckBox();
            this.checkBox1NotifyAboutCopying = new System.Windows.Forms.CheckBox();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.GroupAutoCopying.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GroupAdditionalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupAutoCopying
            // 
            this.GroupAutoCopying.Controls.Add(this.label2);
            this.GroupAutoCopying.Controls.Add(this.label1);
            this.GroupAutoCopying.Controls.Add(this.ListBoxDirectoriesResult);
            this.GroupAutoCopying.Controls.Add(this.TextBoxDaysToCopy);
            this.GroupAutoCopying.Controls.Add(this.LabelTargetDirectory);
            this.GroupAutoCopying.Controls.Add(this.LabelDaysToCopy);
            this.GroupAutoCopying.Controls.Add(this.LabelDirectoryToCopy);
            this.GroupAutoCopying.Controls.Add(this.ButtonChooseTargetDirectory);
            this.GroupAutoCopying.Controls.Add(this.TextBoxTypeExtension);
            this.GroupAutoCopying.Controls.Add(this.ButtonChooseDirectoryToCopy);
            this.GroupAutoCopying.Controls.Add(this.LabelTypeExtension);
            this.GroupAutoCopying.Controls.Add(this.CheckBoxCopyAllTheFiles);
            this.GroupAutoCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAutoCopying.Location = new System.Drawing.Point(12, 27);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Size = new System.Drawing.Size(829, 154);
            this.GroupAutoCopying.TabIndex = 0;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Автоматическое копирование";
            this.GroupAutoCopying.Enter += new System.EventHandler(this.GroupAutoCopying_Enter);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(428, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 145);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(421, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 145);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // ListBoxDirectoriesResult
            // 
            this.ListBoxDirectoriesResult.BackColor = System.Drawing.SystemColors.Control;
            this.ListBoxDirectoriesResult.FormattingEnabled = true;
            this.ListBoxDirectoriesResult.HorizontalScrollbar = true;
            this.ListBoxDirectoriesResult.ItemHeight = 19;
            this.ListBoxDirectoriesResult.Location = new System.Drawing.Point(6, 79);
            this.ListBoxDirectoriesResult.Name = "ListBoxDirectoriesResult";
            this.ListBoxDirectoriesResult.Size = new System.Drawing.Size(398, 61);
            this.ListBoxDirectoriesResult.TabIndex = 5;
            this.ListBoxDirectoriesResult.Visible = false;
            // 
            // TextBoxDaysToCopy
            // 
            this.TextBoxDaysToCopy.Location = new System.Drawing.Point(716, 68);
            this.TextBoxDaysToCopy.Name = "TextBoxDaysToCopy";
            this.TextBoxDaysToCopy.Size = new System.Drawing.Size(100, 24);
            this.TextBoxDaysToCopy.TabIndex = 6;
            // 
            // LabelTargetDirectory
            // 
            this.LabelTargetDirectory.Location = new System.Drawing.Point(6, 50);
            this.LabelTargetDirectory.Name = "LabelTargetDirectory";
            this.LabelTargetDirectory.Size = new System.Drawing.Size(284, 23);
            this.LabelTargetDirectory.TabIndex = 3;
            this.LabelTargetDirectory.Text = "Укажите директорию назначения";
            this.LabelTargetDirectory.Click += new System.EventHandler(this.LabelTargetDirectory_Click);
            this.LabelTargetDirectory.MouseHover += new System.EventHandler(this.LabelDirectoryToCopy_MouseHover);
            // 
            // LabelDaysToCopy
            // 
            this.LabelDaysToCopy.Location = new System.Drawing.Point(454, 52);
            this.LabelDaysToCopy.Name = "LabelDaysToCopy";
            this.LabelDaysToCopy.Size = new System.Drawing.Size(256, 40);
            this.LabelDaysToCopy.TabIndex = 1;
            this.LabelDaysToCopy.Text = "Укажите за сколько последних дней производить копирование";
            this.LabelDaysToCopy.MouseHover += new System.EventHandler(this.LabelDirectoryToCopy_MouseHover);
            // 
            // LabelDirectoryToCopy
            // 
            this.LabelDirectoryToCopy.Location = new System.Drawing.Point(6, 23);
            this.LabelDirectoryToCopy.Name = "LabelDirectoryToCopy";
            this.LabelDirectoryToCopy.Size = new System.Drawing.Size(273, 29);
            this.LabelDirectoryToCopy.TabIndex = 2;
            this.LabelDirectoryToCopy.Text = "Укажите основную директорию";
            this.LabelDirectoryToCopy.Click += new System.EventHandler(this.LabelDirectoryToCopy_Click);
            this.LabelDirectoryToCopy.MouseLeave += new System.EventHandler(this.LabelDirectoryToCopy_MouseLeave);
            this.LabelDirectoryToCopy.MouseHover += new System.EventHandler(this.LabelDirectoryToCopy_MouseHover);
            // 
            // ButtonChooseTargetDirectory
            // 
            this.ButtonChooseTargetDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseTargetDirectory.Location = new System.Drawing.Point(296, 50);
            this.ButtonChooseTargetDirectory.Name = "ButtonChooseTargetDirectory";
            this.ButtonChooseTargetDirectory.Size = new System.Drawing.Size(72, 23);
            this.ButtonChooseTargetDirectory.TabIndex = 4;
            this.ButtonChooseTargetDirectory.Text = "добавить";
            this.ButtonChooseTargetDirectory.UseVisualStyleBackColor = true;
            this.ButtonChooseTargetDirectory.Click += new System.EventHandler(this.ButtonChooseTargetDirectory_Click);
            // 
            // TextBoxTypeExtension
            // 
            this.TextBoxTypeExtension.Location = new System.Drawing.Point(670, 20);
            this.TextBoxTypeExtension.Name = "TextBoxTypeExtension";
            this.TextBoxTypeExtension.Size = new System.Drawing.Size(146, 24);
            this.TextBoxTypeExtension.TabIndex = 5;
            // 
            // ButtonChooseDirectoryToCopy
            // 
            this.ButtonChooseDirectoryToCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseDirectoryToCopy.Location = new System.Drawing.Point(296, 22);
            this.ButtonChooseDirectoryToCopy.Name = "ButtonChooseDirectoryToCopy";
            this.ButtonChooseDirectoryToCopy.Size = new System.Drawing.Size(72, 23);
            this.ButtonChooseDirectoryToCopy.TabIndex = 3;
            this.ButtonChooseDirectoryToCopy.Text = "добавить";
            this.ButtonChooseDirectoryToCopy.UseVisualStyleBackColor = true;
            this.ButtonChooseDirectoryToCopy.Click += new System.EventHandler(this.ButtonChooseDirectoryToCopy_Click);
            // 
            // LabelTypeExtension
            // 
            this.LabelTypeExtension.Location = new System.Drawing.Point(454, 20);
            this.LabelTypeExtension.Name = "LabelTypeExtension";
            this.LabelTypeExtension.Size = new System.Drawing.Size(211, 23);
            this.LabelTypeExtension.TabIndex = 0;
            this.LabelTypeExtension.Text = "Укажите расширение файлов";
            this.LabelTypeExtension.MouseHover += new System.EventHandler(this.LabelDirectoryToCopy_MouseHover);
            // 
            // CheckBoxCopyAllTheFiles
            // 
            this.CheckBoxCopyAllTheFiles.AutoSize = true;
            this.CheckBoxCopyAllTheFiles.Location = new System.Drawing.Point(454, 98);
            this.CheckBoxCopyAllTheFiles.Name = "CheckBoxCopyAllTheFiles";
            this.CheckBoxCopyAllTheFiles.Size = new System.Drawing.Size(368, 23);
            this.CheckBoxCopyAllTheFiles.TabIndex = 7;
            this.CheckBoxCopyAllTheFiles.Text = "Копировать все файлы из выбранной директории";
            this.CheckBoxCopyAllTheFiles.UseVisualStyleBackColor = true;
            this.CheckBoxCopyAllTheFiles.MouseLeave += new System.EventHandler(this.checkBox1NotifyAboutCopying_MouseLeave);
            this.CheckBoxCopyAllTheFiles.MouseHover += new System.EventHandler(this.CheckBoxCopyAllTheFiles_MouseHover);
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(607, 187);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(234, 151);
            this.LabelTips.TabIndex = 2;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков и тут отобразится подробная информация.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // GroupAdditionalSettings
            // 
            this.GroupAdditionalSettings.Controls.Add(this.checkBox4StartCopyingAgain);
            this.GroupAdditionalSettings.Controls.Add(this.checkBox3PermissionToStopCopy);
            this.GroupAdditionalSettings.Controls.Add(this.checkBox2ShutDownProgram);
            this.GroupAdditionalSettings.Controls.Add(this.checkBox1NotifyAboutCopying);
            this.GroupAdditionalSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAdditionalSettings.Location = new System.Drawing.Point(12, 187);
            this.GroupAdditionalSettings.Name = "GroupAdditionalSettings";
            this.GroupAdditionalSettings.Size = new System.Drawing.Size(589, 151);
            this.GroupAdditionalSettings.TabIndex = 1;
            this.GroupAdditionalSettings.TabStop = false;
            this.GroupAdditionalSettings.Text = "Дополнительные настройки";
            // 
            // checkBox4StartCopyingAgain
            // 
            this.checkBox4StartCopyingAgain.Location = new System.Drawing.Point(6, 113);
            this.checkBox4StartCopyingAgain.Name = "checkBox4StartCopyingAgain";
            this.checkBox4StartCopyingAgain.Size = new System.Drawing.Size(518, 24);
            this.checkBox4StartCopyingAgain.TabIndex = 3;
            this.checkBox4StartCopyingAgain.Text = "Если копирование было внезапно прервано, предлагать повторить его";
            this.checkBox4StartCopyingAgain.UseVisualStyleBackColor = true;
            this.checkBox4StartCopyingAgain.MouseLeave += new System.EventHandler(this.checkBox1NotifyAboutCopying_MouseLeave);
            this.checkBox4StartCopyingAgain.MouseHover += new System.EventHandler(this.CheckBoxCopyAllTheFiles_MouseHover);
            // 
            // checkBox3PermissionToStopCopy
            // 
            this.checkBox3PermissionToStopCopy.Location = new System.Drawing.Point(6, 80);
            this.checkBox3PermissionToStopCopy.Name = "checkBox3PermissionToStopCopy";
            this.checkBox3PermissionToStopCopy.Size = new System.Drawing.Size(331, 27);
            this.checkBox3PermissionToStopCopy.TabIndex = 2;
            this.checkBox3PermissionToStopCopy.Text = "Разрешить прерывать процесс копирования";
            this.checkBox3PermissionToStopCopy.UseVisualStyleBackColor = true;
            this.checkBox3PermissionToStopCopy.MouseLeave += new System.EventHandler(this.checkBox1NotifyAboutCopying_MouseLeave);
            this.checkBox3PermissionToStopCopy.MouseHover += new System.EventHandler(this.CheckBoxCopyAllTheFiles_MouseHover);
            // 
            // checkBox2ShutDownProgram
            // 
            this.checkBox2ShutDownProgram.Location = new System.Drawing.Point(6, 53);
            this.checkBox2ShutDownProgram.Name = "checkBox2ShutDownProgram";
            this.checkBox2ShutDownProgram.Size = new System.Drawing.Size(577, 24);
            this.checkBox2ShutDownProgram.TabIndex = 1;
            this.checkBox2ShutDownProgram.Text = "Предлагать завершить работу программы, если копирование не запланировано";
            this.checkBox2ShutDownProgram.UseVisualStyleBackColor = true;
            this.checkBox2ShutDownProgram.MouseLeave += new System.EventHandler(this.checkBox1NotifyAboutCopying_MouseLeave);
            this.checkBox2ShutDownProgram.MouseHover += new System.EventHandler(this.CheckBoxCopyAllTheFiles_MouseHover);
            // 
            // checkBox1NotifyAboutCopying
            // 
            this.checkBox1NotifyAboutCopying.Location = new System.Drawing.Point(6, 23);
            this.checkBox1NotifyAboutCopying.Name = "checkBox1NotifyAboutCopying";
            this.checkBox1NotifyAboutCopying.Size = new System.Drawing.Size(361, 24);
            this.checkBox1NotifyAboutCopying.TabIndex = 0;
            this.checkBox1NotifyAboutCopying.Text = "Оповещать о начале и завершении копирования";
            this.checkBox1NotifyAboutCopying.UseVisualStyleBackColor = true;
            this.checkBox1NotifyAboutCopying.MouseLeave += new System.EventHandler(this.checkBox1NotifyAboutCopying_MouseLeave);
            this.checkBox1NotifyAboutCopying.MouseHover += new System.EventHandler(this.CheckBoxCopyAllTheFiles_MouseHover);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApply.Location = new System.Drawing.Point(610, 340);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(67, 23);
            this.ButtonApply.TabIndex = 10;
            this.ButtonApply.Text = "Принять";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(690, 340);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(67, 23);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOk.Location = new System.Drawing.Point(774, 340);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(67, 23);
            this.ButtonOk.TabIndex = 11;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // FormCopyingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 364);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.GroupAdditionalSettings);
            this.Controls.Add(this.LabelTips);
            this.Controls.Add(this.GroupAutoCopying);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCopyingSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки копирования";
            this.Load += new System.EventHandler(this.FormCopyingSettings_Load);
            this.GroupAutoCopying.ResumeLayout(false);
            this.GroupAutoCopying.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupAdditionalSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupAutoCopying;
        private System.Windows.Forms.Label LabelTips;
        private System.Windows.Forms.Button ButtonChooseTargetDirectory;
        private System.Windows.Forms.Button ButtonChooseDirectoryToCopy;
        private System.Windows.Forms.Label LabelDirectoryToCopy;
        private System.Windows.Forms.Label LabelDaysToCopy;
        private System.Windows.Forms.Label LabelTypeExtension;
        private System.Windows.Forms.Label LabelTargetDirectory;
        private System.Windows.Forms.CheckBox CheckBoxCopyAllTheFiles;
        private System.Windows.Forms.TextBox TextBoxDaysToCopy;
        private System.Windows.Forms.TextBox TextBoxTypeExtension;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupAdditionalSettings;
        private System.Windows.Forms.ListBox ListBoxDirectoriesResult;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4StartCopyingAgain;
        private System.Windows.Forms.CheckBox checkBox3PermissionToStopCopy;
        private System.Windows.Forms.CheckBox checkBox2ShutDownProgram;
        private System.Windows.Forms.CheckBox checkBox1NotifyAboutCopying;
    }
}