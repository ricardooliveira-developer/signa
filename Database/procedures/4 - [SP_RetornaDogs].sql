USE [Teste_Signa]
GO
/****** Object:  StoredProcedure [dbo].[SP_RetornaDogs]    Script Date: 13/08/2021 22:01:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_RetornaDogs]
AS
	SELECT * FROM Dogs