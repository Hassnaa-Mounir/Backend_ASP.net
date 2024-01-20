--------------Demo----------
use mycompany
select * into employees
from MyCompany.dbo.Employee
where 1=2 --(condition impossible to insert structure without data)

---(select structure with data)
select Pnumber ,Pname into myproject
from MyCompany.dbo.Project
where City in('cairo' ,'Alex')

------insert based on select
 insert into myproject(Pname ,Pnumber)
 select Pnumber ,Pname   from MyCompany .dbo.Project

 go
 -----------functions
   ---scalar function(select statement)
   Create OR Alter Function GetNameOfMonth(@mydate date)
		Returns varchar(max)
		 AS
		  Begin
		  Declare @nameOfMonth varchar(max)
		  select @nameOfMonth =FORMAT(@mydate ,'MMMM')
		  Return @nameOfMonth
		  End

		  -----call function
		  select dbo.GetNameOfMonth(GetDate())
		  go
   ---table valued 
   use iti
     ---inline table valued (select statement)
	 Create OR Alter function GetInstructorsofDepart(@dept_id int)
	 Returns Table
	  AS
	    Return
		(
		 select ins_id , Ins_Name , Salary
		 from instructor
		 where Dept_id =@dept_id
		)
		---------calling function
		select * from dbo.GetInstructorsofDepart (3)

	 ---multi statments table valued (select statement ,or insert based on select)
	 Create OR Alter Function DataOfStudent(@std_num int)
		Returns @TableOfResult Table (Dept_name nvarchar(50) ,FullName varchar(max))
		 AS
		 Begin
		   insert into @TableOfResult(Dept_name,FullName)
		   select D.Dept_Name , CONCAT (St_Fname ,' ',St_Lname) 
		   from student S,Department D
		   where S.Dept_Id =D.Dept_Id  and St_Id =@std_num
		   return
		 End

		----calling function 
		 select * from dbo.DataOfStudent(10)

  ------Execution Order

  select concat (St_Fname, ' ',St_Lname) as fullname
  from Student
  where fullname ='Ahmed hassan'  ----have error because where execute before select

select concat (St_Fname, ' ',St_Lname) as fullname
  from Student
  order by fullname ------execute to select first then order by

  -------------create schema
  go
  create schema sales
  go

  -----alter schema
  Alter schema sales
  transfer dbo.employee  --(name of schema . object of this schema)

  ---create table in schema
  create table sales.department  ---(name of schema . name of table)
  (
  id int primary key
  )

  ----to drop schema must drop objects in schema first 
  drop table sales.department
  drop schema sales

  --------------UNion family
  ----union
  select St_Fname  from Student
  union
  select  Ins_Name  from Instructor

  ---union all
    select St_Fname ,St_Id  from Student
  union all
  select  Ins_Name ,Ins_Id  from Instructor

  ----intersct
    select St_Fname  from Student
  intersect
  select  Ins_Name  from Instructor

  -----except
    select St_Fname  from Student
  except
  select  Ins_Name  from Instructor

  ----while syntax with function
  Create OR Alter Function GetValuesinRange(@inialVal int ,@endedVal int)
Returns @ResultTable Table (RangeValues int)
 AS
  Begin
   declare @counter int = @inialVal
    WHILE @Counter <= @endedVal
    BEGIN
        INSERT INTO @ResultTable (RangeValues)
        VALUES (@counter);

        SET @counter = @counter + 1;
    END;
  
  Return
   End



