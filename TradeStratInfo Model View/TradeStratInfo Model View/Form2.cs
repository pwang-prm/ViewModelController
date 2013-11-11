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
    public partial class Form2 : Form
    {
        Form1 ls;
        public Form2()
        {
            InitializeComponent();
        }

        private void gszExchangeContractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gszExchangeContractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRM_COMBINED_TESTDataSet);

        }

        private void openForm1(object sender, EventArgs e)
        {
            ls = new Form1();

            ls.Show();
            this.Hide();
        }


    }
}
