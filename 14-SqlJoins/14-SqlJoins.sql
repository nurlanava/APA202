USE Company;

DROP TABLE IF EXISTS Employees;
DROP TABLE IF EXISTS Cities;
DROP TABLE IF EXISTS Countries;


CREATE DATABASE Company
USE Company
CREATE TABLE Countries (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50)
)
CREATE TABLE Cities (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    CountryId INT,
    FOREIGN KEY (CountryId) REFERENCES Countries(Id)
);
CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Age INT,
    Salary DECIMAL(10,2),
    Position NVARCHAR(50),
    IsDeleted BIT DEFAULT 0,
    CityId INT,
    FOREIGN KEY (CityId) REFERENCES Cities(Id)
);

INSERT INTO Countries (Name)
VALUES ('Azerbaijan'), ('Turkey');

INSERT INTO Cities (Name, CountryId)
VALUES ('Baku', 1),
       ('Ganja', 1),
       ('Istanbul', 2);

INSERT INTO Employees (Name, Surname, Age, Salary, Position, IsDeleted, CityId)
VALUES 
('Ali', 'Aliyev', 25, 2500, 'Developer', 0, 1),
('Veli', 'Veliev', 30, 1800, 'Reseption', 0, 2),
('Ayse', 'Demir', 28, 3000, 'Manager', 0, 3),
('Mehmet', 'Kaya', 35, 1500, 'Reseption', 1, 3);

SELECT e.Name, e.Surname, c.Name AS City, co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id;

SELECT e.Name, co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.Salary > 2000;

SELECT c.Name AS City, co.Name AS Country
FROM Cities c
JOIN Countries co ON c.CountryId = co.Id;

SELECT Name, Surname, Age, Salary, Position, IsDeleted, CityId
FROM Employees
WHERE Position = 'Reseption';

SELECT e.Name, e.Surname, c.Name AS City, co.Name AS Country
FROM Employees e
JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id
WHERE e.IsDeleted = 1;