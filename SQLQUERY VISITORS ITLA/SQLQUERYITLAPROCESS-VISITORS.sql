USE [master]
GO
/****** Object:  Database [Itla]    Script Date: 25/8/2021 11:18:12 a. m. ******/
CREATE DATABASE [Itla]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Itla', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Itla.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Itla_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Itla_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Itla] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Itla].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Itla] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Itla] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Itla] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Itla] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Itla] SET ARITHABORT OFF 
GO
ALTER DATABASE [Itla] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Itla] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Itla] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Itla] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Itla] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Itla] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Itla] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Itla] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Itla] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Itla] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Itla] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Itla] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Itla] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Itla] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Itla] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Itla] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Itla] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Itla] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Itla] SET  MULTI_USER 
GO
ALTER DATABASE [Itla] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Itla] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Itla] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Itla] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Itla] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Itla] SET QUERY_STORE = OFF
GO
USE [Itla]
GO
/****** Object:  User [AdminDewry]    Script Date: 25/8/2021 11:18:12 a. m. ******/
CREATE USER [AdminDewry] FOR LOGIN [AdminDewry] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_datareader] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [AdminDewry]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [AdminDewry]
GO
/****** Object:  Rule [RG_ACCESS_ADMIN]    Script Date: 25/8/2021 11:18:12 a. m. ******/
CREATE RULE [dbo].[RG_ACCESS_ADMIN] 
AS
@acceso in ('ADMINISTRATOR','GENERAL')
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aula](
	[IdAula] [int] IDENTITY(1,1) NOT NULL,
	[Aula] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[IdCarrera] [int] IDENTITY(1,1) NOT NULL,
	[Carrera] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Edificio]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificio](
	[Idedificio] [int] IDENTITY(1,1) NOT NULL,
	[Edificio] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Idedificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](15) NULL,
	[LastName] [varchar](15) NULL,
	[DateBirth] [date] NULL,
	[Username] [varchar](15) NULL,
	[Password] [varchar](15) NULL,
	[Access] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitas]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitas](
	[IdVisites] [int] IDENTITY(1,1) NOT NULL,
	[IdAula] [int] NOT NULL,
	[IdEdificio] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NULL,
	[Reason] [varchar](30) NULL,
	[Mail] [varchar](30) NULL,
	[EntryTime] [time](7) NOT NULL,
	[DepartureTime] [time](7) NULL,
	[Photo] [image] NULL,
	[IdCarrera] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVisites] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aula] ON 

INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (1, N'1A')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (2, N'1B')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (3, N'1C')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (4, N'1D')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (5, N'2A')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (6, N'2B')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (7, N'2C')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (8, N'2D')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (9, N'Library')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (10, N'Auditory')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (11, N'Registration')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (12, N'Department')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (13, N'Software area')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (14, N'Cibersecurity area')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (15, N'Mechatronics area')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (16, N'A.Intelligence area')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (17, N'Manufacturing area')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (18, N'Sound engineer')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (19, N'General office')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (20, N'Rectory Academic')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (21, N'Education Parmenent')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (22, N'Admissions')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (23, N'Finance')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (24, N'Information')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (25, N'Academic department')
INSERT [dbo].[Aula] ([IdAula], [Aula]) VALUES (26, N'Other site')
SET IDENTITY_INSERT [dbo].[Aula] OFF
GO
SET IDENTITY_INSERT [dbo].[Carreras] ON 

INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (1, N'Medicine')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (2, N'Lawyer')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (3, N'Industrial Engineer')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (4, N'Aerospace engineering')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (5, N'Mechanical Engineering')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (6, N'Sound engineering')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (7, N'Software Engineering')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (8, N'Economy')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (9, N'Financial Bachelor')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (10, N'Actuarial science')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (11, N'Mathematical sciences')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (12, N'Veterinarian')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (13, N'Cinematography')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (14, N'Accounting')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (15, N'Marketing')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (16, N'Teacher different areas')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (17, N'Astronomy')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (18, N'Political science')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (19, N'Philosophy')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (20, N'Civil Engineering')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (21, N'Psychology')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (22, N'Sociology')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (23, N'History')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (24, N'Beekeeping')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (25, N'Agronomy')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (26, N'Nursing')
INSERT [dbo].[Carreras] ([IdCarrera], [Carrera]) VALUES (27, N'Bachelor of Surveying')
SET IDENTITY_INSERT [dbo].[Carreras] OFF
GO
SET IDENTITY_INSERT [dbo].[Edificio] ON 

INSERT [dbo].[Edificio] ([Idedificio], [Edificio]) VALUES (1, N'Uno')
INSERT [dbo].[Edificio] ([Idedificio], [Edificio]) VALUES (2, N'Dos')
INSERT [dbo].[Edificio] ([Idedificio], [Edificio]) VALUES (3, N'Tres')
INSERT [dbo].[Edificio] ([Idedificio], [Edificio]) VALUES (4, N'Cuatro')
SET IDENTITY_INSERT [dbo].[Edificio] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([IdUsuario], [Name], [LastName], [DateBirth], [Username], [Password], [Access]) VALUES (4, N'Dewry', N'Pena', CAST(N'2021-08-23' AS Date), N'Dewry01', N'dewry01', N'ADMINISTRATOR')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Visitas] ON 

INSERT [dbo].[Visitas] ([IdVisites], [IdAula], [IdEdificio], [Name], [LastName], [Reason], [Mail], [EntryTime], [DepartureTime], [Photo], [IdCarrera]) VALUES (1, 1, 1, N'dewry', N'dewry', N'dewry', N'dewry', CAST(N'14:01:02' AS Time), CAST(N'15:01:04' AS Time), NULL, NULL)
INSERT [dbo].[Visitas] ([IdVisites], [IdAula], [IdEdificio], [Name], [LastName], [Reason], [Mail], [EntryTime], [DepartureTime], [Photo], [IdCarrera]) VALUES (2, 1, 1, N'perez', N'hernandez', N'dewry', N'dewry', CAST(N'14:01:02' AS Time), CAST(N'15:01:04' AS Time), NULL, NULL)
INSERT [dbo].[Visitas] ([IdVisites], [IdAula], [IdEdificio], [Name], [LastName], [Reason], [Mail], [EntryTime], [DepartureTime], [Photo], [IdCarrera]) VALUES (3, 1, 1, N'garcia', N'guzman', N'dewry', N'dewry', CAST(N'14:01:02' AS Time), CAST(N'15:01:04' AS Time), NULL, NULL)
INSERT [dbo].[Visitas] ([IdVisites], [IdAula], [IdEdificio], [Name], [LastName], [Reason], [Mail], [EntryTime], [DepartureTime], [Photo], [IdCarrera]) VALUES (4, 1, 1, N'D', N'D', N'd', N'd', CAST(N'14:15:01' AS Time), CAST(N'14:15:01' AS Time), NULL, 1)
SET IDENTITY_INSERT [dbo].[Visitas] OFF
GO
ALTER TABLE [dbo].[Visitas]  WITH CHECK ADD  CONSTRAINT [FK_Visitas_Aula] FOREIGN KEY([IdAula])
REFERENCES [dbo].[Aula] ([IdAula])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visitas] CHECK CONSTRAINT [FK_Visitas_Aula]
GO
ALTER TABLE [dbo].[Visitas]  WITH CHECK ADD  CONSTRAINT [FK_Visitas_Carreras] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carreras] ([IdCarrera])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visitas] CHECK CONSTRAINT [FK_Visitas_Carreras]
GO
ALTER TABLE [dbo].[Visitas]  WITH CHECK ADD  CONSTRAINT [FK_Visitas_Edificio] FOREIGN KEY([IdEdificio])
REFERENCES [dbo].[Edificio] ([Idedificio])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visitas] CHECK CONSTRAINT [FK_Visitas_Edificio]
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_visitas_edificio]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_buscar_visitas_edificio]
@textobuscar varchar(50)
as
select IdVisites,Edificio as Edifice, Aula,Name,LastName, Carrera as Career, Reason, Mail,EntryTime, DepartureTime,photo from visitas
inner join Aula on Aula.IdAula = Visitas.IdAula inner join Edificio on Edificio.Idedificio = Visitas.IdEdificio inner join  Carreras on  Visitas.IdCarrera = Carreras.IdCarrera
where Name like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_visitas_edificio2]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_buscar_visitas_edificio2]
@idedificio int
as
select IdVisites, Aula,Name,LastName, Carrera as Career, Reason, Mail,EntryTime, DepartureTime,photo from visitas
inner join Aula on Aula.IdAula = Visitas.IdAula  inner join  Carreras on  Visitas.IdCarrera = Carreras.IdCarrera 
where IdEdificio=@idedificio
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_aula]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_aula]
@idaula int,
@aula varchar(20)
as
update Aula set Aula=@aula
where IdAula=@idaula
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_carrera]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_carrera]
@idcarrera int,
@carrera varchar(150)
as
update Carrera set Carrera=@carrera
where IdCarrera=@idcarrera
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_edificio]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_edificio]
@idedificio int,
@edificio varchar(10)
as
update Edificio set Edificio = @edificio
where IdEdificio=@idedificio
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_usuario]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_editar_usuario]
@IdUsuario int,
@nombre varchar(15),
@apellido varchar(15),
@fechanac date,
@usuario varchar(15),
@password varchar(15),
@acceso varchar(15)
as
update Login set Name=@nombre,LastName=@apellido,DateBirth=@fechanac,Username=@usuario,Password=@password,Access=@acceso
where IdUsuario = @IdUsuario;
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_visitas]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_editar_visitas]
@idvisitas int,
@idaula int,
@idedificio int,
@name varchar(50),
@lastname varchar(50),
@idcarrera int,
@reason varchar(30),
@mail varchar(30),
@entrytime time,
@departuretime time,
@photo image
as
update Visitas set IdAula=@idaula,IdEdificio=@idedificio,Name=@name,Lastname=@lastname,IdCarrera=@idcarrera,Reason=@reason,Mail=@mail,EntryTime=@entrytime,DepartureTime=@departuretime,Photo=@photo
where IdVisites=@idvisitas
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_aula]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_aula]
@idaula int
as
delete from Aula
where IdAula=@idaula
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_carrera]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_carrera]
@idcarrera int
as
delete from Carreras 
where IdCarrera=@idcarrera
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_edificio]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_edificio]
@idedificio int
as
delete from Edificio
where IdEdificio=@idedificio
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_usuario]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_eliminar_usuario]
@IdUsuario int
as
delete from Login
where IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_visitas]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_visitas]
@idvisitas int
as
delete from Visitas
where Idvisites=@idvisitas
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_aula]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_aula]
@Idaula int output, 
@aula varchar(10)
as
insert into Aula values (@aula) 
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_carrera]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_carrera]
@idcarrera int output,
@carrera varchar(150)
as
insert into Carreras values(@carrera)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_edificio]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_edificio]
@Idedificio int output, 
@edificio varchar(10)
as
insert into Edificio values (@edificio)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_usuario]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertar_usuario]
@IdUsuario int output,
@nombre varchar(15),
@apellido varchar(15),
@fechanac date,
@usuario varchar(15),
@password varchar(15),
@acceso varchar(15)
as
if exists (select * from Login where @usuario=Username)
begin
print 'The user exits'
return
end

begin
insert into Login values (@nombre,@apellido,@fechanac,@usuario,@password,@acceso)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_visitas]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertar_visitas]
@idvisitas int output,
@idaula int,
@idedificio int,
@name varchar(50),
@lastname varchar(50),
@idcarrera int,
@reason varchar(30),
@mail varchar(30),
@entrytime time,
@departuretime time,
@photo image
as
insert into Visitas values(@idaula,@idedificio,@name,@lastname,@reason,@mail,@entrytime,@departuretime,@photo,@idcarrera)
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_aula]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_aula]
as
select * from Aula
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_carrera]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_carrera]
as
select * from Carreras
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_edificio]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_edificio]
as
select * from Edificio
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_login]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_login]
as
select IdUsuario, Name, LastName as "Last Name", DateBirth as "Date of Birth", Username, Password, Access as "Access level" from Login 
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_usuario]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_usuario]
@usuario varchar(15),
@password varchar(15)
as
select * from Login
where Username=@usuario and Password=@password
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_visitas]    Script Date: 25/8/2021 11:18:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_visitas]
as
select IdVisites,Edificio as Edifice, Aula,Name,LastName, Carrera as Career, Reason, Mail,EntryTime, DepartureTime,photo from visitas
inner join Aula on Aula.IdAula = Visitas.IdAula inner join Edificio on Edificio.Idedificio = Visitas.IdEdificio inner join  Carreras on  Visitas.IdCarrera = Carreras.IdCarrera
GO
USE [master]
GO
ALTER DATABASE [Itla] SET  READ_WRITE 
GO
