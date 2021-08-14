USE [Teste_Signa]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCats]    Script Date: 13/08/2021 22:01:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[SP_UpdateCats]
	@Id int,
	@Nome varchar(300),
	@Age int,
	@OwnerId int
AS
	UPDATE Cats
	SET 
		Name = @Nome, 
		Age = @Age, 
		OwnerId = @OwnerId
	WHERE Id = @Id