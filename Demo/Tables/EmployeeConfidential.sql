CREATE TABLE [dbo].[EmployeeConfidential]
(
	EmployeeId		INT NOT NULL,
	Salary			MONEY NOT NULL,
	Phone			VARCHAR(20) NULL, 

    CONSTRAINT PK_EmployeeConfidential PRIMARY KEY (EmployeeId), 
    CONSTRAINT [FK_EmployeeConfidential_Employee] FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
)
