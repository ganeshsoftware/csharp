using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;


namespace SimpleEvent
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
  public class Form1 : System.Windows.Forms.Form
  {
    private System.Windows.Forms.Button btnOne;
    private System.Windows.Forms.Button btnTwo;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.Button btnRaise;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    BusEntity _busEntity = new BusEntity();

    public delegate void ActionEventHandler(object sender, ActionCancelEventArgs ev);
    public static event ActionEventHandler Action;

    public Form1()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      btnOne.Click += new EventHandler(Button_Click);
      btnTwo.Click += new EventHandler(Button_Click);
      btnTwo.Click += new EventHandler(btnTwo_Click);

      btnRaise.Click += new EventHandler(btnRaise_Click);
      
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if (components != null) 
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnOne = new System.Windows.Forms.Button();
      this.btnTwo = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.btnRaise = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnOne
      // 
      this.btnOne.Location = new System.Drawing.Point(104, 88);
      this.btnOne.Name = "btnOne";
      this.btnOne.TabIndex = 0;
      this.btnOne.Text = "Button 1";
      // 
      // btnTwo
      // 
      this.btnTwo.Location = new System.Drawing.Point(104, 120);
      this.btnTwo.Name = "btnTwo";
      this.btnTwo.TabIndex = 1;
      this.btnTwo.Text = "Button 2";
      // 
      // lblInfo
      // 
      this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.lblInfo.Location = new System.Drawing.Point(40, 40);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(208, 23);
      this.lblInfo.TabIndex = 2;
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnRaise
      // 
      this.btnRaise.Location = new System.Drawing.Point(104, 160);
      this.btnRaise.Name = "btnRaise";
      this.btnRaise.TabIndex = 3;
      this.btnRaise.Text = "Raise Event";
      // 
      // Form1
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(292, 203);
      this.Controls.Add(this.btnRaise);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.btnTwo);
      this.Controls.Add(this.btnOne);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }
    #endregion

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() 
    {
      Application.Run(new Form1());
    }

    private void Button_Click(object sender, EventArgs e)
    {
      lblInfo.Text = ((Button)sender).Text + " was pressed";
    }

    private void btnTwo_Click(object sender, EventArgs e)
    {
      MessageBox.Show("This only happens in Button 2 click event");
    }

    private void btnRaise_Click(object sender, EventArgs e)
    {
      ActionCancelEventArgs cancelEvent = new ActionCancelEventArgs();
      OnAction(this, cancelEvent);
      if(cancelEvent.Cancel)
        lblInfo.Text = cancelEvent.Message;
      else
        lblInfo.Text = _busEntity.TimeString;
    }

    protected void OnAction(object sender, ActionCancelEventArgs ev)
    {
      if(Action != null)
        Action(sender, ev);
    }

  }

  public class ActionCancelEventArgs : System.ComponentModel.CancelEventArgs
  {
 
    string _msg = "";

    public ActionCancelEventArgs()  : base()  {}

    public ActionCancelEventArgs(bool cancel) : base(cancel)  {}

    public ActionCancelEventArgs(bool cancel, string message) : base(cancel)
    {
      _msg = message;
    }

    public string Message
    {
      get {return _msg;}
      set {_msg = value;}
    }
  }


}
