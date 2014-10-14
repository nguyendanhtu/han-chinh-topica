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
        private string Allow_Null
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
            this.Allow_Null = "N";
        }
        public TCDatetime(DinhDang ip_dinhdang,string ip_str_allow_null)
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
            if (ip_str_allow_null.ToUpper().Trim() == "N")
                this.Allow_Null = "N";
            else this.Allow_Null = "Y";
        }
        public DateTime? getValue()
        {
            DateTime v_dat = new DateTime();
            bool v_b_result = false;
            switch (Format)
            {
                case DinhDang.dd_MM_yyyy:
                    v_b_result = DateTime.TryParseExact(this.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out v_dat);
                    break;
                case DinhDang.MM_yyyy:
                    v_b_result = DateTime.TryParseExact(this.Text, "MM/yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out v_dat);
                    break;
            }
            if (this.Allow_Null == "Y" && !v_b_result) return null;
            return v_dat;
        }
        public enum DinhDang
        {
            dd_MM_yyyy,
            MM_yyyy
        }
        public enum AL
        {
            Y,
            N
        }
        public AL AllowNull
        {
            get
            {
                if (this.Allow_Null == "N") return AL.N;
                else return AL.Y;
            }
            set
            {
                if (value.ToString().Trim().ToUpper() == "N")
                    this.Allow_Null = "N";
                else this.Allow_Null = "Y";
            }
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
                if (this.Allow_Null == "Y") return;
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
