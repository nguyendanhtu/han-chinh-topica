using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BCTKApp.DanhMuc
{
    public partial class f801_DM_PHONG_BAN_DE : Form
    {
        public f801_DM_PHONG_BAN_DE()
        {
            InitializeComponent();
            format_control();
        }

        

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Members
        
        #endregion

        #region Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        #endregion

        #region Events
        
        #endregion
    }
}
