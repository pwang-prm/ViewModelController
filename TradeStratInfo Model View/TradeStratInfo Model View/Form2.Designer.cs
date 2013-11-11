namespace TradeStratInfo_Model_View
{
    partial class Form2
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
            this.pRM_COMBINED_TESTDataSet = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet();
            this.gszExchangeContractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gszExchangeContractsTableAdapter = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSetTableAdapters.gszExchangeContractsTableAdapter();
            this.tableAdapterManager = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.futuresContractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAUMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNextEditExistingContractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEntirelyNewContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pRM_COMBINED_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pRM_COMBINED_TESTDataSet
            // 
            this.pRM_COMBINED_TESTDataSet.DataSetName = "PRM_COMBINED_TESTDataSet";
            this.pRM_COMBINED_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gszExchangeContractsBindingSource
            // 
            this.gszExchangeContractsBindingSource.DataMember = "gszExchangeContracts";
            this.gszExchangeContractsBindingSource.DataSource = this.pRM_COMBINED_TESTDataSet;
            // 
            // gszExchangeContractsTableAdapter
            // 
            this.gszExchangeContractsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gszExchangeContractsTableAdapter = this.gszExchangeContractsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.futuresContractsToolStripMenuItem,
            this.manageAUMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // futuresContractsToolStripMenuItem
            // 
            this.futuresContractsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNextEditExistingContractsToolStripMenuItem,
            this.createEntirelyNewContractToolStripMenuItem});
            this.futuresContractsToolStripMenuItem.Name = "futuresContractsToolStripMenuItem";
            this.futuresContractsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.futuresContractsToolStripMenuItem.Text = "Futures Contracts";
            // 
            // manageAUMToolStripMenuItem
            // 
            this.manageAUMToolStripMenuItem.Name = "manageAUMToolStripMenuItem";
            this.manageAUMToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.manageAUMToolStripMenuItem.Text = "Manage AUM";
            // 
            // addNextEditExistingContractsToolStripMenuItem
            // 
            this.addNextEditExistingContractsToolStripMenuItem.Name = "addNextEditExistingContractsToolStripMenuItem";
            this.addNextEditExistingContractsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addNextEditExistingContractsToolStripMenuItem.Text = "Add Next/Edit Existing Contracts";
            this.addNextEditExistingContractsToolStripMenuItem.Click += new System.EventHandler(this.openForm1);
            // 
            // createEntirelyNewContractToolStripMenuItem
            // 
            this.createEntirelyNewContractToolStripMenuItem.Name = "createEntirelyNewContractToolStripMenuItem";
            this.createEntirelyNewContractToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.createEntirelyNewContractToolStripMenuItem.Text = "Create Entirely New Contract";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 331);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pRM_COMBINED_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PRM_COMBINED_TESTDataSet pRM_COMBINED_TESTDataSet;
        private System.Windows.Forms.BindingSource gszExchangeContractsBindingSource;
        private PRM_COMBINED_TESTDataSetTableAdapters.gszExchangeContractsTableAdapter gszExchangeContractsTableAdapter;
        private PRM_COMBINED_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem futuresContractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNextEditExistingContractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEntirelyNewContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAUMToolStripMenuItem;

        public System.EventHandler openForm2 { get; set; }
    }
}