using System;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            txtTemperature.Text = "12.5 °C";
            txtPrecipitation.Text = "1.2 mm";
            txtHumidity.Text = "78 %";
            txtPressure.Text = "1015 hPa";
            txtWind.Text = "14 km/h";

            
            int wmoCode = 61;
            SetWeatherIconAndDescription(wmoCode);
        }

        private void SetWeatherIconAndDescription(int wmoCode)
        {
            
            string description = "Nieznana pogoda";
            Image icon = Properties.Resources.default_weather; // domyślna ikona

            switch (wmoCode)
            {
                case 0:
                    description = "Bezchmurnie";
                    icon = Properties.Resources.sunny;
                    break;
                case 1:
                case 2:
                    description = "Częściowe zachmurzenie";
                    icon = Properties.Resources.partly_cloudy;
                    break;
                case 3:
                    description = "Zachmurzenie duże";
                    icon = Properties.Resources.cloudy;
                    break;
                case 61:
                    description = "Deszcz umiarkowany";
                    icon = Properties.Resources.rain;
                    break;
                case 71:
                    description = "Śnieg";
                    icon = Properties.Resources.snow;
                    break;
            }

            lblWeatherDescription.Text = description;
            picWeather.Image = icon;
            picWeather.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

using System.ComponentMode
