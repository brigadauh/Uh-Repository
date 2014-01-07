using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;

namespace GetWeather
{
    //[DllImport("user32.dll", EntryPoint="DestroyIcon")]
//static extern bool DestroyIcon(IntPtr hIcon);
    public partial class FrmWeather : Form
    {
        public FrmWeather()
        {
            InitializeComponent();
        }/*
        private XmlNodeList Weather ;
        private XmlDocument weatherfile;
        private double temp_c;
        private double temp_f;
        private double pr_in;
        private double pr_mm;
        private string wind_dir;
        private double wind_mph;
        private double wind_mps;
        private double relative_humidity;
        private double windchill_c;
        private double windchill_f;
        private string sky;
        private string station;
        private string location;
        private string observation_time_rfc822;
        private string observation_time;
        private DateTime observation_time_d;
        */
        private void FrmWeather_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
        private void getweather()
        {   //weatherfile = new XmlDocument();
//            weatherfile.Load("http://nws.noaa.gov/data/current_obs/KTEB.xml");
//            string sURL = (string)System.Configuration.ConfigurationSettings.GetConfig("app.config/WeatherStation");
        string sURL = Properties.Settings.Default.WeatherStation;
        Weather WeatherObj = new Weather(sURL);

        LblTemp.Text = "T: " + System.Convert.ToString(WeatherObj.temp_c) + "°C ( " + System.Convert.ToString(WeatherObj.temp_f) + "°F)";
        LblStation.Text = "Station: " + WeatherObj.station + " - " + WeatherObj.location;
        LblSky.Text = "Sky: " + WeatherObj.sky;
        LblWndChill.Text = "Wind chill: " + System.Convert.ToString(WeatherObj.windchill_c) + "°C ( " + System.Convert.ToString(WeatherObj.windchill_f) + "°F)";
        LblWndDir.Text = "Wind: " + WeatherObj.wind_dir + " " + System.Convert.ToString(WeatherObj.wind_mps) + " m/s ( " + System.Convert.ToString(WeatherObj.wind_mph) + " mph)";
        LblHumid.Text = "Humidity: " + Convert.ToString(WeatherObj.relative_humidity) + "%";

        LblPr.Text = "Barometer: " + Convert.ToString(WeatherObj.pr_mm) + " mm ( " + System.Convert.ToString(WeatherObj.pr_in) + " in)";
        LblObservTime.Text = "Last update: " + WeatherObj.observation_time;

        string MyConnString = ConfigurationManager.ConnectionStrings["GetWeather.Properties.Settings.Weather_DBConnectionString"].ConnectionString; ;// ConfigurationManager.AppSettings["connectionString"];//"Data Source=SERVER\\SERVER;Initial Catalog=Weather_DB;User ID=sa";
            SqlConnection MyConnection = new SqlConnection(MyConnString);
            try
            {
                MyConnection.Open();
                string sSQL = "exec sp_addWeather '" + WeatherObj.sky + "'"
                + "," + Convert.ToString(WeatherObj.temp_c)
                + ",'" + WeatherObj.wind_dir + "'"
                + "," + Convert.ToString(WeatherObj.wind_mps)
                + "," + Convert.ToString(WeatherObj.pr_in)
                + "," + Convert.ToString(WeatherObj.relative_humidity)
                + "," + Convert.ToString(WeatherObj.windchill_c)
                + ",'" + Convert.ToString(WeatherObj.observation_time_d) + "'"
                + ",'" + WeatherObj.station + "'";
                //sSQL = " insert into Weather (Observ_Time_D) values('" + Convert.ToString(observation_time_d) + "')";
                SqlCommand MyCommand = new SqlCommand(sSQL, MyConnection);
                MyCommand.ExecuteNonQuery();
                MyCommand.Dispose();
            }
            finally
            {
                MyConnection.Close();
                MyConnection.Dispose();
            }
            UpdateTaskBar(System.Convert.ToString(WeatherObj.temp_c));
            WeatherNotifyIcon.Text = System.Convert.ToString(WeatherObj.temp_c) + "°C ( " + System.Convert.ToString(WeatherObj.temp_f) + "°F)," + WeatherObj.sky;
            WeatherNotifyIcon.Click+=new EventHandler(WeatherNotifyIcon_Click);
            
            //MyCommand.ExecuteScalar();
            
//            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
//            myDataAdapter = new OleDbDataAdapter(sSQL, MyConnection);

//            Dim ds As New DataSet()
       //myDataAdapter.Fill(ds, "avail")

           
        }
        private void UpdateTaskBar(string Curr_temperature)
        {
            if (Curr_temperature.Length == 0)
                return;

            // Create a graphics instance that draws to a bitmap
            Bitmap bitmap = new Bitmap(16, 16);
            SolidBrush brush = new SolidBrush(Color.Blue);
            Graphics graphics = Graphics.FromImage(bitmap);

            // Draw the temperature and the degrees symbol
            // to the bitmap using the user selected font
            //int index = temperatureLabel.Text.IndexOf('°');
            // don't want 'F' after the degree symbol
            String temperatureOnlyStr = Curr_temperature.Trim() + '°';
            graphics.DrawString(temperatureOnlyStr, new Font("Arial Narrow",8), brush,0,0);
           
            // Convert the bitmap into an icon and use it for the system tray icon
            IntPtr hIcon = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(hIcon);
            WeatherNotifyIcon.Icon = icon;

            // unfortunately, GetHicon creates an 
            // unmanaged handle which must be manually destroyed
            //DestroyIcon(hIcon);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            getweather();
        }
        private void WeatherNotifyIcon_Click(object sender, EventArgs e)
        {
           this.SetTopLevel(true);
           this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now.Minute >= 25 && System.DateTime.Now.Minute <= 40)
                {
                    getweather();
                    //timer1.Interval = 3600000;
                    timer1.Interval = (60 - System.DateTime.Now.Minute + 25) * 60000;
                    LblNextRead.Text = "Next Reading:" + Convert.ToString(DateTime.Now.AddMilliseconds(timer1.Interval));
                }
                else
                {
                    timer1.Interval = (60 - System.DateTime.Now.Minute + 25) * 60000;
                    getweather();
                }
                timer1.Stop();
                timer1.Start();
                LblNextRead.Text = "Next Reading:" + Convert.ToString(DateTime.Now.AddMilliseconds(timer1.Interval));
            }
            catch ( Exception ex )
            { Console.WriteLine(ex); }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            FrmWeatherHistory Whist = new FrmWeatherHistory();
            Whist.Show();
        }

        private void BtnEvent_Click(object sender, EventArgs e)
        {
            FrmEvent Wevent = new FrmEvent();
            Wevent.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings Wsettings = new FrmSettings();
            Wsettings.ShowDialog();
            getweather();
        }

        private void WeatherNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            //Show();
            //this.BringToFront();
            WindowState = FormWindowState.Normal;
            this.Activate();
        }


        private void FrmWeather_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();

        }

        //http://www.weather.gov/data/current_obs/index.xml - stations list
       
    }
}