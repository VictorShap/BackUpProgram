
namespace WinFormsApp1
{
    partial class FormProgramSettings
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
            this.GroupProgramSettings = new System.Windows.Forms.GroupBox();
            this.CheckedListBoxProgramSettings = new System.Windows.Forms.CheckedListBox();
            this.GroupLanguage = new System.Windows.Forms.GroupBox();
            this.RadioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.RadioButtonRussian = new System.Windows.Forms.RadioButton();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.GroupAdditionalSettings = new System.Windows.Forms.GroupBox();
            this.checkBox4StartCopyingAgain = new System.Windows.Forms.CheckBox();
            this.checkBox3PermissionToStopCopy = new System.Windows.Forms.CheckBox();
            this.checkBox1NotifyAboutCopying = new System.Windows.Forms.CheckBox();
            this.GroupProgramSettings.SuspendLayout();
            this.GroupLanguage.SuspendLayout();
            this.GroupAdditionalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupProgramSettings
            // 
            this.GroupProgramSettings.Controls.Add(this.CheckedListBoxProgramSettings);
            this.GroupProgramSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupProgramSettings.Location = new System.Drawing.Point(14, 16);
            this.GroupProgramSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupProgramSettings.Name = "GroupProgramSettings";
            this.GroupProgramSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupProgramSettings.Size = new System.Drawing.Size(439, 101);
            this.GroupProgramSettings.TabIndex = 2;
            this.GroupProgramSettings.TabStop = false;
            this.GroupProgramSettings.Text = "Программные настройки";
            // 
            // CheckedListBoxProgramSettings
            // 
            this.CheckedListBoxProgramSettings.BackColor = System.Drawing.SystemColors.Control;
            this.CheckedListBoxProgramSettings.FormattingEnabled = true;
            this.CheckedListBoxProgramSettings.Items.AddRange(new object[] {
            "Запуск программы вместе с windows",
            "Скрыть окно подсказок в основном окне"});
            this.CheckedListBoxProgramSettings.Location = new System.Drawing.Point(10, 36);
            this.CheckedListBoxProgramSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckedListBoxProgramSettings.Name = "CheckedListBoxProgramSettings";
            this.CheckedListBoxProgramSettings.Size = new System.Drawing.Size(415, 50);
            this.CheckedListBoxProgramSettings.TabIndex = 0;
            // 
            // GroupLanguage
            // 
            this.GroupLanguage.Controls.Add(this.RadioButtonEnglish);
            this.GroupLanguage.Controls.Add(this.RadioButtonRussian);
            this.GroupLanguage.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupLanguage.Location = new System.Drawing.Point(459, 16);
            this.GroupLanguage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupLanguage.Name = "GroupLanguage";
            this.GroupLanguage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupLanguage.Size = new System.Drawing.Size(161, 101);
            this.GroupLanguage.TabIndex = 3;
            this.GroupLanguage.TabStop = false;
            this.GroupLanguage.Text = "Язык";
            // 
            // RadioButtonEnglish
            // 
            this.RadioButtonEnglish.AutoSize = true;
            this.RadioButtonEnglish.Location = new System.Drawing.Point(9, 64);
            this.RadioButtonEnglish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButtonEnglish.Name = "RadioButtonEnglish";
            this.RadioButtonEnglish.Size = new System.Drawing.Size(141, 28);
            this.RadioButtonEnglish.TabIndex = 1;
            this.RadioButtonEnglish.TabStop = true;
            this.RadioButtonEnglish.Text = "Английский";
            this.RadioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRussian
            // 
            this.RadioButtonRussian.AutoSize = true;
            this.RadioButtonRussian.Location = new System.Drawing.Point(9, 31);
            this.RadioButtonRussian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButtonRussian.Name = "RadioButtonRussian";
            this.RadioButtonRussian.Size = new System.Drawing.Size(102, 28);
            this.RadioButtonRussian.TabIndex = 0;
            this.RadioButtonRussian.TabStop = true;
            this.RadioButtonRussian.Text = "Русский";
            this.RadioButtonRussian.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOk.Location = new System.Drawing.Point(544, 299);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(77, 31);
            this.ButtonOk.TabIndex = 14;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(461, 299);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(77, 31);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApply.Location = new System.Drawing.Point(377, 299);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(77, 31);
            this.ButtonApply.TabIndex = 13;
            this.ButtonApply.Text = "Принять";
            this.ButtonApply.UseVisualStyleBackColor = true;
            // 
            // GroupAdditionalSettings
            // 
            this.GroupAdditionalSettings.Controls.Add(this.checkBox4StartCopyingAgain);
            this.GroupAdditionalSettings.Controls.Add(this.checkBox3PermissionToStopCopy);
            this.GroupAdditionalSettings.Controls.Add(this.checkBox1NotifyAboutCopying);
            this.GroupAdditionalSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAdditionalSettings.Location = new System.Drawing.Point(14, 125);
            this.GroupAdditionalSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAdditionalSettings.Name = "GroupAdditionalSettings";
            this.GroupAdditionalSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAdditionalSettings.Size = new System.Drawing.Size(607, 165);
            this.GroupAdditionalSettings.TabIndex = 15;
            this.GroupAdditionalSettings.TabStop = false;
            this.GroupAdditionalSettings.Text = "Дополнительные настройки";
            // 
            // checkBox4StartCopyingAgain
            // 
            this.checkBox4StartCopyingAgain.Location = new System.Drawing.Point(7, 99);
            this.checkBox4StartCopyingAgain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4StartCopyingAgain.Name = "checkBox4StartCopyingAgain";
            this.checkBox4StartCopyingAgain.Size = new System.Drawing.Size(591, 59);
            this.checkBox4StartCopyingAgain.TabIndex = 3;
            this.checkBox4StartCopyingAgain.Text = "Если копирование было внезапно прервано, предлагать повторить его";
            this.checkBox4StartCopyingAgain.UseVisualStyleBackColor = true;
            // 
            // checkBox3PermissionToStopCopy
            // 
            this.checkBox3PermissionToStopCopy.Location = new System.Drawing.Point(7, 67);
            this.checkBox3PermissionToStopCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3PermissionToStopCopy.Name = "checkBox3PermissionToStopCopy";
            this.checkBox3PermissionToStopCopy.Size = new System.Drawing.Size(455, 36);
            this.checkBox3PermissionToStopCopy.TabIndex = 2;
            this.checkBox3PermissionToStopCopy.Text = "Разрешить прерывание процесса копирования";
            this.checkBox3PermissionToStopCopy.UseVisualStyleBackColor = true;
            // 
            // checkBox1NotifyAboutCopying
            // 
            this.checkBox1NotifyAboutCopying.Location = new System.Drawing.Point(7, 31);
            this.checkBox1NotifyAboutCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1NotifyAboutCopying.Name = "checkBox1NotifyAboutCopying";
            this.checkBox1NotifyAboutCopying.Size = new System.Drawing.Size(475, 32);
            this.checkBox1NotifyAboutCopying.TabIndex = 0;
            this.checkBox1NotifyAboutCopying.Text = "Оповещать о начале и завершении копирования";
            this.checkBox1NotifyAboutCopying.UseVisualStyleBackColor = true;
            // 
            // FormProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 332);
            this.Controls.Add(this.GroupAdditionalSettings);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.GroupLanguage);
            this.Controls.Add(this.GroupProgramSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProgramSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки программы";
            this.GroupProgramSettings.ResumeLayout(false);
            this.GroupLanguage.ResumeLayout(false);
            this.GroupLanguage.PerformLayout();
            this.GroupAdditionalSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupProgramSettings;
        private System.Windows.Forms.CheckedListBox CheckedListBoxProgramSettings;
        private System.Windows.Forms.GroupBox GroupLanguage;
        private System.Windows.Forms.RadioButton RadioButtonEnglish;
        private System.Windows.Forms.RadioButton RadioButtonRussian;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.GroupBox GroupAdditionalSettings;
        private System.Windows.Forms.CheckBox checkBox4StartCopyingAgain;
        private System.Windows.Forms.CheckBox checkBox3PermissionToStopCopy;
        private System.Windows.Forms.CheckBox checkBox1NotifyAboutCopying;
    }
}