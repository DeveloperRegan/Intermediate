//Terence Regan 3/15 stop watch
using System;
using System.Windows.Forms;
using TPR.StopWatch.BL;

namespace TPR.StopWatch.UI
{
    public partial class Form1 : Form
    {
        //initialize a watch
        Watch sw = new Watch();
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            // Moved this line to the Watch Class. Time method.
            //    sw.stopTime = DateTime.Now;
            //Moved this to ElapsedTime property
            //   sw.time();
            //   sw.StopClock(DateTime.Now);
            //    sw.time(DateTime.Now);
            //   sw.StartClock(DateTime.Now);

            lblDisplay.Text = sw.ElapsedTIme;
            
        }
        //check in
        private void btnLap_Click(object sender, EventArgs e)
        { //Only lets the user use the lap button if the stopwatch is running
            try  
            {
                //changes the label above the listbox of split times.
                lblSplitTimes.Text = "Hours:Minutes:Seconds.MiliSeconds";
                //calls split time method
                sw.LapTimes();
                lstLaps.Items.Clear();
                //Populates the list box via a foreach loop.
                foreach (TimeSpan times in sw.splitTimes)
                    lstLaps.Items.Add(times.Hours.ToString("D2") + ":" +
                        times.Minutes.ToString("D2") + ":" + times.Seconds.ToString("D2") + "." + times.Milliseconds.ToString());
                //sets the last time to be now.
             //  Removed this line.   sw.lastTime = DateTime.Now;
            }
            catch (StartException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {//Try catches.
            try
            {
                sw.StartClock(DateTime.Now);
                tmrTick.Enabled = true;
                lstLaps.Items.Clear();
            }
            catch (StartException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {//try catches
            try
            {
                tmrTick.Enabled = false;
                sw.StopClock(DateTime.Now);
                sw.splitTimes.Clear();
            }
            catch (StopException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {

            }
       
        }

 
    }
}
