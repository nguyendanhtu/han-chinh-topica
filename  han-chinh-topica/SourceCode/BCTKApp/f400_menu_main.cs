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
        #region Private Methods
        private void set_define_event()
        {
            m_cmd_dm_trung_tam.Click += new EventHandler(m_cmd_dm_trung_tam_Click);
        }

        private void m_cmd_dm_trung_tam_Click(object sender, EventArgs e)
        {
            f800_DM_PHONG_BAN v_frm = new f800_DM_PHONG_BAN();
            v_frm.ShowDialog();
        }

     
        #endregion

        private void m_cmd_dm_trung_tam_Click_1(object sender, EventArgs e)
        {
            f800_DM_PHONG_BAN v_frm = new f800_DM_PHONG_BAN();
            v_frm.display();
        }
    }
}
