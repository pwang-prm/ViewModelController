using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TradeStratInfo_Model_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tradeStrategyInfoDataGridView.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(tradeStrategyInfoDataGridView_ColumnHeaderMouseClick);
        }

        private void tradeStrategyInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tradeStrategyInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRM_COMBINED_TESTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRM_COMBINED_TESTDataSet.TradeStrategyInfo' table. You can move, or remove it, as needed.
            this.tradeStrategyInfoTableAdapter.Fill(this.pRM_COMBINED_TESTDataSet.TradeStrategyInfo);

        }

        private void tradeStrategyInfoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("CHANGED A DATAGRID");
        }

        private void tradeStrategyInfoDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void tradeStrategyInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("YOU CLICKED IT");
        }

    }
}
