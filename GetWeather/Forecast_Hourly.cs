using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Configuration;



namespace GetWeather
{
    class WearherForecast
    {
        private XmlDocument ForecastFile;
        public float minT;//min temperature F
        public float maxT;//max_temperature F
        public float temp_f; // current temperature F
        public float dewpt; // dew point
        public float rh; //relative humidity
        public string wind_dir; //wind direction
        public float wind_speed;
        public string clouds;
        public float pop_12hr;
        public float qpf_12hr;
        public string snow_12hr;
        public string rain_12hr;
        public string rain_shrs;
        public string snow;
        public string snow_shrs;
        public float wind_chill; //wind chill F
        public float min_chill;
        public WearherForecast()
        {
            ForecastFile = new XmlDocument();
            //String URL = ConfigurationManager.AppSettings[];
            String ForecastURL = Properties.Settings.Default.ForecastURL + "=" + Properties.Settings.Default.ForecastLocation;
            ForecastFile.Load(ForecastURL);


        }



    }
}
