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
            this.pRM_COMBINED_TESTDataSet1 = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet1();
            this.gszExchangeContractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gszExchangeContractsTableAdapter = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet1TableAdapters.gszExchangeContractsTableAdapter();
            this.tableAdapterManager = new TradeStratInfo_Model_View.PRM_COMBINED_TESTDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pRM_COMBINED_TESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingSource)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 668);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRM_COMBINED_TESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gszExchangeContractsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PRM_COMBINED_TESTDataSet1 pRM_COMBINED_TESTDataSet1;
        private System.Windows.Forms.BindingSource gszExchangeContractsBindingSource;
        private PRM_COMBINED_TESTDataSet1TableAdapters.gszExchangeContractsTableAdapter gszExchangeContractsTableAdapter;
        private PRM_COMBINED_TESTDataSet1TableAdapters.TableAdapterManager tableAdapterManager;

    }
}