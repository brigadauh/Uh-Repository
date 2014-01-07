using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GetWeather
{
    public partial class FrmWeatherHistory : Form
    {
        public FrmWeatherHistory()
        {
            InitializeComponent();
        }

        private void FrmWeatherHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'weather_DBDataSet.v_Weather_Today' table. You can move, or remove it, as needed.
            this.v_Weather_TodayTableAdapter.Fill(this.weather_DBDataSet.v_Weather_Today);
            // TODO: This line of code loads data into the 'weather_DBDataSet.v_Weather_Today' table. You can move, or remove it, as needed.
            this.v_Weather_TodayTableAdapter.Fill(this.weather_DBDataSet.v_Weather_Today);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vWeatherTodayBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}