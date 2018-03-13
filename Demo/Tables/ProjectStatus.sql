CREATE TABLE [dbo].[ProjectStatus]
(
	[ProjectStatusId]	INT NOT NULL,
	[Description]		VARCHAR(100) NOT NULL, 

    CONSTRAINT [PK_ProjectStatus] PRIMARY KEY ([ProjectStatusId])
)
