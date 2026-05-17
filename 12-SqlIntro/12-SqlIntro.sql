TRUNCATE TABLE Employees;
CREATE DATABASE Company;
USE Company;
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    HireDate DATE,
    JobTitle NVARCHAR(50),
    Salary DECIMAL(10,2),
    Department NVARCHAR(50)
)

INSERT INTO Employees (FirstName, LastName, Email, PhoneNumber, HireDate, JobTitle, Salary, Department)
VALUES 
('Leyla', 'Hesenova', 'leyla@company.az', '050-111-22-33', '2019-05-15', 'HR Mütexessisi', 1800.00, 'HR'),
('Eli', 'Memmedov', 'ali.m@company.az', '051-222-33-44', '2021-03-10', 'Senior Developer', 3200.00, 'IT'),
('Aysel', 'Eliyeva', 'aysel@test.com', '055-333-44-55', '2022-08-20', 'Mühasib', 2100.00, 'Maliyye'),
('Vüqar', 'Qasımov', 'vuqar@company.az', '070-444-55-66', '2023-01-10', 'Data Analitik', 2300.00, 'IT'),
('Orxan', 'Rüstemov', 'orxan@mail.ru', '077-555-66-77', '2018-11-25', 'Ofis Meneceri', 1200.00, 'İnzibati'),
('Nermin', 'Quliyeva', 'nermin@company.az', '050-666-77-88', '2020-07-01', 'Satış Temsilcisi', 1450.00, 'Satıs');
select * from Employees
select * from Employees where Salary>2000
select * from Employees where Department='IT'
select * from Employees order by Salary desc
select FirstName,Salary from Employees
select * from Employees where year(HireDate)>2020
select * from Employees where Email like '%company.az%'
select max(Salary) as MaxSalary from Employees
select min(Salary) as MinSalary from Employees
select avg(Salary) as AvgSalary from Employees
select count(*) as CountEmployees from Employees
select sum(Salary) as SumSalary from Employees
select Department,count (*) as EmpCount from Employees group by Department
select Department,Avg(Salary)as AvgSalary from Employees group by Department
select Department,max(Salary) as MaxSalary from Employees group by Department
update Employees set Salary=2800 where EmployeeID=1
update Employees set Salary=Salary*1.10 where Department='IT'
update Employees set JobTitle='HR Meneceri' where FirstName='Leyla' and LastName='Hesenova'
delete from Employees where EmployeeID=5
delete from Employees where Salary<1500
select * from Employees where Salary between 2000 and 2500
select * from Employees where Department in ('Maliyye','IT')