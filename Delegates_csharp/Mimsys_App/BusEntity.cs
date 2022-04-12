using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Concurrent;

namespace Mimsys_App
{
    public class BusEntity
    {
        ConcurrentDictionary<Int32, string> mydocs = new ConcurrentDictionary<int, string>();
        

        string _time = "";

        public BusEntity()
        {
            Form2.Action += new Form2.ActionEventHandler(Form2_Action);
            //mydocs.AddOrUpdate(100, "abc");   
        }


        private void Form2_Action(object sender, ActionCancelEventArgs ev)
        {
            ev.Cancel = !DoActions();
            if (ev.Cancel)
            {
                ev.Message = "Wasn't the right time!";
            }
        
        }

        private bool DoActions()
        {
            bool retVal = false;
            DateTime tm = DateTime.Now;

            if (tm.Second < 30)
            {
                _time = "The Time is " + DateTime.Now.ToLongTimeString();
                retVal = true;
            }
            else
              _time = "";
            return retVal;
        }

        public string TimeString
        {
            get { return _time; }
        }
    }
}
