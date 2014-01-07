using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GetWeather
{
    class Weather
    {
        private XmlNodeList WeatherNodeList;
        private XmlDocument weatherfile;
        public double temp_c;
        public double temp_f;
        public double pr_in;
        public double pr_mm;
        public string wind_dir;
        public double wind_mph;
        public double wind_mps;
        public double relative_humidity;
        public double windchill_c;
        public double windchill_f;
        public string sky;
        public string station;
        public string location;
        public string observation_time_rfc822;
        public string observation_time;
        public DateTime observation_time_d;
        public Weather(string sURL)
        {
            weatherfile = new XmlDocument();
            weatherfile.Load(sURL);
            WeatherNodeList = weatherfile.GetElementsByTagName("station_id");
            station = WeatherNodeList[0].InnerText;
            WeatherNodeList = weatherfile.GetElementsByTagName("location");
            location = WeatherNodeList[0].InnerText;
            WeatherNodeList = weatherfile.GetElementsByTagName("weather");
            sky = WeatherNodeList[0].InnerText;
            WeatherNodeList = weatherfile.GetElementsByTagName("temp_f");
            try
            {
                temp_c = Math.Round((Convert.ToDouble(WeatherNodeList[0].InnerText) - 32) / 1.8);
            }
            catch (Exception e)
            {
                temp_c = -273;
            }
            temp_f = temp_c * 9 / 5 + 32;
            WeatherNodeList = weatherfile.GetElementsByTagName("pressure_in");
            try
            {
                pr_in = Convert.ToDouble(WeatherNodeList[0].InnerText);
            }
            catch (Exception e)
            {
                pr_in = 0;
            }

            pr_mm = pr_in * 25.4;
            WeatherNodeList = weatherfile.GetElementsByTagName("wind_dir");
            wind_dir = WeatherNodeList[0].InnerText;

            WeatherNodeList = weatherfile.GetElementsByTagName("wind_mph");
            try
            {
                wind_mph = Convert.ToDouble(WeatherNodeList[0].InnerText);
            }
            catch (Exception e)
            {
                wind_mph = 0;
            }

            wind_mps = Math.Round(wind_mph * 1.66 * 1000 / 3600, 1);
            WeatherNodeList = weatherfile.GetElementsByTagName("relative_humidity");
            try
            {
                relative_humidity = Convert.ToDouble(WeatherNodeList[0].InnerText);
            }
            catch (Exception e)
            {
                relative_humidity = 0;
            }


            WeatherNodeList = weatherfile.GetElementsByTagName("windchill_c");
            try
            {
                windchill_c = Convert.ToDouble(WeatherNodeList[0].InnerText);
            }
            catch (Exception e)
            {
                windchill_c = temp_c;

            }


            windchill_f = windchill_c * 9 / 5 + 32;

            WeatherNodeList = weatherfile.GetElementsByTagName("observation_time_rfc822");
            observation_time_rfc822 = WeatherNodeList[0].InnerText;
            observation_time = observation_time_rfc822.Substring(5, 20);
            try
            {
                observation_time_d = Convert.ToDateTime(observation_time);
            }
            catch (Exception e)
            {
                observation_time_d = Convert.ToDateTime("1900/01/01");
            }



        }
        ~Weather()
        {
        }

    }
}
