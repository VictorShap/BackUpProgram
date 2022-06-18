
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
            this.ListBoxDirectoriesResult = new System.Windows.Forms.ListBox();
            this.LabelTargetDirectory = new System.Windows.Forms.Label();
            this.LabelDirectoryToCopy = new System.Windows.Forms.Label();
            this.ButtonChooseTargetDirectory = new System.Windows.Forms.Button();
            this.ButtonChooseDirectoryToCopy = new System.Windows.Forms.Button();
            this.TextBoxDaysToCopy = new System.Windows.Forms.TextBox();
            this.LabelDaysToCopy = new System.Windows.Forms.Label();
            this.TextBoxTypeExtension = new System.Windows.Forms.TextBox();
            this.LabelTypeExtension = new System.Windows.Forms.Label();
            this.CheckBoxCopyAllTheFiles = new System.Windows.Forms.CheckBox();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTips = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.GroupAutoCopying.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupAutoCopying
            // 
            this.GroupAutoCopying.Controls.Add(this.ListBoxDirectoriesResult);
            this.GroupAutoCopying.Controls.Add(this.LabelTargetDirectory);
            this.GroupAutoCopying.Controls.Add(this.LabelDirectoryToCopy);
            this.GroupAutoCopying.Controls.Add(this.ButtonChooseTargetDirectory);
            this.GroupAutoCopying.Controls.Add(this.ButtonChooseDirectoryToCopy);
            this.GroupAutoCopying.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupAutoCopying.Location = new System.Drawing.Point(1, 1);
            this.GroupAutoCopying.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Name = "GroupAutoCopying";
            this.GroupAutoCopying.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupAutoCopying.Size = new System.Drawing.Size(450, 241);
            this.GroupAutoCopying.TabIndex = 0;
            this.GroupAutoCopying.TabStop = false;
            this.GroupAutoCopying.Text = "Регулярное копирование";
            this.GroupAutoCopying.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxDirectoriesResult
            // 
            this.ListBoxDirectoriesResult.FormattingEnabled = true;
            this.ListBoxDirectoriesResult.ItemHeight = 23;
            this.ListBoxDirectoriesResult.Location = new System.Drawing.Point(7, 106);
            this.ListBoxDirectoriesResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxDirectoriesResult.Name = "ListBoxDirectoriesResult";
            this.ListBoxDirectoriesResult.Size = new System.Drawing.Size(431, 119);
            this.ListBoxDirectoriesResult.TabIndex = 25;
            this.ListBoxDirectoriesResult.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTargetDirectory
            // 
            this.LabelTargetDirectory.Location = new System.Drawing.Point(7, 67);
            this.LabelTargetDirectory.Name = "LabelTargetDirectory";
            this.LabelTargetDirectory.Size = new System.Drawing.Size(322, 31);
            this.LabelTargetDirectory.TabIndex = 3;
            this.LabelTargetDirectory.Text = "Укажите директорию назначения";
            this.LabelTargetDirectory.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelDirectoryToCopy
            // 
            this.LabelDirectoryToCopy.Location = new System.Drawing.Point(7, 31);
            this.LabelDirectoryToCopy.Name = "LabelDirectoryToCopy";
            this.LabelDirectoryToCopy.Size = new System.Drawing.Size(295, 39);
            this.LabelDirectoryToCopy.TabIndex = 2;
            this.LabelDirectoryToCopy.Text = "Укажите основную директорию";
            this.LabelDirectoryToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChooseTargetDirectory
            // 
            this.ButtonChooseTargetDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseTargetDirectory.Location = new System.Drawing.Point(331, 67);
            this.ButtonChooseTargetDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChooseTargetDirectory.Name = "ButtonChooseTargetDirectory";
            this.ButtonChooseTargetDirectory.Size = new System.Drawing.Size(107, 31);
            this.ButtonChooseTargetDirectory.TabIndex = 4;
            this.ButtonChooseTargetDirectory.Text = "добавить";
            this.ButtonChooseTargetDirectory.UseVisualStyleBackColor = true;
            this.ButtonChooseTargetDirectory.Click += new System.EventHandler(this.ButtonChooseTargetDirectory_Click);
            this.ButtonChooseTargetDirectory.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChooseDirectoryToCopy
            // 
            this.ButtonChooseDirectoryToCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseDirectoryToCopy.Location = new System.Drawing.Point(331, 29);
            this.ButtonChooseDirectoryToCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonChooseDirectoryToCopy.Name = "ButtonChooseDirectoryToCopy";
            this.ButtonChooseDirectoryToCopy.Size = new System.Drawing.Size(107, 31);
            this.ButtonChooseDirectoryToCopy.TabIndex = 3;
            this.ButtonChooseDirectoryToCopy.Text = "добавить";
            this.ButtonChooseDirectoryToCopy.UseVisualStyleBackColor = true;
            this.ButtonChooseDirectoryToCopy.Click += new System.EventHandler(this.ButtonChooseDirectoryToCopy_Click);
            this.ButtonChooseDirectoryToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // TextBoxDaysToCopy
            // 
            this.TextBoxDaysToCopy.Location = new System.Drawing.Point(301, 84);
            this.TextBoxDaysToCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDaysToCopy.Name = "TextBoxDaysToCopy";
            this.TextBoxDaysToCopy.Size = new System.Drawing.Size(117, 28);
            this.TextBoxDaysToCopy.TabIndex = 6;
            this.TextBoxDaysToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelDaysToCopy
            // 
            this.LabelDaysToCopy.Location = new System.Drawing.Point(7, 84);
            this.LabelDaysToCopy.Name = "LabelDaysToCopy";
            this.LabelDaysToCopy.Size = new System.Drawing.Size(318, 53);
            this.LabelDaysToCopy.TabIndex = 1;
            this.LabelDaysToCopy.Text = "Укажите, за сколько последних дней производить копирование";
            this.LabelDaysToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // TextBoxTypeExtension
            // 
            this.TextBoxTypeExtension.Location = new System.Drawing.Point(301, 32);
            this.TextBoxTypeExtension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTypeExtension.Name = "TextBoxTypeExtension";
            this.TextBoxTypeExtension.Size = new System.Drawing.Size(117, 28);
            this.TextBoxTypeExtension.TabIndex = 5;
            this.TextBoxTypeExtension.TextChanged += new System.EventHandler(this.TextBoxTypeExtension_TextChanged);
            this.TextBoxTypeExtension.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTypeExtension
            // 
            this.LabelTypeExtension.Location = new System.Drawing.Point(7, 31);
            this.LabelTypeExtension.Name = "LabelTypeExtension";
            this.LabelTypeExtension.Size = new System.Drawing.Size(288, 53);
            this.LabelTypeExtension.TabIndex = 0;
            this.LabelTypeExtension.Text = "Укажите расширение файлов, которые нужно копировать";
            this.LabelTypeExtension.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // CheckBoxCopyAllTheFiles
            // 
            this.CheckBoxCopyAllTheFiles.Location = new System.Drawing.Point(-6, -1);
            this.CheckBoxCopyAllTheFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxCopyAllTheFiles.Name = "CheckBoxCopyAllTheFiles";
            this.CheckBoxCopyAllTheFiles.Size = new System.Drawing.Size(444, 73);
            this.CheckBoxCopyAllTheFiles.TabIndex = 7;
            this.CheckBoxCopyAllTheFiles.Text = "Копировать все файлы из выбранной директории";
            this.CheckBoxCopyAllTheFiles.UseVisualStyleBackColor = true;
            this.CheckBoxCopyAllTheFiles.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApply.Location = new System.Drawing.Point(591, 223);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(77, 31);
            this.ButtonApply.TabIndex = 10;
            this.ButtonApply.Text = "Принять";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            this.ButtonApply.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(692, 223);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(77, 31);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOk.Location = new System.Drawing.Point(798, 223);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(77, 31);
            this.ButtonOk.TabIndex = 11;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelTypeExtension);
            this.groupBox1.Controls.Add(this.TextBoxTypeExtension);
            this.groupBox1.Controls.Add(this.TextBoxDaysToCopy);
            this.groupBox1.Controls.Add(this.LabelDaysToCopy);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(457, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(426, 144);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры копирования";
            this.groupBox1.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CheckBoxCopyAllTheFiles);
            this.panel1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(457, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 66);
            this.panel1.TabIndex = 27;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(891, 10);
            this.LabelTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(208, 232);
            this.LabelTips.TabIndex = 28;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков - и тут отобразится подробная информация.";
            this.LabelTips.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.ButtonOk);
            this.Panel.Controls.Add(this.panel1);
            this.Panel.Controls.Add(this.ButtonCancel);
            this.Panel.Controls.Add(this.LabelTips);
            this.Panel.Controls.Add(this.ButtonApply);
            this.Panel.Controls.Add(this.GroupAutoCopying);
            this.Panel.Controls.Add(this.groupBox1);
            this.Panel.Location = new System.Drawing.Point(6, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1116, 258);
            this.Panel.TabIndex = 29;
            this.Panel.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // FormCopyingSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 272);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCopyingSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.FormCopyingSettings_Load);
            this.GroupAutoCopying.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupAutoCopying;
        private System.Windows.Forms.Button ButtonChooseTargetDirectory;
        private System.Windows.Forms.Button ButtonChooseDirectoryToCopy;
        private System.Windows.Forms.Label LabelDirectoryToCopy;
        private System.Windows.Forms.Label LabelDaysToCopy;
        private System.Windows.Forms.Label LabelTypeExtension;
        private System.Windows.Forms.Label LabelTargetDirectory;
        private System.Windows.Forms.CheckBox CheckBoxCopyAllTheFiles;
        private System.Windows.Forms.TextBox TextBoxDaysToCopy;
        private System.Windows.Forms.TextBox TextBoxTypeExtension;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.ListBox ListBoxDirectoriesResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTips;
        private System.Windows.Forms.Panel Panel;
    }
}