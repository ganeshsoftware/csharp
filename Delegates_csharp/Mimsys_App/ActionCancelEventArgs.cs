using System;
using System.Collections.Generic;
using System.Text;

namespace Mimsys_App
{
    public class ActionCancelEventArgs: System.ComponentModel.CancelEventArgs
    {
		string _msg = " ";

		public ActionCancelEventArgs() : base()
		{

		}

		public ActionCancelEventArgs(bool cancel, string message) : base(cancel)
		{
			_msg = message;
		}

		public string Message
		{
			get { return _msg; }
			set { _msg = value; }
		
		}
	}
}
