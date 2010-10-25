using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeCodeCounter
{
    public class TimeCode
    {
        private double frameRate;
        private Boolean dropFrame;
        private DateTime startTime;

        private TimeSpan veryBeginSpan;
        private TimeSpan beginSpan;

        public static readonly int USE_CUSTOM_VALUE = 0;
        public static readonly int USE_SYSTEM_TIME = 1;
        public static readonly int USE_RANDOM_VALUE = 2;

        private int mMode = USE_CUSTOM_VALUE; //模式

        private Boolean mHasBegin = false;

        public Boolean DropFrame
        {
            get
            {
                return dropFrame;
            }
            set
            {
                dropFrame = value;
            }
        }

        public double FrameRate
        {
            get
            {
                return frameRate;
            }
            set
            {
                frameRate = value;
            }
        }

        public int Mode{
            get{
                return mMode;
            }
            set{
                mMode = value;
            }
        }

        public TimeCode()
        {
            frameRate = 25;
            dropFrame = false;
            veryBeginSpan = TimeSpan.Zero;
            beginSpan = TimeSpan.Zero;
        }

        public TimeCode(int hour, int min, int sec, int frame, double frameRate)
        {
            SetInitValue(hour, min, sec, frame, frameRate);
        }

        public override String ToString(){
            int hour = 0, min = 0, sec = 0, frame = 0;
            GetCurrTimeCode(ref hour, ref min, ref sec, ref frame);
            StringBuilder mSb = new StringBuilder();
            mSb.AppendFormat("{0:D2}:{1:D2}:{2:D2}-{3:D2}", hour, min, sec, frame);
            return mSb.ToString();
        }

        public void GetCurrTimeCode(ref int hour, ref int min, ref int sec, ref int frame)
        {
            DateTime currTime = DateTime.Now;
            if(mMode == USE_SYSTEM_TIME){
                hour = currTime.Hour;
                min = currTime.Minute;
                sec = currTime.Second;
                frame = (int)(currTime.Millisecond * frameRate / 1000.0);
            }else{
                TimeSpan span = currTime - startTime + beginSpan;
                hour = (span.Hours + span.Days * 24) % 100;
                min = span.Minutes;
                sec = span.Seconds;
                frame = (int)(span.Milliseconds * frameRate / 1000.0);
            }
        }

        public void GetInitTimeCode(ref int hour, ref int min, ref int sec, ref int frame)
        {
            hour = veryBeginSpan.Hours;
            min = veryBeginSpan.Minutes;
            sec = veryBeginSpan.Seconds;
            frame = (int)(veryBeginSpan.Milliseconds * frameRate / 1000.0);
        }

        public void Start()
        {
            startTime = DateTime.Now;
            if(!mHasBegin && mMode == USE_RANDOM_VALUE){
                Random randobj = new Random();
                int hourRandVal = randobj.Next(100);
                veryBeginSpan = new TimeSpan(hourRandVal / 24, hourRandVal % 24, randobj.Next(60),  randobj.Next(60),
                    (int)(randobj.Next((int)Math.Ceiling(frameRate)) * 1000 / frameRate));
                beginSpan = veryBeginSpan;
            }
            mHasBegin = true;
        }

        public void SetInitValue(int hour, int min, int sec, int frame, double frameRate)
        {
            this.frameRate = frameRate;
            veryBeginSpan = new TimeSpan(hour/24, hour%24, min, sec, (int)(frame * 1000 / frameRate));
            beginSpan = veryBeginSpan;
            Start();
        }

        public void Stop()
        {
            beginSpan = veryBeginSpan;
            mHasBegin = false;
        }

        public void Pause()
        {
            beginSpan = DateTime.Now - startTime + beginSpan;
        }
    }
}
