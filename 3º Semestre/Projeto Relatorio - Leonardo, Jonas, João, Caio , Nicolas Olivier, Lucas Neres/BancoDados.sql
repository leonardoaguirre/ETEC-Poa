USE [master]
GO
/****** Object:  Database [relatorioDS2]    Script Date: 28/06/2017 18:53:34 ******/
CREATE DATABASE [relatorioDS2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'relatorioDS2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\relatorioDS2.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'relatorioDS2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\relatorioDS2_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [relatorioDS2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [relatorioDS2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [relatorioDS2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [relatorioDS2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [relatorioDS2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [relatorioDS2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [relatorioDS2] SET ARITHABORT OFF 
GO
ALTER DATABASE [relatorioDS2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [relatorioDS2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [relatorioDS2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [relatorioDS2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [relatorioDS2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [relatorioDS2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [relatorioDS2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [relatorioDS2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [relatorioDS2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [relatorioDS2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [relatorioDS2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [relatorioDS2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [relatorioDS2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [relatorioDS2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [relatorioDS2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [relatorioDS2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [relatorioDS2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [relatorioDS2] SET RECOVERY FULL 
GO
ALTER DATABASE [relatorioDS2] SET  MULTI_USER 
GO
ALTER DATABASE [relatorioDS2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [relatorioDS2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [relatorioDS2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [relatorioDS2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [relatorioDS2] SET DELAYED_DURABILITY = DISABLED 
GO
USE [relatorioDS2]
GO
/****** Object:  Table [dbo].[agenda]    Script Date: 28/06/2017 18:53:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[agenda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Lembrete] [varchar](50) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Importancia] [varchar](40) NOT NULL,
	[Data] [date] NOT NULL,
	[Hora] [varchar](20) NOT NULL,
	[Observacoes] [varchar](60) NOT NULL,
 CONSTRAINT [PK_agenda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarAgenda]    Script Date: 28/06/2017 18:53:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspAlterarAgenda]
@Id int,
@Nome varchar(50),
@Lembrete varchar(50),
@Importancia varchar(20),
@Data date,
@Hora varchar(15),
@Observacoes varchar(50)


as 
begin
begin try
Update agenda set Lembrete=@Lembrete,Nome=@Nome,Importancia=@Importancia,Data=@Data,Hora=@Hora,Observacoes=@Observacoes Where Id=@Id;

declare @Id1 as int = @@Identity

select @Id1 as Retorno

commit tran
end try
begin catch
rollback tran

select error_message() as Retorno

end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaAgenda]    Script Date: 28/06/2017 18:53:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspConsultaAgenda]
@Nome varchar(50)


as 
begin
begin try
Select * from agenda Where Nome LIKE '%' + @Nome + '%';

declare @Id as int = @@Identity

select @Id as Retorno

commit tran
end try
begin catch
rollback tran

select error_message() as Retorno

end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirAgenda]    Script Date: 28/06/2017 18:53:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspExcluirAgenda]
@Id varchar(10)


as 
begin
begin try
Delete from agenda Where Id = @Id;

declare @Id1 as int = @@Identity

select @Id1 as Retorno

commit tran
end try
begin catch
rollback tran

select error_message() as Retorno

end catch 
end
GO
/****** Object:  StoredProcedure [dbo].[uspInserirAgenda]    Script Date: 28/06/2017 18:53:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspInserirAgenda]
@Nome varchar(50),
@Lembrete varchar(50),
@Importancia varchar(20),
@Data date,
@Hora varchar(15),
@Observacoes varchar(50)


as 
begin
begin try
Insert into agenda (Lembrete,Nome,Importancia,Data,Hora,Observacoes) values (@Lembrete,@Nome,@Importancia,@Data,@Hora,@Observacoes);

declare @Id as int = @@Identity

select @Id as Retorno

commit tran
end try
begin catch
rollback tran

select error_message() as Retorno

end catch 
end
GO
USE [master]
GO
ALTER DATABASE [relatorioDS2] SET  READ_WRITE 
GO
