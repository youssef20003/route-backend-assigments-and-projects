create database ITI;
use iti;

create table Students (
ID int primary key identity(1,1),
FName nvarchar(20) not null,
LName nvarchar(20) not null,
Age int ,
Address nvarchar(50) default 'cairo',
Dep_id int
);

create table Departments(
ID int primary key ,
Name nvarchar(20) not null ,
Hiring_Date date,
ins_id int 
);

alter table Students
add foreign key (Dep_id) references Departments(ID)

create table Instructors(
id int primary key identity(1,1),
name nvarchar(20) not null,
Address nvarchar(50) default 'cairo',
Bouns money ,
Salary money not null,
Hour_Rate int,
Dep_id int references Departments(ID)
);

alter table Departments
add foreign key (ins_id) references Instructors(id)

create table Topics(
id int primary key identity(1,1),
name nvarchar(20) not null
);

create table Courses (
id int primary key identity(1,1),
name nvarchar(20) not null,
Duration int not null ,
Descriptions nvarchar(max),
top_id int references Topics(id)

);



create table Stud_course(
Stud_id int references Students(ID),
Course_id int references Courses(id),
Grade int ,
primary key(stud_id,Course_id)
);


create table Course_instructor(
Course_id int references Courses(id),
inst_id int references Instructors(id),
Evalution int 
primary key(Course_id , inst_id)

);

