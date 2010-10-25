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

        public Boolean FrameShow
        {
            get
            {
                return checkbox_frame.Checked;
            }
        }

        public Boolean SecondShow
        {
            get
            {
                return checkbox_sec.Checked;
            }
        }

        public Boolean HourShow
        {
            get
            {
                return checkbox_hour.Checked;
            }
        }

        public Boolean MinuteShow
        {
            get
            {
                return checkbox_min.Checked;
            }
        }

        public SettingForm(form_timeCode form)
        {
            this.mParentForm = form;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //InitSettingForm();
        }

        public void InitSettingForm()
        {
            checkbox_dropframe.Checked = false;
            checkbox_hour.Checked = true;
            checkbox_min.Checked = true;
            checkbox_sec.Checked = true;
            checkbox_frame.Checked = true;
            rbtn_custom.Checked = true;

            combobox_framerate.Text = "25";
            textbox_init_hour.Text = "0";
            textbox_init_min.Text = "0";
            textbox_init_sec.Text = "0";
            textbox_init_frame.Text = "0";
        }

        private SettingForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            btn_apply_Click(sender, e);
            this.Hide();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if(rbtn_custom.Checked){
                set_custom_value();
            }else if(rbtn_random.Checked){
                set_random_value();
            }
            
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_font_setting_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = mParentForm.GetTimeCodeFont();
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                mParentForm.SetTimeCodeFont(fontDialog.Font);
            }
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

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void formtimeCodeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_custom_CheckedChanged(object sender, EventArgs e)
        {
            textbox_init_hour.Enabled = rbtn_custom.Checked;
            textbox_init_min.Enabled = rbtn_custom.Checked;
            textbox_init_sec.Enabled = rbtn_custom.Checked;
            textbox_init_frame.Enabled = rbtn_custom.Checked;
            if(rbtn_custom.Checked){
                mParentForm.mTimeCode.Mode = TimeCode.USE_CUSTOM_VALUE;
                set_custom_value();
            }
        }

        private void rbtn_systemtime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_systemtime.Checked)
            {
                mParentForm.mTimeCode.Mode = TimeCode.USE_SYSTEM_TIME;
            }
        }

        private void rbtn_random_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_random.Checked)
            {
                mParentForm.mTimeCode.Mode = TimeCode.USE_RANDOM_VALUE;
                set_random_value();
            }
        }

        private void checkbox_hour_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.notify_timeCode_label_size_change();
        }

        private void checkbox_min_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.notify_timeCode_label_size_change();
        }

        private void checkbox_sec_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.notify_timeCode_label_size_change();
        }

        private void checkbox_frame_CheckedChanged(object sender, EventArgs e)
        {
            mParentForm.notify_timeCode_label_size_change();
        }

        private void set_random_value(){
            double frameRate;
            int hour, min, sec, frame;
            //frameRate = Convert.ToDouble(textbox_framerate.Text.Trim());
            frameRate = Convert.ToDouble(combobox_framerate.Text.Trim());
            if (frameRate < 1 || frameRate > 1000)
            {
                MessageBox.Show("错误：帧率不对！");
                return;
            }
            Random randObj = new Random();
            hour = randObj.Next(100);
            min = randObj.Next(60);
            sec = randObj.Next(60);
            frame = (int)(randObj.Next((int)Math.Ceiling(frameRate)));
            //textbox_init_hour.Text = hour.ToString();
            //textbox_init_min.Text = min.ToString();
           // textbox_init_sec.Text = sec.ToString();
            //textbox_init_frame.Text = frame.ToString();
            mParentForm.mTimeCode.SetInitValue(hour, min, sec, frame, frameRate);
        }

        private void set_custom_value()
        {
            double frameRate;
            int hour, min, sec, frame;
            //frameRate = Convert.ToDouble(textbox_framerate.Text.Trim());
            frameRate = Convert.ToDouble(combobox_framerate.Text.Trim());
            if (frameRate < 1 || frameRate > 1000)
            {
                MessageBox.Show("错误：帧率超出[1,1000]的区间！");
                combobox_framerate.Text = combobox_framerate.Text.Trim().Substring(0, 3);
                return;
            }
            hour = Convert.ToInt32(textbox_init_hour.Text.Trim());
            if (hour < 0 || hour > 99)
            {
                MessageBox.Show("错误：小时值不过超过[0, 99]!");
                textbox_init_hour.Text = "99";
                return;
            }

            min = Convert.ToInt32(textbox_init_min.Text.Trim());
            if (min < 0 || min > 59)
            {
                MessageBox.Show("错误：分钟值不过超过[0, 59]!");
                textbox_init_min.Text = "59";
                return;
            }

            sec = Convert.ToInt32(textbox_init_sec.Text.Trim());
            if (sec < 0 || sec > 59)
            {
                MessageBox.Show("错误：秒值不过超过[0, 59]!");
                textbox_init_sec.Text = "59";
                return;
            }

            frame = Convert.ToInt32(textbox_init_frame.Text.Trim());
            if (frameRate == 0 && frame > 0 || frameRate > 0 && frame >= frameRate)
            {
                MessageBox.Show("错误：帧值不能超过帧率！");
                textbox_init_hour.Text = ((int)Math.Ceiling(frameRate) - 1).ToString();
                return;
            }
            mParentForm.mTimeCode.SetInitValue(hour, min, sec, frame, frameRate);
        }

        private void combobox_framerate_SelectedIndexChanged(object sender, EventArgs e)
        {
            double frameRate;
            frameRate = Convert.ToDouble(combobox_framerate.Text.Trim());
            if (frameRate < 1 || frameRate > 1000)
            {
                MessageBox.Show("错误：帧率超出[1,1000]的区间！");
                combobox_framerate.Text = combobox_framerate.Text.Substring(0, 3);
                return;
            }else{
                mParentForm.mTimeCode.FrameRate = frameRate;
            }
        }

        private void combobox_framerate_TextChanged(object sender, EventArgs e)
        {
            double frameRate;
            if(combobox_framerate.Text.Trim().Equals(String.Empty)){
                MessageBox.Show("错误：帧率不能为空！");
                combobox_framerate.Text = "25";
            }
            frameRate = Convert.ToDouble(combobox_framerate.Text.Trim());
            if (frameRate < 1 || frameRate > 1000)
            {
                MessageBox.Show("错误：帧率超出[1,1000]的区间！");
                combobox_framerate.Text = combobox_framerate.Text.Substring(0, 3);
                return;
            }
            else
            {
                mParentForm.mTimeCode.FrameRate = frameRate;
            }
        }
    }
}
