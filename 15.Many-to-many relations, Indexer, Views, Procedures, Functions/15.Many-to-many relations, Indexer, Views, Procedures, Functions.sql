CREATE DATABASE CompanyMM;

USE CompanyMM;
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE,
    Email NVARCHAR(100) UNIQUE,
    CHECK (BirthDate < GETDATE()) 
);


CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY IDENTITY(1,1),
    ProjectName NVARCHAR(100) NOT NULL,
    StartDate DATE,
    EndDate DATE,
    CHECK (EndDate IS NULL OR EndDate >= StartDate) 
);


CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    AssignedDate DATE DEFAULT GETDATE(),

    PRIMARY KEY (EmployeeID, ProjectID),

    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
);

INSERT INTO Employees (FirstName, LastName, BirthDate, Email)
VALUES 
('Ali', 'Mammadov', '1990-05-10', 'ali@mail.com'),
('Aysel', 'Aliyeva', '1992-07-15', 'aysel@mail.com'),
('Rashad', 'Huseynov', '1988-03-22', 'rashad@mail.com'),
('Nigar', 'Karimova', '1995-11-30', 'nigar@mail.com'),
('Tural', 'Ismayilov', '1991-09-05', 'tural@mail.com');


INSERT INTO Projects (ProjectName, StartDate, EndDate)
VALUES
('ERP System', '2024-01-01', '2024-12-31'),
('Mobile App', '2024-03-01', NULL),
('Website Redesign', '2024-02-01', '2024-08-01');


INSERT INTO EmployeeProjects (EmployeeID, ProjectID)
VALUES
(1,1),(1,2),
(2,1),
(3,1),(3,2),(3,3),
(4,3),
(5,2);

SELECT * FROM Employees;


SELECT * FROM Projects;


SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    p.ProjectName
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;


SELECT 
    p.ProjectName,
    COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectName;


SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(ep.ProjectID) > 2;

CREATE VIEW EmployeeProjectView AS
SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    p.ProjectID,
    p.ProjectName,
    ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;


SELECT * 
FROM EmployeeProjectView
WHERE EmployeeID = 1;


CREATE PROCEDURE sp_AssignEmployeeToProject
    @empId INT,
    @projId INT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 
        FROM EmployeeProjects
        WHERE EmployeeID = @empId AND ProjectID = @projId
    )
    BEGIN
        INSERT INTO EmployeeProjects (EmployeeID, ProjectID)
        VALUES (@empId, @projId);
    END
END;


CREATE FUNCTION fn_GetProjectCount (@empId INT)
RETURNS INT
AS
BEGIN
    DECLARE @count INT;

    SELECT @count = COUNT(*)
    FROM EmployeeProjects
    WHERE EmployeeID = @empId;

    RETURN @count;
END;

SELECT dbo.fn_GetProjectCount(3) AS ProjectCount;


EXEC sp_AssignEmployeeToProject @empId = 2, @projId = 2;


SELECT * FROM EmployeeProjects WHERE EmployeeID = 2;


DELETE FROM EmployeeProjects
WHERE EmployeeID = 4;


SELECT * FROM EmployeeProjects WHERE EmployeeID = 4;