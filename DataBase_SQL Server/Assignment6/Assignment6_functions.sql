---------------------Assignment6----------------
use ITI
--1. Create a scalar function that takes a date and returns the
--Month name of that date.
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

---2. Create a multi-statements table-valued function that takes
--2 integers and returns the values between them

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


   ---calling function
    Select * from dbo.GetValuesinRange(10,20)
	----test cases(10,10) ,(20,10)

--3. Create a table-valued function that takes Student No and
--returns Department Name with Student full name.

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

 ---. Create a scalar function that takes Student ID and returns a message to user 
 /*a. If first name and Last name are null then display 'First
name & last name are null'
b. If First name is null then display 'first name is null'
c. If Last name is null then display 'last name is null'
d. Else display 'First name & last name are not null' */
Create OR Alter Function DisplayMessageTUser(@stdID int)
Returns varchar(max)
 AS
  Begin
    Declare @str_message varchar(max)
	Declare @fname nvarchar(50)
	Declare @lname nchar(10)
    select @fname = St_Fname , @lname = St_Lname
	from Student
	where St_Id = @stdID
	if @fname is null and @lname is null
	 set @str_message ='Firstname & last name are null'
   else if @fname is null
     set @str_message = 'first name is null'
   else if @lname is null
     set @str_message = 'last name is null'
   else
     set @str_message = 'First name & last name are not null'
   Return @str_message
  End

  ---calling function

   select dbo.DisplayMessageTUser(13)
 GO
--5.Create a function that takes an integer which represents the format of the Manager hiring date and displays
--department name, Manager Name and hiring date with this format.
 Create OR Alter Function DisplayDataOfManager(@DateFormat int)
 Returns @ResultOfFunction Table(Dept_name nvarchar(50) ,manager_name varchar(max) ,HiringDate date)
 AS
  Begin
   insert into @ResultOfFunction(Dept_name ,manager_name , HiringDate)
   select D.Dept_Name ,Ins_Name ,convert(varchar(50), D.Manager_hiredate, @DateFormat) as HiringDate
   from Department D , Instructor ins
   where D.Dept_Id = ins.Dept_Id 
   Return
  End
go
  ---calling function
  Select * from dbo.DisplayDataOfManager(101)
  
  
  --6.Create multi-statement table-valued function that takes a string
--a. If string='first name' returns student first name
--b. If string='last name' returns student last name 
--c. If string='full name' returns Full Name from student table 
  ----Note: Use “ISNULL” function

Create OR Alter Function DisplayBasedOnFormat(@str_format varchar(50))
Returns @Result Table (Std_Name varchar(max))
 AS
  Begin
    if @str_format ='first name'
		insert into @Result
		select isnull (St_Fname ,'Dont have fname')    from Student
    else if @str_format ='last name'
		insert into @Result
		select isnull (St_Lname ,'Dont have lname')   from Student
	else if @str_format ='full name'
		insert into @Result
		select isnull(isnull (St_Fname ,'no fname') +' ' +isnull (St_Lname ,'no lname'), 'Dont fname & lname')  from Student
	Return
  End

  -----calling function
  Select * from dbo.DisplayBasedOnFormat('full name')

  ---7. Create function that takes project number and display all employees in this project 
  use MyCompany

  Create OR Alter Function GetEmployeeOfProject(@P_number int)
  Returns @AllEmployeesofProject Table (NameOfemployee varchar(max),Essn int ,salary int ,Dept_num int)
   AS
    Begin 

	insert into @AllEmployeesofProject(NameOfemployee ,Essn ,salary ,Dept_num )
	select E.Fname+ ' '+E.Lname ,E.SSN ,E.Salary ,E.Dno
	from Employee E ,Works_for WS ,Project P
	where E.SSN =WS.ESSn and WS.Pno = p.Pnumber and p.Pnumber = @P_number 
	 Return 
	End 

	------------calling function 
	  select * from dbo.GetEmployeeOfProject(400)