using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;


namespace GetWeather
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        private XmlNodeList StationList;
        private XmlDocument StationsFile;
        private XmlDocument StationFile;
        private XmlNodeList Station;
        private string station_id;
        private string station_name;
        private string state;
        private string sURL;
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            int i;
            StationsFile = new XmlDocument();
            StationsFile.Load("http://www.weather.gov/data/current_obs/index.xml");
            StationList = StationsFile.GetElementsByTagName("station");
            StationFile = new XmlDocument();
            
            for (i = 0; i < StationList.Count; i++)
            {

                try
                {
                    StationFile.LoadXml(StationList[i].OuterXml);
                    Station = StationFile.GetElementsByTagName("station_id");
                    station_id = Station[0].InnerText;
                    Station = StationFile.GetElementsByTagName("station_name");
                    station_name = Station[0].InnerText;
                    Station = StationFile.GetElementsByTagName("state");
                    state = Station[0].InnerText;

                    LstStation.Items.Insert(i, state + ", " + station_name + " (" + station_id + ")");
//                    if (i==2) {
//                    LstStation.i;
//                    }
                }
                catch (Exception e_s)
                {
                    MessageBox.Show(e_s.Message);
                }

            }
        }

        private void SetBtnSave_Click(object sender, EventArgs e)
        {
            int i = LstStation.SelectedIndex ;
            try
            {
                
                StationFile.LoadXml(StationList[i].OuterXml);
                Station = StationFile.GetElementsByTagName("xml_url");
                sURL = Station[0].InnerText;
                //MessageBox.Show(sURL);
                Properties.Settings.Default.WeatherStation = sURL;
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch (Exception e_s)
            {
                MessageBox.Show(e_s.Message);
            }


        }
    }
}