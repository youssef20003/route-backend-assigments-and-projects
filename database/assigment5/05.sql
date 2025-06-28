--=====================================================================--
--part01--
use MyCompany

--1
select p.Pname, p.Plocation , d.Dname
from Project p join Departments d
on p.Dnum = d.Dnum


--=====================================================================--
--part02--
use ITI

--1
select i.Ins_Name ,d.Dept_Name
from Instructor i left join Department d
on i.Dept_Id = d.Dept_Id

--2
select CONCAT(s.St_Fname, ' ' , s.St_Lname)  [full name]  ,  c.Crs_Name
from Student s join Stud_Course sc 
on  s.St_Id = sc.St_Id JOIN Course c 
on sc.Crs_Id = c.Crs_Id
where sc.Grade is not null

--3
select s.St_Fname , sup.St_Id , sup.St_Fname
from Student s  join Student sup
on s.St_Id = sup.St_super

--4
select s.St_Id [Student ID] ,
CONCAT(s.St_Fname, ' ' , s.St_Lname)  [Student FullName] ,
d.Dept_Name [Departmentname]
from Student s join Department d
on s.Dept_Id =d.Dept_Id


--=====================================================================--
--part03--
use MyCompany

--1
select d.Dnum , d.Dname , e.Fname
from Departments d join Employee e
on d.MGRSSN = e. SSN

--2
select d.Dname ,p.Pname
from Departments d join Project p
on d.Dnum = p.Dnum

--3
select d.* , e.Fname
from Dependent d join Employee e
on d.ESSN = e.SSN

--4
select e.Fname
from Employee e join Works_for wf
on e.SSN = wf.ESSn join Departments d
on e.Dno =d.Dnum join Project p 
on  wf.Pno  =p.Dnum
where d.Dnum = '10' and wf.Hours >=10 and p.Pname='Al Rabwah'

--5
select e.Fname ,e.Lname
from Employee e  join Employee sup
on e.Superssn = sup.SSN
where concat(sup.Fname,' ',sup.Lname ) ='Kamel Mohamed'

--6
SELECT DISTINCT sup.*
FROM Employee e JOIN Employee sup ON e.SuperSSN = sup.SSN;

--7
select e.Fname ,e.Lname ,p.Pname
from Employee e join Works_for wf 
on e.SSN = wf.ESSn join Project p
on wf.Pno = p.Pnumber
order by p.Pname

--8
select p.Pnumber , d.Dname , e.Lname , e.Address , e.Bdate 
from Project p  join Departments d
on p.Dnum = d.Dnum join Employee e
on d.MGRSSN = e.SSN
where p.City = 'Cairo'

--9
select *
from Employee e left join Dependent d
on e.SSN = d.ESSN


--=====================================================================--
--part04--
use ITI

--1
select count(s.St_Age)
from Student s
 where s.St_Age is not null

 --2
 select s.St_Id [StudentID] , concat(isnull(s.St_Fname,' '),' ' ,isnull(s.St_Lname,' ') ) [Student FullName] , d.Dept_Name [Department name]
 from Student s join Department d 
 on s.Dept_Id =d.Dept_Id

 --3
 select i.Ins_Name ,isnull( i.Salary,'0000')
 from Instructor i

 --4
 select max(i.Salary) [max salary] , min(i.Salary) [min salary]
  from Instructor i

  --5
  select avg(i.Salary) 
  from Instructor i

  --6
  select *
  from Instructor i
where Salary < (select AVG(Salary) from Instructor)

--7
select d.Dept_Name
from Department d join Instructor i
on d.Dept_Id = i.Dept_Id
where i.Salary = (select min(Salary) from Instructor)

--8
select top(2) i.Salary
from Instructor i 
order by Salary desc

--9
select COUNT(c.Crs_Id) ,t.Top_Name
from Course c join Topic t
on c.Top_Id = t.Top_Id
group by t.Top_Name

--10
select sup.St_Fname , count(s.St_super)
from Student s join Student sup
on s.St_super  = sup.St_Id
group by sup.St_Fname


--=====================================================================--
--part05--
use MyCompany

--1
select d.*
from Departments d join Employee e
on d.Dnum =e.Dno
where e.SSN = (select MIN(SSN) FROM Employee where Dno is not null)

--2
select e.Lname ,dep.Dname
from Employee e join Departments dep
on e.SSN = dep.MGRSSN 
where e.ssn not in (select ESSN from Dependent)

--3
select e.SSN ,e.Fname ,e.Lname
from Employee e 
where exists (select 1 from Dependent d WHERE d.ESSN = e.SSN )

--4
select p.Pname , sum(wf.Hours)
from Project p join Works_for wf
on p.Pnumber = wf.Pno
group by p.Pname

--5
select d.Dname , max(e.Salary) [max slary] , min(e.Salary) [min salary] , avg(e.Salary) [avg salary]
from Departments d join Employee e
on d.Dnum = e.Dno
group by d.Dname

--6
select d.Dname , d.Dnum , count(e.SSN)
from Departments d join Employee e
on d.Dnum = e.Dno
group by d.Dnum,d.Dname
having Avg(e.Salary) < (select Avg(Salary) from Employee)

