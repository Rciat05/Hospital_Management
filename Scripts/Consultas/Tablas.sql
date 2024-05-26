use Hospital_DB

CREATE TABLE Pacientes (
    PacienteID INT PRIMARY KEY IDENTITY(1,1),
    NombrePaciente NVARCHAR(100),
    ApellidoPaciente NVARCHAR(100),
    FechaNacimiento DATE,
    Sexo NVARCHAR(10),
    Telefono NVARCHAR(15),
    Email NVARCHAR(100),
    FechaRegistro DATETIME
);

CREATE TABLE Doctores (
    DoctorID INT PRIMARY KEY IDENTITY(1,1),
    NombreDoctor NVARCHAR(100),
    ApellidoDoctor NVARCHAR(100),
    Especialidad NVARCHAR(100),
    Telefono NVARCHAR(15),
    Email NVARCHAR(100),
    FechaContratacion DATE,
    Estado NVARCHAR(1)
);

CREATE TABLE Citas (
    CitaID INT PRIMARY KEY IDENTITY(1,1),
    PacienteID INT,
    DoctorID INT,
    FechaCita DATETIME,
    MotivoCita NVARCHAR(200),
    EstadoCitas NVARCHAR(1),
	FOREIGN KEY (PacienteID) REFERENCES Pacientes(PacienteID),
	FOREIGN KEY (DoctorID) REFERENCES Doctores(DoctorID),
);

CREATE TABLE Habitaciones (
    HabitacionID INT PRIMARY KEY IDENTITY(1,1),
    NumeroHabitacion NVARCHAR(10),
    TipoHabitacion NVARCHAR(50),
    EstadoHabitaciones NVARCHAR(1)
);

CREATE TABLE Ingresos (
    IngresoID INT PRIMARY KEY IDENTITY(1,1),
    PacienteID INT,
    HabitacionID INT,
    FechaIngreso DATETIME,
    FechaAlta DATETIME,
    DiagnosticoInicial NVARCHAR(255),
    EstadoIngresos NVARCHAR(1),
	FOREIGN KEY (PacienteID) REFERENCES Pacientes(PacienteID),
	FOREIGN KEY (HabitacionID) REFERENCES Habitaciones(HabitacionID),
);

CREATE TABLE Medicamentos (
    MedicamentoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(255),
    TiempoAdministrable NVARCHAR(20),
    Cantidad NVARCHAR(5)
);

CREATE TABLE Prescripciones (
    PrescripcionID INT PRIMARY KEY IDENTITY(1,1),
    CitaID INT,
    MedicamentoID INT,
	FOREIGN KEY (CitaID) REFERENCES Citas(CitaID),
	FOREIGN KEY (MedicamentoID) REFERENCES Medicamentos(MedicamentoID),
);