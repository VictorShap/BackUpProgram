
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
            this.TextBoxDaysToCopy = new System.Windows.Forms.TextBox();
            this.LabelDaysToCopy = new System.Windows.Forms.Label();
            this.TextBoxTypeExtension = new System.Windows.Forms.TextBox();
            this.LabelTypeExtension = new System.Windows.Forms.Label();
            this.CheckBoxCopyAllTheFiles = new System.Windows.Forms.CheckBox();
            this.LabelTips = new System.Windows.Forms.Label();
            this.ListBoxDirectoriesResult = new System.Windows.Forms.ListBox();
            this.LabelTargetDirectory = new System.Windows.Forms.Label();
            this.LabelDirectoryToCopy = new System.Windows.Forms.Label();
            this.ButtonChooseTargetDirectory = new System.Windows.Forms.Button();
            this.ButtonChooseDirectoryToCopy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupAdditionalSettings = new System.Windows.Forms.GroupBox();
            this.CheckedListBoxAdditionalSettings = new System.Windows.Forms.CheckedListBox();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.GroupAutoCopying.Size = new System.Drawing.Size(822, 127);
            this.GroupAutoCopying.TabIndex = 0;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Автоматическое копирование";
            this.GroupAutoCopying.Enter += new System.EventHandler(this.GroupAutoCopying_Enter);
            // 
            // TextBoxDaysToCopy
            // 
            this.TextBoxDaysToCopy.Location = new System.Drawing.Point(651, 68);
            this.TextBoxDaysToCopy.Name = "TextBoxDaysToCopy";
            this.TextBoxDaysToCopy.Size = new System.Drawing.Size(100, 24);
            this.TextBoxDaysToCopy.TabIndex = 6;
            // 
            // LabelDaysToCopy
            // 
            this.LabelDaysToCopy.Location = new System.Drawing.Point(389, 52);
            this.LabelDaysToCopy.Name = "LabelDaysToCopy";
            this.LabelDaysToCopy.Size = new System.Drawing.Size(256, 40);
            this.LabelDaysToCopy.TabIndex = 1;
            this.LabelDaysToCopy.Text = "Укажите за сколько последних дней производить копирование";
            // 
            // TextBoxTypeExtension
            // 
            this.TextBoxTypeExtension.Location = new System.Drawing.Point(605, 20);
            this.TextBoxTypeExtension.Name = "TextBoxTypeExtension";
            this.TextBoxTypeExtension.Size = new System.Drawing.Size(146, 24);
            this.TextBoxTypeExtension.TabIndex = 5;
            // 
            // LabelTypeExtension
            // 
            this.LabelTypeExtension.Location = new System.Drawing.Point(389, 20);
            this.LabelTypeExtension.Name = "LabelTypeExtension";
            this.LabelTypeExtension.Size = new System.Drawing.Size(211, 23);
            this.LabelTypeExtension.TabIndex = 0;
            this.LabelTypeExtension.Text = "Укажите расширение файлов";
            // 
            // CheckBoxCopyAllTheFiles
            // 
            this.CheckBoxCopyAllTheFiles.AutoSize = true;
            this.CheckBoxCopyAllTheFiles.Location = new System.Drawing.Point(389, 98);
            this.CheckBoxCopyAllTheFiles.Name = "CheckBoxCopyAllTheFiles";
            this.CheckBoxCopyAllTheFiles.Size = new System.Drawing.Size(368, 23);
            this.CheckBoxCopyAllTheFiles.TabIndex = 7;
            this.CheckBoxCopyAllTheFiles.Text = "Копировать все файлы из выбранной директории";
            this.CheckBoxCopyAllTheFiles.UseVisualStyleBackColor = true;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Location = new System.Drawing.Point(607, 160);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(234, 151);
            this.LabelTips.TabIndex = 2;
            this.LabelTips.Text = "label1";
            // 
            // ListBoxDirectoriesResult
            // 
            this.ListBoxDirectoriesResult.BackColor = System.Drawing.SystemColors.Control;
            this.ListBoxDirectoriesResult.FormattingEnabled = true;
            this.ListBoxDirectoriesResult.HorizontalScrollbar = true;
            this.ListBoxDirectoriesResult.ItemHeight = 19;
            this.ListBoxDirectoriesResult.Location = new System.Drawing.Point(6, 79);
            this.ListBoxDirectoriesResult.Name = "ListBoxDirectoriesResult";
            this.ListBoxDirectoriesResult.Size = new System.Drawing.Size(361, 42);
            this.ListBoxDirectoriesResult.TabIndex = 5;
            this.ListBoxDirectoriesResult.Visible = false;
            // 
            // LabelTargetDirectory
            // 
            this.LabelTargetDirectory.Location = new System.Drawing.Point(6, 50);
            this.LabelTargetDirectory.Name = "LabelTargetDirectory";
            this.LabelTargetDirectory.Size = new System.Drawing.Size(243, 23);
            this.LabelTargetDirectory.TabIndex = 3;
            this.LabelTargetDirectory.Text = "Укажите директорию назначения";
            // 
            // LabelDirectoryToCopy
            // 
            this.LabelDirectoryToCopy.Location = new System.Drawing.Point(6, 23);
            this.LabelDirectoryToCopy.Name = "LabelDirectoryToCopy";
            this.LabelDirectoryToCopy.Size = new System.Drawing.Size(233, 23);
            this.LabelDirectoryToCopy.TabIndex = 2;
            this.LabelDirectoryToCopy.Text = "Укажите основную директорию";
            // 
            // ButtonChooseTargetDirectory
            // 
            this.ButtonChooseTargetDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseTargetDirectory.Location = new System.Drawing.Point(255, 49);
            this.ButtonChooseTargetDirectory.Name = "ButtonChooseTargetDirectory";
            this.ButtonChooseTargetDirectory.Size = new System.Drawing.Size(72, 23);
            this.ButtonChooseTargetDirectory.TabIndex = 4;
            this.ButtonChooseTargetDirectory.Text = "добавить";
            this.ButtonChooseTargetDirectory.UseVisualStyleBackColor = true;
            // 
            // ButtonChooseDirectoryToCopy
            // 
            this.ButtonChooseDirectoryToCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseDirectoryToCopy.Location = new System.Drawing.Point(255, 23);
            this.ButtonChooseDirectoryToCopy.Name = "ButtonChooseDirectoryToCopy";
            this.ButtonChooseDirectoryToCopy.Size = new System.Drawing.Size(72, 23);
            this.ButtonChooseDirectoryToCopy.TabIndex = 3;
            this.ButtonChooseDirectoryToCopy.Text = "добавить";
            this.ButtonChooseDirectoryToCopy.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
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
            this.GroupAdditionalSettings.Controls.Add(this.CheckedListBoxAdditionalSettings);
            this.GroupAdditionalSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAdditionalSettings.Location = new System.Drawing.Point(12, 160);
            this.GroupAdditionalSettings.Name = "GroupAdditionalSettings";
            this.GroupAdditionalSettings.Size = new System.Drawing.Size(589, 151);
            this.GroupAdditionalSettings.TabIndex = 1;
            this.GroupAdditionalSettings.TabStop = false;
            this.GroupAdditionalSettings.Text = "Дополнительные настройки";
            // 
            // CheckedListBoxAdditionalSettings
            // 
            this.CheckedListBoxAdditionalSettings.BackColor = System.Drawing.SystemColors.Control;
            this.CheckedListBoxAdditionalSettings.CheckOnClick = true;
            this.CheckedListBoxAdditionalSettings.FormattingEnabled = true;
            this.CheckedListBoxAdditionalSettings.Items.AddRange(new object[] {
            "Оповещать о начале и завершении копирования",
            "Предлагать завершить работу программы, если копирование не запланировано",
            "Разрешить прерывать процесс копирования",
            "Если копирование было внезапно прервано, предлагать повторить его"});
            this.CheckedListBoxAdditionalSettings.Location = new System.Drawing.Point(6, 23);
            this.CheckedListBoxAdditionalSettings.Name = "CheckedListBoxAdditionalSettings";
            this.CheckedListBoxAdditionalSettings.Size = new System.Drawing.Size(575, 118);
            this.CheckedListBoxAdditionalSettings.TabIndex = 0;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApply.Location = new System.Drawing.Point(628, 314);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(67, 23);
            this.ButtonApply.TabIndex = 10;
            this.ButtonApply.Text = "Принять";
            this.ButtonApply.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(701, 314);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(67, 23);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOk.Location = new System.Drawing.Point(774, 314);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(67, 23);
            this.ButtonOk.TabIndex = 11;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(373, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 146);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(381, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 146);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // FormCopyingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 339);
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
        private System.Windows.Forms.CheckedListBox CheckedListBoxAdditionalSettings;
        private System.Windows.Forms.ListBox ListBoxDirectoriesResult;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}