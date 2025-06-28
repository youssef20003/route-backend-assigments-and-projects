------part1------
use MyCompany
--1.display all emp data
select * from Employee
--2
select emp.Fname , emp.Lname ,emp.Salary , emp.Dno
from Employee emp
--3
select emp.Fname + '' + emp.Lname  as fullname , emp.Salary +(emp.Salary*12)*0.10 as ANNUAL_COMM
from Employee emp
--4
select emp.SSN , emp.Fname ,emp.Salary
from Employee emp
where emp.Salary >1000
--5
select emp.SSN , emp.Fname
from Employee emp
where (emp.Salary*12) >10000
--6
select emp.Fname ,emp.Salary
from Employee emp
where emp.Sex = 'F'
--7
select dep.Dnum , dep.Dname
from Departments dep
where dep.MGRSSN = 968574
--8
select p.Pnumber , p.Pname , p.Plocation 
from Project p
where p.Dnum = 10
---------------------------------------------------------------------
------part2------
use ITI
--1
select distinct Instructor.Ins_Name 
from Instructor
--bouns
/* 
@@ is used in global variables 
@@VERSION : display the version of ssms 
@@SERVERNAME : display the servername or instance
*/
select @@VERSION
select @@SERVERNAME
---------------------------------------------------------------------
------part3------
use MyCompany
--1
select p.Pnumber , p.Pname , p.Plocation 
from Project p
where p.City in ('Cairo' , 'Alex')
--2
select *
from project
where project.Pname  like 'a%'
--3
select *
from Employee e
where e.Dno =30 and e.Salary between 1000 and 2000
---------------------------------------------------------------------
------part4------
use MyCompany
--1
insert into Departments
values ('DEPT IT', 100,112233,'1-11-2006')
--2
--a
update Departments 
set MGRSSN = 968574
where Dnum = 100
--b
insert into Employee(Fname , Lname ,SSN)
values ('youssef','mostafa',102672)

update Departments 
set MGRSSN = 102672
where Dnum = 20
--c
insert into Employee(Fname , Lname ,SSN)
values ('ashraf','mora', 102660)

update Employee
set Superssn = 102672
where SSN = 102660
--3
update Employee
set Superssn = 102672
where Superssn = 223344

update Works_for
set ESSn = 102672
where ESSn =223344

update Departments
set MGRSSN =102672
where MGRSSN =223344

delete Dependent
where ESSN =223344

delete from Employee
where SSN = 223344