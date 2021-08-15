create database QuizMSystem
use QuizMSystem

create table Admins
(
Admin_ID int primary key,
Admin_Password varchar (50)
)

select * from Admins
truncate table Admins
insert into Admins values('1918','1234')

select * from Modules
truncate table Modules

select * from Questions
truncate table Questions

select * from Results
truncate table Results

select * from Students
truncate table Students

select * from Results
truncate table Results

create table DegreePrograms
(
Degree_ID varchar (50) primary key,
Degree_Name varchar (50)
)

select * from DegreePrograms
truncate table DegreePrograms
insert into DegreePrograms values('SOFT1','Software Engineering')
insert into DegreePrograms values('CS1','Computer Security')

create table Batch
(
Batch varchar (50) primary key,
Batch_Year varchar(50)
)

select * from Batch
truncate table Batch
insert into Batch values('19.1','2019 March')
insert into Batch values('19.2','2019 September')
insert into Batch values('20.1','2020 March')
insert into Batch values('20.2','2019 September')
