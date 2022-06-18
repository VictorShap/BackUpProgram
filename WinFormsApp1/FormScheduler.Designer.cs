namespace WinFormsApp1
{
    partial class FormScheduler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxDaysToCopy = new System.Windows.Forms.TextBox();
            this.LabelDaysToCopy = new System.Windows.Forms.Label();
            this.TextBoxTypeExtension = new System.Windows.Forms.TextBox();
            this.LabelTypeExtension = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBoxCopyAllTheFiles = new System.Windows.Forms.CheckBox();
            this.ListBoxDirectoriesResult = new System.Windows.Forms.ListBox();
            this.LabelDirectoryToCopy = new System.Windows.Forms.Label();
            this.ButtonChooseDirectoryToCopy = new System.Windows.Forms.Button();
            this.ButtonChooseTargetDirectory = new System.Windows.Forms.Button();
            this.LabelTargetDirectory = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.LabelTips = new System.Windows.Forms.Label();
            this.PanelSelectDate = new System.Windows.Forms.Panel();
            this.LabelSelectDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PanelSelectDate.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxDaysToCopy);
            this.groupBox1.Controls.Add(this.LabelDaysToCopy);
            this.groupBox1.Controls.Add(this.TextBoxTypeExtension);
            this.groupBox1.Controls.Add(this.LabelTypeExtension);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(451, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(473, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры копирования";
            this.groupBox1.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // TextBoxDaysToCopy
            // 
            this.TextBoxDaysToCopy.Location = new System.Drawing.Point(312, 103);
            this.TextBoxDaysToCopy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxDaysToCopy.Name = "TextBoxDaysToCopy";
            this.TextBoxDaysToCopy.Size = new System.Drawing.Size(153, 28);
            this.TextBoxDaysToCopy.TabIndex = 12;
            this.TextBoxDaysToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelDaysToCopy
            // 
            this.LabelDaysToCopy.Location = new System.Drawing.Point(6, 84);
            this.LabelDaysToCopy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelDaysToCopy.Name = "LabelDaysToCopy";
            this.LabelDaysToCopy.Size = new System.Drawing.Size(315, 52);
            this.LabelDaysToCopy.TabIndex = 10;
            this.LabelDaysToCopy.Text = "Укажите, за сколько последних дней производить копирование";
            this.LabelDaysToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // TextBoxTypeExtension
            // 
            this.TextBoxTypeExtension.Location = new System.Drawing.Point(312, 33);
            this.TextBoxTypeExtension.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxTypeExtension.Name = "TextBoxTypeExtension";
            this.TextBoxTypeExtension.Size = new System.Drawing.Size(153, 28);
            this.TextBoxTypeExtension.TabIndex = 11;
            this.TextBoxTypeExtension.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTypeExtension
            // 
            this.LabelTypeExtension.Location = new System.Drawing.Point(7, 27);
            this.LabelTypeExtension.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTypeExtension.Name = "LabelTypeExtension";
            this.LabelTypeExtension.Size = new System.Drawing.Size(314, 57);
            this.LabelTypeExtension.TabIndex = 9;
            this.LabelTypeExtension.Text = "Укажите расширение файлов, которые нужно копировать";
            this.LabelTypeExtension.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBoxCopyAllTheFiles);
            this.groupBox2.Controls.Add(this.ListBoxDirectoriesResult);
            this.groupBox2.Controls.Add(this.LabelDirectoryToCopy);
            this.groupBox2.Controls.Add(this.ButtonChooseDirectoryToCopy);
            this.groupBox2.Controls.Add(this.ButtonChooseTargetDirectory);
            this.groupBox2.Controls.Add(this.LabelTargetDirectory);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(439, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные параметры";
            this.groupBox2.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // CheckBoxCopyAllTheFiles
            // 
            this.CheckBoxCopyAllTheFiles.Location = new System.Drawing.Point(7, 177);
            this.CheckBoxCopyAllTheFiles.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CheckBoxCopyAllTheFiles.Name = "CheckBoxCopyAllTheFiles";
            this.CheckBoxCopyAllTheFiles.Size = new System.Drawing.Size(421, 62);
            this.CheckBoxCopyAllTheFiles.TabIndex = 7;
            this.CheckBoxCopyAllTheFiles.Text = "Копировать все файлы из выбранной директории";
            this.CheckBoxCopyAllTheFiles.UseVisualStyleBackColor = true;
            this.CheckBoxCopyAllTheFiles.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.CheckBoxCopyAllTheFiles.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxDirectoriesResult
            // 
            this.ListBoxDirectoriesResult.FormattingEnabled = true;
            this.ListBoxDirectoriesResult.ItemHeight = 23;
            this.ListBoxDirectoriesResult.Location = new System.Drawing.Point(7, 103);
            this.ListBoxDirectoriesResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxDirectoriesResult.Name = "ListBoxDirectoriesResult";
            this.ListBoxDirectoriesResult.Size = new System.Drawing.Size(423, 73);
            this.ListBoxDirectoriesResult.TabIndex = 24;
            this.ListBoxDirectoriesResult.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelDirectoryToCopy
            // 
            this.LabelDirectoryToCopy.Location = new System.Drawing.Point(7, 27);
            this.LabelDirectoryToCopy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelDirectoryToCopy.Name = "LabelDirectoryToCopy";
            this.LabelDirectoryToCopy.Size = new System.Drawing.Size(297, 39);
            this.LabelDirectoryToCopy.TabIndex = 5;
            this.LabelDirectoryToCopy.Text = "Укажите основную директорию";
            this.LabelDirectoryToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChooseDirectoryToCopy
            // 
            this.ButtonChooseDirectoryToCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseDirectoryToCopy.Location = new System.Drawing.Point(323, 24);
            this.ButtonChooseDirectoryToCopy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonChooseDirectoryToCopy.Name = "ButtonChooseDirectoryToCopy";
            this.ButtonChooseDirectoryToCopy.Size = new System.Drawing.Size(107, 31);
            this.ButtonChooseDirectoryToCopy.TabIndex = 7;
            this.ButtonChooseDirectoryToCopy.Text = "добавить";
            this.ButtonChooseDirectoryToCopy.UseVisualStyleBackColor = true;
            this.ButtonChooseDirectoryToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChooseTargetDirectory
            // 
            this.ButtonChooseTargetDirectory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonChooseTargetDirectory.Location = new System.Drawing.Point(323, 64);
            this.ButtonChooseTargetDirectory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonChooseTargetDirectory.Name = "ButtonChooseTargetDirectory";
            this.ButtonChooseTargetDirectory.Size = new System.Drawing.Size(107, 31);
            this.ButtonChooseTargetDirectory.TabIndex = 8;
            this.ButtonChooseTargetDirectory.Text = "добавить";
            this.ButtonChooseTargetDirectory.UseVisualStyleBackColor = true;
            this.ButtonChooseTargetDirectory.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTargetDirectory
            // 
            this.LabelTargetDirectory.Location = new System.Drawing.Point(7, 63);
            this.LabelTargetDirectory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTargetDirectory.Name = "LabelTargetDirectory";
            this.LabelTargetDirectory.Size = new System.Drawing.Size(340, 31);
            this.LabelTargetDirectory.TabIndex = 6;
            this.LabelTargetDirectory.Text = "Укажите директорию назначения";
            this.LabelTargetDirectory.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOk.Location = new System.Drawing.Point(845, 216);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(79, 31);
            this.ButtonOk.TabIndex = 14;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(751, 216);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(84, 31);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApply.Location = new System.Drawing.Point(652, 216);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(86, 31);
            this.ButtonApply.TabIndex = 13;
            this.ButtonApply.Text = "Принять";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(933, 11);
            this.LabelTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(208, 235);
            this.LabelTips.TabIndex = 15;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков - и тут отобразится подробная информация.";
            this.LabelTips.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // PanelSelectDate
            // 
            this.PanelSelectDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSelectDate.Controls.Add(this.LabelSelectDate);
            this.PanelSelectDate.Controls.Add(this.dateTimePicker);
            this.PanelSelectDate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PanelSelectDate.Location = new System.Drawing.Point(451, 153);
            this.PanelSelectDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PanelSelectDate.Name = "PanelSelectDate";
            this.PanelSelectDate.Size = new System.Drawing.Size(473, 49);
            this.PanelSelectDate.TabIndex = 16;
            this.PanelSelectDate.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelSelectDate
            // 
            this.LabelSelectDate.Location = new System.Drawing.Point(6, 8);
            this.LabelSelectDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSelectDate.Name = "LabelSelectDate";
            this.LabelSelectDate.Size = new System.Drawing.Size(174, 32);
            this.LabelSelectDate.TabIndex = 23;
            this.LabelSelectDate.Text = "Выберите дату копирования";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(180, 13);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(284, 27);
            this.dateTimePicker.TabIndex = 22;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.PanelSelectDate);
            this.Panel.Controls.Add(this.groupBox1);
            this.Panel.Controls.Add(this.LabelTips);
            this.Panel.Controls.Add(this.ButtonApply);
            this.Panel.Controls.Add(this.ButtonOk);
            this.Panel.Controls.Add(this.ButtonCancel);
            this.Panel.Controls.Add(this.groupBox2);
            this.Panel.Location = new System.Drawing.Point(-2, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1144, 252);
            this.Panel.TabIndex = 17;
            this.Panel.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // FormScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 251);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormScheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Планировщик";
            this.Load += new System.EventHandler(this.FormScheduler_Load);
            this.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.PanelSelectDate.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxDaysToCopy;
        private System.Windows.Forms.Label LabelDaysToCopy;
        private System.Windows.Forms.TextBox TextBoxTypeExtension;
        private System.Windows.Forms.Label LabelTypeExtension;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelDirectoryToCopy;
        private System.Windows.Forms.Button ButtonChooseDirectoryToCopy;
        private System.Windows.Forms.Button ButtonChooseTargetDirectory;
        private System.Windows.Forms.Label LabelTargetDirectory;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Label LabelTips;
        private System.Windows.Forms.Panel PanelSelectDate;
        private System.Windows.Forms.CheckBox CheckBoxCopyAllTheFiles;
        private System.Windows.Forms.Label LabelSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox ListBoxDirectoriesResult;
        private System.Windows.Forms.Panel Panel;
    }
}