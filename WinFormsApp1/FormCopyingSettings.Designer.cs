
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
            this.label6 = new System.Windows.Forms.Label();
            this.LabelTips = new System.Windows.Forms.Label();
            this.GroupGeneralSettings = new System.Windows.Forms.GroupBox();
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
            this.GroupAutoCopying.SuspendLayout();
            this.GroupGeneralSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GroupAdditionalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupAutoCopying
            // 
            this.GroupAutoCopying.Controls.Add(this.TextBoxDaysToCopy);
            this.GroupAutoCopying.Controls.Add(this.LabelDaysToCopy);
            this.GroupAutoCopying.Controls.Add(this.TextBoxTypeExtension);
            this.GroupAutoCopying.Controls.Add(this.LabelTypeExtension);
            this.GroupAutoCopying.Controls.Add(this.CheckBoxCopyAllTheFiles);
            this.GroupAutoCopying.Controls.Add(this.label6);
            this.GroupAutoCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAutoCopying.Location = new System.Drawing.Point(472, 36);
            this.GroupAutoCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Size = new System.Drawing.Size(491, 204);
            this.GroupAutoCopying.TabIndex = 0;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Автоматическое копирование";
            // 
            // TextBoxDaysToCopy
            // 
            this.TextBoxDaysToCopy.Location = new System.Drawing.Point(306, 111);
            this.TextBoxDaysToCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDaysToCopy.Name = "TextBoxDaysToCopy";
            this.TextBoxDaysToCopy.Size = new System.Drawing.Size(114, 28);
            this.TextBoxDaysToCopy.TabIndex = 6;
            // 
            // LabelDaysToCopy
            // 
            this.LabelDaysToCopy.Location = new System.Drawing.Point(7, 89);
            this.LabelDaysToCopy.Name = "LabelDaysToCopy";
            this.LabelDaysToCopy.Size = new System.Drawing.Size(293, 53);
            this.LabelDaysToCopy.TabIndex = 1;
            this.LabelDaysToCopy.Text = "Укажите за сколько последних дней производить копирование";
            // 
            // TextBoxTypeExtension
            // 
            this.TextBoxTypeExtension.Location = new System.Drawing.Point(254, 47);
            this.TextBoxTypeExtension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTypeExtension.Name = "TextBoxTypeExtension";
            this.TextBoxTypeExtension.Size = new System.Drawing.Size(166, 28);
            this.TextBoxTypeExtension.TabIndex = 5;
            // 
            // LabelTypeExtension
            // 
            this.LabelTypeExtension.Location = new System.Drawing.Point(7, 47);
            this.LabelTypeExtension.Name = "LabelTypeExtension";
            this.LabelTypeExtension.Size = new System.Drawing.Size(241, 31);
            this.LabelTypeExtension.TabIndex = 0;
            this.LabelTypeExtension.Text = "Укажите расширение файлов";
            // 
            // CheckBoxCopyAllTheFiles
            // 
            this.CheckBoxCopyAllTheFiles.AutoSize = true;
            this.CheckBoxCopyAllTheFiles.Location = new System.Drawing.Point(7, 163);
            this.CheckBoxCopyAllTheFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxCopyAllTheFiles.Name = "CheckBoxCopyAllTheFiles";
            this.CheckBoxCopyAllTheFiles.Size = new System.Drawing.Size(482, 28);
            this.CheckBoxCopyAllTheFiles.TabIndex = 7;
            this.CheckBoxCopyAllTheFiles.Text = "Копировать все файлы из выбранной директории";
            this.CheckBoxCopyAllTheFiles.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(38, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 3);
            this.label6.TabIndex = 3;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Location = new System.Drawing.Point(694, 248);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(267, 222);
            this.LabelTips.TabIndex = 2;
            this.LabelTips.Text = "label1";
            // 
            // GroupGeneralSettings
            // 
            this.GroupGeneralSettings.Controls.Add(this.ListBoxDirectoriesResult);
            this.GroupGeneralSettings.Controls.Add(this.LabelTargetDirectory);
            this.GroupGeneralSettings.Controls.Add(this.LabelDirectoryToCopy);
            this.GroupGeneralSettings.Controls.Add(this.ButtonChooseTargetDirectory);
            this.GroupGeneralSettings.Controls.Add(this.ButtonChooseDirectoryToCopy);
            this.GroupGeneralSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupGeneralSettings.Location = new System.Drawing.Point(14, 36);
            this.GroupGeneralSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupGeneralSettings.Name = "GroupGeneralSettings";
            this.GroupGeneralSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupGeneralSettings.Size = new System.Drawing.Size(429, 204);
            this.GroupGeneralSettings.TabIndex = 1;
            this.GroupGeneralSettings.TabStop = false;
            this.GroupGeneralSettings.Text = "Общие настройки";
            // 
            // ListBoxDirectoriesResult
            // 
            this.ListBoxDirectoriesResult.BackColor = System.Drawing.SystemColors.Control;
            this.ListBoxDirectoriesResult.FormattingEnabled = true;
            this.ListBoxDirectoriesResult.HorizontalScrollbar = true;
            this.ListBoxDirectoriesResult.ItemHeight = 23;
            this.ListBoxDirectoriesResult.Location = new System.Drawing.Point(9, 111);
            this.ListBoxDirectoriesResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxDirectoriesResult.Name = "ListBoxDirectoriesResult";
            this.ListBoxDirectoriesResult.Size = new System.Drawing.Size(412, 50);
            this.ListBoxDirectoriesResult.TabIndex = 5;
            this.ListBoxDirectoriesResult.Visible = false;
            // 
            // LabelTargetDirectory
            // 
            this.LabelTargetDirectory.Location = new System.Drawing.Point(7, 63);
            this.LabelTargetDirectory.Name = "LabelTargetDirectory";
            this.LabelTargetDirectory.Size = new System.Drawing.Size(278, 31);
            this.LabelTargetDirectory.TabIndex = 3;
            this.LabelTargetDirectory.Text = "Укажите директорию назначения";
            // 
            // LabelDirectoryToCopy
            // 
            this.LabelDirectoryToCopy.Location = new System.Drawing.Point(7, 27);
            this.LabelDirectoryToCopy.Name = "LabelDirectoryToCopy";
            this.LabelDirectoryToCopy.Size = new System.Drawing.Size(266, 31);
            this.LabelDirectoryToCopy.TabIndex = 2;
            this.LabelDirectoryToCopy.Text = "Укажите основную директорию";
            // 
            // ButtonChooseTargetDirectory
            // 
            this.ButtonChooseTargetDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseTargetDirectory.Location = new System.Drawing.Point(291, 61);
            this.ButtonChooseTargetDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChooseTargetDirectory.Name = "ButtonChooseTargetDirectory";
            this.ButtonChooseTargetDirectory.Size = new System.Drawing.Size(82, 31);
            this.ButtonChooseTargetDirectory.TabIndex = 4;
            this.ButtonChooseTargetDirectory.Text = "добавить";
            this.ButtonChooseTargetDirectory.UseVisualStyleBackColor = true;
            // 
            // ButtonChooseDirectoryToCopy
            // 
            this.ButtonChooseDirectoryToCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseDirectoryToCopy.Location = new System.Drawing.Point(291, 27);
            this.ButtonChooseDirectoryToCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChooseDirectoryToCopy.Name = "ButtonChooseDirectoryToCopy";
            this.ButtonChooseDirectoryToCopy.Size = new System.Drawing.Size(82, 31);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(965, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // GroupAdditionalSettings
            // 
            this.GroupAdditionalSettings.Controls.Add(this.CheckedListBoxAdditionalSettings);
            this.GroupAdditionalSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAdditionalSettings.Location = new System.Drawing.Point(14, 248);
            this.GroupAdditionalSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAdditionalSettings.Name = "GroupAdditionalSettings";
            this.GroupAdditionalSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAdditionalSettings.Size = new System.Drawing.Size(673, 223);
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
            this.CheckedListBoxAdditionalSettings.Location = new System.Drawing.Point(7, 31);
            this.CheckedListBoxAdditionalSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckedListBoxAdditionalSettings.Name = "CheckedListBoxAdditionalSettings";
            this.CheckedListBoxAdditionalSettings.Size = new System.Drawing.Size(657, 142);
            this.CheckedListBoxAdditionalSettings.TabIndex = 0;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApply.Location = new System.Drawing.Point(709, 475);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(77, 31);
            this.ButtonApply.TabIndex = 10;
            this.ButtonApply.Text = "Принять";
            this.ButtonApply.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(792, 475);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(77, 31);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOk.Location = new System.Drawing.Point(875, 475);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(77, 31);
            this.ButtonOk.TabIndex = 11;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // FormCopyingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 515);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.GroupAdditionalSettings);
            this.Controls.Add(this.GroupGeneralSettings);
            this.Controls.Add(this.LabelTips);
            this.Controls.Add(this.GroupAutoCopying);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCopyingSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки копирования";
            this.Load += new System.EventHandler(this.FormCopyingSettings_Load);
            this.GroupAutoCopying.ResumeLayout(false);
            this.GroupAutoCopying.PerformLayout();
            this.GroupGeneralSettings.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupAdditionalSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupAutoCopying;
        private System.Windows.Forms.Label LabelTips;
        private System.Windows.Forms.GroupBox GroupGeneralSettings;
        private System.Windows.Forms.Button ButtonChooseTargetDirectory;
        private System.Windows.Forms.Button ButtonChooseDirectoryToCopy;
        private System.Windows.Forms.Label LabelDirectoryToCopy;
        private System.Windows.Forms.Label LabelDaysToCopy;
        private System.Windows.Forms.Label LabelTypeExtension;
        private System.Windows.Forms.Label label6;
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
    }
}