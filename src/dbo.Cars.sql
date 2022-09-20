CREATE TABLE [dbo].[Cars] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [NumberCar] NVARCHAR (MAX) NOT NULL,
    [DateTime]  DATETIME2 (7)  NOT NULL,
    [IdCamer]   INT            NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

