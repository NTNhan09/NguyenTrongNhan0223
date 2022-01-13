create database HR
go
use HR

create table Employee_0223
(
IdEmployee int primary key, 
Name nvarchar(255), 
DateBirth datetime, 
Gender bit, 
PlaceBirth nvarchar(255), 
IdDepartment char(5)
)

go 
create table Department_0223(
IdDepartment char(5) primary key,
NameD nvarchar(255)
)

go
ALTER TABLE Employee_0233
ADD FOREIGN KEY (IdDepartment) REFERENCES dbo.Department_0223(IdDepartment);

go
insert into Employee_0233 values('53418',N'Tr?n T�n', 11/10/2000, 1,N'H� N?i', 'IT')
go
insert into Employee_0233 values('53416', N'Nguy?n C??ng', 21/07/1996, 0, N'?ak Lak', 'KT')
go
insert into Employee_0233 values('53417', N'Nguy?n H�o', 25/12/1996, 1, N'TP.H? Ch� Minh', 'KSNB')

go
insert into Departmen_0223 values('IT', N'C�ng Ngh? Th�ng Tin')
insert into Departmen_0223 values('KT', N'K? to�n')
insert into Departmen_0223 values('KSNB', N'Ki?m so�t n?i b?')


select*from Employee_0223
select*from Departmen_0223

