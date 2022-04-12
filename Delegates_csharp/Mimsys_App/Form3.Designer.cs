
namespace Mimsys_App
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCountChars = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCountChars
            // 
            this.btnCountChars.Location = new System.Drawing.Point(66, 104);
            this.btnCountChars.Name = "btnCountChars";
            this.btnCountChars.Size = new System.Drawing.Size(180, 34);
            this.btnCountChars.TabIndex = 0;
            this.btnCountChars.Text = "Count the Characters";
            this.btnCountChars.UseVisualStyleBackColor = true;
            this.btnCountChars.Click += new System.EventHandler(this.btnCountChars_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(46, 52);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 218);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCountChars);
            this.Name = "Form3";
            this.Text = "Mimsys Master Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountChars;
        private System.Windows.Forms.Label lblInfo;

    }
}

