USE [Teste_Signa]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteDogs]    Script Date: 13/08/2021 22:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[SP_DeleteDogs]
	@Id int
AS
	DELETE FROM Dogs WHERE Id = @Id