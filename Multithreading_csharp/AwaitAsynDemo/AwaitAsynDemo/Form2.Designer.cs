namespace AwaitAsynDemo
{
    partial class Form2
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
            this.buttonDataSize = new System.Windows.Forms.Button();
            this.labelDisplau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDataSize
            // 
            this.buttonDataSize.Location = new System.Drawing.Point(54, 116);
            this.buttonDataSize.Name = "buttonDataSize";
            this.buttonDataSize.Size = new System.Drawing.Size(189, 23);
            this.buttonDataSize.TabIndex = 0;
            this.buttonDataSize.Text = "Click me to know the data size!";
            this.buttonDataSize.UseVisualStyleBackColor = true;
            this.buttonDataSize.Click += new System.EventHandler(this.buttonDataSize_Click);
            // 
            // labelDisplau
            // 
            this.labelDisplau.AutoSize = true;
            this.labelDisplau.Location = new System.Drawing.Point(79, 75);
            this.labelDisplau.Name = "labelDisplau";
            this.labelDisplau.Size = new System.Drawing.Size(0, 13);
            this.labelDisplau.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 173);
            this.Controls.Add(this.labelDisplau);
            this.Controls.Add(this.buttonDataSize);
            this.Name = "Form2";
            this.Text = "Await Async demo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDataSize;
        private System.Windows.Forms.Label labelDisplau;
    }
}

