using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeCodeCounter
{
    public partial class SettingForm : Form
    {
        private form_timeCode mParentForm;

        public SettingForm(form_timeCode form)
        {
            this.mParentForm = form;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            InitSettingForm();
        }

        public void InitSettingForm()
        {
            checkbox_hour.Checked = mParentForm.mTimeCode.HourShow;
            checkbox_min.Checked = mParentForm.mTimeCode.MinuteShow;
            checkbox_sec.Checked = mParentForm.mTimeCode.SecondShow;
            checkbox_frame.Checked = mParentForm.mTimeCode.FrameShow;
            checkbox_dropframe.Enabled = false;
            textbox_framerate.Text = mParentForm.mTimeCode.FrameRate.ToString();
            textbox_init_hour.Text = "0";
            textbox_init_min.Text = "0";
            textbox_init_sec.Text = "0";
            textbox_init_frame.Text = "0"; 
        }

        public void UpdateSettingParam()
        {
            mParentForm.mTimeCode.SetShowMode(checkbox_hour.Checked, checkbox_min.Checked,
                checkbox_sec.Checked, checkbox_frame.Checked);
        }

        private SettingForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.mTimeCode.DropFrame = checkbox_dropframe.Checked;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            double frameRate = Convert.ToDouble(textbox_framerate.Text.Trim());
            if(frameRate < 1 || frameRate > 1000){
                MessageBox.Show("错误：帧率不对！");
            }else{
                mParentForm.mTimeCode.FrameRate = frameRate;
            }

            int val;
            val = Convert.ToInt32(textbox_init_hour.Text.Trim());
            if (val < 0 && val > 99)
            {
                MessageBox.Show("错误：小时值不过超过[0, 99]!");
            }
            else
            {
                mParentForm.mTimeCode.Hour = val;
            }

            val = Convert.ToInt32(textbox_init_min.Text.Trim());
            if (val < 0 && val > 59)
            {
                MessageBox.Show("错误：分钟值不过超过[0, 59]!");
            }
            else
            {
                mParentForm.mTimeCode.Minute = val;
            }

            val = Convert.ToInt32(textbox_init_sec.Text.Trim());
            if (val < 0 && val > 59)
            {
                MessageBox.Show("错误：秒值不过超过[0, 59]!");
            }
            else
            {
                mParentForm.mTimeCode.Second = val;
            }

            val = Convert.ToInt32(textbox_init_frame.Text.Trim());
            if (val < 0 && val > 99)
            {
                MessageBox.Show("错误：帧值不过超过[0, 99]!");
            }
            else
            {
                mParentForm.mTimeCode.Frame = val;
            }

            this.Close();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_font_setting_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = mParentForm.GetTimeCodeFont();
            if(fontDialog.ShowDialog() != DialogResult.Cancel){
                mParentForm.SetTimeCodeFont(fontDialog.Font);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.mTimeCode.MinuteShow = checkbox_min.Checked;
        }

        private void checkbox_hour_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.mTimeCode.HourShow = checkbox_hour.Checked;
        }

        private void checkbox_sec_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.mTimeCode.SecondShow = checkbox_sec.Checked;
        }

        private void checkbox_frame_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.mTimeCode.FrameShow = checkbox_frame.Checked;
        }

        private void textbox_framerate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_backgroundcolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = mParentForm.GetTimeCodeBackColor();
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                mParentForm.SetTimeCodeBackColor(colorDialog.Color);
            }
        }

        private void btn_forecolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = mParentForm.GetTimeCodeForeColor();
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                mParentForm.SetTimeCodeForeColor(colorDialog.Color);
            }
        }
    }
}
