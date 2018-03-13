CREATE TABLE [dbo].[Project]
(
	ProjectId		INT NOT NULL,
	Name			VARCHAR(100) NOT NULL,
	ProjectStatusId	INT NOT NULL, 

    CONSTRAINT PK_Project PRIMARY KEY (ProjectId), 
    CONSTRAINT FK_Project_ProjectStatus FOREIGN KEY (ProjectStatusId) REFERENCES ProjectStatus(ProjectStatusId)
)
