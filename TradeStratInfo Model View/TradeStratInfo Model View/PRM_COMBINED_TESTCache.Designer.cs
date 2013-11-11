﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeStratInfo_Model_View {
    
    
    public partial class PRM_COMBINED_TESTCacheClientSyncProvider : Microsoft.Synchronization.Data.SqlServerCe.SqlCeClientSyncProvider {
        
        public PRM_COMBINED_TESTCacheClientSyncProvider() {
            this.ConnectionString = global::TradeStratInfo_Model_View.Properties.Settings.Default.ClientPRM_COMBINED_TESTConnectionString;
        }
        
        public PRM_COMBINED_TESTCacheClientSyncProvider(string connectionString) {
            this.ConnectionString = connectionString;
        }
    }
    
    public partial class PRM_COMBINED_TESTCacheSyncAgent : Microsoft.Synchronization.SyncAgent {
        
        private gszExchangeContractsSyncTable _gszExchangeContractsSyncTable;
        
        partial void OnInitialized();
        
        public PRM_COMBINED_TESTCacheSyncAgent() {
            this.InitializeSyncProviders();
            this.InitializeSyncTables();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public gszExchangeContractsSyncTable gszExchangeContracts {
            get {
                return this._gszExchangeContractsSyncTable;
            }
            set {
                this.Configuration.SyncTables.Remove(this._gszExchangeContractsSyncTable);
                this._gszExchangeContractsSyncTable = value;
                this.Configuration.SyncTables.Add(this._gszExchangeContractsSyncTable);
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncProviders() {
            // Create SyncProviders.
            this.RemoteProvider = new PRM_COMBINED_TESTCacheServerSyncProvider();
            this.LocalProvider = new PRM_COMBINED_TESTCacheClientSyncProvider();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncTables() {
            // Create SyncTables.
            this._gszExchangeContractsSyncTable = new gszExchangeContractsSyncTable();
            this._gszExchangeContractsSyncTable.SyncGroup = new Microsoft.Synchronization.Data.SyncGroup("gszExchangeContractsSyncTableSyncGroup");
            this.Configuration.SyncTables.Add(this._gszExchangeContractsSyncTable);
        }
        
        public partial class gszExchangeContractsSyncTable : Microsoft.Synchronization.Data.SyncTable {
            
            partial void OnInitialized();
            
            public gszExchangeContractsSyncTable() {
                this.InitializeTableOptions();
                this.OnInitialized();
            }
            
            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private void InitializeTableOptions() {
                this.TableName = "gszExchangeContracts";
                this.CreationOption = Microsoft.Synchronization.Data.TableCreationOption.DropExistingOrCreateNewTable;
            }
        }
    }
}
namespace TradeStratInfo_Model_View {
    
    
    public partial class gszExchangeContractsSyncAdapter : Microsoft.Synchronization.Data.Server.SyncAdapter {
        
        partial void OnInitialized();
        
        public gszExchangeContractsSyncAdapter() {
            this.InitializeCommands();
            this.InitializeAdapterProperties();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeCommands() {
            // gszExchangeContractsSyncTableInsertCommand command.
            this.InsertCommand = new System.Data.SqlClient.SqlCommand();
            this.InsertCommand.CommandText = @";WITH CHANGE_TRACKING_CONTEXT (@sync_client_id_binary) INSERT INTO dbo.gszExchangeContracts ([gszContractName], [gszProductFamily], [contractType], [expiration], [series], [underlyingContract], [underlyingSeries], [exchangeID], [exchProdID], [exchExpMonth], [exchExpYear], [openTime], [settlement], [BatchRecalcMktWidth], [TopMonth]) VALUES (@gszContractName, @gszProductFamily, @contractType, @expiration, @series, @underlyingContract, @underlyingSeries, @exchangeID, @exchProdID, @exchExpMonth, @exchExpYear, @openTime, @settlement, @BatchRecalcMktWidth, @TopMonth) SET @sync_row_count = @@rowcount; IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'dbo.gszExchangeContracts')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'dbo.gszExchangeContracts') ";
            this.InsertCommand.CommandType = System.Data.CommandType.Text;
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gszContractName", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gszProductFamily", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@contractType", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@expiration", System.Data.SqlDbType.DateTime));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@series", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@underlyingContract", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@underlyingSeries", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchangeID", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchProdID", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchExpMonth", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchExpYear", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@openTime", System.Data.SqlDbType.Char));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@settlement", System.Data.SqlDbType.Float));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BatchRecalcMktWidth", System.Data.SqlDbType.Float));
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TopMonth", System.Data.SqlDbType.Int));
            System.Data.SqlClient.SqlParameter insertcommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            insertcommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.InsertCommand.Parameters.Add(insertcommand_sync_row_countParameter);
            this.InsertCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            // gszExchangeContractsSyncTableDeleteCommand command.
            this.DeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.DeleteCommand.CommandText = @";WITH CHANGE_TRACKING_CONTEXT (@sync_client_id_binary) DELETE dbo.gszExchangeContracts FROM dbo.gszExchangeContracts JOIN CHANGETABLE(VERSION dbo.gszExchangeContracts, ([gszContractName]), (@gszContractName)) CT  ON CT.[gszContractName] = dbo.gszExchangeContracts.[gszContractName] WHERE (@sync_force_write = 1 OR CT.SYS_CHANGE_VERSION IS NULL OR CT.SYS_CHANGE_VERSION <= @sync_last_received_anchor OR (CT.SYS_CHANGE_CONTEXT IS NOT NULL AND CT.SYS_CHANGE_CONTEXT = @sync_client_id_binary)) SET @sync_row_count = @@rowcount; IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'dbo.gszExchangeContracts')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'dbo.gszExchangeContracts') ";
            this.DeleteCommand.CommandType = System.Data.CommandType.Text;
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gszContractName", System.Data.SqlDbType.Char));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_force_write", System.Data.SqlDbType.Bit));
            this.DeleteCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            System.Data.SqlClient.SqlParameter deletecommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            deletecommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.DeleteCommand.Parameters.Add(deletecommand_sync_row_countParameter);
            // gszExchangeContractsSyncTableUpdateCommand command.
            this.UpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.UpdateCommand.CommandText = @";WITH CHANGE_TRACKING_CONTEXT (@sync_client_id_binary) UPDATE dbo.gszExchangeContracts SET [gszProductFamily] = @gszProductFamily, [contractType] = @contractType, [expiration] = @expiration, [series] = @series, [underlyingContract] = @underlyingContract, [underlyingSeries] = @underlyingSeries, [exchangeID] = @exchangeID, [exchProdID] = @exchProdID, [exchExpMonth] = @exchExpMonth, [exchExpYear] = @exchExpYear, [openTime] = @openTime, [settlement] = @settlement, [BatchRecalcMktWidth] = @BatchRecalcMktWidth, [TopMonth] = @TopMonth FROM dbo.gszExchangeContracts  JOIN CHANGETABLE(VERSION dbo.gszExchangeContracts, ([gszContractName]), (@gszContractName)) CT  ON CT.[gszContractName] = dbo.gszExchangeContracts.[gszContractName] WHERE (@sync_force_write = 1 OR CT.SYS_CHANGE_VERSION IS NULL OR CT.SYS_CHANGE_VERSION <= @sync_last_received_anchor OR (CT.SYS_CHANGE_CONTEXT IS NOT NULL AND CT.SYS_CHANGE_CONTEXT = @sync_client_id_binary)) SET @sync_row_count = @@rowcount; IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'dbo.gszExchangeContracts')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'dbo.gszExchangeContracts') ";
            this.UpdateCommand.CommandType = System.Data.CommandType.Text;
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gszProductFamily", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@contractType", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@expiration", System.Data.SqlDbType.DateTime));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@series", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@underlyingContract", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@underlyingSeries", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchangeID", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchProdID", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchExpMonth", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@exchExpYear", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@openTime", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@settlement", System.Data.SqlDbType.Float));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BatchRecalcMktWidth", System.Data.SqlDbType.Float));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TopMonth", System.Data.SqlDbType.Int));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gszContractName", System.Data.SqlDbType.Char));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_force_write", System.Data.SqlDbType.Bit));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.UpdateCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            System.Data.SqlClient.SqlParameter updatecommand_sync_row_countParameter = new System.Data.SqlClient.SqlParameter("@sync_row_count", System.Data.SqlDbType.Int);
            updatecommand_sync_row_countParameter.Direction = System.Data.ParameterDirection.Output;
            this.UpdateCommand.Parameters.Add(updatecommand_sync_row_countParameter);
            // gszExchangeContractsSyncTableSelectConflictDeletedRowsCommand command.
            this.SelectConflictDeletedRowsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectConflictDeletedRowsCommand.CommandText = "SELECT CT.[gszContractName], CT.SYS_CHANGE_CONTEXT, CT.SYS_CHANGE_VERSION FROM CH" +
                "ANGETABLE(CHANGES dbo.gszExchangeContracts, @sync_last_received_anchor) CT WHERE" +
                " (CT.[gszContractName] = @gszContractName AND CT.SYS_CHANGE_OPERATION = \'D\')";
            this.SelectConflictDeletedRowsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectConflictDeletedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectConflictDeletedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gszContractName", System.Data.SqlDbType.Char));
            // gszExchangeContractsSyncTableSelectConflictUpdatedRowsCommand command.
            this.SelectConflictUpdatedRowsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectConflictUpdatedRowsCommand.CommandText = @"SELECT dbo.gszExchangeContracts.[gszContractName], [gszProductFamily], [contractType], [expiration], [series], [underlyingContract], [underlyingSeries], [exchangeID], [exchProdID], [exchExpMonth], [exchExpYear], [openTime], [settlement], [BatchRecalcMktWidth], [TopMonth], CT.SYS_CHANGE_CONTEXT, CT.SYS_CHANGE_VERSION FROM dbo.gszExchangeContracts JOIN CHANGETABLE(VERSION dbo.gszExchangeContracts, ([gszContractName]), (@gszContractName)) CT  ON CT.[gszContractName] = dbo.gszExchangeContracts.[gszContractName]";
            this.SelectConflictUpdatedRowsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectConflictUpdatedRowsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@gszContractName", System.Data.SqlDbType.Char));
            // gszExchangeContractsSyncTableSelectIncrementalInsertsCommand command.
            this.SelectIncrementalInsertsCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalInsertsCommand.CommandText = "IF @sync_initialized = 0 SELECT dbo.gszExchangeContracts.[gszContractName], [gszP" +
                "roductFamily], [contractType], [expiration], [series], [underlyingContract], [un" +
                "derlyingSeries], [exchangeID], [exchProdID], [exchExpMonth], [exchExpYear], [ope" +
                "nTime], [settlement], [BatchRecalcMktWidth], [TopMonth] FROM dbo.gszExchangeCont" +
                "racts LEFT OUTER JOIN CHANGETABLE(CHANGES dbo.gszExchangeContracts, @sync_last_r" +
                "eceived_anchor) CT ON CT.[gszContractName] = dbo.gszExchangeContracts.[gszContra" +
                "ctName] WHERE (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONTEXT <> @sync_c" +
                "lient_id_binary) ELSE  BEGIN SELECT dbo.gszExchangeContracts.[gszContractName], " +
                "[gszProductFamily], [contractType], [expiration], [series], [underlyingContract]" +
                ", [underlyingSeries], [exchangeID], [exchProdID], [exchExpMonth], [exchExpYear]," +
                " [openTime], [settlement], [BatchRecalcMktWidth], [TopMonth] FROM dbo.gszExchang" +
                "eContracts JOIN CHANGETABLE(CHANGES dbo.gszExchangeContracts, @sync_last_receive" +
                "d_anchor) CT ON CT.[gszContractName] = dbo.gszExchangeContracts.[gszContractName" +
                "] WHERE (CT.SYS_CHANGE_OPERATION = \'I\' AND CT.SYS_CHANGE_CREATION_VERSION  <= @s" +
                "ync_new_received_anchor AND (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONT" +
                "EXT <> @sync_client_id_binary)); IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(" +
                "N\'dbo.gszExchangeContracts\')) > @sync_last_received_anchor RAISERROR (N\'SQL Serv" +
                "er Change Tracking has cleaned up tracking information for table \'\'%s\'\'. To reco" +
                "ver from this error, the client must reinitialize its local database and try aga" +
                "in\',16,3,N\'dbo.gszExchangeContracts\')  END ";
            this.SelectIncrementalInsertsCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_initialized", System.Data.SqlDbType.Bit));
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            this.SelectIncrementalInsertsCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt));
            // gszExchangeContractsSyncTableSelectIncrementalDeletesCommand command.
            this.SelectIncrementalDeletesCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalDeletesCommand.CommandText = @"IF @sync_initialized > 0  BEGIN SELECT CT.[gszContractName] FROM CHANGETABLE(CHANGES dbo.gszExchangeContracts, @sync_last_received_anchor) CT WHERE (CT.SYS_CHANGE_OPERATION = 'D' AND CT.SYS_CHANGE_VERSION <= @sync_new_received_anchor AND (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONTEXT <> @sync_client_id_binary)); IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'dbo.gszExchangeContracts')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'dbo.gszExchangeContracts')  END ";
            this.SelectIncrementalDeletesCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_initialized", System.Data.SqlDbType.Bit));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalDeletesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
            // gszExchangeContractsSyncTableSelectIncrementalUpdatesCommand command.
            this.SelectIncrementalUpdatesCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectIncrementalUpdatesCommand.CommandText = @"IF @sync_initialized > 0  BEGIN SELECT dbo.gszExchangeContracts.[gszContractName], [gszProductFamily], [contractType], [expiration], [series], [underlyingContract], [underlyingSeries], [exchangeID], [exchProdID], [exchExpMonth], [exchExpYear], [openTime], [settlement], [BatchRecalcMktWidth], [TopMonth] FROM dbo.gszExchangeContracts JOIN CHANGETABLE(CHANGES dbo.gszExchangeContracts, @sync_last_received_anchor) CT ON CT.[gszContractName] = dbo.gszExchangeContracts.[gszContractName] WHERE (CT.SYS_CHANGE_OPERATION = 'U' AND CT.SYS_CHANGE_VERSION <= @sync_new_received_anchor AND (CT.SYS_CHANGE_CONTEXT IS NULL OR CT.SYS_CHANGE_CONTEXT <> @sync_client_id_binary)); IF CHANGE_TRACKING_MIN_VALID_VERSION(object_id(N'dbo.gszExchangeContracts')) > @sync_last_received_anchor RAISERROR (N'SQL Server Change Tracking has cleaned up tracking information for table ''%s''. To recover from this error, the client must reinitialize its local database and try again',16,3,N'dbo.gszExchangeContracts')  END ";
            this.SelectIncrementalUpdatesCommand.CommandType = System.Data.CommandType.Text;
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_initialized", System.Data.SqlDbType.Bit));
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_last_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt));
            this.SelectIncrementalUpdatesCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sync_client_id_binary", System.Data.SqlDbType.VarBinary));
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeAdapterProperties() {
            this.TableName = "gszExchangeContracts";
        }
    }
    
    public partial class PRM_COMBINED_TESTCacheServerSyncProvider : Microsoft.Synchronization.Data.Server.DbServerSyncProvider {
        
        private gszExchangeContractsSyncAdapter _gszExchangeContractsSyncAdapter;
        
        partial void OnInitialized();
        
        public PRM_COMBINED_TESTCacheServerSyncProvider() {
            string connectionString = global::TradeStratInfo_Model_View.Properties.Settings.Default.PRM_COMBINED_TESTConnectionString;
            this.InitializeConnection(connectionString);
            this.InitializeSyncAdapters();
            this.InitializeNewAnchorCommand();
            this.OnInitialized();
        }
        
        public PRM_COMBINED_TESTCacheServerSyncProvider(string connectionString) {
            this.InitializeConnection(connectionString);
            this.InitializeSyncAdapters();
            this.InitializeNewAnchorCommand();
            this.OnInitialized();
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public gszExchangeContractsSyncAdapter gszExchangeContractsSyncAdapter {
            get {
                return this._gszExchangeContractsSyncAdapter;
            }
            set {
                this._gszExchangeContractsSyncAdapter = value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeConnection(string connectionString) {
            this.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeSyncAdapters() {
            // Create SyncAdapters.
            this._gszExchangeContractsSyncAdapter = new gszExchangeContractsSyncAdapter();
            this.SyncAdapters.Add(this._gszExchangeContractsSyncAdapter);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void InitializeNewAnchorCommand() {
            // selectNewAnchorCmd command.
            this.SelectNewAnchorCommand = new System.Data.SqlClient.SqlCommand();
            this.SelectNewAnchorCommand.CommandText = "Select @sync_new_received_anchor = CHANGE_TRACKING_CURRENT_VERSION()";
            this.SelectNewAnchorCommand.CommandType = System.Data.CommandType.Text;
            System.Data.SqlClient.SqlParameter selectnewanchorcommand_sync_new_received_anchorParameter = new System.Data.SqlClient.SqlParameter("@sync_new_received_anchor", System.Data.SqlDbType.BigInt);
            selectnewanchorcommand_sync_new_received_anchorParameter.Direction = System.Data.ParameterDirection.Output;
            this.SelectNewAnchorCommand.Parameters.Add(selectnewanchorcommand_sync_new_received_anchorParameter);
        }
    }
}