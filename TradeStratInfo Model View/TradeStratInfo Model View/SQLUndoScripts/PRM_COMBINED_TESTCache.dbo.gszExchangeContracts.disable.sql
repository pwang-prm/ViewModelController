IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[gszExchangeContracts]')) 
   ALTER TABLE [dbo].[gszExchangeContracts] 
   DISABLE  CHANGE_TRACKING
GO
