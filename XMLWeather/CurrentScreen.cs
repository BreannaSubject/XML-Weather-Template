﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        const int ICON_SIZE = 200;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            double currentTemp = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp));
            double minTemp = Math.Round(Convert.ToDouble(Form1.days[0].tempLow));
            double maxTemp = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh));
            int lastUpdate = Convert.ToInt32(Form1.days[0].lastUpdate);

            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = currentTemp.ToString("#") + "°C";
            minOutput.Text = minTemp.ToString("#") + "°C";
            maxOutput.Text = maxTemp.ToString("#") + "°C";
            timeLabel.Text += ;


        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            if (Convert.ToDouble(Form1.days[0].condition) <= 232)
            {
                e.Graphics.DrawImage(Form1.thunderstorm, this.Width / 2 - ICON_SIZE/2, this.Height / 2 - ICON_SIZE, ICON_SIZE, ICON_SIZE);
            }
            else if (Convert.ToDouble(Form1.days[0].condition) <= 531)
            {
                e.Graphics.DrawImage(Form1.rainy, this.Width / 2 - ICON_SIZE/2, this.Height / 2 - ICON_SIZE, ICON_SIZE, ICON_SIZE);
            }
            else if (Convert.ToDouble(Form1.days[0].condition) <= 622)
            {
                e.Graphics.DrawImage(Form1.snowy, this.Width / 2 - ICON_SIZE/2, this.Height / 2 - ICON_SIZE, ICON_SIZE, ICON_SIZE);
            }
            else if (Convert.ToDouble(Form1.days[0].condition) == 800)
            {
                e.Graphics.DrawImage(Form1.sunny, this.Width / 2 - ICON_SIZE/2, this.Height / 2 - ICON_SIZE, ICON_SIZE, ICON_SIZE);
            }
            else if (Convert.ToDouble(Form1.days[0].condition) >= 801)
            {
                e.Graphics.DrawImage(Form1.cloudy, this.Width / 2 - ICON_SIZE/2, this.Height / 2 - ICON_SIZE, ICON_SIZE, ICON_SIZE);
            }
        }
    }
}
