
USE master;
GO

DROP DATABASE IF EXISTS  CompanyMyData;
GO

CREATE DATABASE  CompanyMyData;
GO


USE CompanyMyData
GO


create table employees
(
  employee_ID  integer identity(1,1) NOT NULL,
  jobTitle varchar(50) NOT NULL,
  lastName varchar(50) NOT NULL,
  firstName varchar(50) NOT NULL,
  gender varchar(5),
  dateOfBirth date not null,
  dateOFHire date not null,
  department_id int,
  project_id int 
  constraint pk_employeeID primary key (employee_ID)
)

create table departments
(
  department_id integer identity(1,1) NOT NULL,
  departmentName varchar(50) not null, 
  constraint pk_departmentID primary key (department_ID)
)

create table projects
(
  project_id integer identity(1,1) NOT NULL,
  projectName varchar(50),
  projectStart date,
  employee_id int 
  constraint pk_projectID primary key (project_ID)
)




ALTER TABLE employees
ADD FOREIGN KEY(department_id)
references departments(department_id);

ALTER TABLE employees
ADD FOREIGN KEY(project_id)
references projects(project_id);



ALTER TABLE projects
ADD FOREIGN KEY(employee_id)
references employees(employee_id);

-- Creating Data. 

insert into Departments (departmentName) values ('Developers'),('Security'),('Testers')
insert into Projects (projectName, projectStart) values ('Collect Underpants', '2017-10-11'), ('Upside Down Triangle','2018-07-12'), ('Profit', '2019-05-05'), ('Make Programs', '2017-05-10')
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Senior Developer', 'Simpson', 'Karl', 'M', '1992-07-18', '2017-10-03', 1, 3)
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Junior Developer', 'Gina', 'Richards', 'F', '1984-09-12', '2018-10-03',1 , 2)
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Junior Developer', 'Mike', 'Jenkins', 'M', '1994-09-17', '2016-06-07', 1, 2)
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Junior Developer', 'Glenn', 'Owens', 'M', '1993-06-17', '2015-05-07', 1, 4)
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Security', 'Leah', 'Aflen', 'F', '1987-04-22', '2015-11-10',2, 1)
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Quality Assurance Tester', 'Matt', 'Williams', 'M', '1986-04-22', '2012-11-11',3, 4)
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Quality Assurance Tester', 'Jeff', 'Stevens', 'M', '1976-04-27', '2008-11-07',3,1)
insert into Employees (jobTitle, lastName, firstName, gender, dateOfBirth, dateOFHire, department_id, project_id) values ('Security', 'Paul', 'Pavlo', 'M', '1956-04-13', '2012-02-07',2,3)
select * from employees
