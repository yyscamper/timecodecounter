using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TimeCodeCounter
{
    public partial class form_timeCode : Form
    {
        private delegate void _safeSetTimeCodeLabelCall(String str);

        static SettingForm mSettingForm = null;
        Boolean mStartFlag = false;
        Boolean mPauseFlag = false;
        public TimeCode mTimeCode = null;
        StringBuilder mSb;
        Thread updateTimeCodeThread;

        public form_timeCode()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            
            mSb = new StringBuilder();
            mTimeCode = new TimeCode();  
            mSettingForm = new SettingForm(this);    
            mPreLabelHeight = label_timeCode.Height;
            mPreLabelWidth = label_timeCode.Width;
        }


        public void StartCount(){
            mTimeCode.Start();
            updateTimeCodeThread = new Thread(new ThreadStart(this.updateTimeCodeThreadFunc));
            try
            {
                updateTimeCodeThread.Start();
            }
            catch (ThreadStartException)
            {
                Console.WriteLine("updateTimeCodeThread create failed!");
            }
            mStartFlag = true;
        }

        public void updateTimeCodeThreadFunc()
        {
            int hour = 0, min = 0, sec = 0, frame = 0;
            while (true)
            {
                if(!mStartFlag){ //Stop
                    break;
                }
                if(mPauseFlag){
                    Thread.Sleep(10);
                    continue;
                }
                mTimeCode.GetCurrTimeCode(ref hour, ref min, ref sec, ref frame);
                DisplayTimeCode(hour, min, sec, frame);
                auto_adjust_wndSize();
                Thread.Sleep(2);
            }
        }  

        public void SetTimeCodeFont(Font font)
        {
            this.label_timeCode.Font = font;
            notify_timeCode_label_size_change();
        }

        public Font GetTimeCodeFont()
        {
            return this.label_timeCode.Font;
        }

        public void SetTimeCodeForeColor(Color color)
        {
            this.label_timeCode.ForeColor = color;
        }

        public Color GetTimeCodeForeColor()
        {
            return this.label_timeCode.ForeColor;
        }

        public void SetTimeCodeBackColor(Color color)
        {
            this.label_timeCode.BackColor = color;
        }

        public Color GetTimeCodeBackColor()
        {
            return this.label_timeCode.BackColor;
        }

       
        private void label_timeCode_Click(object sender, EventArgs e)
        {

        }
          
        private void form_timeCode_load(object sender, EventArgs e)
        {
            
        }

        private void rightMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mStartFlag = true;
            mPauseFlag = false;
            StartCount();
        }

        private void rightmenu_setting_Click(object sender, EventArgs e)
        {
            //mSettingForm = new SettingForm(this);
            mSettingForm.Visible = true;
            mSettingForm.Show();
            //mSettingForm.Visible = true;
            //this.Show(mSettingForm);
        }

        private void form_timeCode_KeyDown(object sender, KeyEventArgs e)
        {
            //暂停计数显示，但是时码仍然在累计时间
            if (e.KeyCode == Keys.Enter)
            {
                mStartFlag = !mStartFlag;
                if(mStartFlag){
                    StartCount();
                }else{
                    mTimeCode.Stop();
                    Stop_Thread();
                    int hour = 0, min = 0, sec = 0, frame = 0;
                    mTimeCode.GetInitTimeCode(ref hour, ref min, ref sec, ref frame);
                    DisplayTimeCode(hour, min, sec, frame);
                }
            }else if(e.KeyCode == Keys.Space){//在开始计数与停止计数状态翻转，停止计数时，时码不会累计时间
                if(!mStartFlag){
                    mPauseFlag = false;
                    mStartFlag = true;
                    this.StartCount();
                }else{
                    mPauseFlag = !mPauseFlag;
                    if (mPauseFlag)
                    {
                        mTimeCode.Pause();
                    }else{
                        mTimeCode.Start();
                    }
                } 
            }else if(e.KeyCode == Keys.Oemplus){
                float currSize = label_timeCode.Font.Size + 2.0f;
                if(currSize > 1000){
                    currSize = 1000;
                }
                label_timeCode.Font = new Font(label_timeCode.Font.FontFamily.Name, currSize, label_timeCode.Font.Style, label_timeCode.Font.Unit);
                notify_timeCode_label_size_change();
            }else if(e.KeyCode == Keys.OemMinus){
                float currSize = label_timeCode.Font.Size - 2.0f;
                if (currSize < 2)
                {
                    currSize = 2;
                }
                label_timeCode.Font = new Font(label_timeCode.Font.FontFamily.Name, currSize, label_timeCode.Font.Style, label_timeCode.Font.Unit);
                notify_timeCode_label_size_change();
            }else if(e.KeyCode == Keys.D){
                this.Width += 1;
            }else if(e.KeyCode == Keys.A){
                if(this.Width > 2){
                    this.Width -= 1;
                }      
            }else if(e.KeyCode == Keys.S){
                this.Height += 1;
            }else if(e.KeyCode == Keys.W){
                if(this.Height > 2){
                    this.Height -= 1;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                label_timeCode.Location = new Point(label_timeCode.Location.X, label_timeCode.Location.Y - 1);
            }
            else if (e.KeyCode == Keys.Down)
            {
                label_timeCode.Location = new Point(label_timeCode.Location.X, label_timeCode.Location.Y + 1);
            }
            else if (e.KeyCode == Keys.Left)
            {
                label_timeCode.Location = new Point(label_timeCode.Location.X - 1, label_timeCode.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                label_timeCode.Location = new Point(label_timeCode.Location.X + 1, label_timeCode.Location.Y);
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            mStartFlag = false;
            mTimeCode.Stop();
            Stop_Thread();
            int hour = 0, min = 0, sec = 0, frame = 0;
            mTimeCode.GetInitTimeCode(ref hour, ref min, ref sec, ref frame);
            DisplayTimeCode(hour, min, sec, frame);
        }

        private void rightmenu_pause_Click(object sender, EventArgs e)
        {
            mPauseFlag = true;
            mTimeCode.Pause();
        }

        private void rightmenu_reset_Click(object sender, EventArgs e)
        { 
            mPauseFlag = false;
            if(mStartFlag){
                mTimeCode.Stop();
                Stop_Thread();
                mTimeCode.Start();
            }else{
                StartCount();
            }  
        }

        private void rightmenu_close_Click(object sender, EventArgs e)
        {
            Stop_Thread();
            Application.Exit();
        }

        private void rightmenu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("软件名称：时码计数软件\n版本：1.0\n作者：袁宇\n时间：2010-10-23\n源代码：http://code.google.com/p/timecodecounter/");
        }


        private void DisplayTimeCode(int hour, int min, int sec, int frame)
        {
            mSb.Remove(0, mSb.Length);
            if (mSettingForm.HourShow)
            {
                mSb.AppendFormat("{0:D2}", hour);
            }
            if (mSettingForm.MinuteShow)
            {
                mSb.AppendFormat(":{0:D2}", min);
            }
            if (mSettingForm.SecondShow)
            {
                mSb.AppendFormat(":{0:D2}", sec);
            }
            if (mSettingForm.FrameShow)
            {
                mSb.AppendFormat("-{0:D2}", frame);
            }
            if (mSb.Length > 1 && (mSb[0] == ':' || mSb[0] == '-'))
            {
                mSb.Remove(0, 1);
            }
            this.label_timeCode.Text = mSb.ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
      
        private void form_timeCode_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void form_timeCode_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void rightmenu_topmost_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            if (this.TopMost == true)
            {
                rightmenu_topmost.Text = "取消置顶";
            }
            else
            {
                rightmenu_topmost.Text = "置顶";
            } 
        }

        private void rightmenu_hideTitle_Click_1(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.rightmenu_hideTitle.Text = "隐藏标题栏";
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.rightmenu_hideTitle.Text = "显示标题栏";
            } 
        }

        private int mPreLabelWidth = 0;
        private int mPreLabelHeight = 0;
        private void auto_adjust_wndSize()
        {
            if(label_timeCode.Width > mPreLabelWidth){
               // Console.WriteLine("adjust: labelWidth:{0}, preLabelWidth:{1}, wndWidth:{2}",
                    //label_timeCode.Width, mPreLabelWidth, this.Width);

                this.Width = label_timeCode.Width;
                mPreLabelWidth = label_timeCode.Width;
            }
            if (label_timeCode.Height > mPreLabelHeight)
            {
               // Console.WriteLine("adjust: labelHeight:{0}, preLabelHeight:{1}, wndHeight:{2}",
                   // label_timeCode.Height, mPreLabelHeight, this.Height);

                this.Height = label_timeCode.Height + 15;
                mPreLabelHeight = label_timeCode.Height;
            }

        }

        private void Change_Label_Location(){
            this.label_timeCode.Location = new System.Drawing.Point(0, 0);
        }

        private void form_timeCode_SizeChanged(object sender, EventArgs e)
        {
            if(this.FormBorderStyle == FormBorderStyle.None){
                this.label_timeCode.Location = new System.Drawing.Point(
                    (this.Width - label_timeCode.Width) / 2, 
                    (this.Height - label_timeCode.Height) / 2);
            }
        }

        public void notify_timeCode_label_size_change(){
            int hour = 0, min = 0, sec = 0, frame = 0;
            if(mStartFlag){
                mTimeCode.GetCurrTimeCode(ref hour, ref min, ref sec, ref frame);
            }else{
                mTimeCode.GetInitTimeCode(ref hour, ref min, ref sec, ref frame);
            }
            DisplayTimeCode(hour, min, sec, frame);
            mPreLabelWidth = 0;
            mPreLabelHeight = 0;
            label_timeCode.Location = new Point(0, 0);
            auto_adjust_wndSize();
        }

        private void form_timeCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop_Thread();
        }

        private void Stop_Thread(){
            if(updateTimeCodeThread != null){
                Stop_Thread();
            }
            updateTimeCodeThread = null;
        }
    }
}
