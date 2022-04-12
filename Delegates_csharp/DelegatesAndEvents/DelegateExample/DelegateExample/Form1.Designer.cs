namespace DelegateExample
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
      this.txtPrice = new System.Windows.Forms.TextBox();
      this.txtDisc = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.cboCompany = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
// 
// txtPrice
// 
      this.txtPrice.Location = new System.Drawing.Point(139, 37);
      this.txtPrice.Name = "txtPrice";
      this.txtPrice.TabIndex = 0;
// 
// txtDisc
// 
      this.txtDisc.Location = new System.Drawing.Point(139, 65);
      this.txtDisc.Name = "txtDisc";
      this.txtDisc.TabIndex = 1;
// 
// label1
// 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(97, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 14);
      this.label1.TabIndex = 2;
      this.label1.Text = "Price";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
// 
// label2
// 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(79, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 14);
      this.label2.TabIndex = 3;
      this.label2.Text = "Discount";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
// 
// label3
// 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(139, 110);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(0, 0);
      this.label3.TabIndex = 4;
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
// 
// label4
// 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(69, 110);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 14);
      this.label4.TabIndex = 5;
      this.label4.Text = "Total Price";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
// 
// button1
// 
      this.button1.Location = new System.Drawing.Point(139, 187);
      this.button1.Name = "button1";
      this.button1.TabIndex = 6;
      this.button1.Text = "button1";
// 
// cboCompany
// 
      this.cboCompany.FormattingEnabled = true;
      this.cboCompany.Location = new System.Drawing.Point(139, 9);
      this.cboCompany.Name = "cboCompany";
      this.cboCompany.Size = new System.Drawing.Size(75, 21);
      this.cboCompany.TabIndex = 7;
// 
// Form1
// 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(344, 308);
      this.Controls.Add(this.cboCompany);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDisc);
      this.Controls.Add(this.txtPrice);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPrice;
    private System.Windows.Forms.TextBox txtDisc;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox cboCompany;
  }
}

