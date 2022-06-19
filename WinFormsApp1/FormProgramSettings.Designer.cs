
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgramSettings));
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
            resources.ApplyResources(this.GroupProgramSettings, "GroupProgramSettings");
            this.GroupProgramSettings.Name = "GroupProgramSettings";
            this.GroupProgramSettings.TabStop = false;
            // 
            // CheckedListBoxProgramSettings
            // 
            this.CheckedListBoxProgramSettings.BackColor = System.Drawing.SystemColors.Control;
            this.CheckedListBoxProgramSettings.FormattingEnabled = true;
            this.CheckedListBoxProgramSettings.Items.AddRange(new object[] {
            resources.GetString("CheckedListBoxProgramSettings.Items"),
            resources.GetString("CheckedListBoxProgramSettings.Items1")});
            resources.ApplyResources(this.CheckedListBoxProgramSettings, "CheckedListBoxProgramSettings");
            this.CheckedListBoxProgramSettings.Name = "CheckedListBoxProgramSettings";
            // 
            // GroupLanguage
            // 
            this.GroupLanguage.Controls.Add(this.RadioButtonEnglish);
            this.GroupLanguage.Controls.Add(this.RadioButtonRussian);
            resources.ApplyResources(this.GroupLanguage, "GroupLanguage");
            this.GroupLanguage.Name = "GroupLanguage";
            this.GroupLanguage.TabStop = false;
            // 
            // RadioButtonEnglish
            // 
            resources.ApplyResources(this.RadioButtonEnglish, "RadioButtonEnglish");
            this.RadioButtonEnglish.Name = "RadioButtonEnglish";
            this.RadioButtonEnglish.TabStop = true;
            this.RadioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRussian
            // 
            resources.ApplyResources(this.RadioButtonRussian, "RadioButtonRussian");
            this.RadioButtonRussian.Name = "RadioButtonRussian";
            this.RadioButtonRussian.TabStop = true;
            this.RadioButtonRussian.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            resources.ApplyResources(this.ButtonOk, "ButtonOk");
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonApply
            // 
            resources.ApplyResources(this.ButtonApply, "ButtonApply");
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            // 
            // GroupAdditionalSettings
            // 
            this.GroupAdditionalSettings.Controls.Add(this.checkBox4StartCopyingAgain);
            this.GroupAdditionalSettings.Controls.Add(this.checkBox3PermissionToStopCopy);
            this.GroupAdditionalSettings.Controls.Add(this.checkBox1NotifyAboutCopying);
            resources.ApplyResources(this.GroupAdditionalSettings, "GroupAdditionalSettings");
            this.GroupAdditionalSettings.Name = "GroupAdditionalSettings";
            this.GroupAdditionalSettings.TabStop = false;
            // 
            // checkBox4StartCopyingAgain
            // 
            resources.ApplyResources(this.checkBox4StartCopyingAgain, "checkBox4StartCopyingAgain");
            this.checkBox4StartCopyingAgain.Name = "checkBox4StartCopyingAgain";
            this.checkBox4StartCopyingAgain.UseVisualStyleBackColor = true;
            // 
            // checkBox3PermissionToStopCopy
            // 
            resources.ApplyResources(this.checkBox3PermissionToStopCopy, "checkBox3PermissionToStopCopy");
            this.checkBox3PermissionToStopCopy.Name = "checkBox3PermissionToStopCopy";
            this.checkBox3PermissionToStopCopy.UseVisualStyleBackColor = true;
            // 
            // checkBox1NotifyAboutCopying
            // 
            resources.ApplyResources(this.checkBox1NotifyAboutCopying, "checkBox1NotifyAboutCopying");
            this.checkBox1NotifyAboutCopying.Name = "checkBox1NotifyAboutCopying";
            this.checkBox1NotifyAboutCopying.UseVisualStyleBackColor = true;
            // 
            // FormProgramSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupAdditionalSettings);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.GroupLanguage);
            this.Controls.Add(this.GroupProgramSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProgramSettings";
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