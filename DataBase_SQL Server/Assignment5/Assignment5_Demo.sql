-----------------Demo of session6 --------------------------
use ITI
----Group By
s
Select Dept_Id ,min(Salary)
from Instructor
where Dept_Id is not null
Group By Dept_Id

------Get  # students study in each depatment
Select Dept_Id ,count(*) as numberofstudent
from student
where Dept_id is not null
Group By Dept_id

------Example for calculate sum of salary when # of instructor more than ten

Select sum(salary)
from Instructor
having count(*) >10

------------example for select item with aggregate fun 

Select Dept_Id , St_Address ,count(*) as numberofstudent
from student
where Dept_id is not null and St_Address is not  null
Group By Dept_id ,St_Address

-----------select # of student and name of our supervisor  (must check if you have  more than instructor have same name using Group Key)

Select  super.St_Fname ,count(*) as numberofstudent
from student std ,Student super
where std.St_super =super.St_Id
Group By super.St_Id ,super.St_Fname


------------example for subquery display age which more than avarage of students

Select St_Id,St_Fname ,St_Age
from Student
where St_Age > (select AVG(St_Age)
                 from Student )

---------------another example for display each student and number of students

Select st_id ,(select count (*) from Student)
from Student


-----------using subquery with  delete

Delete  from Stud_Course
where St_Id in (select St_Id from Student  where St_Address ='cairo')


-------------using Top

------select first two studens

Select TOP(2)*
from Student

-----select last two student

Select TOP(2) St_Id ,St_Fname
from Student
order By St_Id Desc
 
 ----------if you want select instractor which have max salary

 Select max(Salary) as maxSalary
 from Instructor

 -----------select second max salary for instructor
 Select max(Salary) as maxSalary
 from Instructor
where Salary != (Select max(Salary) as maxSalary
 from Instructor)
  -----------another way

 Select  top(1)* 
 from (select top (2) Ins_Name ,Ins_Id ,Salary
       from Instructor
	   order by salary desc
 ) as tt  ---sub query get 2nd max 
 order by salary -- take the second small from first


 --------- top with ties for get if last value have another same value

 Select  top(5) with ties  St_Age
 from Student
 order By st_Age Desc


 ---------Random selection 
  Select St_Fname ,NEWID()
  from Student

   Select Top(2)*
  from Student 
  order By NEWID()

  create Table orders (
  id varchar(50) default newid() primary key ,
  totalval decimal (5,2)
  )

------------Ranking
------ROW_number()
------Dense_Rank()
------Rank()

Select Ins_Id ,Ins_Name,Salary,
      ROW_number() OVER (order by salary Desc)as RN ,
	  Dense_Rank() OVER (order by salary Desc)as DR ,
	  Rank() OVER (order by salary Desc)as Rankk
from Instructor

----NTILE() 

Select Ins_Id ,Ins_Name,Salary,
      NTILE(4) OVER (order by salary Desc)as ntileGroup
from Instructor

-------GET the 5th younger student 

----using TOP (best practise result of subquery is 5 rows)
 Select  top(1)* 
 from (select top (5) St_Fname,St_Id ,St_Age
       from Student
	   where St_Age is not null
	   order by St_Age
 ) as tt  ---sub query get 2nd max 
 order by St_Age
----using Ranking (result of subquery is all table)

Select * 
from ( select St_Fname,St_Id ,St_Age ,
      ROW_number() OVER (order by st_age Desc) as RN
		   from Student
	   where st_age is not null ) as tt
where RN=5
