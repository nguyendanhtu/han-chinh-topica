using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace BCTKApp
{
    public partial class f400_menu_main : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public f400_menu_main()
        {
            InitializeComponent();
        }
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
        }
    }
}
