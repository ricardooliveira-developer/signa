USE [Teste_Signa]
GO
/****** Object:  StoredProcedure [dbo].[SP_InserirCats]    Script Date: 13/08/2021 22:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[SP_InserirCats]
	@Nome varchar(300),
	@Age  int,
	@Id int
AS
	Insert Into Cats
	Values(@Nome, @Age, @Id)