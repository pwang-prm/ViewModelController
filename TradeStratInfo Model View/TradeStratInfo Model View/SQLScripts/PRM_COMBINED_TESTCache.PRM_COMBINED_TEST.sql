IF NOT EXISTS (SELECT * FROM sys.change_tracking_databases WHERE database_id = DB_ID(N'PRM_COMBINED_TEST')) 
   ALTER DATABASE [PRM_COMBINED_TEST] 
   SET  CHANGE_TRACKING = ON
GO
