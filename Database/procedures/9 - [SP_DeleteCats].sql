USE [Teste_Signa]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCats]    Script Date: 13/08/2021 22:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_DeleteCats]
	@Id int
AS
	DELETE FROM Cats WHERE Id = @Id