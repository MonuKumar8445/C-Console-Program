create database HRDB
use HRDB
create table Departments(id int primary key identity, name varchar(max))

create table Employees
(id int primary key identity,
name varchar(max),
email varchar(max),
gender varchar(15),
mobile varchar(15),
department_id int foreign key references Departments(id))
select * from Departments
select * from Employees
exec SP_Department 'SELECT'
exec SP_Department 'CREATE',0,'HR'

create proc SP_Department
@action varchar(20),
@id int=0,
@name varchar(100)=null
as 
begin
if(@action='CREATE')
BEGIN
insert into Departments(name)values(@name)
select 1 as result
end
else if(@action='DELETE')
BEGIN
delete from Departments where id=@id
select 1 as result
end
else if(@action='SELECT')
begin
select * from Departments
select 1 as result
end
else if(@action='UPDATE')
begin
update Departments set name=@name where id=@id
select 1 as result
end 
end
-----------------------------------------
exec SP_Employee 'SELECT'
exec SP_Employee 'CREATE',1,'Monu','monuk@112gmail.com','male','558475475',4

create proc SP_Employee
@action varchar(20),
@id int=0,
@Name varchar(100)=null,
@Email varchar(100)=null,
@Gender varchar(15)=null,
@Mobile varchar(15)=null,
@dept_id int=0
as 
begin
if(@action='CREATE')
BEGIN
insert into Employees(Name,Email,Gender,Mobile,department_id)values
(@Name,@Email,@Gender,@Mobile,@dept_id)
select 1 as result
end
else if(@action='DELETE')
BEGIN
delete from Employees where id=@id
select 1 as result
end
else if(@action='SELECT')
begin
select * from Employees
select 1 as result
end
else if(@action='SELECT_JOIN')
begin
select e.Id,e.Name,e.Email,e.Gender,d.Name
from Employees e
full join
Departments d
on department_id=d.id
select 1 as result
end
else if(@action='UPDATE')
begin
update Employees set Name=@Name,Email=@Email,Gender=@Gender,
Mobile=@Mobile where id=@id
select 1 as result
end 
end




