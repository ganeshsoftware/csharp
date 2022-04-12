namespace EmployeeManager
{
    partial class Form1
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
            this.groupBoxDataEntry = new System.Windows.Forms.GroupBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelSavingFormat = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.checkBoxBinary = new System.Windows.Forms.CheckBox();
            this.checkBoxXML = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxXMLFiles = new System.Windows.Forms.ListBox();
            this.listBoxBinaryFiles = new System.Windows.Forms.ListBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.groupBoxDataEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDataEntry
            // 
            this.groupBoxDataEntry.Controls.Add(this.buttonCheck);
            this.groupBoxDataEntry.Controls.Add(this.buttonCancel);
            this.groupBoxDataEntry.Controls.Add(this.buttonSave);
            this.groupBoxDataEntry.Controls.Add(this.checkBoxBinary);
            this.groupBoxDataEntry.Controls.Add(this.checkBoxXML);
            this.groupBoxDataEntry.Controls.Add(this.comboBoxDepartment);
            this.groupBoxDataEntry.Controls.Add(this.checkBoxOther);
            this.groupBoxDataEntry.Controls.Add(this.checkBoxMale);
            this.groupBoxDataEntry.Controls.Add(this.checkBoxFemale);
            this.groupBoxDataEntry.Controls.Add(this.textBoxName);
            this.groupBoxDataEntry.Controls.Add(this.textBoxId);
            this.groupBoxDataEntry.Controls.Add(this.labelSavingFormat);
            this.groupBoxDataEntry.Controls.Add(this.labelDepartment);
            this.groupBoxDataEntry.Controls.Add(this.labelGender);
            this.groupBoxDataEntry.Controls.Add(this.labelName);
            this.groupBoxDataEntry.Controls.Add(this.labelId);
            this.groupBoxDataEntry.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDataEntry.Name = "groupBoxDataEntry";
            this.groupBoxDataEntry.Size = new System.Drawing.Size(421, 257);
            this.groupBoxDataEntry.TabIndex = 10;
            this.groupBoxDataEntry.TabStop = false;
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Location = new System.Drawing.Point(314, 101);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(52, 17);
            this.checkBoxOther.TabIndex = 19;
            this.checkBoxOther.Text = "Other";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            this.checkBoxOther.CheckedChanged += new System.EventHandler(this.checkBoxOther_CheckedChanged);
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(221, 100);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(49, 17);
            this.checkBoxMale.TabIndex = 18;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(118, 100);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(60, 17);
            this.checkBoxFemale.TabIndex = 17;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(118, 28);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(60, 20);
            this.textBoxId.TabIndex = 15;
            // 
            // labelSavingFormat
            // 
            this.labelSavingFormat.AutoSize = true;
            this.labelSavingFormat.Location = new System.Drawing.Point(9, 178);
            this.labelSavingFormat.Name = "labelSavingFormat";
            this.labelSavingFormat.Size = new System.Drawing.Size(75, 13);
            this.labelSavingFormat.TabIndex = 14;
            this.labelSavingFormat.Text = "Saving Format";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(22, 140);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(62, 13);
            this.labelDepartment.TabIndex = 13;
            this.labelDepartment.Text = "Department";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(18, 101);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Gender";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 64);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(22, 32);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(118, 137);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(193, 21);
            this.comboBoxDepartment.TabIndex = 20;
            // 
            // checkBoxBinary
            // 
            this.checkBoxBinary.AutoSize = true;
            this.checkBoxBinary.Location = new System.Drawing.Point(221, 177);
            this.checkBoxBinary.Name = "checkBoxBinary";
            this.checkBoxBinary.Size = new System.Drawing.Size(55, 17);
            this.checkBoxBinary.TabIndex = 22;
            this.checkBoxBinary.Text = "Binary";
            this.checkBoxBinary.UseVisualStyleBackColor = true;
            // 
            // checkBoxXML
            // 
            this.checkBoxXML.AutoSize = true;
            this.checkBoxXML.Location = new System.Drawing.Point(118, 177);
            this.checkBoxXML.Name = "checkBoxXML";
            this.checkBoxXML.Size = new System.Drawing.Size(48, 17);
            this.checkBoxXML.TabIndex = 21;
            this.checkBoxXML.Text = "XML";
            this.checkBoxXML.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(118, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(218, 218);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // listBoxXMLFiles
            // 
            this.listBoxXMLFiles.FormattingEnabled = true;
            this.listBoxXMLFiles.Location = new System.Drawing.Point(485, 21);
            this.listBoxXMLFiles.Name = "listBoxXMLFiles";
            this.listBoxXMLFiles.Size = new System.Drawing.Size(142, 251);
            this.listBoxXMLFiles.TabIndex = 12;
            // 
            // listBoxBinaryFiles
            // 
            this.listBoxBinaryFiles.FormattingEnabled = true;
            this.listBoxBinaryFiles.Location = new System.Drawing.Point(672, 21);
            this.listBoxBinaryFiles.Name = "listBoxBinaryFiles";
            this.listBoxBinaryFiles.Size = new System.Drawing.Size(142, 251);
            this.listBoxBinaryFiles.TabIndex = 13;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(184, 26);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(49, 23);
            this.buttonCheck.TabIndex = 25;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 296);
            this.Controls.Add(this.listBoxBinaryFiles);
            this.Controls.Add(this.listBoxXMLFiles);
            this.Controls.Add(this.groupBoxDataEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDataEntry.ResumeLayout(false);
            this.groupBoxDataEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataEntry;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelSavingFormat;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox checkBoxBinary;
        private System.Windows.Forms.CheckBox checkBoxXML;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxXMLFiles;
        private System.Windows.Forms.ListBox listBoxBinaryFiles;
        private System.Windows.Forms.Button buttonCheck;
    }
}

