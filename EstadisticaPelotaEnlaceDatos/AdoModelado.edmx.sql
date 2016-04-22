
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/20/2016 10:40:30
-- Generated from EDMX file: K:\EstadisticaPelota.Modelo\EstadisticaPelotaEnlaceDatos\AdoModelado.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbestadistica];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EquipoJugador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugadores] DROP CONSTRAINT [FK_EquipoJugador];
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
IF OBJECT_ID(N'[dbo].[FK_Jugadors_Liga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugadores] DROP CONSTRAINT [FK_Jugadors_Liga];
GO
IF OBJECT_ID(N'[dbo].[FK_Jugadors_Posiciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jugadores] DROP CONSTRAINT [FK_Jugadors_Posiciones];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoEstadistica_Jugadors]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TipoEstadisticas] DROP CONSTRAINT [FK_TipoEstadistica_Jugadors];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Equipos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Equipos];
GO
IF OBJECT_ID(N'[dbo].[Juegos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Juegos];
GO
IF OBJECT_ID(N'[dbo].[Jugadores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jugadores];
GO
IF OBJECT_ID(N'[dbo].[Ligas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ligas];
GO
IF OBJECT_ID(N'[dbo].[Posiciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Posiciones];
GO
IF OBJECT_ID(N'[dbo].[TipoEstadisticas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoEstadisticas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Equipos'
CREATE TABLE [dbo].[Equipos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

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

-- Creating table 'Jugadores'
CREATE TABLE [dbo].[Jugadores] (
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

-- Creating table 'Posiciones'
CREATE TABLE [dbo].[Posiciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TipoEstadisticas'
CREATE TABLE [dbo].[TipoEstadisticas] (
    [Id] int  NOT NULL,
    [Promedio] float  NULL,
    [SLG] float  NULL,
    [JugadorID] int  NULL
);
GO

-- Creating table 'Ligas'
CREATE TABLE [dbo].[Ligas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [tipo] nvarchar(max)  NOT NULL,
    [JugadoresId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Equipos'
ALTER TABLE [dbo].[Equipos]
ADD CONSTRAINT [PK_Equipos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [PK_Juegos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jugadores'
ALTER TABLE [dbo].[Jugadores]
ADD CONSTRAINT [PK_Jugadores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Posiciones'
ALTER TABLE [dbo].[Posiciones]
ADD CONSTRAINT [PK_Posiciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoEstadisticas'
ALTER TABLE [dbo].[TipoEstadisticas]
ADD CONSTRAINT [PK_TipoEstadisticas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ligas'
ALTER TABLE [dbo].[Ligas]
ADD CONSTRAINT [PK_Ligas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EquipoId] in table 'Jugadores'
ALTER TABLE [dbo].[Jugadores]
ADD CONSTRAINT [FK_EquipoJugador]
    FOREIGN KEY ([EquipoId])
    REFERENCES [dbo].[Equipos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipoJugador'
CREATE INDEX [IX_FK_EquipoJugador]
ON [dbo].[Jugadores]
    ([EquipoId]);
GO

-- Creating foreign key on [Equipo1] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [FK_Juegos_Equipoes]
    FOREIGN KEY ([Equipo1])
    REFERENCES [dbo].[Equipos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Juegos_Equipoes'
CREATE INDEX [IX_FK_Juegos_Equipoes]
ON [dbo].[Juegos]
    ([Equipo1]);
GO

-- Creating foreign key on [Equipo2] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [FK_Juegos_Equipoes1]
    FOREIGN KEY ([Equipo2])
    REFERENCES [dbo].[Equipos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Juegos_Equipoes1'
CREATE INDEX [IX_FK_Juegos_Equipoes1]
ON [dbo].[Juegos]
    ([Equipo2]);
GO

-- Creating foreign key on [Ganador] in table 'Juegos'
ALTER TABLE [dbo].[Juegos]
ADD CONSTRAINT [FK_Juegos_Equipoes2]
    FOREIGN KEY ([Ganador])
    REFERENCES [dbo].[Equipos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Juegos_Equipoes2'
CREATE INDEX [IX_FK_Juegos_Equipoes2]
ON [dbo].[Juegos]
    ([Ganador]);
GO

-- Creating foreign key on [PosicionID] in table 'Jugadores'
ALTER TABLE [dbo].[Jugadores]
ADD CONSTRAINT [FK_Jugadors_Posiciones]
    FOREIGN KEY ([PosicionID])
    REFERENCES [dbo].[Posiciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Jugadors_Posiciones'
CREATE INDEX [IX_FK_Jugadors_Posiciones]
ON [dbo].[Jugadores]
    ([PosicionID]);
GO

-- Creating foreign key on [JugadorID] in table 'TipoEstadisticas'
ALTER TABLE [dbo].[TipoEstadisticas]
ADD CONSTRAINT [FK_TipoEstadistica_Jugadors]
    FOREIGN KEY ([JugadorID])
    REFERENCES [dbo].[Jugadores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoEstadistica_Jugadors'
CREATE INDEX [IX_FK_TipoEstadistica_Jugadors]
ON [dbo].[TipoEstadisticas]
    ([JugadorID]);
GO

-- Creating foreign key on [JugadoresId] in table 'Ligas'
ALTER TABLE [dbo].[Ligas]
ADD CONSTRAINT [FK_JugadoresLiga]
    FOREIGN KEY ([JugadoresId])
    REFERENCES [dbo].[Jugadores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadoresLiga'
CREATE INDEX [IX_FK_JugadoresLiga]
ON [dbo].[Ligas]
    ([JugadoresId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------