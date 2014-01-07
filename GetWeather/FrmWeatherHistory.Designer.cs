namespace GetWeather
{
    partial class FrmWeatherHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.observedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windDirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windMphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relativeHumidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windchillCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInsertedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vWeatherTodayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weather_DBDataSet = new GetWeather.Weather_DBDataSet();
            this.v_Weather_TodayTableAdapter = new GetWeather.Weather_DBDataSetTableAdapters.v_Weather_TodayTableAdapter();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observed_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wind_Dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wind_mph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relative_humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windchill_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Inserted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeatherTodayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // observedTimeDataGridViewTextBoxColumn
            // 
            this.observedTimeDataGridViewTextBoxColumn.DataPropertyName = "Observed Time";
            this.observedTimeDataGridViewTextBoxColumn.HeaderText = "Observed Time";
            this.observedTimeDataGridViewTextBoxColumn.Name = "observedTimeDataGridViewTextBoxColumn";
            this.observedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skyDataGridViewTextBoxColumn
            // 
            this.skyDataGridViewTextBoxColumn.DataPropertyName = "Sky";
            this.skyDataGridViewTextBoxColumn.HeaderText = "Sky";
            this.skyDataGridViewTextBoxColumn.Name = "skyDataGridViewTextBoxColumn";
            this.skyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempCDataGridViewTextBoxColumn
            // 
            this.tempCDataGridViewTextBoxColumn.DataPropertyName = "Temp (C)";
            this.tempCDataGridViewTextBoxColumn.HeaderText = "Temp (C)";
            this.tempCDataGridViewTextBoxColumn.Name = "tempCDataGridViewTextBoxColumn";
            this.tempCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // windDirDataGridViewTextBoxColumn
            // 
            this.windDirDataGridViewTextBoxColumn.DataPropertyName = "Wind Dir";
            this.windDirDataGridViewTextBoxColumn.HeaderText = "Wind Dir";
            this.windDirDataGridViewTextBoxColumn.Name = "windDirDataGridViewTextBoxColumn";
            this.windDirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // windMphDataGridViewTextBoxColumn
            // 
            this.windMphDataGridViewTextBoxColumn.DataPropertyName = "Wind mph";
            this.windMphDataGridViewTextBoxColumn.HeaderText = "Wind mph";
            this.windMphDataGridViewTextBoxColumn.Name = "windMphDataGridViewTextBoxColumn";
            this.windMphDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pressureinDataGridViewTextBoxColumn
            // 
            this.pressureinDataGridViewTextBoxColumn.DataPropertyName = "Pressure (in)";
            this.pressureinDataGridViewTextBoxColumn.HeaderText = "Pressure (in)";
            this.pressureinDataGridViewTextBoxColumn.Name = "pressureinDataGridViewTextBoxColumn";
            this.pressureinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relativeHumidityDataGridViewTextBoxColumn
            // 
            this.relativeHumidityDataGridViewTextBoxColumn.DataPropertyName = "relative humidity";
            this.relativeHumidityDataGridViewTextBoxColumn.HeaderText = "relative humidity";
            this.relativeHumidityDataGridViewTextBoxColumn.Name = "relativeHumidityDataGridViewTextBoxColumn";
            this.relativeHumidityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // windchillCDataGridViewTextBoxColumn
            // 
            this.windchillCDataGridViewTextBoxColumn.DataPropertyName = "windchill (C)";
            this.windchillCDataGridViewTextBoxColumn.HeaderText = "windchill (C)";
            this.windchillCDataGridViewTextBoxColumn.Name = "windchillCDataGridViewTextBoxColumn";
            this.windchillCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeInsertedDataGridViewTextBoxColumn
            // 
            this.timeInsertedDataGridViewTextBoxColumn.DataPropertyName = "Time Inserted";
            this.timeInsertedDataGridViewTextBoxColumn.HeaderText = "Time Inserted";
            this.timeInsertedDataGridViewTextBoxColumn.Name = "timeInsertedDataGridViewTextBoxColumn";
            this.timeInsertedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Station,
            this.Observed_Time,
            this.Temp_C,
            this.Wind_Dir,
            this.Wind_mph,
            this.Pressure_in,
            this.relative_humidity,
            this.windchill_C,
            this.Time_Inserted,
            this.skyDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.vWeatherTodayBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 502);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // vWeatherTodayBindingSource
            // 
            this.vWeatherTodayBindingSource.DataMember = "v_Weather_Today";
            this.vWeatherTodayBindingSource.DataSource = this.weather_DBDataSet;
            this.vWeatherTodayBindingSource.CurrentChanged += new System.EventHandler(this.vWeatherTodayBindingSource_CurrentChanged);
            // 
            // weather_DBDataSet
            // 
            this.weather_DBDataSet.DataSetName = "Weather_DBDataSet";
            this.weather_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_Weather_TodayTableAdapter
            // 
            this.v_Weather_TodayTableAdapter.ClearBeforeFill = true;
            // 
            // Station
            // 
            this.Station.DataPropertyName = "Station";
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            // 
            // Observed_Time
            // 
            this.Observed_Time.DataPropertyName = "Observed_Time";
            this.Observed_Time.HeaderText = "Observed Time";
            this.Observed_Time.Name = "Observed_Time";
            // 
            // Temp_C
            // 
            this.Temp_C.DataPropertyName = "Temp_C";
            this.Temp_C.HeaderText = "Temp(C)";
            this.Temp_C.Name = "Temp_C";
            // 
            // Wind_Dir
            // 
            this.Wind_Dir.DataPropertyName = "Wind_Dir";
            this.Wind_Dir.HeaderText = "Wind Dir";
            this.Wind_Dir.Name = "Wind_Dir";
            // 
            // Wind_mph
            // 
            this.Wind_mph.DataPropertyName = "Wind_mph";
            this.Wind_mph.HeaderText = "Wind mph";
            this.Wind_mph.Name = "Wind_mph";
            // 
            // Pressure_in
            // 
            this.Pressure_in.DataPropertyName = "Pressure_in";
            this.Pressure_in.HeaderText = "Pressure (in)";
            this.Pressure_in.Name = "Pressure_in";
            // 
            // relative_humidity
            // 
            this.relative_humidity.DataPropertyName = "relative_humidity";
            this.relative_humidity.HeaderText = "Relative Humidity";
            this.relative_humidity.Name = "relative_humidity";
            // 
            // windchill_C
            // 
            this.windchill_C.DataPropertyName = "windchill_C";
            this.windchill_C.HeaderText = "windchill (C)";
            this.windchill_C.Name = "windchill_C";
            // 
            // Time_Inserted
            // 
            this.Time_Inserted.DataPropertyName = "Time_Inserted";
            this.Time_Inserted.HeaderText = "Time Inserted";
            this.Time_Inserted.Name = "Time_Inserted";
            // 
            // skyDataGridViewTextBoxColumn1
            // 
            this.skyDataGridViewTextBoxColumn1.DataPropertyName = "Sky";
            this.skyDataGridViewTextBoxColumn1.HeaderText = "Sky";
            this.skyDataGridViewTextBoxColumn1.Name = "skyDataGridViewTextBoxColumn1";
            // 
            // FrmWeatherHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 502);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmWeatherHistory";
            this.Text = "FrmWeatherHistory";
            this.Load += new System.EventHandler(this.FrmWeatherHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeatherTodayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Weather_DBDataSet weather_DBDataSet;
        private System.Windows.Forms.BindingSource vWeatherTodayBindingSource;
        private GetWeather.Weather_DBDataSetTableAdapters.v_Weather_TodayTableAdapter v_Weather_TodayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn observedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windDirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windMphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relativeHumidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windchillCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInsertedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observedTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observed_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wind_Dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wind_mph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressure_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn relative_humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn windchill_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Inserted;
        private System.Windows.Forms.DataGridViewTextBoxColumn skyDataGridViewTextBoxColumn1;

            }
}