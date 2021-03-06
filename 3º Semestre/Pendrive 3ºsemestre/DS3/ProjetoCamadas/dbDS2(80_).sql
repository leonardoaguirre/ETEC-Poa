USE [master]
GO
/****** Object:  Database [DBDS2]    Script Date: 04/12/2017 22:35:12 ******/
CREATE DATABASE [DBDS2] ON  PRIMARY 
( NAME = N'DBDS2', FILENAME = N'c:\Arquivos de programas\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DBDS2.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBDS2_log', FILENAME = N'c:\Arquivos de programas\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\DBDS2_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBDS2] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBDS2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBDS2] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DBDS2] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DBDS2] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DBDS2] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DBDS2] SET ARITHABORT OFF
GO
ALTER DATABASE [DBDS2] SET AUTO_CLOSE ON
GO
ALTER DATABASE [DBDS2] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DBDS2] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DBDS2] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DBDS2] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DBDS2] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DBDS2] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DBDS2] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DBDS2] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DBDS2] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DBDS2] SET  ENABLE_BROKER
GO
ALTER DATABASE [DBDS2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DBDS2] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DBDS2] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DBDS2] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DBDS2] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DBDS2] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DBDS2] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DBDS2] SET  READ_WRITE
GO
ALTER DATABASE [DBDS2] SET RECOVERY SIMPLE
GO
ALTER DATABASE [DBDS2] SET  MULTI_USER
GO
ALTER DATABASE [DBDS2] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DBDS2] SET DB_CHAINING OFF
GO
USE [DBDS2]
GO
/****** Object:  Table [dbo].[tblClientes]    Script Date: 04/12/2017 22:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblClientes](
	[CodCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[CPF] [varchar](14) NULL,
	[DataNascimento] [datetime] NOT NULL,
 CONSTRAINT [PK_tblClientes] PRIMARY KEY CLUSTERED 
(
	[CodCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTipoTelefone]    Script Date: 04/12/2017 22:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTipoTelefone](
	[CodTipoTelefone] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblTipoTelefone] PRIMARY KEY CLUSTERED 
(
	[CodTipoTelefone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTelefones]    Script Date: 04/12/2017 22:35:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTelefones](
	[CodTelefone] [int] IDENTITY(1,1) NOT NULL,
	[CodCliente] [int] NOT NULL,
	[CodTipoTelefone] [int] NOT NULL,
	[Numero] [varchar](15) NOT NULL,
 CONSTRAINT [PK_tblTelefones] PRIMARY KEY CLUSTERED 
(
	[CodTelefone] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaClienteNome]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspConsultaClienteNome]
@Nome varchar(50)

as 
begin
begin try
Select * from tblCLientes Where Nome LIKE '%' + @Nome + '%';


declare @CodCli as int = @@Identity

select @CodCli as Retorno

commit tran
end try
begin catch
rollback tran

select error_message() as Retorno

end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarTipoTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspAlterarTipoTelefone]
@CodTipoTelefone int,
@Descricao int



as 
	begin
		begin try

UPDATE tblTipoTelefone
SET Descricao = @Descricao
WHERE CodTipoTelefone = @CodTipoTelefone


declare @Cod as int = @@Identity

select @Cod as Retorno6

		commit tran
	end try
	
begin catch
	rollback tran

select error_message() as Retorno6

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaNumeroTipoTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspConsultaNumeroTipoTelefone]
@Descricao varchar(20)

as 
begin
begin try
Select * from tblTipoTelefone Where Descricao LIKE '%' + @Descricao + '%';

declare @CodTipoTelefone as int = @@Identity

select @CodTipoTelefone as Retorno

commit tran
end try
begin catch
rollback tran

select error_message() as Retorno

end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspInserirCliente]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspInserirCliente]

@Nome varchar(50),
@CPF varchar(14),
@DataNascimento datetime





as 
	begin
		begin try

insert into tblClientes (Nome, CPF, DataNascimento)
values(@Nome, @CPF, @DataNascimento)


declare @CodCliente as int = @@Identity
select @CodCliente as Retorno

		commit tran
	end try
	
begin catch


select error_message() as Retorno

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirTipoTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspExcluirTipoTelefone]

@CodTipoTelefone varchar(50)


as 
begin
	begin try
		begin tran
		
		delete from tblTipoTelefone Where CodTipoTelefone=@CodTipoTelefone
		
		select @CodTipoTelefone as Retorno

		commit tran
	end try
	
	begin catch
		rollback tran
		
		select error_message() as Retorno

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarCliente]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspAlterarCliente]
@CodCliente int,
@Nome varchar(50),
@CPF varchar(14),
@DataNascimento datetime


as 
	begin
		begin try

UPDATE tblClientes
SET Nome = @Nome,CPF = @CPF,DataNascimento = @DataNascimento 
WHERE CodCliente = @CodCliente


declare @Cod as int = @@Identity

select @Cod as Retorno4

		commit tran
	end try
	
begin catch
	rollback tran

select error_message() as Retorno4

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspInserirTipoTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirTipoTelefone]

@Descricao varchar(20)

as 
	begin
		begin try

insert into tblTipoTelefone (Descricao)
values(@Descricao)


declare @CodTipoTelefone as int = @@Identity

select @CodTipoTelefone as Retorno3

		commit tran
	end try
	
begin catch
	

select error_message() as Retorno3

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspInserirTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirTelefone]


@CodCliente int,
@CodTipoTelefone int,
@Numero varchar(15)

as 
	begin
		begin try

insert into tblTelefones (Numero, CodCliente, CodTipoTelefone)
values(@Numero, @CodCliente, @CodTipoTelefone)


declare @Cod as int = @@Identity

select @Cod as Retorno2

		commit tran
	end try
	
begin catch

	

select error_message() as Retorno2

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspExcluirTelefone]
@CodTelefone int

as 
begin
	begin try
		begin tran
		
		delete from tblTelefones Where CodTelefone=@CodTelefone
		
		select @CodTelefone as Retorno

		commit tran
	end try
	
	begin catch
		rollback tran
		
		select error_message() as Retorno

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirCliente]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspExcluirCliente]

@CodCliente int,
@CodTipoTelefone int


as 
begin
	begin try
		begin tran
		
		delete from tblClientes Where CodCliente=@CodCliente
		delete from tblTelefones Where CodCliente=@CodCliente
		delete from tblTipoTelefone where CodTipoTelefone = @CodTipoTelefone
		
		select @CodCliente as Retorno

		commit tran
	end try
	
	begin catch
		rollback tran
		
		select error_message() as Retorno

	end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaNumeroTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspConsultaNumeroTelefone]
@Numero varchar(15)

as 
begin
begin try
Select * from tblTelefones Where Numero LIKE '%' + @Numero + '%';

declare @CodTelefone as int = @@Identity

select @CodTelefone as Retorno

commit tran
end try
begin catch
rollback tran

select error_message() as Retorno

end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarTelefone]    Script Date: 04/12/2017 22:35:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspAlterarTelefone]
@CodTelefone int,
@CodCliente int,
@CodTipoTelefone varchar(14),
@Numero varchar(15)


as 
	begin
		begin try

UPDATE tblTelefones
SET CodCliente = @CodCliente,CodTipoTelefone = @CodTipoTelefone, Numero = @Numero 
WHERE CodTelefone = @CodTelefone


declare @Cod as int = @@Identity

select @Cod as Retorno5

		commit tran
	end try
	
begin catch
	rollback tran

select error_message() as Retorno5

	end catch 
end
GO
/****** Object:  ForeignKey [FK_tblTelefones_tblClientes]    Script Date: 04/12/2017 22:35:13 ******/
ALTER TABLE [dbo].[tblTelefones]  WITH NOCHECK ADD  CONSTRAINT [FK_tblTelefones_tblClientes] FOREIGN KEY([CodCliente])
REFERENCES [dbo].[tblClientes] ([CodCliente])
GO
ALTER TABLE [dbo].[tblTelefones] NOCHECK CONSTRAINT [FK_tblTelefones_tblClientes]
GO
/****** Object:  ForeignKey [FK_tblTelefones_tblTipoTelefone]    Script Date: 04/12/2017 22:35:13 ******/
ALTER TABLE [dbo].[tblTelefones]  WITH CHECK ADD  CONSTRAINT [FK_tblTelefones_tblTipoTelefone] FOREIGN KEY([CodTipoTelefone])
REFERENCES [dbo].[tblTipoTelefone] ([CodTipoTelefone])
GO
ALTER TABLE [dbo].[tblTelefones] CHECK CONSTRAINT [FK_tblTelefones_tblTipoTelefone]
GO
