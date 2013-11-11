using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using Prescient.Database;
using System.Data.SqlClient;
using PrescientBusinessObjects.ViewModels;
using PrescientBusinessObjects;

namespace TradeStratInfo_Model_View
{
    public partial class Form1 : Form
    {
        private BindingSource bindingsource1 = new BindingSource();
        private DataGridView dataGridView1 = new DataGridView();

        DataBase db;
        DataTable currentTable;
        
        public Form1()
        {
            dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
            IntializeDataGridView();
            AddMenu();

        }
        public void AddMenu()
        {
            MainMenu mnuFuturesContractsMenu = new MainMenu();
            this.Menu = mnuFuturesContractsMenu;
            MenuItem FuturesContracts = new MenuItem("&FuturesContracts");
            MenuItem addNextExistingContracts = new MenuItem("&Add Next/Edit Existing Contracts");
            MenuItem createNewContract = new MenuItem("&Create a new contract");
        }
    
        public void IntializeDataGridView()
        {
        //    initbusinessobjects
            BusinessObjectsManager.initBusinessObjects("OLDAUTO2\\MSSQL_PEIXIAN", "PRM_COMBINED_TEST", "sa", "Old$ch00l", "OLDAUTO2\\MSSQL_PEIXIAN", "PRM_COMBINED_TEST", "sa", "Old$ch00l");
            db = new DataBase("OLDAUTO2\\MSSQL_PEIXIAN", "PRM_COMBINED_TEST", "sa", "Old$ch00l", 0);
            currentTable = db.GetDataTable("SELECT gszProductFamily, exchExpYear, exchExpMonth, contractType, TopMonth FROM gszExchangeContracts");

            //create the binding source
            bindingsource1.DataSource = currentTable;

            //Initalize the datagridview
            dataGridView1.AutoSize = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingsource1;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            //Initalize the gszproductfamily column
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.DataPropertyName = "gszProductFamily";
            column.HeaderText = "gszProductFamily";
            column.Name = "gszProductFamily";

            DataTable data = new DataTable();

            data.Columns.Add(new DataColumn("Value", typeof(string)));
            data.Columns.Add(new DataColumn("Description", typeof(string)));

            data.Rows.Add("6A", "6A");
            data.Rows.Add("6B", "6B");
            data.Rows.Add("6C", "6C");
            data.Rows.Add("6E", "6E");
            data.Rows.Add("6M", "6M");
            data.Rows.Add("6S", "6S");
            data.Rows.Add("FGBM", "FGBM");
            data.Rows.Add("ZB", "ZB");
            data.Rows.Add("FGBL", "FGBL");
            column.DataSource = data;
            column.ValueMember = "Value";
            column.DisplayMember = "Description";

            dataGridView1.Columns.Add(column);

            //Intializes the expMonth Column
            DataGridViewComboBoxColumn expMonthCol = new DataGridViewComboBoxColumn();
            expMonthCol.DataPropertyName = "exchExpMonth";
            expMonthCol.HeaderText = "exchExpMonth";
            expMonthCol.Name = "exchExpMonth";
            DataTable comboboxReference2 = new DataTable();
            comboboxReference2.Columns.Add(new DataColumn("Value", typeof(string)));
            comboboxReference2.Columns.Add(new DataColumn("Description", typeof(string)));
            comboboxReference2.Rows.Add("1", "1");
            comboboxReference2.Rows.Add("2", "2");
            comboboxReference2.Rows.Add("3", "3");
            comboboxReference2.Rows.Add("4", "4");
            comboboxReference2.Rows.Add("5", "5");
            comboboxReference2.Rows.Add("6", "6");
            comboboxReference2.Rows.Add("7", "7");
            comboboxReference2.Rows.Add("8", "8");
            comboboxReference2.Rows.Add("9", "9");
            comboboxReference2.Rows.Add("10", "10");
            comboboxReference2.Rows.Add("11", "11");
            comboboxReference2.Rows.Add("12", "12");
            comboboxReference2.Rows.Add("01", "01");
            comboboxReference2.Rows.Add("02", "02");
            comboboxReference2.Rows.Add("03", "03");
            comboboxReference2.Rows.Add("04", "04");
            comboboxReference2.Rows.Add("05", "05");
            comboboxReference2.Rows.Add("06", "06");
            comboboxReference2.Rows.Add("07", "07");
            comboboxReference2.Rows.Add("08", "08");
            comboboxReference2.Rows.Add("09", "09");
            expMonthCol.DataSource = comboboxReference2;
            expMonthCol.ValueMember = "Value";
            expMonthCol.DisplayMember = "Description";
            dataGridView1.Columns.Add(expMonthCol);

            //Intializes the expYear Column
            DataGridViewComboBoxColumn exchExpYear = new DataGridViewComboBoxColumn();
            exchExpYear.DataPropertyName = "exchExpYear";
            exchExpYear.HeaderText = "exchExpYear";
            exchExpYear.Name = "exchExpYear";
            DataTable comboboxReference3 = new DataTable();
            comboboxReference3.Columns.Add(new DataColumn("Value", typeof(string)));
            comboboxReference3.Columns.Add(new DataColumn("Description", typeof(string)));
            comboboxReference3.Rows.Add("2013", "2013");
            comboboxReference3.Rows.Add("2014", "2014");
            comboboxReference3.Rows.Add("2011", "2011");
            comboboxReference3.Rows.Add("2012", "2012");
            comboboxReference3.Rows.Add("2010", "2010");

            exchExpYear.DataSource = comboboxReference3;
            exchExpYear.ValueMember = "Value";
            exchExpYear.DisplayMember = "Description";
            dataGridView1.Columns.Add(exchExpYear);

            //Intializes the topMonth Column
            DataGridViewComboBoxColumn topMonth = new DataGridViewComboBoxColumn();
            topMonth.DataPropertyName = "TopMonth";
            topMonth.HeaderText = "TopMonth";
            topMonth.Name = "TopMonth";
            DataTable comboboxReference4 = new DataTable();
            comboboxReference4.Columns.Add(new DataColumn("Value", typeof(int)));
            comboboxReference4.Columns.Add(new DataColumn("Description", typeof(int)));
            comboboxReference4.Rows.Add(0, 0);
            comboboxReference4.Rows.Add(1, 1);
          
            topMonth.DataSource = comboboxReference4;
            topMonth.ValueMember = "Value";
            topMonth.DisplayMember = "Description";
            dataGridView1.Columns.Add(topMonth);


          // DataGridViewComboBoxColumn topMonthCol = new DataGridViewComboBoxColumn();
          // topMonthCol.DataPropertyName = "TopMonth";
          // topMonthCol.HeaderText = "TopMonth";
          // topMonthCol.Name = "TopMonth";
          // DataTable comboboxReference4 = new DataTable();
          // comboboxReference4.Columns.Add(new DataColumn("Value", typeofz


        // Intializes the rest of the columns
            DataGridViewTextBoxColumn contractTypeCol = new DataGridViewTextBoxColumn();
            contractTypeCol.DataPropertyName = "contractType";
            contractTypeCol.HeaderText = "contractType";
            contractTypeCol.Name = "contractType";
            contractTypeCol.ReadOnly = true;
            dataGridView1.Columns.Add(contractTypeCol);
          // DataGridViewTextBoxColumn seriesCol = new DataGridViewTextBoxColumn();
          // seriesCol.DataPropertyName = "series";
          // seriesCol.HeaderText = "series";
          // seriesCol.Name = "series";
          // dataGridView1.Columns.Add(seriesCol);
          // DataGridViewTextBoxColumn underlyingContractCol = new DataGridViewTextBoxColumn();
          // underlyingContractCol.DataPropertyName = "underlyingContract";
          // underlyingContractCol.HeaderText = "underlyingContract";
          // underlyingContractCol.Name = "underlyingContract";
          // underlyingContractCol.ReadOnly = true;
          // dataGridView1.Columns.Add(underlyingContractCol);
          // DataGridViewTextBoxColumn underlyingSeriesCol = new DataGridViewTextBoxColumn();
          // underlyingSeriesCol.DataPropertyName = "underlyingSeries";
          // underlyingSeriesCol.HeaderText = "underlyingSeries";
          // underlyingSeriesCol.Name = "underlyingSeries";
          // underlyingSeriesCol.ReadOnly = true;
          // dataGridView1.Columns.Add(underlyingSeriesCol);

            


  
            

           // this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
        }

        private void none(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // VMInfragisticsFuturesContract vm = new VMInfragisticsFuturesContract(currentTable);
          //  vm.topMonthEntered(e.RowIndex, e.ColumnIndex);
        }
        private void updateGrid()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRM_COMBINED_TESTDataSet1.gszExchangeContracts' table. You can move, or remove it, as needed.
            this.gszExchangeContractsTableAdapter.Fill(this.pRM_COMBINED_TESTDataSet1.gszExchangeContracts);

        }

    }
}
