USE [master]
GO
/****** Object:  Database [dbclinica]    Script Date: 30/06/2021 23:23:45 ******/
CREATE DATABASE [dbclinica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbclinica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbclinica.mdf' , SIZE = 25600KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbclinica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbclinica_log.ldf' , SIZE = 9216KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbclinica] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbclinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbclinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbclinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbclinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbclinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbclinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbclinica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbclinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbclinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbclinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbclinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbclinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbclinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbclinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbclinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbclinica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbclinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbclinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbclinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbclinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbclinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbclinica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbclinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbclinica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbclinica] SET  MULTI_USER 
GO
ALTER DATABASE [dbclinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbclinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbclinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbclinica] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbclinica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbclinica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbclinica] SET QUERY_STORE = OFF
GO
USE [dbclinica]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[idcita] [int] IDENTITY(1,1) NOT NULL,
	[idpaciente] [int] NOT NULL,
	[idusuario] [int] NOT NULL,
	[fecha] [varchar](50) NOT NULL,
	[idservicio] [int] NOT NULL,
	[costo] [decimal](6, 2) NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[idcita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuracion]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuracion](
	[idconfiguracion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empresa] [varchar](50) NULL,
	[logo] [image] NULL,
 CONSTRAINT [PK_Configuracion] PRIMARY KEY CLUSTERED 
(
	[idconfiguracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[iddiagnostico] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[enfermedad] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Diagnostico] PRIMARY KEY CLUSTERED 
(
	[iddiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historia]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historia](
	[idhistoria] [int] IDENTITY(1,1) NOT NULL,
	[idpaciente] [int] NOT NULL,
	[fecha_consulta] [varchar](50) NULL,
	[razon_consulta] [varchar](50) NULL,
	[enfermedad_actual] [varchar](50) NULL,
	[historia_familiar] [varchar](50) NULL,
	[historia_personal] [varchar](50) NULL,
	[tratamiento_actual] [varchar](50) NULL,
	[examen_fisico] [varchar](50) NULL,
	[laboratorio] [varchar](50) NULL,
	[ecg] [varchar](50) NULL,
	[rayos_x] [varchar](50) NULL,
	[ecocardiograma] [varchar](50) NULL,
	[plan_estudio] [varchar](50) NULL,
	[plan_terapeutico] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_Historia] PRIMARY KEY CLUSTERED 
(
	[idhistoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operacion]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operacion](
	[idoperacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Operacion] PRIMARY KEY CLUSTERED 
(
	[idoperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[idpaciente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[tipo_cedula] [varchar](20) NULL,
	[num_cedula] [varchar](20) NULL,
	[fecha_nacimiento] [varchar](50) NULL,
	[sexo] [varchar](50) NULL,
	[estado_civil] [varchar](50) NULL,
	[direccion] [varchar](100) NULL,
	[ocupacion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[peso] [varchar](50) NULL,
	[talla] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[idpaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanEstudio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanEstudio](
	[idplanestudio] [int] IDENTITY(1,1) NOT NULL,
	[idpaciente] [int] NOT NULL,
	[estudios] [varchar](100) NOT NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_PlanEstudio] PRIMARY KEY CLUSTERED 
(
	[idplanestudio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receta]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receta](
	[idreceta] [int] IDENTITY(1,1) NOT NULL,
	[idpaciente] [int] NOT NULL,
	[medicamento] [varchar](50) NOT NULL,
	[presentacion] [varchar](50) NOT NULL,
	[dosis] [varchar](50) NOT NULL,
	[duracion] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Receta] PRIMARY KEY CLUSTERED 
(
	[idreceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuestas_Usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuestas_Usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[Respuesta_1] [varchar](50) NOT NULL,
	[Respuesta_2] [varchar](50) NOT NULL,
	[Respuesta_3] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[idservicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[costo] [decimal](6, 2) NOT NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[idservicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cargo] [varchar](50) NOT NULL,
	[especialidad] [varchar](50) NOT NULL,
	[acceso] [varchar](50) NOT NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY([idpaciente])
REFERENCES [dbo].[Paciente] ([idpaciente])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Paciente]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Servicio] FOREIGN KEY([idservicio])
REFERENCES [dbo].[Servicio] ([idservicio])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Servicio]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuario] ([idusuario])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Usuario]
GO
ALTER TABLE [dbo].[Historia]  WITH CHECK ADD  CONSTRAINT [FK_Historia_Paciente] FOREIGN KEY([idpaciente])
REFERENCES [dbo].[Paciente] ([idpaciente])
GO
ALTER TABLE [dbo].[Historia] CHECK CONSTRAINT [FK_Historia_Paciente]
GO
ALTER TABLE [dbo].[Receta]  WITH CHECK ADD  CONSTRAINT [FK_Receta_Paciente] FOREIGN KEY([idpaciente])
REFERENCES [dbo].[Paciente] ([idpaciente])
GO
ALTER TABLE [dbo].[Receta] CHECK CONSTRAINT [FK_Receta_Paciente]
GO
ALTER TABLE [dbo].[Respuestas_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Respuestas_Usuario_Usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuario] ([idusuario])
GO
ALTER TABLE [dbo].[Respuestas_Usuario] CHECK CONSTRAINT [FK_Respuestas_Usuario_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[sbbuscar_nombre_servicio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sbbuscar_nombre_servicio]
@textobuscar varchar(50)
as
select * from Servicio
where nombre like @textobuscar +'%'
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[sbbuscar_receta_medicamento]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sbbuscar_receta_medicamento]
@textobuscar varchar(50)
as
select * from Receta
where medicamento like @textobuscar +'%'
order by medicamento asc
GO
/****** Object:  StoredProcedure [dbo].[sbbuscar_receta_presentacion]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sbbuscar_receta_presentacion]
@textobuscar varchar(50)
as
select * from Receta
where presentacion like @textobuscar +'%'
order by medicamento asc
GO
/****** Object:  StoredProcedure [dbo].[spanular_paciente]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spanular_paciente]
@idpaciente int
as 
update Paciente set estado = 'Inactivo'
where idpaciente=@idpaciente
GO
/****** Object:  StoredProcedure [dbo].[spanular_servicio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spanular_servicio]
@idservicio int
as 
update Servicio set estado = 'Inactivo'
where idservicio=@idservicio
GO
/****** Object:  StoredProcedure [dbo].[spanular_usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spanular_usuario]
@idusuario int
as 
update Usuario set estado = 'Inactivo'
where idusuario=@idusuario
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_acceso_usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spbuscar_acceso_usuario]
@textobuscar varchar(50)
as
select * from Usuario
where cargo like @textobuscar +'%'
order by cargo asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_cargo_usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_cargo_usuario]
@textobuscar varchar(50)
as
select * from Usuario
where cargo like @textobuscar +'%'
order by cargo asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_cliente_nombre]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_cliente_nombre]
@textobuscar varchar(50)
as
select * from Paciente
where nombre like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_codigo_diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_codigo_diagnostico]
@textobuscar varchar(50)
as
select * from Diagnostico
where codigo like @textobuscar +'%'
order by enfermedad asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_enfermedad_diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_enfermedad_diagnostico]
@textobuscar varchar(50)
as
select * from Diagnostico
where enfermedad like @textobuscar +'%'
order by enfermedad asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_nombre_servicio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_nombre_servicio]
@textobuscar varchar(50)
as
select * from Servicio
where nombre like @textobuscar +'%'
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_nombre_usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_nombre_usuario]
@textobuscar varchar(50)
as
select * from Usuario
where nombre like @textobuscar +'%'
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_paciente_nombre]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_paciente_nombre]
@textobuscar varchar(50)
as
select * from Paciente
where nombre like @textobuscar +'%'
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_paciente_num_documento]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spbuscar_paciente_num_documento]
@textobuscar varchar(50)
as
select * from Paciente
where num_cedula like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_paciente_peso]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_paciente_peso]
@textobuscar varchar(50)
as
select * from Paciente
where peso like @textobuscar +'%'
order by peso asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_paciente_talla]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_paciente_talla]
@textobuscar varchar(50)
as
select * from Paciente
where talla like @textobuscar +'%'
order by talla asc
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_tipo_diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spbuscar_tipo_diagnostico]
@textobuscar varchar(50)
as
select * from Diagnostico
where tipo like @textobuscar +'%'
order by tipo asc
GO
/****** Object:  StoredProcedure [dbo].[speditar_diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_diagnostico]
@iddiagnostico int,
@codigo varchar(50),
@enfermedad varchar(70),
@tipo varchar(30)
as
update Diagnostico set codigo=@codigo, enfermedad=@enfermedad, tipo=@tipo
where iddiagnostico=@iddiagnostico
GO
/****** Object:  StoredProcedure [dbo].[speditar_paciente]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[speditar_paciente]

@idpaciente int,
@nombre varchar(50),
@tipo_cedula varchar(20),
@num_cedula varchar(11),
@fecha_nacimiento varchar(100),
@sexo varchar(10),
@estado_civil varchar(20),
@direccion varchar(100),
@ocupacion varchar(50),
@telefono varchar(20),
@correo varchar(50),
@peso varchar(20),
@talla varchar(20),
@estado varchar(10)
as
update Paciente set nombre=@nombre, tipo_cedula=@tipo_cedula, num_cedula=@num_cedula,
fecha_nacimiento=@fecha_nacimiento, sexo=@sexo, estado_civil=@estado_civil, direccion=@direccion, ocupacion=@ocupacion, telefono=@telefono,
correo=@correo, peso=@peso, talla=@talla, estado=@estado 
where idpaciente=@idpaciente
GO
/****** Object:  StoredProcedure [dbo].[speditar_receta]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_receta]
@idreceta int,
@idpaciente int,
@medicamento varchar(50),
@presentacion varchar(50),
@dosis varchar(50),
@duracion varchar(50),
@cantidad int
as
update Receta set idpaciente=@idpaciente, medicamento=@medicamento, presentacion=@presentacion, dosis=@dosis, duracion=@duracion, cantidad=@cantidad
where idreceta=@idreceta
GO
/****** Object:  StoredProcedure [dbo].[speditar_servicio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speditar_servicio]
@idservicio int,
@nombre varchar(50),
@costo decimal(6,2),
@estado varchar(50)
as
update Servicio set nombre=@nombre, costo=@costo, estado=@estado
where idservicio=@idservicio
GO
/****** Object:  StoredProcedure [dbo].[speditar_usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[speditar_usuario]

@idusuario int,
@nombre varchar(50),
@especialidad varchar(50),
@cargo varchar(50),
@acceso varchar(50),
@login varchar(50),
@password varchar(50),
@estado varchar(10)
as
update Usuario set nombre=@nombre, especialidad=@especialidad, cargo=@cargo, acceso=@acceso,
login=@login, password=@password, estado=@estado
where idusuario=@idusuario
GO
/****** Object:  StoredProcedure [dbo].[speditar_usuario_contrasena]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[speditar_usuario_contrasena]

@idusuario int,
@password varchar(50)
as
update Usuario set password=@password
where idusuario=@idusuario
GO
/****** Object:  StoredProcedure [dbo].[speliminar_diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_diagnostico]
@iddiagnostico int
as
delete from Diagnostico
where iddiagnostico=@iddiagnostico
GO
/****** Object:  StoredProcedure [dbo].[speliminar_paciente]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_paciente]
@idpaciente int
as
delete from Paciente
where idpaciente=@idpaciente
GO
/****** Object:  StoredProcedure [dbo].[speliminar_receta]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[speliminar_receta]
@idreceta int
as
delete from Receta
where idreceta=@idreceta
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_diagnostico]
@iddiagnostico int output,
@codigo varchar(50),
@enfermedad varchar(70),
@tipo varchar(30)
as
insert into Diagnostico (codigo, enfermedad, tipo) 
values (@codigo, @enfermedad, @tipo)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_operacion]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_operacion]
@idoperacion int output,
@fecha varchar(50),
@descripcion varchar(50)
as
insert into Operacion (fecha, descripcion) 
values (@fecha, @descripcion)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_paciente]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spinsertar_paciente]
@idpaciente int output,
@nombre varchar(50),
@tipo_cedula varchar(20),
@num_cedula varchar(11),
@fecha_nacimiento varchar(100),
@sexo varchar(10),
@estado_civil varchar(20),
@direccion varchar(100),
@ocupacion varchar(50),
@telefono varchar(20),
@correo varchar(50),
@peso varchar(20),
@talla varchar(20),
@estado varchar(10)
as
insert into Paciente (nombre, tipo_cedula, num_cedula, fecha_nacimiento, sexo, estado_civil,
direccion, ocupacion, telefono, correo, peso, talla, estado) 
values (@nombre, @tipo_cedula, @num_cedula, @fecha_nacimiento, @sexo, @estado_civil,
@direccion, @ocupacion, @telefono, @correo, @peso, @talla, @estado)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_planestudio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spinsertar_planestudio]
@idpaciente int,
@listaestudios varchar(100)
as
insert into PlanEstudio(idpaciente, estudios, estado) 
values (@idpaciente, @listaestudios, 'Activo');
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_receta]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_receta]
@idreceta int output,
@idpaciente int,
@medicamento varchar(50),
@presentacion varchar(50),
@dosis varchar(50),
@duracion varchar(50),
@cantidad int
as
insert into Receta(idpaciente, medicamento, presentacion, dosis, duracion, cantidad) 
values (@idpaciente, @medicamento, @presentacion, @dosis, @duracion, @cantidad)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_servicio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spinsertar_servicio]
@idservicio int output,
@nombre varchar(50),
@costo decimal(6,2),
@estado varchar(50)
as
insert into Servicio(nombre, costo, estado) 
values (@nombre, @costo, @estado)
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spinsertar_usuario]

@idusuario int output,
@nombre varchar(50),
@cargo varchar(50),
@especialidad varchar(50),
@acceso varchar(50),
@login varchar(50),
@password varchar(50),
@estado varchar(10)
as
insert into Usuario (nombre, especialidad, cargo, acceso, login, password, estado) 
values (@nombre, @especialidad, @cargo, @acceso, @login, @password, @estado)
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_cliente]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_cliente]
as
select top 100 * from Paciente
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_diagnostico]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_diagnostico]
as
select top 100 * from Diagnostico
order by codigo asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_operacion]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_operacion]
as
select * from Operacion
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_paciente]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_paciente]
as
select * from Paciente
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_planestudio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spmostrar_planestudio]
as
select * from PlanEstudio
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_receta]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_receta]
as
select top 100 * from Receta
order by medicamento asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_servicio]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_servicio]
as
select top 100 * from Servicio
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_usuario]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spmostrar_usuario]
as
select top 100 * from Usuario
order by nombre asc
GO
/****** Object:  StoredProcedure [dbo].[spreporte_receta]    Script Date: 30/06/2021 23:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spreporte_receta]
@idreceta int
as
select * from Paciente inner join Receta
on Paciente.idpaciente = Receta.idpaciente
where idreceta = @idreceta
GO
USE [master]
GO
ALTER DATABASE [dbclinica] SET  READ_WRITE 
GO
