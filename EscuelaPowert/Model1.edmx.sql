
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2020 10:31:46
-- Generated from EDMX file: C:\Users\Roberto\source\repos\EscuelaV23\EscuelaPowert\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Escuela];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Actividad__ID_Ac__5070F446]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Actividades] DROP CONSTRAINT [FK__Actividad__ID_Ac__5070F446];
GO
IF OBJECT_ID(N'[dbo].[FK__Actividad__ID_Cl__4F7CD00D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Actividades] DROP CONSTRAINT [FK__Actividad__ID_Cl__4F7CD00D];
GO
IF OBJECT_ID(N'[dbo].[FK__Alumnos__ID_Grup__47DBAE45]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alumnos] DROP CONSTRAINT [FK__Alumnos__ID_Grup__47DBAE45];
GO
IF OBJECT_ID(N'[dbo].[FK__Asistenci__ID_Al__5441852A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Asistencia] DROP CONSTRAINT [FK__Asistenci__ID_Al__5441852A];
GO
IF OBJECT_ID(N'[dbo].[FK__Asistenci__ID_Cl__5535A963]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Asistencia] DROP CONSTRAINT [FK__Asistenci__ID_Cl__5535A963];
GO
IF OBJECT_ID(N'[dbo].[FK__Clase__ID_Grupo__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clase] DROP CONSTRAINT [FK__Clase__ID_Grupo__4AB81AF0];
GO
IF OBJECT_ID(N'[dbo].[FK__Evaluacio__ID_Al__5812160E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluacion] DROP CONSTRAINT [FK__Evaluacio__ID_Al__5812160E];
GO
IF OBJECT_ID(N'[dbo].[FK__Grupo__ID_Ciclo__3F466844]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grupo] DROP CONSTRAINT [FK__Grupo__ID_Ciclo__3F466844];
GO
IF OBJECT_ID(N'[dbo].[FK__Grupo_Inf__ID_Gr__440B1D61]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grupo_Info] DROP CONSTRAINT [FK__Grupo_Inf__ID_Gr__440B1D61];
GO
IF OBJECT_ID(N'[dbo].[FK__Grupo_Inf__ID_Pr__44FF419A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Grupo_Info] DROP CONSTRAINT [FK__Grupo_Inf__ID_Pr__44FF419A];
GO
IF OBJECT_ID(N'[dbo].[FK__Materias__ID_Pla__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Materias] DROP CONSTRAINT [FK__Materias__ID_Pla__3C69FB99];
GO
IF OBJECT_ID(N'[dbo].[FK__Plan_Estu__ID_Ci__398D8EEE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Plan_Estudio] DROP CONSTRAINT [FK__Plan_Estu__ID_Ci__398D8EEE];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Actividades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Actividades];
GO
IF OBJECT_ID(N'[dbo].[Alumnos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alumnos];
GO
IF OBJECT_ID(N'[dbo].[Asistencia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Asistencia];
GO
IF OBJECT_ID(N'[dbo].[Ciclo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ciclo];
GO
IF OBJECT_ID(N'[dbo].[Clase]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clase];
GO
IF OBJECT_ID(N'[dbo].[Evaluacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Evaluacion];
GO
IF OBJECT_ID(N'[dbo].[Grupo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grupo];
GO
IF OBJECT_ID(N'[dbo].[Grupo_Info]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grupo_Info];
GO
IF OBJECT_ID(N'[dbo].[Materias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materias];
GO
IF OBJECT_ID(N'[dbo].[Plan_Estudio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Plan_Estudio];
GO
IF OBJECT_ID(N'[dbo].[Profesor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profesor];
GO
IF OBJECT_ID(N'[dbo].[Tipo_Actividad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_Actividad];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Actividades'
CREATE TABLE [dbo].[Actividades] (
    [Actividades_ID] int IDENTITY(1,1) NOT NULL,
    [Actividades_Nombre] varchar(30)  NOT NULL,
    [ID_Clase] int  NOT NULL,
    [Actividad_Descripcion] varchar(300)  NULL,
    [ID_Actividad] int  NOT NULL
);
GO

-- Creating table 'Alumnos'
CREATE TABLE [dbo].[Alumnos] (
    [Alumno_ID] int IDENTITY(1,1) NOT NULL,
    [Alumno_Control] int  NOT NULL,
    [Alumno_Nombre] varchar(30)  NOT NULL,
    [Alumno_Apellido] varchar(40)  NOT NULL,
    [Alumno_Grupo] int  NOT NULL,
    [Alumno_Estado] bit  NOT NULL,
    [ID_Grupo] int  NOT NULL
);
GO

-- Creating table 'Asistencia'
CREATE TABLE [dbo].[Asistencia] (
    [Asistencia_ID] int IDENTITY(1,1) NOT NULL,
    [Asistencia_Fecha] datetime  NOT NULL,
    [ID_Alumno] int  NOT NULL,
    [ID_Clase] int  NOT NULL
);
GO

-- Creating table 'Ciclo'
CREATE TABLE [dbo].[Ciclo] (
    [Ciclo_ID] int IDENTITY(1,1) NOT NULL,
    [Ciclo_Ano] datetime  NOT NULL
);
GO

-- Creating table 'Clase'
CREATE TABLE [dbo].[Clase] (
    [Clase_ID] int IDENTITY(1,1) NOT NULL,
    [ID_Grupo] int  NOT NULL
);
GO

-- Creating table 'Grupo'
CREATE TABLE [dbo].[Grupo] (
    [Grupo_ID] int IDENTITY(1,1) NOT NULL,
    [Grupo_Nombre] varchar(30)  NOT NULL,
    [ID_Ciclo] int  NOT NULL
);
GO

-- Creating table 'Materias'
CREATE TABLE [dbo].[Materias] (
    [Materia_ID] int IDENTITY(1,1) NOT NULL,
    [Materia_Nombre] varchar(30)  NOT NULL,
    [ID_Plan] int  NOT NULL
);
GO

-- Creating table 'Plan_Estudio'
CREATE TABLE [dbo].[Plan_Estudio] (
    [Plan_ID] int IDENTITY(1,1) NOT NULL,
    [ID_Ciclo] int  NOT NULL
);
GO

-- Creating table 'Profesor'
CREATE TABLE [dbo].[Profesor] (
    [Profesor_ID] int IDENTITY(1,1) NOT NULL,
    [Profesor_Nombre] varchar(30)  NOT NULL,
    [ID_Grupo] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Evaluacion'
CREATE TABLE [dbo].[Evaluacion] (
    [Evalucacion_ID] int IDENTITY(1,1) NOT NULL,
    [Evalucacion_Total] int  NOT NULL,
    [ID_Alumno] int  NOT NULL
);
GO

-- Creating table 'Grupo_Info'
CREATE TABLE [dbo].[Grupo_Info] (
    [Info_ID] int IDENTITY(1,1) NOT NULL,
    [ID_Grupo] int  NOT NULL,
    [ID_Profesor] int  NOT NULL
);
GO

-- Creating table 'Tipo_Actividad'
CREATE TABLE [dbo].[Tipo_Actividad] (
    [Actividad_ID] int IDENTITY(1,1) NOT NULL,
    [Actividad_Nombre] varchar(20)  NOT NULL,
    [Actividad_Porcentaje] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Actividades_ID] in table 'Actividades'
ALTER TABLE [dbo].[Actividades]
ADD CONSTRAINT [PK_Actividades]
    PRIMARY KEY CLUSTERED ([Actividades_ID] ASC);
GO

-- Creating primary key on [Alumno_ID] in table 'Alumnos'
ALTER TABLE [dbo].[Alumnos]
ADD CONSTRAINT [PK_Alumnos]
    PRIMARY KEY CLUSTERED ([Alumno_ID] ASC);
GO

-- Creating primary key on [Asistencia_ID] in table 'Asistencia'
ALTER TABLE [dbo].[Asistencia]
ADD CONSTRAINT [PK_Asistencia]
    PRIMARY KEY CLUSTERED ([Asistencia_ID] ASC);
GO

-- Creating primary key on [Ciclo_ID] in table 'Ciclo'
ALTER TABLE [dbo].[Ciclo]
ADD CONSTRAINT [PK_Ciclo]
    PRIMARY KEY CLUSTERED ([Ciclo_ID] ASC);
GO

-- Creating primary key on [Clase_ID] in table 'Clase'
ALTER TABLE [dbo].[Clase]
ADD CONSTRAINT [PK_Clase]
    PRIMARY KEY CLUSTERED ([Clase_ID] ASC);
GO

-- Creating primary key on [Grupo_ID] in table 'Grupo'
ALTER TABLE [dbo].[Grupo]
ADD CONSTRAINT [PK_Grupo]
    PRIMARY KEY CLUSTERED ([Grupo_ID] ASC);
GO

-- Creating primary key on [Materia_ID] in table 'Materias'
ALTER TABLE [dbo].[Materias]
ADD CONSTRAINT [PK_Materias]
    PRIMARY KEY CLUSTERED ([Materia_ID] ASC);
GO

-- Creating primary key on [Plan_ID] in table 'Plan_Estudio'
ALTER TABLE [dbo].[Plan_Estudio]
ADD CONSTRAINT [PK_Plan_Estudio]
    PRIMARY KEY CLUSTERED ([Plan_ID] ASC);
GO

-- Creating primary key on [Profesor_ID] in table 'Profesor'
ALTER TABLE [dbo].[Profesor]
ADD CONSTRAINT [PK_Profesor]
    PRIMARY KEY CLUSTERED ([Profesor_ID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Evalucacion_ID] in table 'Evaluacion'
ALTER TABLE [dbo].[Evaluacion]
ADD CONSTRAINT [PK_Evaluacion]
    PRIMARY KEY CLUSTERED ([Evalucacion_ID] ASC);
GO

-- Creating primary key on [Info_ID] in table 'Grupo_Info'
ALTER TABLE [dbo].[Grupo_Info]
ADD CONSTRAINT [PK_Grupo_Info]
    PRIMARY KEY CLUSTERED ([Info_ID] ASC);
GO

-- Creating primary key on [Actividad_ID] in table 'Tipo_Actividad'
ALTER TABLE [dbo].[Tipo_Actividad]
ADD CONSTRAINT [PK_Tipo_Actividad]
    PRIMARY KEY CLUSTERED ([Actividad_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_Clase] in table 'Actividades'
ALTER TABLE [dbo].[Actividades]
ADD CONSTRAINT [FK__Actividad__ID_Cl__4AB81AF0]
    FOREIGN KEY ([ID_Clase])
    REFERENCES [dbo].[Clase]
        ([Clase_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Actividad__ID_Cl__4AB81AF0'
CREATE INDEX [IX_FK__Actividad__ID_Cl__4AB81AF0]
ON [dbo].[Actividades]
    ([ID_Clase]);
GO

-- Creating foreign key on [ID_Grupo] in table 'Alumnos'
ALTER TABLE [dbo].[Alumnos]
ADD CONSTRAINT [FK__Alumnos__ID_Grup__44FF419A]
    FOREIGN KEY ([ID_Grupo])
    REFERENCES [dbo].[Grupo]
        ([Grupo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Alumnos__ID_Grup__44FF419A'
CREATE INDEX [IX_FK__Alumnos__ID_Grup__44FF419A]
ON [dbo].[Alumnos]
    ([ID_Grupo]);
GO

-- Creating foreign key on [ID_Clase] in table 'Asistencia'
ALTER TABLE [dbo].[Asistencia]
ADD CONSTRAINT [FK__Asistenci__ID_Cl__4D94879B]
    FOREIGN KEY ([ID_Clase])
    REFERENCES [dbo].[Clase]
        ([Clase_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Asistenci__ID_Cl__4D94879B'
CREATE INDEX [IX_FK__Asistenci__ID_Cl__4D94879B]
ON [dbo].[Asistencia]
    ([ID_Clase]);
GO

-- Creating foreign key on [ID_Ciclo] in table 'Grupo'
ALTER TABLE [dbo].[Grupo]
ADD CONSTRAINT [FK__Grupo__ID_Ciclo__3F466844]
    FOREIGN KEY ([ID_Ciclo])
    REFERENCES [dbo].[Ciclo]
        ([Ciclo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Grupo__ID_Ciclo__3F466844'
CREATE INDEX [IX_FK__Grupo__ID_Ciclo__3F466844]
ON [dbo].[Grupo]
    ([ID_Ciclo]);
GO

-- Creating foreign key on [ID_Ciclo] in table 'Plan_Estudio'
ALTER TABLE [dbo].[Plan_Estudio]
ADD CONSTRAINT [FK__Plan_Estu__ID_Ci__398D8EEE]
    FOREIGN KEY ([ID_Ciclo])
    REFERENCES [dbo].[Ciclo]
        ([Ciclo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Plan_Estu__ID_Ci__398D8EEE'
CREATE INDEX [IX_FK__Plan_Estu__ID_Ci__398D8EEE]
ON [dbo].[Plan_Estudio]
    ([ID_Ciclo]);
GO

-- Creating foreign key on [ID_Grupo] in table 'Clase'
ALTER TABLE [dbo].[Clase]
ADD CONSTRAINT [FK__Clase__ID_Grupo__47DBAE45]
    FOREIGN KEY ([ID_Grupo])
    REFERENCES [dbo].[Grupo]
        ([Grupo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Clase__ID_Grupo__47DBAE45'
CREATE INDEX [IX_FK__Clase__ID_Grupo__47DBAE45]
ON [dbo].[Clase]
    ([ID_Grupo]);
GO

-- Creating foreign key on [ID_Grupo] in table 'Profesor'
ALTER TABLE [dbo].[Profesor]
ADD CONSTRAINT [FK__Profesor__ID_Gru__4222D4EF]
    FOREIGN KEY ([ID_Grupo])
    REFERENCES [dbo].[Grupo]
        ([Grupo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Profesor__ID_Gru__4222D4EF'
CREATE INDEX [IX_FK__Profesor__ID_Gru__4222D4EF]
ON [dbo].[Profesor]
    ([ID_Grupo]);
GO

-- Creating foreign key on [ID_Plan] in table 'Materias'
ALTER TABLE [dbo].[Materias]
ADD CONSTRAINT [FK__Materias__ID_Pla__3C69FB99]
    FOREIGN KEY ([ID_Plan])
    REFERENCES [dbo].[Plan_Estudio]
        ([Plan_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Materias__ID_Pla__3C69FB99'
CREATE INDEX [IX_FK__Materias__ID_Pla__3C69FB99]
ON [dbo].[Materias]
    ([ID_Plan]);
GO

-- Creating foreign key on [ID_Alumno] in table 'Asistencia'
ALTER TABLE [dbo].[Asistencia]
ADD CONSTRAINT [FK__Asistenci__ID_Al__534D60F1]
    FOREIGN KEY ([ID_Alumno])
    REFERENCES [dbo].[Alumnos]
        ([Alumno_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Asistenci__ID_Al__534D60F1'
CREATE INDEX [IX_FK__Asistenci__ID_Al__534D60F1]
ON [dbo].[Asistencia]
    ([ID_Alumno]);
GO

-- Creating foreign key on [ID_Actividad] in table 'Actividades'
ALTER TABLE [dbo].[Actividades]
ADD CONSTRAINT [FK__Actividad__ID_Ac__5070F446]
    FOREIGN KEY ([ID_Actividad])
    REFERENCES [dbo].[Tipo_Actividad]
        ([Actividad_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Actividad__ID_Ac__5070F446'
CREATE INDEX [IX_FK__Actividad__ID_Ac__5070F446]
ON [dbo].[Actividades]
    ([ID_Actividad]);
GO

-- Creating foreign key on [ID_Alumno] in table 'Evaluacion'
ALTER TABLE [dbo].[Evaluacion]
ADD CONSTRAINT [FK__Evaluacio__ID_Al__571DF1D5]
    FOREIGN KEY ([ID_Alumno])
    REFERENCES [dbo].[Alumnos]
        ([Alumno_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Evaluacio__ID_Al__571DF1D5'
CREATE INDEX [IX_FK__Evaluacio__ID_Al__571DF1D5]
ON [dbo].[Evaluacion]
    ([ID_Alumno]);
GO

-- Creating foreign key on [ID_Grupo] in table 'Grupo_Info'
ALTER TABLE [dbo].[Grupo_Info]
ADD CONSTRAINT [FK__Grupo_Inf__ID_Gr__440B1D61]
    FOREIGN KEY ([ID_Grupo])
    REFERENCES [dbo].[Grupo]
        ([Grupo_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Grupo_Inf__ID_Gr__440B1D61'
CREATE INDEX [IX_FK__Grupo_Inf__ID_Gr__440B1D61]
ON [dbo].[Grupo_Info]
    ([ID_Grupo]);
GO

-- Creating foreign key on [ID_Profesor] in table 'Grupo_Info'
ALTER TABLE [dbo].[Grupo_Info]
ADD CONSTRAINT [FK__Grupo_Inf__ID_Pr__44FF419A]
    FOREIGN KEY ([ID_Profesor])
    REFERENCES [dbo].[Profesor]
        ([Profesor_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Grupo_Inf__ID_Pr__44FF419A'
CREATE INDEX [IX_FK__Grupo_Inf__ID_Pr__44FF419A]
ON [dbo].[Grupo_Info]
    ([ID_Profesor]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------