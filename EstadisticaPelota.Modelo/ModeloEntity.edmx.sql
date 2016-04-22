
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/18/2016 19:44:43
-- Generated from EDMX file: C:\Users\Ing. Luis Humeau\documents\visual studio 2012\Projects\EstadisticaPelota.Modelo\EstadisticaPelota.Modelo\ModeloEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DbEstadistica];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EquipoJugador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugadors] DROP CONSTRAINT [FK_EquipoJugador];
GO
IF OBJECT_ID(N'[dbo].[FK_Juegos_Equipoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Juegos] DROP CONSTRAINT [FK_Juegos_Equipoes];
GO
IF OBJECT_ID(N'[dbo].[FK_Juegos_Equipoes1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Juegos] DROP CONSTRAINT [FK_Juegos_Equipoes1];
GO
IF OBJECT_ID(N'[dbo].[FK_Juegos_Equipoes2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Juegos] DROP CONSTRAINT [FK_Juegos_Equipoes2];
GO
IF OBJECT_ID(N'[dbo].[FK_Jugadors_Liga1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugadors] DROP CONSTRAINT [FK_Jugadors_Liga1];
GO
IF OBJECT_ID(N'[dbo].[FK_Jugadors_Posiciones1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugadors] DROP CONSTRAINT [FK_Jugadors_Posiciones1];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoEstadisticas_Jugadors]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TipoEstadisticas] DROP CONSTRAINT [FK_TipoEstadisticas_Jugadors];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Juegos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Juegos];
GO
IF OBJECT_ID(N'[dbo].[Equipoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Equipoes];
GO
IF OBJECT_ID(N'[dbo].[Jugadors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jugadors];
GO
IF OBJECT_ID(N'[dbo].[Ligas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ligas];
GO
IF OBJECT_ID(N'[dbo].[Posiciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posiciones];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TipoEstadisticas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoEstadisticas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Juegos'
CREATE TABLE [dbo].[Juegos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumeroJuego] nvarchar(max)  NULL,
    [fecha] datetime  NULL,
    [Equipo1] int  NULL,
    [Equipo2] int  NULL,
    [Ganador] int  NULL
);
GO

-- Creating table 'Equipoes'
CREATE TABLE [dbo].[Equipoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Jugadors'
CREATE TABLE [dbo].[Jugadors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Ponche] nvarchar(max)  NOT NULL,
    [Hits] nvarchar(max)  NOT NULL,
    [Carreras] nvarchar(max)  NOT NULL,
    [HomeRun] nvarchar(max)  NOT NULL,
    [EquipoId] int  NULL,
    [PosicionID] int  NULL,
    [ligaID] int  NULL
);
GO

-- Creating table 'Ligas'
CREATE TABLE [dbo].[Ligas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Posiciones'
CREATE TABLE [dbo].[Posiciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [JugadorId] int  NOT NULL
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

-- Creating table 'TipoEstadisticas'
CREATE TABLE [dbo].[TipoEstadisticas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Promedio] nvarchar(max)  NOT NULL,
    [EquipoId] int  NOT NULL,
    [SLG] nvarchar(max)  NOT NULL,
    [JugadorId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [PK_Juegos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Equipoes'
ALTER TABLE [dbo].[Equipoes]
ADD CONSTRAINT [PK_Equipoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jugadors'
ALTER TABLE [dbo].[Jugadors]
ADD CONSTRAINT [PK_Jugadors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ligas'
ALTER TABLE [dbo].[Ligas]
ADD CONSTRAINT [PK_Ligas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posiciones'
ALTER TABLE [dbo].[Posiciones]
ADD CONSTRAINT [PK_Posiciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoEstadisticas'
ALTER TABLE [dbo].[TipoEstadisticas]
ADD CONSTRAINT [PK_TipoEstadisticas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EquipoId] in table 'Jugadors'
ALTER TABLE [dbo].[Jugadors]
ADD CONSTRAINT [FK_EquipoJugador]
    FOREIGN KEY ([EquipoId])
    REFERENCES [dbo].[Equipoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipoJugador'
CREATE INDEX [IX_FK_EquipoJugador]
ON [dbo].[Jugadors]
    ([EquipoId]);
GO

-- Creating foreign key on [Equipo1] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [FK_Juegos_Equipoes]
    FOREIGN KEY ([Equipo1])
    REFERENCES [dbo].[Equipoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Juegos_Equipoes'
CREATE INDEX [IX_FK_Juegos_Equipoes]
ON [dbo].[Juegos]
    ([Equipo1]);
GO

-- Creating foreign key on [Equipo2] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [FK_Juegos_Equipoes1]
    FOREIGN KEY ([Equipo2])
    REFERENCES [dbo].[Equipoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Juegos_Equipoes1'
CREATE INDEX [IX_FK_Juegos_Equipoes1]
ON [dbo].[Juegos]
    ([Equipo2]);
GO

-- Creating foreign key on [Ganador] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [FK_Juegos_Equipoes2]
    FOREIGN KEY ([Ganador])
    REFERENCES [dbo].[Equipoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Juegos_Equipoes2'
CREATE INDEX [IX_FK_Juegos_Equipoes2]
ON [dbo].[Juegos]
    ([Ganador]);
GO

-- Creating foreign key on [ligaID] in table 'Jugadors'
ALTER TABLE [dbo].[Jugadors]
ADD CONSTRAINT [FK_Jugadors_Liga1]
    FOREIGN KEY ([ligaID])
    REFERENCES [dbo].[Ligas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Jugadors_Liga1'
CREATE INDEX [IX_FK_Jugadors_Liga1]
ON [dbo].[Jugadors]
    ([ligaID]);
GO

-- Creating foreign key on [PosicionID] in table 'Jugadors'
ALTER TABLE [dbo].[Jugadors]
ADD CONSTRAINT [FK_Jugadors_Posiciones1]
    FOREIGN KEY ([PosicionID])
    REFERENCES [dbo].[Posiciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Jugadors_Posiciones1'
CREATE INDEX [IX_FK_Jugadors_Posiciones1]
ON [dbo].[Jugadors]
    ([PosicionID]);
GO

-- Creating foreign key on [JugadorId] in table 'TipoEstadisticas'
ALTER TABLE [dbo].[TipoEstadisticas]
ADD CONSTRAINT [FK_TipoEstadisticas_Jugadors]
    FOREIGN KEY ([JugadorId])
    REFERENCES [dbo].[Jugadors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoEstadisticas_Jugadors'
CREATE INDEX [IX_FK_TipoEstadisticas_Jugadors]
ON [dbo].[TipoEstadisticas]
    ([JugadorId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------