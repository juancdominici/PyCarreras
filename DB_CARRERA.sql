USE [master]
GO
/****** Object:  Database [DB_CARRERA]    Script Date: 07/11/2021 04:43:27 p. m. ******/
CREATE DATABASE [DB_CARRERA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_CARRERA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_CARRERA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_CARRERA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_CARRERA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_CARRERA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_CARRERA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_CARRERA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_CARRERA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_CARRERA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_CARRERA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_CARRERA] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_CARRERA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_CARRERA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_CARRERA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_CARRERA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_CARRERA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_CARRERA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_CARRERA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_CARRERA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_CARRERA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_CARRERA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_CARRERA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_CARRERA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_CARRERA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_CARRERA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_CARRERA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_CARRERA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_CARRERA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_CARRERA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_CARRERA] SET  MULTI_USER 
GO
ALTER DATABASE [DB_CARRERA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_CARRERA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_CARRERA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_CARRERA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_CARRERA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_CARRERA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_CARRERA] SET QUERY_STORE = OFF
GO
USE [DB_CARRERA]
GO
/****** Object:  Table [dbo].[T_CARRERAS]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_CARRERAS](
	[ID_CARRERA] [int] IDENTITY(1,1) NOT NULL,
	[N_CARRERA] [varchar](80) NULL,
	[N_TITULO] [varchar](80) NULL,
 CONSTRAINT [PK_CARRERA] PRIMARY KEY CLUSTERED 
(
	[ID_CARRERA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_DETALLE_CARRERAS]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_DETALLE_CARRERAS](
	[ID_CARRERA] [int] NOT NULL,
	[ID_DETALLE] [int] NOT NULL,
	[ANIO_CURSADO] [datetime] NULL,
	[CUATRIMESTRE] [int] NULL,
	[ID_MATERIA] [int] NULL,
 CONSTRAINT [PK_CARRERA_DETALLE] PRIMARY KEY CLUSTERED 
(
	[ID_CARRERA] ASC,
	[ID_DETALLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_MATERIAS]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_MATERIAS](
	[ID_MATERIA] [int] IDENTITY(1,1) NOT NULL,
	[N_MATERIA] [varchar](80) NULL,
 CONSTRAINT [PK_MATERIA] PRIMARY KEY CLUSTERED 
(
	[ID_MATERIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_USUARIOS]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_USUARIOS](
	[ID_USUARIO] [int] IDENTITY(1,1) NOT NULL,
	[USUARIO] [varchar](50) NULL,
	[CONTRASENA] [varchar](50) NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[T_DETALLE_CARRERAS]  WITH CHECK ADD  CONSTRAINT [FK_MATERIA] FOREIGN KEY([ID_MATERIA])
REFERENCES [dbo].[T_MATERIAS] ([ID_MATERIA])
GO
ALTER TABLE [dbo].[T_DETALLE_CARRERAS] CHECK CONSTRAINT [FK_MATERIA]
GO
ALTER TABLE [dbo].[T_DETALLE_CARRERAS]  WITH CHECK ADD  CONSTRAINT [FK_T_DETALLE_CARRERAS_T_CARRERAS] FOREIGN KEY([ID_CARRERA])
REFERENCES [dbo].[T_CARRERAS] ([ID_CARRERA])
GO
ALTER TABLE [dbo].[T_DETALLE_CARRERAS] CHECK CONSTRAINT [FK_T_DETALLE_CARRERAS_T_CARRERAS]
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZAR_MAESTRO]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ACTUALIZAR_MAESTRO]
	@ID_CARRERA INT,
    @N_CARRERA VARCHAR(50), 
    @N_TITULO VARCHAR(50)
AS
	BEGIN
     UPDATE T_CARRERAS SET N_CARRERA = @N_CARRERA, N_TITULO = @N_TITULO WHERE ID_CARRERA = @ID_CARRERA;
				
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZAR_MATERIA]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ACTUALIZAR_MATERIA]
	@ID_MATERIA INT,
    @NOM_MATERIA VARCHAR(50)
AS
	BEGIN
     UPDATE T_MATERIAS SET N_MATERIA = @NOM_MATERIA WHERE ID_MATERIA = @ID_MATERIA;
				
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_BORRAR_DETALLE]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BORRAR_DETALLE]
    @ID_CARRERA INT
AS
	BEGIN
     DELETE T_DETALLE_CARRERAS WHERE ID_CARRERA = @ID_CARRERA;
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_BORRAR_MATERIA]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BORRAR_MATERIA]
	@ID_MATERIA INT
AS
	BEGIN
     DELETE FROM T_MATERIAS WHERE ID_MATERIA = @ID_MATERIA;
				
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CARRERA]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_CARRERA]
	@NOMBRE VARCHAR(50) = null,
    @TITULO VARCHAR(50) = null
AS
BEGIN
	SELECT * FROM T_CARRERAS
	WHERE  N_CARRERA = @NOMBRE OR N_TITULO = @TITULO
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CARRERA_POR_ID]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_CARRERA_POR_ID]
	@nro int	
AS
BEGIN
	SELECT *
	FROM T_CARRERAS t, T_DETALLE_CARRERAS t1, T_MATERIAS t2
	WHERE T.ID_CARRERA = t1.ID_CARRERA
	AND t1.ID_MATERIA = t2.ID_MATERIA
	AND t.ID_CARRERA = @nro;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_MATERIAS]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_MATERIAS]
AS
BEGIN
	
	SELECT * from T_MATERIAS;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE]
	@ID_CARRERA INT,
	@ID_DETALLE INT,
	@ANIO_CURSADO DATETIME,
	@CUATRIMESTRE INT,
	@ID_MATERIA INT
AS
	BEGIN
		INSERT INTO T_DETALLE_CARRERAS (ID_CARRERA, ID_DETALLE, ANIO_CURSADO, CUATRIMESTRE,ID_MATERIA)
		VALUES (@ID_CARRERA, @ID_DETALLE, @ANIO_CURSADO, @CUATRIMESTRE, @ID_MATERIA);
				
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_MAESTRO]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_MAESTRO]
	@N_CARRERA VARCHAR(50),
	@N_TITULO VARCHAR(50),
	@ID_CARRERA INT OUTPUT
AS
BEGIN
	INSERT INTO T_CARRERAS(N_CARRERA, N_TITULO)
    VALUES (@N_CARRERA, @N_TITULO);
    SET @ID_CARRERA = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_MATERIA]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_MATERIA]
	@NOM_MATERIA VARCHAR(50)
AS
	BEGIN
		INSERT INTO T_MATERIAS (N_MATERIA)
		VALUES (@NOM_MATERIA);
				
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LOGIN]
	@USUARIO VARCHAR(50) = null,
    @CONTRASENA VARCHAR(50) = null,
    @USUARIOS int OUTPUT
AS
BEGIN
	SELECT * FROM T_USUARIOS
	WHERE USUARIO = @USUARIO AND @CONTRASENA = @CONTRASENA;

    SELECT @USUARIOS = @@ROWCOUNT;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PLANES_DE_ESTUDIO]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PLANES_DE_ESTUDIO]
	@DESDE DATETIME,
    @HASTA DATETIME
AS
BEGIN
    SELECT C.N_CARRERA 'CARRERA', C.N_TITULO 'TITULO', YEAR(DC.ANIO_CURSADO) 'AÑO DE CURSADO', DC.CUATRIMESTRE, M.N_MATERIA MATERIA
    FROM T_DETALLE_CARRERAS DC 
    JOIN T_CARRERAS C ON DC.ID_CARRERA = C.ID_CARRERA
    JOIN T_MATERIAS M ON DC.ID_MATERIA = M.ID_MATERIA
    WHERE DC.ANIO_CURSADO BETWEEN @DESDE AND @HASTA
    GROUP BY C.N_CARRERA, C.N_TITULO, DC.ANIO_CURSADO, DC.CUATRIMESTRE, M.N_MATERIA
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID_CARRERA]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID_CARRERA]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(ID_CARRERA)+1  FROM T_CARRERAS);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID_MATERIAS]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID_MATERIAS]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(ID_MATERIA)+1  FROM T_MATERIAS);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRAR_BAJA_CARRERA]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_REGISTRAR_BAJA_CARRERA]
	@ID_CARRERA int
AS
BEGIN
    DELETE T_DETALLE_CARRERAS WHERE ID_CARRERA = @ID_CARRERA;
	DELETE T_CARRERAS WHERE ID_CARRERA = @ID_CARRERA;
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_MATERIAS]    Script Date: 07/11/2021 04:43:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_REPORTE_MATERIAS]
AS
BEGIN
	SELECT t2.N_MATERIA as MATERIA
	FROM T_CARRERAS t, T_DETALLE_CARRERAS t1, T_MATERIAS t2
	WHERE t.ID_CARRERA = t1.ID_CARRERA
	AND t1.ID_MATERIA = t2.ID_MATERIA
	GROUP BY t2.N_MATERIA
END
GO
USE [master]
GO
ALTER DATABASE [DB_CARRERA] SET  READ_WRITE 
GO
