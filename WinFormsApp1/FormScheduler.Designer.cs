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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ListBoxDirectoriesResult = new System.Windows.Forms.ListBox();
            this.LabelDirectoryToCopy = new System.Windows.Forms.Label();
            this.ButtonChooseDirectoryToCopy = new System.Windows.Forms.Button();
            this.ButtonChooseTargetDirectory = new System.Windows.Forms.Button();
            this.LabelTargetDirectory = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.LabelTips = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelSelectDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxDaysToCopy);
            this.groupBox1.Controls.Add(this.LabelDaysToCopy);
            this.groupBox1.Controls.Add(this.TextBoxTypeExtension);
            this.groupBox1.Controls.Add(this.LabelTypeExtension);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(462, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(473, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры копирования";
            // 
            // TextBoxDaysToCopy
            // 
            this.TextBoxDaysToCopy.Location = new System.Drawing.Point(330, 103);
            this.TextBoxDaysToCopy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxDaysToCopy.Name = "TextBoxDaysToCopy";
            this.TextBoxDaysToCopy.Size = new System.Drawing.Size(135, 28);
            this.TextBoxDaysToCopy.TabIndex = 12;
            // 
            // LabelDaysToCopy
            // 
            this.LabelDaysToCopy.Location = new System.Drawing.Point(6, 84);
            this.LabelDaysToCopy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelDaysToCopy.Name = "LabelDaysToCopy";
            this.LabelDaysToCopy.Size = new System.Drawing.Size(315, 52);
            this.LabelDaysToCopy.TabIndex = 10;
            this.LabelDaysToCopy.Text = "Укажите, за сколько последних дней производить копирование";
            // 
            // TextBoxTypeExtension
            // 
            this.TextBoxTypeExtension.Location = new System.Drawing.Point(330, 33);
            this.TextBoxTypeExtension.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxTypeExtension.Name = "TextBoxTypeExtension";
            this.TextBoxTypeExtension.Size = new System.Drawing.Size(135, 28);
            this.TextBoxTypeExtension.TabIndex = 11;
            // 
            // LabelTypeExtension
            // 
            this.LabelTypeExtension.Location = new System.Drawing.Point(7, 27);
            this.LabelTypeExtension.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTypeExtension.Name = "LabelTypeExtension";
            this.LabelTypeExtension.Size = new System.Drawing.Size(315, 57);
            this.LabelTypeExtension.TabIndex = 9;
            this.LabelTypeExtension.Text = "Укажите расширение файлов, которые нужно копировать";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.ListBoxDirectoriesResult);
            this.groupBox2.Controls.Add(this.LabelDirectoryToCopy);
            this.groupBox2.Controls.Add(this.ButtonChooseDirectoryToCopy);
            this.groupBox2.Controls.Add(this.ButtonChooseTargetDirectory);
            this.groupBox2.Controls.Add(this.LabelTargetDirectory);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(439, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные параметры";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(7, 177);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(421, 62);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Копировать все файлы из выбранной директории";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ListBoxDirectoriesResult
            // 
            this.ListBoxDirectoriesResult.FormattingEnabled = true;
            this.ListBoxDirectoriesResult.ItemHeight = 23;
            this.ListBoxDirectoriesResult.Location = new System.Drawing.Point(7, 103);
            this.ListBoxDirectoriesResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListBoxDirectoriesResult.Name = "ListBoxDirectoriesResult";
            this.ListBoxDirectoriesResult.Size = new System.Drawing.Size(409, 73);
            this.ListBoxDirectoriesResult.TabIndex = 24;
            // 
            // LabelDirectoryToCopy
            // 
            this.LabelDirectoryToCopy.Location = new System.Drawing.Point(7, 27);
            this.LabelDirectoryToCopy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelDirectoryToCopy.Name = "LabelDirectoryToCopy";
            this.LabelDirectoryToCopy.Size = new System.Drawing.Size(297, 39);
            this.LabelDirectoryToCopy.TabIndex = 5;
            this.LabelDirectoryToCopy.Text = "Укажите основную директорию";
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
            // 
            // LabelTargetDirectory
            // 
            this.LabelTargetDirectory.Location = new System.Drawing.Point(7, 63);
            this.LabelTargetDirectory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTargetDirectory.Name = "LabelTargetDirectory";
            this.LabelTargetDirectory.Size = new System.Drawing.Size(340, 31);
            this.LabelTargetDirectory.TabIndex = 6;
            this.LabelTargetDirectory.Text = "Укажите директорию назначения";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOk.Location = new System.Drawing.Point(856, 232);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(79, 31);
            this.ButtonOk.TabIndex = 14;
            this.ButtonOk.Text = "Ок";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCancel.Location = new System.Drawing.Point(762, 232);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(84, 31);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonApply.Location = new System.Drawing.Point(663, 232);
            this.ButtonApply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(86, 31);
            this.ButtonApply.TabIndex = 13;
            this.ButtonApply.Text = "Принять";
            this.ButtonApply.UseVisualStyleBackColor = true;
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTips.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelTips.Location = new System.Drawing.Point(944, 27);
            this.LabelTips.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.Size = new System.Drawing.Size(208, 235);
            this.LabelTips.TabIndex = 15;
            this.LabelTips.Text = "Наведите курсор на любой из заголовков - и тут отобразится подробная информация.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LabelSelectDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(462, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 49);
            this.panel1.TabIndex = 16;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 13);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 27);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // FormScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelTips);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormScheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Планировщик";
            this.Load += new System.EventHandler(this.FormScheduler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label LabelSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox ListBoxDirectoriesResult;
    }
}