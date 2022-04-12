using System;
using System.IO;
using System.ComponentModel;

namespace SimpleEvent
{
	/// <summary>
	/// Summary description for BusEntity.
	/// </summary>
	public class BusEntity
	{

    string _time = "";

		public BusEntity()
		{
		  //Form1.Action += new Form1.ActionEventHandler(EventManager_Action);
    }

    private void EventManager_Action(object sender, ActionCancelEventArgs ev)
    {
      ev.Cancel = !DoActions();
      if(ev.Cancel)
        ev.Message = "Wasn't the right time.";
    }

    private bool DoActions()
    {
      bool retVal = false;
      DateTime tm = DateTime.Now;

      if(tm.Second < 30)
      {
        _time = "The time is " + DateTime.Now.ToLongTimeString();
        retVal = true;
      }
      else
        _time = "";

      return retVal;

    }

    public string TimeString
    {
      get {return _time;}
    }

  }
}
