using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mimsys_App
{


    public partial class Form2 : Form
    {

        
        // custom delegate that will wrap up the event handler.
        public delegate void ActionEventHandler(object sender, ActionCancelEventArgs ev);

        // created an event named Action that has the ActionEventHandler delegate associated tp it.
        public static event ActionEventHandler Action;

        BusEntity _busEntity = new BusEntity();
        public Form2()
        {
            InitializeComponent();
        }

        protected void OnAction(object sender, ActionCancelEventArgs ev)
        {
            if (Action != null)
                Action(sender, ev);
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            ActionCancelEventArgs cancelEvent = new ActionCancelEventArgs();
            OnAction(this, cancelEvent);
            if (cancelEvent.Cancel)
                lblInfo.Text = cancelEvent.Message;
            else
                lblInfo.Text = _busEntity.TimeString;

        }
    }
}
