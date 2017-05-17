CREATE TABLE [dbo].[Person] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    [CountryId] INT          NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Person_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id])
);

