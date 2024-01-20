------------------------------Demo _Session8 ----------------------------

--1- standard view
go
 create OR Alter view AlexStudentsView
 AS
 --body(query)
  select St_Id ,St_Fname ,St_Address
  from Student
  where St_Address ='Alex'
   go
  -----calling 
  select* from AlexStudentsView
 
 -- 2- partitioned view
 go

 create OR Alter view CairoAlexStudents
 AS
  select * from CairoStudentView
  UNION
   select * from AlexStudentsView
   go
  -----calling 
  select* from CairoAlexStudents


  -------------------more examples on view
  -----oartitioned view
  go
   create view studentInDepartment 
    AS
	select s.St_Id ,s.St_Fname ,d.Dept_Id ,d.Dept_Name
	from Student  s,Department d
	where s.Dept_Id=d.Dept_Id
	go
	-----calling 
  select* from studentInDepartment 

  ------Alter schema  to take object of DB
  Alter  Schema sales
  transfer [dbo].[studentInDepartment]

  ----Build in Procedure take text return query
  exec sp_helptext 'studentInDepartment '

  -----using with encryption to scure object of DB
  go
   create OR Alter view CairoStudentsView
   with encryption
 AS
 --body(query)
  select St_Id ,St_Fname ,St_Address
  from Student
  where St_Address ='Cairo'
   go
  -----calling 
  select* from CairoStudentsView

  -------------------- by using alise name to donot show column name of table
  go
     create OR Alter view CairoStudentsView (studentID , studentName ,AddressOFStudent)
   with encryption
 AS
 --body(query)
  select St_Id ,St_Fname ,St_Address
  from Student
  where St_Address ='Cairo' with check option ----check constrain to ensure that all data which added achieve constrain
   go
  -----calling 
  select* from CairoStudentsView

  -------------------- another example 
  go
  Create OR Alter view Student_courseView (StudentID ,StudentName ,CourseName ,GradeOfStudent)
   with encryption
   AS
    select S.St_Id ,S.St_Fname ,c.Crs_Name ,SC.Grade
	from Student S,Stud_Course SC,Course C
	where S.St_Id =SC.St_Id and SC.Crs_Id =C.Crs_Id
	go
	------------calling
	 select* from Student_courseView
	 ---------------------View with DML
	 -----------view ---> one table
		 -----insert
	
		 insert into CairoStudentsView
		 values(30,'Ayman','tanta') ----have error that constrain not achieved
	
		 -----update values of columns of view only
		 update CairoStudentsView
		   set studentName ='yasmin'
		   where studentID =30
	   -----delete values of columns of view only
	   delete CairoStudentsView
	   where studentID =30

----------------view ---> more than one table
    ------Delete (can not delete because that effect confilct with another table)
	-------insert
	 insert into Student_courseView (StudentID ,StudentName)  ----must detect احدد columns which want to insert as new data if you given all data it  consider you want add new student in table student and new depart in table department and this is impossible xxxxxx add data to more than one table at same time
	 values (101 ,'mohamed')
	 ------update
	 update Student_courseView
	   set GradeOfStudent = 108
	   where StudentID = 1

---------------------------------------Stored Procedure
go
Create Procedure SP_GetStudentId @st_id int
AS
  select *
  from Student
  where st_id = @st_id

  go
  ------------calling
   SP_GetStudentId 1

   ---insert based on execute
   insert into studentWithSepecificId  --table name
   Exec  SP_GetStudentId 1   ---insert result of procedure in table

   ------------Handling Error
   go
   Create OR Alter procedure DeleteTopic @topId int
   with encryption
   AS
    Begin try
	Delete from topic
	where top_id = @topId
	Declare @datavalue int =4 ---not execute when happen error when delete topic
	End try

	Begin catch
	   select 'Have Error when delect this topic'
	End catch

	-----------------procedure input parameter
	go
	create procedure sp_sumData @x int =2,@y varchar (max) ='4'
	with encryption
	AS
	 select @x +@y

	 ---calling
	exec sp_sumData 5 ,7
	exec sp_sumData  --take default value
	exec sp_sumData 5 --in order x=5 ,y=4
	exec sp_sumData '8' --error
	exec sp_sumData @y='8'  --x=2 ,y=8

	---------------procedure output parameter
	go
	create procedure sp_getData @id int ,@name varchar (max) output
	AS
	 select @name =st_fname
	 from Student
	 where St_Id= @id

	 ----calling 
	 Declare @studentName varchar(max) --store in output
	 exec sp_getData 3 , @studentName output ---store out of name for student id =3 in var
	 select @studentName  ---display name in variable

	 
	---------------procedure input-output parameter
	go
	create procedure sp_getDataV02 @Data int output ,@name varchar (max) output
	AS
	 select @name =st_fname ,@Data =St_Age
	 from Student
	 where St_Id= @Data

	 ----calling 
	 Declare @DataRes int =3 , @studentName varchar(max) --store in output
	 exec sp_getDataV02 @DataRes output , @studentName output ---store out of name for student id =3 in var
	 select @studentName  ---display name in variable

	 




