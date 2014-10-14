using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCTKApp.App_Code;
using BCTKDS;
using BCTKDS.CDBNames;
using BCTKUS;
using IP.Core.IPCommon;

namespace BCTKApp
{
    public partial class TCSoVaKyHieu : TextBox
    {
        private string _loaiCongVan = string.Empty;
        public string LoaiCongVan
        {
            get { return _loaiCongVan; }
            set { _loaiCongVan = value; }
        }
        public TCSoVaKyHieu()
        {
            InitializeComponent();
            set_define_events();
        }

        public void UpdateValue()
        {
            get_so_ky_hieu();
        }

        private void set_define_events()
        {
            this.LostFocus += m_txt_so_va_ky_hieu_LostFocus;
            this.GotFocus += m_txt_so_va_ky_hieu_GotFocus;
        }

        private void m_txt_so_va_ky_hieu_GotFocus(object sender, EventArgs e)
        {
            this.Text = getYear();
        }

        private void m_txt_so_va_ky_hieu_LostFocus(object sender, EventArgs eventArgs)
        {
            if(!NumbericUtil.IsNumberic(this.Text))
                preset_data();
            else
                get_so_ky_hieu();
        }

        private string getYear()
        {
            var v_dat = new DateTime();
            if (DateTime.TryParseExact(this.Text, "MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out v_dat))
                return v_dat.Year.ToString();
            else
                return DateTime.Now.Year.ToString();
        }

        private void preset_data()
        {
            var v_dat_current_year = DateTime.Now.Year;
            this.Text = v_dat_current_year.ToString();        
        }

        private void get_so_ky_hieu()
        {
            var v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            var v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();

            v_us_cm_dm_tu_dien.FillDataset(v_ds_cm_dm_tu_dien, "where MA_TU_DIEN = '" + _loaiCongVan + "' and TEN = '" + getYear() + "'");
            var v_int_cv_count = 1;
            if (v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.Rows.Count > 0)
            {
                var v_dr = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.Rows[0];
                int.TryParse(v_dr[CM_DM_TU_DIEN.TEN_NGAN].ToString(), out v_int_cv_count);
            }
            else if(!string.IsNullOrEmpty(_loaiCongVan))
            {
                //v_us_cm_dm_tu_dien.strMA_TU_DIEN = _loaiCongVan;
                //v_us_cm_dm_tu_dien.dcID_LOAI_TU_DIEN = 26;
                //v_us_cm_dm_tu_dien.strTEN_NGAN = "01";
                //v_us_cm_dm_tu_dien.strTEN = this.Text;
                //v_us_cm_dm_tu_dien.Insert();
            }
            this.Text = string.Format("{0:00}", v_int_cv_count) + "/" + getYear();
        }
    }
}
