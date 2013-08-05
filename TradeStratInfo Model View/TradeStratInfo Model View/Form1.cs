using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrescientBusinessObjects.Data;
using PrescientBusinessObjects.FinancialInstruments;

namespace TradeStratInfo_Model_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gszExchangeContractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gszExchangeContractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRM_COMBINED_TESTDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRM_COMBINED_TESTDataSet1.gszExchangeContracts' table. You can move, or remove it, as needed.
            this.gszExchangeContractsTableAdapter.Fill(this.pRM_COMBINED_TESTDataSet1.gszExchangeContracts);
            // TODO: This line of code loads data into the 'pRM_COMBINED_TESTDataSet1.gszExchangeContracts' table. You can move, or remove it, as needed.
            this.gszExchangeContractsTableAdapter.Fill(this.pRM_COMBINED_TESTDataSet1.gszExchangeContracts);
            // TODO: This line of code loads data into the 'pRM_COMBINED_TESTDataSet1.gszExchangeContracts' table. You can move, or remove it, as needed.
            this.gszExchangeContractsTableAdapter.Fill(this.pRM_COMBINED_TESTDataSet1.gszExchangeContracts);

        }

        private void gszExchangeContractsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gszExchangeContractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRM_COMBINED_TESTDataSet1);

        }

        private void gszExchangeContractsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

            this.Validate();
            this.gszExchangeContractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRM_COMBINED_TESTDataSet1);

        }
    }
}
