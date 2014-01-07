namespace GetWeather
{
    partial class FrmEvent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.observDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weather_DBDataSet = new GetWeather.Weather_DBDataSet();
            this.weatherDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new GetWeather.Weather_DBDataSetTableAdapters.eventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.observDateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 467);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // observDateDataGridViewTextBoxColumn
            // 
            this.observDateDataGridViewTextBoxColumn.DataPropertyName = "Observ_Date";
            this.observDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.observDateDataGridViewTextBoxColumn.Name = "observDateDataGridViewTextBoxColumn";
            this.observDateDataGridViewTextBoxColumn.ToolTipText = "Event Date";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "event";
            this.eventBindingSource.DataSource = this.weather_DBDataSet;
            this.eventBindingSource.PositionChanged += new System.EventHandler(this.eventBindingSource_PositionChanged);
            // 
            // weather_DBDataSet
            // 
            this.weather_DBDataSet.DataSetName = "Weather_DBDataSet";
            this.weather_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weatherDBDataSetBindingSource
            // 
            this.weatherDBDataSetBindingSource.DataSource = this.weather_DBDataSet;
            this.weatherDBDataSetBindingSource.Position = 0;
            this.weatherDBDataSetBindingSource.CurrentChanged += new System.EventHandler(this.weatherDBDataSetBindingSource_CurrentChanged);
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 467);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEvent";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.FrmEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weather_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource weatherDBDataSetBindingSource;
        private Weather_DBDataSet weather_DBDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private GetWeather.Weather_DBDataSetTableAdapters.eventTableAdapter eventTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn observDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}