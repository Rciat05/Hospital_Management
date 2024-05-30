-- FALTAN POR HACER ESTOS, SOLO ESTAN PEGADOS

-- Procedimiento para insertar un nuevo paciente
CREATE PROCEDURE spPaciente_Insert
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @FechaNacimiento DATE,
    @Sexo NVARCHAR(10),
    @Telefono NVARCHAR(15),
    @Email NVARCHAR(100),
    @FechaRegistro DATETIME
AS
BEGIN
    INSERT INTO Pacientes (NombrePaciente, ApellidoPaciente, FechaNacimiento, Sexo, Telefono, Email, FechaRegistro)
    VALUES (@Nombre, @Apellido, @FechaNacimiento, @Sexo, @Telefono, @Email, @FechaRegistro)
END;

-- Procedimiento para actualizar información de un paciente
CREATE PROCEDURE spPaciente_Update
    @PacienteID INT,
    @Nombre NVARCHAR(100),
    @Apellido NVARCHAR(100),
    @FechaNacimiento DATE,
    @Sexo NVARCHAR(10),
    @Telefono NVARCHAR(15),
    @Email NVARCHAR(100),
    @FechaRegistro DATETIME
AS
BEGIN
    UPDATE Pacientes
    SET NombrePaciente = @Nombre,
        ApellidoPaciente = @Apellido,
        FechaNacimiento = @FechaNacimiento,
        Sexo = @Sexo,
        Telefono = @Telefono,
        Email = @Email,
        FechaRegistro = @FechaRegistro
    WHERE PacienteID = @PacienteID
END;

-- Procedimiento para eliminar un paciente
CREATE PROCEDURE spPaciente_Delete
    @PacienteID INT
AS
BEGIN
    DELETE FROM Pacientes
    WHERE PacienteID = @PacienteID
END;

-- Procedimiento para obtener información de un paciente por su ID
CREATE PROCEDURE spPaciente_GetByID
    @PacienteID INT
AS
BEGIN
    SELECT *
    FROM Pacientes
    WHERE PacienteID = @PacienteID
END;

-- Procedimiento para obtener información de todos los pacientes
CREATE PROCEDURE spPaciente_GetAll
AS
BEGIN
    SELECT *
    FROM Pacientes
END;



--TODAVIA NO SE HACE
--ATENTOS
--LEAN TARADOS.



-- Procedimiento para insertar una nueva cita
CREATE PROCEDURE spCita_Insert
    @PacienteID INT,
    @DoctorID INT,
    @FechaCita DATETIME,
    @MotivoCita NVARCHAR(200),
    @EstadoCitas NVARCHAR(1)
AS
BEGIN
    INSERT INTO Citas (PacienteID, DoctorID, FechaCita, MotivoCita, EstadoCitas)
    VALUES (@PacienteID, @DoctorID, @FechaCita, @MotivoCita, @EstadoCitas)
END;
DROP PROCEDURE spCita_Insert

-- Procedimiento para actualizar información de una cita
CREATE PROCEDURE ActualizarCita
    @CitaID INT,
    @PacienteID INT,
    @DoctorID INT,
    @FechaCita DATETIME,
    @MotivoCita NVARCHAR(200),
    @EstadoCitas NVARCHAR(1)
AS
BEGIN
    UPDATE Citas
    SET PacienteID = @PacienteID,
        DoctorID = @DoctorID,
        FechaCita = @FechaCita,
        MotivoCita = @MotivoCita,
        EstadoCitas = @EstadoCitas
    WHERE CitaID = @CitaID
END;

-- Procedimiento para eliminar una cita
CREATE PROCEDURE EliminarCita
    @CitaID INT
AS
BEGIN
    DELETE FROM Citas
    WHERE CitaID = @CitaID
END;

-- Procedimiento para obtener información de una cita por su ID
CREATE PROCEDURE ObtenerCitaPorID
    @CitaID INT
AS
BEGIN
    SELECT *
    FROM Citas
    WHERE CitaID = @CitaID
END;
