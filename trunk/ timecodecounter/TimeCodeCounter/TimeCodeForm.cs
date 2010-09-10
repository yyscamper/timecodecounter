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

        public form_timeCode()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void label_timeCode_Click(object sender, EventArgs e)
        {

        }
          
        public void updateTimeCodeThreadFunc()
        {
            String labelStr;
            DateTime preTime, currTime;
            TimeSpan span;
            preTime = DateTime.Now;
            int hour = 12, minute = 0, second = 0, frame = 0;
            StringBuilder strbuf = new StringBuilder(12);
            while(true){
                currTime = DateTime.Now;
                span = currTime - preTime;
                if(span.Milliseconds >= 40){
                    preTime = currTime;
                    if (++frame >= 25)
                    {
                        frame = 0;
                        if (++second >= 60)
                        {
                            second = 0;
                            if (++minute >= 60)
                            {
                                minute = 0;
                                if (++hour >= 24)
                                {
                                    hour = 0;
                                }
                            }

                        }
                    }
                }
                strbuf.Remove(0, strbuf.Length);
                strbuf.AppendFormat("{0:D2}:", hour);
                strbuf.AppendFormat("{0:D2}:", minute);
                strbuf.AppendFormat("{0:D2}-", second);
                strbuf.AppendFormat("{0:D2}", frame);
                safeSetTimeCodeLabel(strbuf.ToString());
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

        private void form_timeCode_SizeChanged(object sender, EventArgs e)
        {

        }

        private void form_timeCode_MouseClick(object sender, MouseEventArgs e)
        {
            /*DateTime now = DateTime.Now;
            String labelStr = now.Hour + ":" + now.Minute + ":" + now.Second + ":" + now.Millisecond;
            label_timeCode.Text = labelStr;*/
        }

        private void safeSetTimeCodeLabel(String str)
        {
            /*if(this.InvokeRequired){
                _safeSetTimeCodeLabelCall call = delegate(String s)
                {
                    this.label_timeCode.Text = s;
                };
                this.Invoke(call, str);
            }else{
                this.label_timeCode.Text = str;
            }*/

            this.label_timeCode.Text = str;
        }

        private void rightMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (mSettingForm == null)
            {
                mSettingForm = new SettingForm();
            }
            this.Visible = false;
            this.ShowDialog(mSettingForm);
        }
    }
}
