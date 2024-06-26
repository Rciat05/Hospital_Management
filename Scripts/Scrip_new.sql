USE Hospital_DB
GO

/****** Object:  Database [Hospital_DB]    Script Date: 01/06/2024 18:52:02 ******/
CREATE DATABASE Hospital_DB

 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Hospital_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hospital_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Hospital_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Hospital_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Hospital_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Hospital_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital_DB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Hospital_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hospital_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hospital_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hospital_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hospital_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [Hospital_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Hospital_DB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[CitaID] [int] IDENTITY(1,1) NOT NULL,
	[PacienteID] [int] NULL,
	[DoctorID] [int] NULL,
	[FechaCita] [datetime] NULL,
	[MotivoCita] [nvarchar](200) NULL,
	[EstadoCitas] [nvarchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[CitaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctores]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctores](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[NombreDoctor] [nvarchar](100) NULL,
	[ApellidoDoctor] [nvarchar](100) NULL,
	[Especialidad] [nvarchar](100) NULL,
	[Telefono] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[FechaContratacion] [date] NULL,
	[Estado] [nvarchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitaciones]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitaciones](
	[HabitacionID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroHabitacion] [nvarchar](10) NULL,
	[TipoHabitacion] [nvarchar](50) NULL,
	[EstadoHabitaciones] [nvarchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[HabitacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingresos]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresos](
	[IngresoID] [int] IDENTITY(1,1) NOT NULL,
	[PacienteID] [int] NULL,
	[HabitacionID] [int] NULL,
	[FechaIngreso] [datetime] NULL,
	[FechaAlta] [datetime] NULL,
	[DiagnosticoInicial] [nvarchar](255) NULL,
	[EstadoIngresos] [nvarchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[IngresoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamentos]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamentos](
	[MedicamentoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Descripcion] [nvarchar](255) NULL,
	[TiempoAdministrable] [nvarchar](20) NULL,
	[Cantidad] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MedicamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[PacienteID] [int] IDENTITY(1,1) NOT NULL,
	[NombrePaciente] [nvarchar](100) NULL,
	[ApellidoPaciente] [nvarchar](100) NULL,
	[FechaNacimiento] [date] NULL,
	[Sexo] [nvarchar](10) NULL,
	[Telefono] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PacienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prescripciones]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescripciones](
	[PrescripcionID] [int] IDENTITY(1,1) NOT NULL,
	[CitaID] [int] NULL,
	[MedicamentoID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrescripcionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'8.0.5')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2aa87eb7-3cd0-45c0-96f7-e737f66d4f7a', N'EmmaSecretary2@gmail.com', N'EMMASECRETARY2@GMAIL.COM', N'EmmaSecretary2@gmail.com', N'EMMASECRETARY2@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEJ+VzORNHL6d0x4hUz1zexG2GODbo2lIxqsawoceR3r0M7bikb8UfkUDSEL19ELYjA==', N'2RHY4Q4FOLG3NWYDYFRVC7DH7I4WBNNQ', N'c5c67bc1-b446-41eb-bd61-2c820299dc82', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5e33b1f3-e166-4cbb-8c65-ff32ff52e93f', N'EmmaSecretary@gmail.com', N'EMMASECRETARY@GMAIL.COM', N'EmmaSecretary@gmail.com', N'EMMASECRETARY@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEHscoSjs8k41IEFwO4B5NTPTeHA6zBbIxX/dvV/FW02jDjQOc+kK92XcFLrNHOx8YQ==', N'7SCQPKLU4VWMSLI66QR3SACSPAW2CXMS', N'd5a68427-478d-4517-9754-004cda736017', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Doctores] ON 

INSERT [dbo].[Doctores] ([DoctorID], [NombreDoctor], [ApellidoDoctor], [Especialidad], [Telefono], [Email], [FechaContratacion], [Estado]) VALUES (2, N'Jonh ', N'Do', N'Cuidado Infantil', N'1212-1212', N'enfermero@gmail.com', CAST(N'2024-06-01' AS Date), N'I')
INSERT [dbo].[Doctores] ([DoctorID], [NombreDoctor], [ApellidoDoctor], [Especialidad], [Telefono], [Email], [FechaContratacion], [Estado]) VALUES (3, N'Alvinacio', N'Rosales', N'Cirugía plastica', N'Masculino', N'Elmeroalvin@univo.edu.sv', CAST(N'2024-06-01' AS Date), N'A')
SET IDENTITY_INSERT [dbo].[Doctores] OFF
GO
SET IDENTITY_INSERT [dbo].[Habitaciones] ON 

INSERT [dbo].[Habitaciones] ([HabitacionID], [NumeroHabitacion], [TipoHabitacion], [EstadoHabitaciones]) VALUES (2, N'14', N'HackerHospital', N'I')
SET IDENTITY_INSERT [dbo].[Habitaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicamentos] ON 

INSERT [dbo].[Medicamentos] ([MedicamentoID], [Nombre], [Descripcion], [TiempoAdministrable], [Cantidad]) VALUES (3, N'Acetaminofen', N'Para curar de todo sobre las gripe, y por si se puede morir', N'Cada 8 horas', N'2')
SET IDENTITY_INSERT [dbo].[Medicamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([PacienteID], [NombrePaciente], [ApellidoPaciente], [FechaNacimiento], [Sexo], [Telefono], [Email], [FechaRegistro]) VALUES (11, N'Steven', N'Schafick', CAST(N'1979-10-09' AS Date), N'Masculino', N'9876-5432', N'Soyuncorreo@gmail.com', CAST(N'2024-05-31T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 01/06/2024 18:52:03 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 01/06/2024 18:52:03 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 01/06/2024 18:52:03 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 01/06/2024 18:52:03 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 01/06/2024 18:52:03 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 01/06/2024 18:52:03 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 01/06/2024 18:52:03 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctores] ([DoctorID])
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD FOREIGN KEY([PacienteID])
REFERENCES [dbo].[Pacientes] ([PacienteID])
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD FOREIGN KEY([HabitacionID])
REFERENCES [dbo].[Habitaciones] ([HabitacionID])
GO
ALTER TABLE [dbo].[Ingresos]  WITH CHECK ADD FOREIGN KEY([PacienteID])
REFERENCES [dbo].[Pacientes] ([PacienteID])
GO
ALTER TABLE [dbo].[Prescripciones]  WITH CHECK ADD FOREIGN KEY([CitaID])
REFERENCES [dbo].[Citas] ([CitaID])
GO
ALTER TABLE [dbo].[Prescripciones]  WITH CHECK ADD FOREIGN KEY([MedicamentoID])
REFERENCES [dbo].[Medicamentos] ([MedicamentoID])
GO
/****** Object:  StoredProcedure [dbo].[spDoctor_Delete]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spDoctor_Delete]
    @DoctorID INT
AS
BEGIN
    DELETE FROM Doctores
    WHERE DoctorID = @DoctorID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spDoctor_GetAll]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDoctor_GetAll]
AS
BEGIN
    SELECT * FROM Doctores;
END;

GO
/****** Object:  StoredProcedure [dbo].[spDoctor_GetByID]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDoctor_GetByID]
    @DoctorID INT
AS
BEGIN
    SELECT * FROM Doctores
    WHERE DoctorID = @DoctorID;
END;

GO
/****** Object:  StoredProcedure [dbo].[spDoctor_Insert]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDoctor_Insert]
    @NombreDoctor NVARCHAR(100),
    @ApellidoDoctor NVARCHAR(100),
    @Especialidad NVARCHAR(100),
    @Telefono NVARCHAR(15),
    @Email NVARCHAR(100),
    @FechaContratacion DATE,
    @Estado NVARCHAR(1)
AS
BEGIN
    INSERT INTO Doctores (NombreDoctor, ApellidoDoctor, Especialidad, Telefono, Email, FechaContratacion, Estado)
    VALUES (@NombreDoctor, @ApellidoDoctor, @Especialidad, @Telefono, @Email, @FechaContratacion, @Estado);
END;
GO
/****** Object:  StoredProcedure [dbo].[spDoctor_Update]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDoctor_Update]
    @DoctorID INT,
    @NombreDoctor NVARCHAR(100),
    @ApellidoDoctor NVARCHAR(100),
    @Especialidad NVARCHAR(100),
    @Telefono NVARCHAR(15),
    @Email NVARCHAR(100),
    @FechaContratacion DATE,
    @Estado NVARCHAR(1)
AS
BEGIN
    UPDATE Doctores
    SET NombreDoctor = @NombreDoctor,
        ApellidoDoctor = @ApellidoDoctor,
        Especialidad = @Especialidad,
        Telefono = @Telefono,
        Email = @Email,
        FechaContratacion = @FechaContratacion,
        Estado = @Estado
    WHERE DoctorID = @DoctorID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spHabitacion_Delete]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spHabitacion_Delete]
    @HabitacionID INT
AS
BEGIN
    DELETE FROM Habitaciones
    WHERE HabitacionID = @HabitacionID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spHabitacion_GetAll]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spHabitacion_GetAll]
AS
BEGIN
    SELECT * FROM Habitaciones;
END;

GO
/****** Object:  StoredProcedure [dbo].[spHabitacion_GetByID]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spHabitacion_GetByID]
    @HabitacionID INT
AS
BEGIN
    SELECT * FROM Habitaciones
    WHERE HabitacionID = @HabitacionID;
END;

GO
/****** Object:  StoredProcedure [dbo].[spHabitacion_Insert]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spHabitacion_Insert]
    @NumeroHabitacion NVARCHAR(10),
    @TipoHabitacion NVARCHAR(50),
    @EstadoHabitaciones NVARCHAR(1)
AS
BEGIN
    INSERT INTO Habitaciones (NumeroHabitacion, TipoHabitacion, EstadoHabitaciones)
    VALUES (@NumeroHabitacion, @TipoHabitacion, @EstadoHabitaciones);
END;
GO
/****** Object:  StoredProcedure [dbo].[spHabitacion_Update]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spHabitacion_Update]
    @HabitacionID INT,
    @NumeroHabitacion NVARCHAR(10),
    @TipoHabitacion NVARCHAR(50),
    @EstadoHabitaciones NVARCHAR(1)
AS
BEGIN
    UPDATE Habitaciones
    SET NumeroHabitacion = @NumeroHabitacion,
        TipoHabitacion = @TipoHabitacion,
        EstadoHabitaciones = @EstadoHabitaciones
    WHERE HabitacionID = @HabitacionID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spMedicamento_Delete]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMedicamento_Delete]
    @MedicamentoID INT
AS
BEGIN
    DELETE FROM Medicamentos
    WHERE MedicamentoID = @MedicamentoID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spMedicamento_GetAll]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMedicamento_GetAll]
AS
BEGIN
    SELECT * FROM Medicamentos;
END;
GO
/****** Object:  StoredProcedure [dbo].[spMedicamento_GetByID]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMedicamento_GetByID]
    @MedicamentoID INT
AS
BEGIN
    SELECT * FROM Medicamentos
    WHERE MedicamentoID = @MedicamentoID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spMedicamento_Insert]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMedicamento_Insert]
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255),
    @TiempoAdministrable NVARCHAR(20),
    @Cantidad NVARCHAR(5)
AS
BEGIN
    INSERT INTO Medicamentos (Nombre, Descripcion, TiempoAdministrable, Cantidad)
    VALUES (@Nombre, @Descripcion, @TiempoAdministrable, @Cantidad);
END;
GO
/****** Object:  StoredProcedure [dbo].[spMedicamento_Update]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMedicamento_Update]
    @MedicamentoID INT,
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255),
    @TiempoAdministrable NVARCHAR(20),
    @Cantidad NVARCHAR(5)
AS
BEGIN
    UPDATE Medicamentos
    SET Nombre = @Nombre,
        Descripcion = @Descripcion,
        TiempoAdministrable = @TiempoAdministrable,
        Cantidad = @Cantidad
    WHERE MedicamentoID = @MedicamentoID;
END;
GO
/****** Object:  StoredProcedure [dbo].[spPaciente_Delete]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPaciente_Delete]
    @PacienteID INT
AS
BEGIN
    DELETE FROM Pacientes
    WHERE PacienteID = @PacienteID
END;
GO
/****** Object:  StoredProcedure [dbo].[spPaciente_GetAll]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPaciente_GetAll]
AS
BEGIN
    SELECT *
    FROM Pacientes
END;
GO
/****** Object:  StoredProcedure [dbo].[spPaciente_GetByID]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPaciente_GetByID]
    @PacienteID INT
AS
BEGIN
    SELECT *
    FROM Pacientes
    WHERE PacienteID = @PacienteID
END;
GO
/****** Object:  StoredProcedure [dbo].[spPaciente_Insert]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPaciente_Insert]
    @NombrePaciente NVARCHAR(100),
    @ApellidoPaciente NVARCHAR(100),
    @FechaNacimiento DATETIME,
    @Sexo NVARCHAR(10),
    @Telefono NVARCHAR(15),
    @Email NVARCHAR(100),
    @FechaRegistro DATETIME
AS
BEGIN
    INSERT INTO Pacientes (NombrePaciente, ApellidoPaciente, FechaNacimiento, Sexo, Telefono, Email, FechaRegistro) 
    VALUES (@NombrePaciente, @ApellidoPaciente, @FechaNacimiento, @Sexo, @Telefono, @Email, @FechaRegistro);
END
GO
/****** Object:  StoredProcedure [dbo].[spPaciente_Update]    Script Date: 01/06/2024 18:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPaciente_Update]
    @PacienteID INT,
    @NombrePaciente NVARCHAR(100),
    @ApellidoPaciente NVARCHAR(100),
    @FechaNacimiento DATE,
    @Sexo NVARCHAR(10),
    @Telefono NVARCHAR(15),
    @Email NVARCHAR(100),
    @FechaRegistro DATETIME
AS
BEGIN
    UPDATE Pacientes
    SET NombrePaciente = @NombrePaciente,
        ApellidoPaciente = @ApellidoPaciente,
        FechaNacimiento = @FechaNacimiento,
        Sexo = @Sexo,
        Telefono = @Telefono,
        Email = @Email,
        FechaRegistro = @FechaRegistro
    WHERE PacienteID = @PacienteID
END;
GO
USE [master]
GO
ALTER DATABASE [Hospital_DB] SET  READ_WRITE 
GO
