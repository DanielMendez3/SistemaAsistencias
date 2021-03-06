
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PlanillaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PlanillaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PlanillaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PlanillaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PlanillaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PlanillaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PlanillaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PlanillaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PlanillaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PlanillaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PlanillaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PlanillaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PlanillaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PlanillaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PlanillaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PlanillaDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PlanillaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PlanillaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PlanillaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PlanillaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PlanillaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PlanillaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PlanillaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PlanillaDB] SET RECOVERY FULL 
GO
ALTER DATABASE [PlanillaDB] SET  MULTI_USER 
GO
ALTER DATABASE [PlanillaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PlanillaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PlanillaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PlanillaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PlanillaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PlanillaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PlanillaDB', N'ON'
GO
ALTER DATABASE [PlanillaDB] SET QUERY_STORE = OFF
GO
USE [PlanillaDB]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 17/7/2021 21:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Identificator] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[PositionID] [int] NULL,
	[Salary x Hour] [decimal](18, 2) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 17/7/2021 21:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[PositionID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NULL,
	[Salary x Hour] [decimal](18, 2) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusEmployee]    Script Date: 17/7/2021 21:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusEmployee](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_StatusEmployee] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Positions] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Positions] ([PositionID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Positions]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_StatusEmployee] FOREIGN KEY([Status])
REFERENCES [dbo].[StatusEmployee] ([StatusID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_StatusEmployee]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateEmployee]    Script Date: 17/7/2021 21:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Daniel Medina>
-- Create date: <17/07/2021>
-- Description:	<Crear un nuevo empleado>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CreateEmployee]
@Name VARCHAR(100),
@Identificator VARCHAR(50),
@Country VARCHAR(50),
@Position INT,
@SalaryxHour decimal(18, 2)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @Status INT = 1;
	DECLARE @Code VARCHAR = '';
	--VALIDAMOS SI IDENTIFICACION YA EXISTE
	IF (SELECT COUNT(*) FROM dbo.Employees WHERE [Identificator] = @Identificator) > 0
		BEGIN
			RAISERROR('YA EXISTE UN REGISTRO CON LA IDENTIFICACIÓN',16,1);
		END
	ELSE
		BEGIN
			INSERT INTO [dbo].[Employees]
           ([Name]
           ,[Identificator]
           ,[Country]
           ,[PositionID]
           ,[Salary x Hour]
           ,[Status])
			 VALUES
				   (@Name
				   ,@Identificator
				   ,@Country
				   ,@Position
				   ,@SalaryxHour
				   ,@Status)
		END


END
GO
/****** Object:  StoredProcedure [dbo].[sp_EditEmployee]    Script Date: 17/7/2021 21:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Daniel Medina>
-- Create date: <17/07/2021>
-- Description:	<Modifica un empleado>
-- =============================================
CREATE PROCEDURE [dbo].[sp_EditEmployee]
@EmployeID INT,
@Name VARCHAR(100),
@Identificator VARCHAR(50),
@Country VARCHAR(50),
@Position INT,
@SalaryxHour decimal(18, 2),
@Status INT

AS
BEGIN
	SET NOCOUNT ON;
	--VALIDAMOS SI IDENTIFICACION YA EXISTE
	IF (SELECT COUNT(*) FROM dbo.Employees WHERE [Identificator] = @Identificator) = 0
		BEGIN
			RAISERROR('NO EXISTE UN REGISTRO CON LA IDENTIFICACIÓN',16,1);
		END
	ELSE
		BEGIN
			UPDATE [dbo].[Employees]
			   SET [Name] = @Name
				  ,[Identificator] = @Identificator
				  ,[Country] = @Country
				  ,[PositionID] = @Position
				  ,[Salary x Hour] = @SalaryxHour
				  ,[Status] = @Status
			 WHERE [EmployeeID] = @EmployeID
		END;

END
GO
/****** Object:  StoredProcedure [dbo].[sp_MostrarPersonal]    Script Date: 17/7/2021 21:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DANIEL MEDINA
-- Create date: <17/07/2021>
-- Description:	<MOSTRAR TODOS LOS REGISTROS DE PERSONAL>
-- EXECUTE [sp_MostrarPersonal] 1,1,NULL
-- =============================================
CREATE PROCEDURE [dbo].[sp_MostrarPersonal]
@PageNumber INT = 1, 
@RowspPage INT = 10,
@Filter VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

DECLARE @Offset INT = 0;
DECLARE @SQL VARCHAR(4000) = '';
	SET @SQL += 'SELECT E.EmployeeID, E.[Name], E.Identificator, E.Country, 
		P.PositionName, E.[Salary x Hour], SE.[Description][Status]
		FROM dbo.Employees E
		JOIN dbo.Positions P ON E.PositionID = P.PositionID
		JOIN dbo.StatusEmployee SE ON E.[Status] = SE.StatusID';
	
		IF (@Filter IS NOT NULL AND @Filter != '') SET @SQL += ' WHERE E.[Name] LIKE ''%'+ @Filter + '%''';

	SET @PageNumber = @PageNumber - 1;
	SET @Offset = @PageNumber * @RowspPage;
	SET @SQL += '	ORDER BY E.EmployeeID
					OFFSET (' + CAST(@Offset AS VARCHAR) + ') ROWS
					FETCH NEXT ' +  CAST(@RowspPage AS VARCHAR) + ' ROWS ONLY;'
    
	EXEC(@SQL)

END



GO
USE [master]
GO
ALTER DATABASE [PlanillaDB] SET  READ_WRITE 
GO
