create database EmpDBAsh

Create table EmpInfo
(
EmpId int Primary Key Identity, 
EmpFName nvarchar(150),
EmpLName nvarchar(100),
Department nvarchar(100),
Project nvarchar(150),
EmpAddress nvarchar(300),
DOB datetime,
Gender varchar(30),
);

Create table EmpPosition
(
EmpId int Foreign Key references EmpInfo(EmpId), 
Designation nvarchar(150),
Date_of_Joining datetime(),
Salary int,
);

Insert into EmpInfo (EmpFName, EmpLName, Department, Project, EmpAddress, DOB, Gender) values ('Sam', 'Mathew' , 'HR', 'Testing', 'AL Street Melbourne', '1982-02-14','Male')
Insert into EmpInfo (EmpFName, EmpLName, Department, Project, EmpAddress, DOB, Gender) values ('Ann', 'Marry' , 'QA', 'MIS', 'Washington Road', '1972-08-14','Female')
Insert into EmpInfo (EmpFName, EmpLName, Department, Project, EmpAddress, DOB, Gender) values ('Jacob', 'Pitt' , 'HR', 'MIS', 'Down Town', '1985-10-12','Male')
Insert into EmpInfo (EmpFName, EmpLName, Department, Project, EmpAddress, DOB, Gender) values ('Smith', 'Warner' , 'HQ', 'Dotnet', 'Hilton cliffary', '1988-03-19','Male')
Insert into EmpInfo (EmpFName, EmpLName, Department, Project, EmpAddress, DOB, Gender) values ('Julie', 'Plec' , 'QA', 'MIS', 'Alfred street', '1990-12-04','Female')

select * from EmpInfo

Insert into EmpPosition (EmpId, Designation, Date_Of_Joining, Salary) values (1, 'Software Engineer', '2002-12-04',38000)
Insert into EmpPosition (EmpId, Designation, Date_Of_Joining, Salary) values (3, 'Senior Associate', '2003-10-09',89000)
Insert into EmpPosition (EmpId, Designation, Date_Of_Joining, Salary) values (4, 'Associate Tech', '2013-11-04',42000)
Insert into EmpPosition (EmpId, Designation, Date_Of_Joining, Salary) values (5, 'Project Manager', '2000-12-16',150000)
Insert into EmpPosition (EmpId, Designation, Date_Of_Joining, Salary) values (6, 'Project Manager', '1999-11-03',185000)

select * from EmpPosition

--Query to fetch the number of employees working in the department ‘HR’.

select count(*) as 'No of Employees' from EmpInfo 
where Department = 'HR'

--query to get the current date.

Select Cast(GETDATE() AS Date)

--query to retrieve EmpLName with second character as "a"  EmployeeInfo table.

Select EmpLName from EmpInfo
where EmpLName like '_a%'

--query to find all the employees whose salary is between 50000 to 100000.

select * from EmpPosition e INNER JOIN EmpInfo i on e.Empid=i.Empid where e.Salary BETWEEN 50000 AND 100000

--query to find the names of employees that begin with ‘S’

Select EmpFName from EmpInfo
where EmpFName like 's%'

-- query to fetch top 3 records.

Select TOP 3 * from EmpInfo

-- query to retrieve the EmpFname and EmpLname in a single column as “FullName”. The first name and the last name must be separated with space.

select EmpFName+ ' ' +EmpLName as EmpFullName from EmpInfo



--EmpFName, Prj, Salary, Designation for all employees
select ei.EmpFName, ei.Project, ep.Salary, ep.Designation from EmpInfo ei Inner join EmpPosition ep on ei.EmpId = ep.EmpId



-- Get total employees grouped by project name having projectname = "MIS"

Select count(*) as 'Total Employees' from EmpInfo where Project = 'MIS'



--Get all employees belonging to Designation "Software Engineer", "Project Manager"

select * from EmpInfo ei Inner join EmpPosition ep on ei.EmpId = ep.EmpId where ep.Designation='Software Engineer' or ep.Designation = 'Project Manager'



