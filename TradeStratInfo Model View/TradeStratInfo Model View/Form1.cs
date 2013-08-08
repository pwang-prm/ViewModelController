using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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


        }

        private void IntializeDataGridView()
        {
        //    initbusinessobjects
            BusinessObjectsManager.initBusinessObjects("OLDAUTO2\\MSSQL_PEIXIAN", "PRM_COMBINED_TEST", "sa", "Old$ch00l", "OLDAUTO2\\MSSQL_PEIXIAN", "PRM_COMBINED_TEST", "sa", "Old$ch00l");
            db = new DataBase("OLDAUTO2\\MSSQL_PEIXIAN", "PRM_COMBINED_TEST", "sa", "Old$ch00l", 0);
            currentTable = db.GetDataTable("SELECT gszProductFamily, exchExpYear, exchExpMonth, contractType, TopMonth FROM gszExchangeContracts");
         
            dataGridView1.AutoGenerateColumns = true;
            bindingsource1.DataSource = currentTable;
            dataGridView1.DataSource = bindingsource1;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            VMInfragisticsFuturesContract vm = new VMInfragisticsFuturesContract(currentTable);
            vm.topMonthEntered(e.RowIndex, e.ColumnIndex);
        }
        private void updateGrid()
        {
        }
    }
}
