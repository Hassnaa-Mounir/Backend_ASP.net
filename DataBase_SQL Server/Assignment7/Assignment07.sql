---------------------Assignment 07 ----------
use iti
  ----Part 01 (views)
  --1. Create a view that displays the student's full name,course name if the student has a grade more than 50. 
  go
  Create OR Alter view DisplayPassedStudent (fullname ,CourseName ) --aliase name
   with encryption
   AS
    select s.St_Fname + ' '+ s.St_Lname ,C.Crs_Name --,SC.Grade
	from Student S,Stud_Course SC,Course C
	where S.St_Id =SC.St_Id and SC.Crs_Id =C.Crs_Id and  SC.Grade > 50

	go
	----calling 
	select * from DisplayPassedStudent

---2. Create an Encrypted view that displays manager names and the topics they teach. 
  go
  Create OR Alter view DisplayManagerWithTopips (ManagerName ,TopicName ) --aliase name
   with encryption
   AS
    select ins.Ins_Name  ,t.Top_Name
	from Instructor ins ,Ins_Course IC ,Course C ,Topic T
	where ins.Ins_Id =IC.Ins_Id and IC.Crs_Id =C.Crs_Id  and c.Top_Id =t.Top_Id

	go
	------calling 
	select * from DisplayManagerWithTopips

---3. Create a view that will display Instructor Name,Department Name for the ‘SD’ or ‘Java’ Department “use
--Schema binding” and describe what is the meaning of Schema Binding
go
  CREATE  VIEW dbo.InstructorDepartmentView
    WITH SCHEMABINDING  ----- the view is bound to the schema of the underlying tables (dbo.Instructors and dbo.Departments), and any changes to the underlying schema will require the view to be recompiled (Drop then create view  again based on new change ).
	AS
	 select ins.Ins_Name  , D.Dept_Name
	from dbo.Instructor ins ,dbo.Department D
	where ins.Dept_Id =D.Dept_Id and D.Dept_Name in ('SD','Java')
go

----calling
select * from dbo.InstructorDepartmentView

---4. Create a view “V1” that displays student data for students who live in Alex or Cairo.
---Note: Prevent the users to run the following query Update V1 set st_address=’tanta’ Where st_address=’alex’
go
create OR Alter view CairoStudentsView (studentID , studentName ,AddressOFStudent)
   with encryption
 AS
  select St_Id ,St_Fname ,St_Address
  from Student
  where St_Address in('Cairo','Alex') with check option ----check constrain to ensure that all data which added achieve constrain
   go
  -----calling 
  select* from CairoStudentsView

  update CairoStudentsView
     set AddressOFStudent='tanta'
   where AddressOFStudent='Alex'

----5. Create a view that will display the project name and the number of employees working on it. (Use Company DB)
use MyCompany
go
create OR Alter view DisplayProjectWithNUMofEmployees (ProjectName ,NumberOfEmployees)
   with encryption
   AS
    select  P.Pname ,count (WS.ESSn) as EmployeeNumber
	from Project P , Works_for WS ,Employee E
	where P.Pnumber =WS.Pno and E.SSN =WS.ESSn 
	Group By p.Pname ,p.Pnumber ---using pk as key of grouping
go
	-------calling 
	select * from DisplayProjectWithNUMofEmployees

-----------------------Using DB[SD32-Company]
use [SD32-Company]
---1. Create a view named “v_clerk” that will display employeeNumber ,project Number, the date of hiring of all the jobs of the type 'Clerk'.
go
Create OR Alter View v_clerk (employeeNumber ,projectNumber, dateofhiring)
with encryption
 AS
  select E.EmpNo ,P.ProjectNo ,Wo.Enter_Date
  from HR.Project  P, Works_on WO ,HR.Employee E
  Where P.ProjectNo =WO.ProjectNo and E.EmpNo =WO.EmpNo and WO.Job ='clerk' -- with check option
  go

  ----calling 
  select * from v_clerk

  ---2. Create view named “v_without_budget” that will display all the projects data without budget
  go
Create OR Alter View v_without_budget (projectNumber, ProjectName)
with encryption
 AS
 select ProjectNo,ProjectName
 from HR.Project
 go
 ---------------calling
 select * from v_without_budget

 ---3. Create view named “v_count “ that will display the project name and the Number of jobs in it
  go
Create OR Alter View v_count (ProjectName , NumOfJobs)
with encryption
 AS
  select p.ProjectName ,count(WO.Job) as NumberOfJobs
  from HR.Project P,Works_on WO
  where P.ProjectNo =WO.ProjectNo
  Group By p.ProjectNo ,p.ProjectName
  go
   ---------------calling
 select * from v_count

 ---4. Create view named ” v_project_p2” that will display the emp# s for the project# ‘p2’ . (use the previously created view “v_clerk”)
 go
 Create OR Alter view v_project_p2 (EmployeeNumber)
 with encryption
  AS
   select employeeNumber 
   from v_clerk
   where projectNumber=2
   go

   -------calling 
   select * from v_project_p2 

   ----5. modify the view named “v_without_budget” to display all DATA in project p1 and p2.
   go
 Alter View v_without_budget (projectNumber, ProjectName)
  with encryption
   AS
	 select ProjectNo,ProjectName
	 from HR.Project
	 where ProjectNo in(1 ,2)
 go
 ---------------calling
 select * from v_without_budget
   
   ---6. Delete the views “v_ clerk” and “v_count”
      Delete  v_clerk 
	  ---can not delete because it is view is based on more than one table and can not delete from more than table at same time
      Delete  v_count  
	  ---can not delete because it is view is based on more than one table and can not delete from more than table at same time

   ---7. Create view that will display the emp# and emp last name who works on deptNumber is ‘d2’
   go
   Create OR Alter View DisplayEmployeeInDept2 (Emp_Number ,Emp_lname )
    with encryption
	AS
	 select E.EmpNo ,E.EmpLname
	 from HR.Employee E
	 where E.DeptNo =2
	 go 

	 ----calling
         select * from DisplayEmployeeInDept2

  ---8. Display the employee lastname that contains letter “J”(Use the previous view created in Q#7)
   select Emp_lname
   from DisplayEmployeeInDept2
   where Emp_lname like '%J%'

   ---9. Create view named “v_dept” that will display the department# and department name
   go
   Create OR Alter View v_dept (Dept_Number ,Dept_name )
    with encryption
	AS
	 select CD.DeptNo ,CD.DeptName
	 from Company.Department CD
	 go
  ----calling
         select * from v_dept

  ---10. using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’
  insert into v_dept
  values (4 ,'Development')

  ---11-Create view name “v_2006_check” that will display employee Number, the project Number where he works and the date of joining the project which must be from the
   --first of January and the last of December 2006.this view will be used to insert data so make sure that the comingnew data must match the condition
  go
   Create OR Alter View v_2006_check (Emp_number ,ProjectNumber ,DateOfJoiningProject )
    with encryption
	AS
	 select E.EmpNo ,P.ProjectNo ,WO.Enter_Date
	 from HR.Project  P, Works_on WO ,HR.Employee E
     Where P.ProjectNo =WO.ProjectNo and E.EmpNo =WO.EmpNo 
	        and WO.Enter_Date  between '01-01-2006'and'31-12-2006' with check option 

			go
  ------calling 
  select * from v_2006_check

  ---------------------------------------- Part 02
  --------------Stored Procedure
  use iti

-- 1. Create a stored procedure to show the number of students per department.[use ITI DB] 
go
Create OR Alter procedure DisplayNum_StdsPerDepart 
with encryption
AS
  select D.Dept_Id,count(S.St_Id)
  from Department D ,Student S
  where D.Dept_Id =S.Dept_Id
  group By D.Dept_Id

  go
  ---calling 
  exec DisplayNum_StdsPerDepart

  -- 2. Create a stored procedure that will check for the Number of employees in the project 100 if they are more than 3 print message to the user 
	--“'The number of employees in the project 100 is 3 or more'” if they are less display a message to the user “'The following employees work for 
	--the project 100'” in addition to the first name and last name of each one.
 use MyCompany
go
Create OR Alter procedure DisplayNum_EmpsPerProject
with encryption
AS
  Declare @counter int
  select @counter= count(WS.ESSn)
  from  Works_for WS 
  where WS.Pno=100
  if @counter > = 3
   Begin
	select  'The number of employees in project 100 is 3 or more' as MessageForCount ,E.Fname +' '+E.Lname 'fullname'
	from Project P , Works_for WS ,Employee E
    where P.Pnumber =WS.Pno and E.SSN =WS.ESSn and p.Pnumber=100
   End
  else 
   Begin
   
	select 'The following employees work for project 100:' as MessageForCount ,E.Fname +' '+E.Lname 'fullname' 
	from Project P , Works_for WS ,Employee E
    where P.Pnumber =WS.Pno and E.SSN =WS.ESSn and p.Pnumber=100
   End
    

  go
  ---calling 
  exec DisplayNum_EmpsPerProject

  ---3. Create a stored procedure that will be used in case an old employee has left the project and a new one becomes his replacement. The procedure 
	--should take 3 parameters (old Emp. number, new Emp. number and the 
	--project number) and it will be used to update works_on table.
go
Create OR Alter procedure Replace_oldEmpWithNewEmp @oldEmp int, @newEmp int ,@ProjectNum int
with encryption
AS   ------confilct
Update Works_for 
   set ESSn = @newEmp
 where ESSn = @oldEmp and Pno = @ProjectNum 
 Update Employee 
   set SSn = @newEmp
 where SSn = @oldEmp
  Update Employee 
   set Superssn = null
 where Superssn = @oldEmp

  go
  ---calling 
  exec Replace_oldEmpWithNewEmp 112233 , 20180 ,100


  ----------------------Part 03
  ---1. Create a stored procedure that calculates the sum of a given range of numbers
  go
	create OR Alter procedure sp_sumOfRange (@initOfRange int ,@EndOfRange int ,@Result int output)
	with encryption
	AS
	 Declare @currentItem int = @initOfRange
     set @Result=0
	 while @currentItem <= @EndOfRange
	  Begin
	   set @Result += @currentItem
	   set  @currentItem +=1
	  End


	  -----calling
	  Declare @resultOfOut int 
	  exec sp_sumOfRange 1,5 ,@resultOfOut output
	  Select @resultOfOut as ResultOfSum
	 
	 ---2. Create a stored procedure that calculates the area of a circle given its radius
	 go
	create OR Alter procedure sp_AreaOfCircle (@radius float ,@Result float output)
	with encryption
	AS
	set @Result= PI() * POWER(@Radius, 2)

	-----calling
	  Declare @resultOfOut float 
	  exec sp_AreaOfCircle 3.5 ,@resultOfOut output
	  Select @resultOfOut as AreaOfCircle

  ----3. Create a stored procedure that calculates the age category based on a person's age ( Note: IF Age < 18 then Category is Child 
   --and if Age >= 18 AND Age < 60 then Category is Adult otherwise Category is Senior)
	go
	create OR Alter procedure sp_AgeCategory (@Age int)
	with encryption
	AS
	if @Age < 18
	Begin
	 select 'this person belongs to Category Child' as categoryOfAge
	End
	else if @Age >= 18
	Begin
	 select 'this person belongs to Category Adult' as categoryOfAge
	End
	else
	Begin
	 select 'this person belongs to Category Senior' as categoryOfAge
	End

	-----calling 
	  exec sp_AgeCategory 30
	  
	----4. Create a stored procedure that determines the maximum, minimum, and average of a given set of numbers ( Note : set of 
     --numbers as Numbers = '5, 10, 15, 20, 25')
	 --------spliting
	 go
	 CREATE FUNCTION dbo.SplitString
(
    @String NVARCHAR(MAX),
    @Delimiter NVARCHAR(10)
)
RETURNS @Result TABLE (Value NVARCHAR(MAX))
AS
BEGIN
    DECLARE @StartPosition INT = 1;
    DECLARE @EndPosition INT;

    WHILE CHARINDEX(@Delimiter, @String, @StartPosition) > 0
    BEGIN
        SET @EndPosition = CHARINDEX(@Delimiter, @String, @StartPosition);
        INSERT INTO @Result (Value) VALUES (SUBSTRING(@String, @StartPosition, @EndPosition - @StartPosition));
        SET @StartPosition = @EndPosition + LEN(@Delimiter);
    END

    INSERT INTO @Result (Value) VALUES (SUBSTRING(@String, @StartPosition, LEN(@String) - @StartPosition + 1));

    RETURN;
END;

	 	go

	create OR Alter procedure sp_CalculateMathOperation (@numbers varchar(max),@MaxNumber int output,@MinNumber int output ,@AvarageNum float output)
	with encryption
	AS
	Declare @tableNumders Table (num int)
	insert into @tableNumders(num)
		SELECT CONVERT(INT, value) AS numbers   ---split and convert
		FROM dbo.SplitString(@Numbers, ',')
   SELECT
        @MaxNumber = MAX(num),
        @MinNumber = MIN(num),
        @AvarageNum = AVG(CAST(num AS FLOAT))
    FROM @tableNumders

	 -----calling
	  Declare @ARRayAsText varchar(max) ='5, 10, 15, 20, 25' , @Max int , @Min int ,@Avarage float
	  exec sp_CalculateMathOperation  '5, 10, 15, 20, 25' , @Max output, @Min output,@Avarage output
	  