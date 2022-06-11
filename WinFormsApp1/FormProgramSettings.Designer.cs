﻿
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
            this.GroupProgramSettings.SuspendLayout();
            this.GroupLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupProgramSettings
            // 
            this.GroupProgramSettings.Controls.Add(this.CheckedListBoxProgramSettings);
            this.GroupProgramSettings.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupProgramSettings.Location = new System.Drawing.Point(15, 127);
            this.GroupProgramSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupProgramSettings.Name = "GroupProgramSettings";
            this.GroupProgramSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupProgramSettings.Size = new System.Drawing.Size(426, 227);
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
            this.CheckedListBoxProgramSettings.Size = new System.Drawing.Size(416, 119);
            this.CheckedListBoxProgramSettings.TabIndex = 0;
            // 
            // GroupLanguage
            // 
            this.GroupLanguage.Controls.Add(this.RadioButtonEnglish);
            this.GroupLanguage.Controls.Add(this.RadioButtonRussian);
            this.GroupLanguage.Location = new System.Drawing.Point(15, 17);
            this.GroupLanguage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupLanguage.Name = "GroupLanguage";
            this.GroupLanguage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupLanguage.Size = new System.Drawing.Size(142, 101);
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
            this.RadioButtonEnglish.Size = new System.Drawing.Size(113, 24);
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
            this.RadioButtonRussian.Size = new System.Drawing.Size(84, 24);
            this.RadioButtonRussian.TabIndex = 0;
            this.RadioButtonRussian.TabStop = true;
            this.RadioButtonRussian.Text = "Русский";
            this.RadioButtonRussian.UseVisualStyleBackColor = true;
            // 
            // FormProgramSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 357);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupProgramSettings;
        private System.Windows.Forms.CheckedListBox CheckedListBoxProgramSettings;
        private System.Windows.Forms.GroupBox GroupLanguage;
        private System.Windows.Forms.RadioButton RadioButtonEnglish;
        private System.Windows.Forms.RadioButton RadioButtonRussian;
    }
}