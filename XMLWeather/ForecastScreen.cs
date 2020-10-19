using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            List<PictureBox> icons = new List<PictureBox>(new PictureBox [] { iconBox0,iconBox1, iconBox2, iconBox3, iconBox4, iconBox5 });
            double minTempOne = Math.Round(Convert.ToDouble(Form1.days[1].tempLow));
            double maxTempOne = Math.Round(Convert.ToDouble(Form1.days[1].tempHigh));
            DateTime dateOne = Convert.ToDateTime(Form1.days[1].date);

            double minTempTwo = Math.Round(Convert.ToDouble(Form1.days[2].tempLow));
            double maxTempTwo = Math.Round(Convert.ToDouble(Form1.days[2].tempHigh));
            DateTime dateTwo = Convert.ToDateTime(Form1.days[2].date);

            double minTempThree = Math.Round(Convert.ToDouble(Form1.days[3].tempLow));
            double maxTempThree = Math.Round(Convert.ToDouble(Form1.days[3].tempHigh));
            DateTime dateThree = Convert.ToDateTime(Form1.days[3].date);

            double minTempFour = Math.Round(Convert.ToDouble(Form1.days[4].tempLow));
            double maxTempFour = Math.Round(Convert.ToDouble(Form1.days[4].tempHigh));
            DateTime dateFour = Convert.ToDateTime(Form1.days[4].date);

            double minTempFive = Math.Round(Convert.ToDouble(Form1.days[5].tempLow));
            double maxTempFive = Math.Round(Convert.ToDouble(Form1.days[5].tempHigh));
            DateTime dateFive = Convert.ToDateTime(Form1.days[5].date);

            date1.Text = dateOne.ToString ("dddd dd");
            min1.Text = minTempOne.ToString("#") + "°C";
            max1.Text = maxTempOne.ToString("#") + "°C";

            date2.Text = dateTwo.ToString("dddd dd");
            min2.Text = minTempTwo.ToString("#") + "°C";
            max2.Text = maxTempTwo.ToString("#") + "°C";

            date3.Text = dateThree.ToString("dddd dd");
            min3.Text = minTempThree.ToString("#") + "°C";
            max3.Text = maxTempThree.ToString("#") + "°C";

            date4.Text = dateFour.ToString("dddd dd");
            min4.Text = minTempFour.ToString("#") + "°C";
            max4.Text = maxTempFour.ToString("#") + "°C";

            date5.Text = dateFive.ToString("dddd dd");
            min5.Text = minTempFive.ToString("#") + "°C";
            max5.Text = maxTempFive.ToString("#") + "°C";

            for (int i = 0; i < 6 ; i++)
            {
                Image newimage;
                

                if (Convert.ToDouble(Form1.days[i].condition) <= 232)
                {
                    newimage = Form1.thunderstorm;
                    icons[i].Image = newimage;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) <= 531)
                {
                    newimage = Form1.rainy;
                    icons[i].Image = newimage;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) <= 622)
                {
                    newimage = Form1.snowy;
                    icons[i].Image = newimage;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) == 800)
                {
                    newimage = Form1.sunny;
                    icons[i].Image = newimage;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) >= 801)
                {
                    newimage = Form1.cloudy;
                    icons[i].Image = newimage;
                }

                
            }

            if ( Convert.ToDouble(Form1.days[0].currentTemp) >= 20)
            {
                BackgroundImage = Properties.Resources.Red_Background;
            }
            else if (Convert.ToDouble(Form1.days[0].currentTemp) < 20 && Convert.ToDouble(Form1.days[0].currentTemp) > 10)
            {
                BackgroundImage = Properties.Resources.Grey_Background;
            }
            else
            {
                BackgroundImage = Properties.Resources.Blue_Background;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
