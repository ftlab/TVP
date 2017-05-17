CREATE TABLE [dbo].[Order] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [PersonId] INT          NOT NULL,
    [Sum]      FLOAT (53)   NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Order_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

