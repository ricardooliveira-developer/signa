USE [Teste_Signa]
GO
/****** Object:  StoredProcedure [dbo].[SP_InserirDogs]    Script Date: 13/08/2021 22:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_InserirDogs]
	@Nome varchar(300),
	@Age  int,
	@Id int
AS
	Insert Into Dogs
	Values(@Nome, @Age, @Id)