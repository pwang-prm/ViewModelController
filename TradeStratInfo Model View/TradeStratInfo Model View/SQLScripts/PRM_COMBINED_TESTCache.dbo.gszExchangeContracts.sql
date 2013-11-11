IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[gszExchangeContracts]')) 
   ALTER TABLE [dbo].[gszExchangeContracts] 
   ENABLE  CHANGE_TRACKING
GO
