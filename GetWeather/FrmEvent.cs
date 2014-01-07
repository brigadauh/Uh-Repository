using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GetWeather
{
    public partial class FrmEvent : Form
    {
        public FrmEvent()
        {
            InitializeComponent();
        }
        //tracks for PositionChanged event last row
        private DataRow LastDataRow = null;
        /// <SUMMARY>
        /// Checks if there is a row with changes and
        /// writes it to the database
        /// </SUMMARY>
        private void UpdateRowToDatabase(DataRow LastDataRow)
        {
            if (LastDataRow != null)
            {
                if (LastDataRow.RowState ==
                    DataRowState.Modified)
                {
                    eventTableAdapter.Update(LastDataRow);
                    //MessageBox.Show("updated");

                }
                if (LastDataRow.RowState ==
                    DataRowState.Added)
                {
                    eventTableAdapter.Update(LastDataRow);
                }
                if (LastDataRow.RowState ==
                    DataRowState.Deleted)
                {
                    eventTableAdapter.Update(LastDataRow);
                }
            }
        }
 
        private void FrmEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'weather_DBDataSet._event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.weather_DBDataSet._event);

        }
        private void eventBindingSource_PositionChanged(
    object sender, EventArgs e)
        {
            // if the user moves to a new row, check if the 
            // last row was changed
            BindingSource thisBindingSource =
              (BindingSource)sender;
            DataRow ThisDataRow =
              ((DataRowView)thisBindingSource.Current).Row;
            if (ThisDataRow == LastDataRow)
            {
                // we need to avoid to write a datarow to the 
                // database when it is still processed. Otherwise
                // we get a problem with the event handling of 
                //the DataTable.
                throw new ApplicationException("It seems the" +
                  " PositionChanged event was fired twice for" +
                  " the same row");
            }
            else
            {
                UpdateRowToDatabase(LastDataRow);
            }
            // track the current row for next 
            // PositionChanged event
            LastDataRow = ThisDataRow;
        }

        private void FrmEvent_FormClosed(
          object sender, FormClosedEventArgs e)
        {
            UpdateRowToDatabase(LastDataRow);
        }

        private void weatherDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}