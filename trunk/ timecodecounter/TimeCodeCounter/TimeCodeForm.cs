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
        SettingForm mSettingForm = null;
        Boolean mStartFlag = false;
        public TimeCode mTimeCode = null;

        public void SetTimeCodeFont(Font font)
        {
            this.label_timeCode.Font = font;
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

        public form_timeCode()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            mTimeCode = new TimeCode();
        }

        private void label_timeCode_Click(object sender, EventArgs e)
        {

        }
          
        public void updateTimeCodeThreadFunc()
        {
            DateTime preTime, currTime;
            TimeSpan span;
            preTime = DateTime.Now;
            while(true){
                currTime = DateTime.Now;
                span = currTime - preTime;
                if(span.Milliseconds >= 40){
                    preTime = currTime;
                    mTimeCode.Increase();
                }
                this.label_timeCode.Text = mTimeCode.ToString();
                Thread.Sleep(1);
            } 
        }  
         
        private void form_timeCode_load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String labelStr = now.Hour + ":" + now.Minute + ":" + now.Second + ":" + now.Millisecond;
            label_timeCode.Text = labelStr;
            Thread updateTimeCodeThread = new Thread(new ThreadStart(this.updateTimeCodeThreadFunc));
            try{
                 updateTimeCodeThread.Start();
            }catch(ThreadStartException){
                Console.WriteLine("updateTimeCodeThread create failed!");
            }
        }

        private void rightMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void rightmenu_setting_Click(object sender, EventArgs e)
        {
            if (mSettingForm == null)
            {
                mSettingForm = new SettingForm(this);
            }
            this.Visible = false;
            mSettingForm.Visible = true;
            this.Show(mSettingForm);
        }
    }
}
