using SQLManager.DAL;
using SQLManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLManager
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
            Init();
        }

        private void Init()=>LoadDatabases();

        private void LoadDatabases()
            => CbDatabase.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string selectedDatabase = $"use {CbDatabase.SelectedItem.ToString()} ";
            DataGrid dataGrid = new DataGrid();
            try
            {
                string query = selectedDatabase + TbQuery.Text.Trim();
                DataSet dataTable = RepositoryFactory.GetRepository().GetDataSet(query);

                foreach (DataTable data in dataTable.Tables)
                {
                    dataGrid.DataSource = data;
                    dataGrid.Width = TbResults.Width;
                    dataGrid.Height = TbResults.Height;

                    TbResults.Controls.Add(dataGrid);
                }

                TbMessages.Text = $"({dataGrid.VisibleRowCount}  " + $"rows affected)\n  Completion time: {DateTime.Now}";
            }
            catch (Exception)
            {
                dataGrid = new DataGrid();
                TbMessages.Text = "Nope try again";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
           
        }
    }
}
