using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BCTKApp
{
    public partial class TCDatetime : MaskedTextBox
    {
        public TCDatetime()
        {
            InitializeComponent();
            this.ValidatingType = typeof(DateTime);
            this.TypeValidationCompleted += TCDatetime_TypeValidationCompleted;
        }

        private string DatetimeFormat
        {
            get;
            set;
        }
        public TCDatetime(DinhDang ip_dinhdang)
        {
            InitializeComponent();
            this.ValidatingType = typeof(DateTime);
            switch (ip_dinhdang)
            {
                case DinhDang.dd_MM_yyyy:
                    this.Mask = "00/00/0000";
                    break;

                case DinhDang.MM_yyyy:
                    this.Mask = "00/0000";
                    break;
                default:
                    this.Mask = "00/00/0000";
                    break;
            }
        }
        public enum DinhDang
        {
            dd_MM_yyyy,
            MM_yyyy
        }
        public DinhDang Format
        {
            get
            {
                switch (this.DatetimeFormat)
                {
                    case "dd/MM/yyyy":
                        return DinhDang.dd_MM_yyyy;
                    case "MM/yyyy":
                        return DinhDang.MM_yyyy;
                }
                return DinhDang.dd_MM_yyyy;
            }
            set
            {
                switch (value)
                {
                    case DinhDang.dd_MM_yyyy:
                        this.Mask = "00/00/0000";
                        this.DatetimeFormat = "dd/MM/yyyy";
                        break;
                    case DinhDang.MM_yyyy:
                        this.Mask = "00/0000";
                        this.DatetimeFormat = "MM/yyyy";
                        break;
                }
            }
        }
        void TCDatetime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            try
            {
                DateTime v_dat = new DateTime();
                bool v_b_result =false;
                switch (Format)
                {
                    case DinhDang.dd_MM_yyyy:
                        v_b_result = DateTime.TryParseExact(this.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out v_dat);
                        break;
                    case DinhDang.MM_yyyy:
                        v_b_result = DateTime.TryParseExact(this.Text, "MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out v_dat);
                        break;
                }
                
                if (!v_b_result)
                {
                    MessageBox.Show("Bạn nhập sai định dạng!");
                    this.Focus();
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
