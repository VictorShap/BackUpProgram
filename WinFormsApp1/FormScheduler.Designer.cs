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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScheduler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxDaysToCopy = new System.Windows.Forms.TextBox();
            this.LabelDaysToCopy = new System.Windows.Forms.Label();
            this.TextBoxTypeExtension = new System.Windows.Forms.TextBox();
            this.LabelTypeExtension = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBoxDirectoriesResult = new System.Windows.Forms.ListBox();
            this.CheckBoxCopyAllTheFiles = new System.Windows.Forms.CheckBox();
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // TextBoxDaysToCopy
            // 
            resources.ApplyResources(this.TextBoxDaysToCopy, "TextBoxDaysToCopy");
            this.TextBoxDaysToCopy.Name = "TextBoxDaysToCopy";
            this.TextBoxDaysToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelDaysToCopy
            // 
            resources.ApplyResources(this.LabelDaysToCopy, "LabelDaysToCopy");
            this.LabelDaysToCopy.Name = "LabelDaysToCopy";
            this.LabelDaysToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // TextBoxTypeExtension
            // 
            resources.ApplyResources(this.TextBoxTypeExtension, "TextBoxTypeExtension");
            this.TextBoxTypeExtension.Name = "TextBoxTypeExtension";
            this.TextBoxTypeExtension.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTypeExtension
            // 
            resources.ApplyResources(this.LabelTypeExtension, "LabelTypeExtension");
            this.LabelTypeExtension.Name = "LabelTypeExtension";
            this.LabelTypeExtension.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBoxDirectoriesResult);
            this.groupBox2.Controls.Add(this.CheckBoxCopyAllTheFiles);
            this.groupBox2.Controls.Add(this.LabelDirectoryToCopy);
            this.groupBox2.Controls.Add(this.ButtonChooseDirectoryToCopy);
            this.groupBox2.Controls.Add(this.ButtonChooseTargetDirectory);
            this.groupBox2.Controls.Add(this.LabelTargetDirectory);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ListBoxDirectoriesResult
            // 
            this.ListBoxDirectoriesResult.FormattingEnabled = true;
            resources.ApplyResources(this.ListBoxDirectoriesResult, "ListBoxDirectoriesResult");
            this.ListBoxDirectoriesResult.Name = "ListBoxDirectoriesResult";
            // 
            // CheckBoxCopyAllTheFiles
            // 
            resources.ApplyResources(this.CheckBoxCopyAllTheFiles, "CheckBoxCopyAllTheFiles");
            this.CheckBoxCopyAllTheFiles.Name = "CheckBoxCopyAllTheFiles";
            this.CheckBoxCopyAllTheFiles.UseVisualStyleBackColor = true;
            this.CheckBoxCopyAllTheFiles.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.CheckBoxCopyAllTheFiles.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelDirectoryToCopy
            // 
            resources.ApplyResources(this.LabelDirectoryToCopy, "LabelDirectoryToCopy");
            this.LabelDirectoryToCopy.Name = "LabelDirectoryToCopy";
            this.LabelDirectoryToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChooseDirectoryToCopy
            // 
            resources.ApplyResources(this.ButtonChooseDirectoryToCopy, "ButtonChooseDirectoryToCopy");
            this.ButtonChooseDirectoryToCopy.Name = "ButtonChooseDirectoryToCopy";
            this.ButtonChooseDirectoryToCopy.UseVisualStyleBackColor = true;
            this.ButtonChooseDirectoryToCopy.Click += new System.EventHandler(this.ButtonChooseDirectoryToCopy_Click);
            this.ButtonChooseDirectoryToCopy.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonChooseTargetDirectory
            // 
            resources.ApplyResources(this.ButtonChooseTargetDirectory, "ButtonChooseTargetDirectory");
            this.ButtonChooseTargetDirectory.Name = "ButtonChooseTargetDirectory";
            this.ButtonChooseTargetDirectory.UseVisualStyleBackColor = true;
            this.ButtonChooseTargetDirectory.Click += new System.EventHandler(this.ButtonChooseTargetDirectory_Click);
            this.ButtonChooseTargetDirectory.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTargetDirectory
            // 
            resources.ApplyResources(this.LabelTargetDirectory, "LabelTargetDirectory");
            this.LabelTargetDirectory.Name = "LabelTargetDirectory";
            this.LabelTargetDirectory.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonOk
            // 
            resources.ApplyResources(this.ButtonOk, "ButtonOk");
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // ButtonApply
            // 
            resources.ApplyResources(this.ButtonApply, "ButtonApply");
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelTips
            // 
            this.LabelTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.LabelTips, "LabelTips");
            this.LabelTips.Name = "LabelTips";
            this.LabelTips.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // PanelSelectDate
            // 
            this.PanelSelectDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSelectDate.Controls.Add(this.LabelSelectDate);
            this.PanelSelectDate.Controls.Add(this.dateTimePicker);
            resources.ApplyResources(this.PanelSelectDate, "PanelSelectDate");
            this.PanelSelectDate.Name = "PanelSelectDate";
            this.PanelSelectDate.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // LabelSelectDate
            // 
            resources.ApplyResources(this.LabelSelectDate, "LabelSelectDate");
            this.LabelSelectDate.Name = "LabelSelectDate";
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.MinDate = new System.DateTime(2022, 6, 25, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            resources.ApplyResources(this.Panel, "Panel");
            this.Panel.Name = "Panel";
            this.Panel.MouseHover += new System.EventHandler(this.ShowToolTips_MouseHover);
            // 
            // FormScheduler
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormScheduler";
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
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ListBox ListBoxDirectoriesResult;
    }
}