using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCFuelCalc
{
    public partial class Form1 : Form
    {
        int hoursToSec;
        int minutesToSec;
        int seconds;
        int minutesToSecL;
        int secondsL;
        int miliSecL;
        int total;

        public Form1()
        {
            InitializeComponent();
        }


        private void Calc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                hoursToSec = int.Parse(hoursLeft.Text);
                minutesToSec = int.Parse(minutesLeft.Text);
                seconds = int.Parse(secondsLeft.Text);
                System.DateTime time = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hoursToSec, minutesToSec, seconds);
                label2.Text = (time.Hour * 3600 + time.Minute * 60 + time.Second).ToString();

                minutesToSecL = int.Parse(LapTimesMin.Text);
                secondsL = int.Parse(LapTimesSec.Text);
                miliSecL = int.Parse(LapTimesMiliSec.Text);
                System.DateTime timeL = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, minutesToSecL, secondsL, miliSecL);
                label3.Text = (timeL.Minute * 60 + timeL.Second + Math.Ceiling(Convert.ToDouble(timeL.Millisecond)/1000)).ToString();

                double lapsRemaining = Math.Ceiling((time.Hour * 3600 + time.Minute * 60 + time.Second) / (timeL.Minute * 60 + timeL.Second + Math.Ceiling(Convert.ToDouble(timeL.Millisecond) / 1000)));
                Console.WriteLine(lapsRemaining);

                int t = (time.Hour * 3600 + time.Minute * 60 + time.Second);


                double fuelConsumption = double.Parse(FuelConsumption.Text);
                double fuelNeeded = Math.Ceiling(lapsRemaining * fuelConsumption);
                label1.Text = fuelNeeded.ToString();

                total = hoursToSec * 3600 + minutesToSec * 60 + seconds;

                timer1.Start();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Value must be type of number");
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            hoursLeft.Text = "0";
            minutesLeft.Text = "0";
            secondsLeft.Text = "0";
            LapTimesMin.Text = "0";
            LapTimesSec.Text = "0";
            LapTimesMiliSec.Text = "0";
            FuelConsumption.Text = "0";
            textBox1.Text = "00:00:00";

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
           // total = hoursToSec * 3600 + minutesToSec * 60 + seconds;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeSpan.FromSeconds(total);
            textBox1.Text = time.ToString(@"hh\:mm\:ss");
            total -= 1;

            double lapInSec = minutesToSecL * 60 + secondsL + (miliSecL / 1000);
            lapInSec = Math.Ceiling(lapInSec);
            double lapsRemaining = Math.Ceiling(total / lapInSec);

            double fuelConsumption = double.Parse(FuelConsumption.Text);
            double fuelNeeded = Math.Ceiling(lapsRemaining * fuelConsumption);
            label1.Text = fuelNeeded.ToString() + "l";
            label4.Text = lapsRemaining.ToString() + "L";

            if(total <= 0)
            {
                timer1.Stop();
                resetBtn_Click(sender, e);
            }




        }

        private void hoursLeft_TextChanged(object sender, EventArgs e)
        {

        }

        private void minutesLeft_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondsLeft_TextChanged(object sender, EventArgs e)
        {

        }

        private void LapTimesMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LapTimesSec_TextChanged(object sender, EventArgs e)
        {

        }

        private void LapTimesMiliSec_TextChanged(object sender, EventArgs e)
        {

        }

        private void FuelConsumption_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hoursLeft.Text = "0";
            minutesLeft.Text = "0";
            secondsLeft.Text = "0";
            LapTimesMin.Text = "0";
            LapTimesSec.Text = "0";
            LapTimesMiliSec.Text = "0";
            FuelConsumption.Text = "0";
            textBox1.Text = "00:00:00";
        }
    }
}
