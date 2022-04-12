#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace DelegateExample
{
  partial class Form1 : Form
  {
    private delegate decimal calcDisc(decimal cost);

    public Form1()
    {
      InitializeComponent();

      cboCompany.Items.Add("Some Corp");
      
      cboCompany.Items.Add("Other Inc");
      cboCompany.Items.Add("That Company Ltd");
      cboCompany.Items.Add("Small Company LLC");
    }

    private decimal CalcStableDiscount(decimal originalCost)
    {
      return originalCost - (originalCost * .25);
    }

    private decimal CalcRandomDiscount(decimal originalCost)
    {
      return originalCost - (originalCost * (System.DateTime.Now.Millisecond * .00001));
    }

    
  }
}