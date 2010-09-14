using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeCodeCounter
{
    public class TimeCode
    {
        private double frameRate;
        private Boolean dropFrameFlag;
        private int hour;
        private int min;
        private int sec;
        private int frame;
        private Boolean hourShowFlag = true;
        private Boolean minShowFlag = true;
        private Boolean secShowFlag = true;
        private Boolean frameShowFlag = true;

        private StringBuilder mSb = new StringBuilder(12);

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return min;
            }
            set
            {
                min = value;
            }
        }

        public int Second
        {
            get
            {
                return sec;
            }
            set
            {
                sec = value;
            }
        }

        public int Frame{
            get{
                return frame;
            }
            set
            {
                frame = value;
            }
        }

        public Boolean DropFrame
        {
            get
            {
                return dropFrameFlag;
            }
            set
            {
                dropFrameFlag = value;
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

        public Boolean HourShow
        {
            get
            {
                return hourShowFlag;
            }
            set
            {
                hourShowFlag = value;
            }
        }

        public Boolean MinuteShow
        {
            get
            {
                return minShowFlag;
            }
            set
            {
                minShowFlag = value;
            }
        }

        public Boolean SecondShow
        {
            get
            {
                return secShowFlag;
            }
            set
            {
                secShowFlag = value;
            }
        }

        public Boolean FrameShow
        {
            get
            {
                return frameShowFlag;
            }
            set
            {
                frameShowFlag = value;
            }
        }

        public TimeCode()
        {
            hour = 0;
            min = 0;
            sec = 0;
            frame = 0;
            frameRate = 25;
            dropFrameFlag = false;
        }

        public TimeCode(int hour, int min, int sec, int frame)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
            this.frame = frame;
        }

        public TimeCode(int hour, int min, int sec, int frame, Boolean dropframe, double framerate)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
            this.frame = frame;
            this.dropFrameFlag = dropframe;
            this.frameRate = framerate;
        }

        public override String ToString(){
            mSb.Remove(0, mSb.Length);
            if(hourShowFlag){
                mSb.AppendFormat("{0:D2}:", hour);
            }
            if(minShowFlag){
                mSb.AppendFormat("{0:D2}:", min);
            }
            if(secShowFlag){
                mSb.AppendFormat("{0:D2}-", sec);
            }
            if(frameShowFlag){
                mSb.AppendFormat("{0:D2}", frame);
            }
            return mSb.ToString();
        }

        public void SetShowMode(Boolean hourShow, Boolean minShow, Boolean secShow, Boolean frameShow)
        {
            this.hourShowFlag = hourShow;
            this.minShowFlag = minShow;
            this.secShowFlag = secShow;
            this.frameShowFlag = frameShow;
        }

        public void Increase()
        {
            if (++frame >= 25)
            {
                frame = 0;
                if (++sec >= 60)
                {
                    sec = 0;
                    if (++min >= 60)
                    {
                        min = 0;
                        if (++hour >= 24)
                        {
                            hour = 0;
                        }
                    }

                }
            }
        }

        public void Decrease()
        {

        }

    }
}
