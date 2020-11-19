//TErence REgan 3/15
using System;
using System.Collections.Generic;

namespace TPR.StopWatch.BL
{
    public class Watch
    {
        //Changed these from properties to fields.
        private DateTime startTime;
        private DateTime stopTime;
        private DateTime lastTime;
        public TimeSpan LapTime { get; set; }
        public String ElapsedTIme { get
            {
                //Moved this from the timerTick method
              time(DateTime.Now);
                return hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + secs.ToString("D2");
            } }
        public int splitTime { get; set; }
        //Set these to private
        private int secs;
        private int minutes;
        private int hours;

        //creates a TimeSpan Variable
      private   TimeSpan timePassed;
        //bool to test if watch is started or stopped;
        private bool isrunning = false;

        //list of split times
        public List<TimeSpan> splitTimes = new List<TimeSpan>();

        public void StartClock(DateTime start)
        { 
            //If isrunning is true and this is called, which it would via the start button, startExecpetion is thrown.
            if (isrunning == true)
            {
                StartException e = new StartException("You are already Running");
                    throw e;
                    }
            //Sets the starttime
            startTime = start;
           // time(DateTime.Now);
          
            isrunning = true;
        }

        public void StopClock(DateTime end)
        {
            if (isrunning == false)
            { StopException e = new StopException("You are already Stopped");
                throw e;
            }
            
            stopTime = end;
            isrunning = false;
        }

       
        public void LapTimes()
        {if (isrunning==false)
            {
                StartException e = new StartException("Start Before you do laps");
                throw e;
            }
            if (splitTimes.Count == 0)
            {
                
                lastTime = DateTime.Now;
                LapTime = lastTime - startTime;
                splitTimes.Add(LapTime);
            }
            else
            {
                splitTimes.Add(DateTime.Now - lastTime);
                lastTime = DateTime.Now;
            }
        }
public void time(DateTime stop)
        {
            //Moved this from UI to the BL
            stopTime = stop;
            //Sets a timespan variable to the diffrences of start and stop time
        timePassed = stopTime - startTime;
            //Assigns hours, minutes, and seconds of the TimePassed to the pertinent variable
            hours = timePassed.Hours;
            minutes = timePassed.Minutes;
            secs = timePassed.Seconds;
        }     
    }
}
