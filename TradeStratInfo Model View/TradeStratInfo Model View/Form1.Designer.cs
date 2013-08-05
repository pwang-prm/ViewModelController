namespace TradeStratInfo_Model_View
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pRM_COMBINED_TESTDataSet1 = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet1();
            this.gszExchangeContractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gszExchangeContractsTableAdapter = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet1TableAdapters.gszExchangeContractsTableAdapter();
            this.tableAdapterManager = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet1TableAdapters.TableAdapterManager();
            this.gszExchangeContractsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.gszExchangeContractsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gszExchangeContractsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pRM_COMBINED_TESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingNavigator)).BeginInit();
            this.gszExchangeContractsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pRM_COMBINED_TESTDataSet1
            // 
            this.pRM_COMBINED_TESTDataSet1.DataSetName = "PRM_COMBINED_TESTDataSet1";
            this.pRM_COMBINED_TESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gszExchangeContractsBindingSource
            // 
            this.gszExchangeContractsBindingSource.DataMember = "gszExchangeContracts";
            this.gszExchangeContractsBindingSource.DataSource = this.pRM_COMBINED_TESTDataSet1;
            // 
            // gszExchangeContractsTableAdapter
            // 
            this.gszExchangeContractsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gszExchangeContractsTableAdapter = this.gszExchangeContractsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gszExchangeContractsBindingNavigator
            // 
            this.gszExchangeContractsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gszExchangeContractsBindingNavigator.BindingSource = this.gszExchangeContractsBindingSource;
            this.gszExchangeContractsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gszExchangeContractsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gszExchangeContractsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.gszExchangeContractsBindingNavigatorSaveItem});
            this.gszExchangeContractsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gszExchangeContractsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gszExchangeContractsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gszExchangeContractsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gszExchangeContractsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gszExchangeContractsBindingNavigator.Name = "gszExchangeContractsBindingNavigator";
            this.gszExchangeContractsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gszExchangeContractsBindingNavigator.Size = new System.Drawing.Size(1279, 25);
            this.gszExchangeContractsBindingNavigator.TabIndex = 0;
            this.gszExchangeContractsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // gszExchangeContractsBindingNavigatorSaveItem
            // 
            this.gszExchangeContractsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gszExchangeContractsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gszExchangeContractsBindingNavigatorSaveItem.Image")));
            this.gszExchangeContractsBindingNavigatorSaveItem.Name = "gszExchangeContractsBindingNavigatorSaveItem";
            this.gszExchangeContractsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.gszExchangeContractsBindingNavigatorSaveItem.Text = "Save Data";
            this.gszExchangeContractsBindingNavigatorSaveItem.Click += new System.EventHandler(this.gszExchangeContractsBindingNavigatorSaveItem_Click_2);
            // 
            // gszExchangeContractsDataGridView
            // 
            this.gszExchangeContractsDataGridView.AutoGenerateColumns = false;
            this.gszExchangeContractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gszExchangeContractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gszExchangeContractsDataGridView.DataSource = this.gszExchangeContractsBindingSource;
            this.gszExchangeContractsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gszExchangeContractsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.gszExchangeContractsDataGridView.Name = "gszExchangeContractsDataGridView";
            this.gszExchangeContractsDataGridView.Size = new System.Drawing.Size(1279, 614);
            this.gszExchangeContractsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "gszContractName";
            this.dataGridViewTextBoxColumn1.HeaderText = "gszContractName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "gszProductFamily";
            this.dataGridViewTextBoxColumn2.HeaderText = "gszProductFamily";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "exchExpMonth";
            this.dataGridViewTextBoxColumn3.HeaderText = "exchExpMonth";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "exchExpYear";
            this.dataGridViewTextBoxColumn4.HeaderText = "exchExpYear";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TopMonth";
            this.dataGridViewTextBoxColumn5.HeaderText = "TopMonth";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 639);
            this.Controls.Add(this.gszExchangeContractsDataGridView);
            this.Controls.Add(this.gszExchangeContractsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRM_COMBINED_TESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingNavigator)).EndInit();
            this.gszExchangeContractsBindingNavigator.ResumeLayout(false);
            this.gszExchangeContractsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PRM_COMBINED_TESTDataSet1 pRM_COMBINED_TESTDataSet1;
        private System.Windows.Forms.BindingSource gszExchangeContractsBindingSource;
        private PRM_COMBINED_TESTDataSet1TableAdapters.gszExchangeContractsTableAdapter gszExchangeContractsTableAdapter;
        private PRM_COMBINED_TESTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gszExchangeContractsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton gszExchangeContractsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gszExchangeContractsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;


    }
}