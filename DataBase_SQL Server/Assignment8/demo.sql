----------------Demo
Create OR Alter Trigger SayWelcome
on student
with encryption
after insert 
AS 
  select 'Welcome to Route'


  insert into student (st_id,st_name)
  values (22,'samy')

  -----trigger 
Create Trigger DisplayUpdateData 
on course
with encryption
After update 
AS
  select * from inserted
  select * from deleted
  ----------
  Create Trigger PreventDeleteOnCourse
  on course 
  with encryption
  instead of delete
  AS
    select concat_ws(' ','you can''t Delete',(select crs_name from deleted))

	--------test 
	delete from course 
	where crs_id=8000
-------------
	Create Trigger DisableDeleteFromStudent
	  on student
	  with encryption
	  instead of delete
	  AS
        if formate (GetDate(),'dddd') != 'saturday'
			delete from student 
			  where st_id in (select st_id from deleted)
        else
		select 'you can''t delete this St_id in saturday '
-------------
create Trigger notifyCreateTable
on Database
 with encryption
 After Create_Table
 AS
   select 'Table is created'
-------------------

Create OR Alter Trigger notifyOnDBCreated
on All Server
 with encryption
  After Create_Table
  AS
  if isMember('db_owner') =0
   begin
     print 'you must ask your DBA to create this DB!'
     Rollback Transaction
------------------
Create trigger connect_limit_trigger
on All Server
 with encryption
 for logon
 AS
 begin
 if orginal_login()='mai' and (select count(*) from sys.dm_exec_sessions where is_user_process=1 and orginal_login_name='mai')>3
  Rollback;
  end

  --------------Index
  ----------nonclustered (only one for table)
  create nonclustered index IX_name
  on employees(name)

  --------indexed view(schema binding )
  create OR Alter view studentDeptViews
 with schema Buinding , encryption
 AS
 select s.st_id ,s.st_name ,d.deptname
 from student s ,department d
 where s.dept_id=d.dept_id and st_id=1
 ----------
 create unique index IX_03
 on studentDeptViews(st_id)

 select * from studentDeptViews where st_id=1 --(best)

 ----------Delete vs Truncate
 Delete from student  where st_id=20 --(sepecific data)
 truncate table student

 -------------Tranaction 
 ----1.implicit transaction 
 insert into student (st_id,st_name)
 values(100,'ahmed')

 update student 
    set st_age=30
	   where st_age=20

------2.Explicit transaction 
create  table parent (parentId int primary key)

create table child (child_Id int primary key , PID int references parent(parentId))
insert into parent values (1),(2),(3)
 begin try
    begin transaction
	 insert into child values(1,2)
	 save tran p01
	  insert into child values(3,1)
	   insert into child values(6,100)  ---error
	    insert into child values(7,3)
	commit transaction 
 end try
 begin catch
      Rollback tran p01
 end catch



 ---------------DCL
 -----1. login server(user)
 -----2. user DB ITI (user)
 -----3. schema HR (determine tables to can access)
 ----4. permission

 
CREATE LOGIN YourName WITH PASSWORD = 'YourPassword';

-- Create a user for the login
CREATE USER YourNameUser FOR LOGIN YourName;

-- Grant SELECT and INSERT permissions on Employee and Floor tables
GRANT SELECT, INSERT ON Employee TO YourNameUser;
GRANT SELECT, INSERT ON Floor TO YourNameUser;

-- Deny DELETE and UPDATE permissions on Employee and Floor tables
DENY DELETE, UPDATE ON Employee TO YourNameUser;
DENY DELETE, UPDATE ON Floor TO YourNameUser