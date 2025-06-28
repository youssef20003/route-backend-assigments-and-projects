------------exam 01------------
use Library

--1
select e.Fname , e.Lname
from Employee e
where len(e.Fname) > 3

--2
select count(b.Cat_id) [NO OF PROGRAMMING BOOKS]
from Book b , Category c
where b.Cat_id =c.Id
and c.Cat_name = 'programming '

--3
select count(b.Id) [NO_OF_BOOKS]
from Book b ,Publisher p
where b.Publisher_id = p.Id
and p.Name = 'HarperCollins' 

--4
select u.SSN ,u.User_Name , b.Borrow_date , b.Due_date
from Users u , Borrowing b
where u.SSN = b.User_ssn
and b.Due_date < '2022-7-1'

--5
select CONCAT(b.Title , ' is written by ' , a.Name)
from book b , Book_Author ba , Author a 
where b.Id = ba.Book_id 
and ba.Author_id = a.Id

--6
select u.User_Name
from Users u
where u.User_Name like 'A%'

--7
select top 1 b.User_ssn
from Borrowing b
group by b.User_ssn
order by count(b.User_ssn) desc


--8
select top 1 b.Amount
from Borrowing b
order by b.Amount desc

--9
select top 1 c.Cat_name
from Borrowing br , Book b , Category c
where br.Book_id = b.Id 
and b.Cat_id = c.Id
group by c.Cat_name
order by COUNT(c.Cat_name) asc


--10
select isnull(e.Email ,isnull(e.Address,e.DOB))
from Employee e 

--11
select c.Cat_name, count(b.Id) [Count Of Books]
from Book b , Category c
where b.Cat_id = c.Id
group by c.Cat_name 

--12
select b.Id
from book b
where b.Id not in(
select b.Id
from Book b ,Shelf s , Floor f
where b.Shelf_code = s.Code
and s.Floor_num = f.Number
and f.Number = 1
and s.Code = 'A1'
)


--13
select f.Number , f.Num_blocks ,count(e.Id)
from floor f , Employee e
where f.Number = e.Floor_no
group by f.Number ,f.Num_blocks

--14
select b.Title , u.User_Name
from book b , Borrowing br ,Users u
where b.Id = br.Book_id
and br.User_ssn = u.SSN
and br.Borrow_date between '2022-3-1' and '2022-10-1'

--15
select e.Fname + ' '+e.Lname as [Employee Full Name] ,sup.Fname + ' '+sup.Lname as [Supervisor Name] 
from Employee e , Employee sup
where e.Super_id = sup.id

--16
select e.Fname + ' '+e.Lname , isnull(e.Salary , e.Bouns)
from Employee e

--17
select max(e.Salary) [max] , min(e.Salary) [min]
from Employee e

--18
create  function evenorodd (@num int)
returns varchar(8)
as
begin
declare @r varchar(8)
if @num % 2=0
set @r = 'even'
else
set @r = 'odd'
RETURN @r
end

--19
create function displaybooktittle(@cat varchar(20))
returns table
as
return
(
select b.Title
from Book b , Category c
where b.Cat_id = c.Id
and c.Cat_name = @cat
)

--20
create function diplaybuad (@phone nvarchar(20))
returns table
as
return
(
select b.Title , u.User_Name , br.Amount ,br.Due_date
from book b , Borrowing br , Users u , User_phones up
where b.Id =br.Book_id 
and br.User_ssn = u.SSN 
and u.SSN = up.User_ssn
and up.Phone_num = @phone
)

--21
create or alter function chechduplicated (@name varchar(20))
returns nvarchar(50)
as
begin

declare @count int
declare @res nvarchar(50)

select @count = count(u.User_Name)
from Users u
where u.User_Name =@name

if @count = 0
set @res = @name + ' is Not Found'
else if @count = 1
set @res = @name + ' is not duplicated'
else
set @res = @name + ' is Repeated ' + cast(@count AS nvarchar) + '  times' 

return @res
end

--22
create function  formatdate(@date date , @format nvarchar(50))
returns nvarchar(50)
as
begin
return format(@date ,@format)
end


--23
create proc sp_numberpercat
as
select c.Cat_name , count(b.Id)
from book b ,Category c
where b.Cat_id = c.Id
group by c.Cat_name

--24
create proc sp_updatefloormang @oldemp int ,@newemp int ,@floornum int
as
update Floor 
set MG_ID = @newemp
where MG_ID = @oldemp
and Number = @floornum

--25
--do mean users table or emp?????
create view AlexAndCairoEmp
as
select *
from Employee e 
where e.Address in ('Alex' , 'Cairo')

--26
create view V2
as
select s.Code , count(b.Id) [number of books]
from book b, Shelf s
where b.Shelf_code = s.Code
group by s.Code

--27
create view V3
as
select top 1 v2.Code
from V2
order by V2.[number of books] desc


--28
create table ReturnedBooks
(
User_SSN varchar(50) references Users(SSN),
Book_id int references Book(Id),
due_date date,
return_date date,
fees money
)

create trigger checkdate
on ReturnedBooks
instead of insert
as
declare @original_amount int
if return_date > due_date then
set fees = @original_amount *0.20

--29
insert into Floor(Number,Num_blocks,MG_ID,Hiring_Date)
values(7,2,20,getdate())

update Floor 
set MG_ID = 5
where Number = 7

update Floor 
set MG_ID = 12
where MG_ID = 5

--30
create view v_2006_check
as
select f.MG_ID ,f.Number ,f.Num_blocks ,f.Hiring_Date 
from Floor f
where Hiring_Date between '2022-03-1' and '2022-05-31'


 select * from v_2006_check

insert into v_2006_check(MG_ID , Number , Num_blocks , Hiring_Date)
values(2, 6, 2 ,'7-8-2023')


insert into v_2006_check(MG_ID , Number , Num_blocks , Hiring_Date)
values(4, 7, 1 ,'4-8-2022')

--both gives error because of dublicat primary key and in first one is date exceded

--31
create trigger cantdeleteormodify
on Employee
instead of delete , insert , update
as
print 'you cant take any action with this Table'

drop trigger cantdeleteormodify

--32

--a
insert into User_phones (User_ssn ,Phone_num )
values(50,0100102103)
--user with ssn 50 does not exist so cant be added to a table with forign key fro users

--b
update Employee
set Id = 20
where Id = 21
--cant update a primary key becaues of the forien keys and the trigger wont let me

--c
delete from Employee
where Id = 1
--cant be deleted beacues its refernced in another table and the trigger wont let me

--d
delete from Employee
where Id = 12
--cant be deleted beacues its refernced in another table and the trigger wont let me

--e
create clustered index ix_salary
on Employee(Salary)
--only one clusterd in table

--33
create schema youssefschema
alter schema youssefschema transfer Employee 
alter schema youssefschema transfer floor 