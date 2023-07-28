use master

create database CSharpCourseDb

GO

use CSharpCourseDb

create table dbo.Members
(
	MemberId int primary key,
	Firstname nvarchar(50) not null,
	Company nvarchar(50) not null,
	Position nvarchar(50) not null,
	Salary decimal null,
	[Date] datetime not null
)

insert into dbo.Members (MemberId, Firstname, Company, Position, Salary, [Date])
	values (1, 'Damian','Abc','developer',100.99,'2023-07-27'),
	(2, 'Micha³','Abc','developer',200.50,'2023-07-27'),
	(3, 'Micha³','Abc','developer',300.54,'2023-07-27'),
	(4, 'Agnieszka','Abc','developer',100.99,'2023-07-27'),
	(5, 'Marcin','Sulmar','instructor',50.01,'2023-07-27')