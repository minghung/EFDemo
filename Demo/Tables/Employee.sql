CREATE TABLE [dbo].[Employee]
(
	EmployeeId			INT NOT NULL IDENTITY(1,1),
	Title				INT NOT NULL,
	Name				VARCHAR(50) NOT NULL,
	ManagerEmployeeId	INT NULL,

    CONSTRAINT PK_Employee PRIMARY KEY (EmployeeId)
)
