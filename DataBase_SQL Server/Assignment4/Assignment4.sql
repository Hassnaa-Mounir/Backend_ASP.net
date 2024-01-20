-- Using Database ITI

use ITI

------part 01
  -- 1.Get all instructors Names without repetition
   
   Select Distinct Ins_Name
    From Instructor

   --2.	Display instructor Name and Department Name note:display all the instructors if they are attached to a department or not
    
	SELECT I.Ins_name, D.Dept_Name
    FROM Instructor I LEFT JOIN Department D ON I.Dept_Id = D.Dept_Id

	--3.Display student full name and the name of the course he is taking For only courses which have a grade  

	Select 'Full name' =S.St_Fname +' '+S.St_Lname , C.Crs_Name
	from Student S inner join Stud_Course SC
	on S.St_Id =SC.St_Id
	inner join Course C
	on C.Crs_Id =SC.Crs_Id

	--BOUNS point
	 --@@AnyExpression meaning -->used with specific system variables or functions
	
	Select @@VERSION
      	--returns the version information of the SQL Server instance.

    Select @@SERVERNAME
	    --returns the name of the SQL Server machine


---------------Part 02
   use MyCompany

   --1.	Display the Department id, name and id and the name of its manager.

     Select  D.Dnum ,D.Dname ,E.SSN ,'full name'=E.Fname+ ' ' +E.Lname
	 from Departments D,Employee E
	 where D.MGRSSN = E.SSN

   --2.	Display the name of the departments and the name of the projects under its control.
     
	 select D.Dname ,P.Pname 
	 from Departments D inner join project P
	 on D.Dnum = P.Dnum

  --3.Display the full data about all the dependence associated with the name of the employee they depend on 

     Select D.* ,'EmployeeName'= E.Fname + ' '+E.Lname
	 from Dependent D inner join Employee E
	 on D.ESSN =E.SSN

	 --4.Display the Id, name and location of the projects in Cairo or Alex city.

	 Select Pname , Pnumber ,Plocation 
	 from Project 
	 where City in ('cairo','Alex')

	
	--5.Display the Projects full data of the projects with a name starting with "a" letter.
	
	Select *
	from Project
	where Pname like'a%'

	--6.display all the employees in department 30 whose salary from 1000 to 2000 LE monthly

	Select  *
	from Employee
	where Dno=30 and Salary between 1000 and 2000

	--7.Retrieve the names of all employees in department 10 who work more than or equal 10 hours per week on the "AL Rabwah" project.

	Select CONCAT_WS(' ' ,Fname ,Lname) --, p.pname
	from Employee E inner join Works_for WS
    on E.SSN = WS.ESSn
	Inner Join Project P
	on WS.Pno =P.Pnumber
	where P.Dnum =10 and (p.Pname ='AL Rabwah' and WS.Hours > =10 )

	--8.Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.

    Select 'name of employee' = CONCAT_WS(' ' ,Fname ,Lname) , p.pname
	from Employee E inner join Works_for WS
    on E.SSN = WS.ESSn
	Inner Join Project P
	on WS.Pno =P.Pnumber
	order By Pname

	--9.For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.

	Select P.Pnumber ,D.Dname ,E.Lname ,E.Address ,E.Bdate
	from Departments D inner join Project P
    on D.Dnum =P.Dnum
	Inner Join Employee E
	on E.SSN =D.MGRSSN
	where P.City ='cairo'

	-------------------Part 03 
	use ITI

	--1.Retrieve a number of students who have a value in their age. 
	 
	 Select COUNT(St_age)
	 from Student

	 --2.Display number of courses for each topic name 

	SELECT T.Top_Name, COUNT(C.Crs_Id) AS NumberOfCourses
    FROM Topic T inner JOIN Course C 
    ON T.Top_Id = C.Top_Id

	--3.Select Student first name and the data of his supervisor (self join)

	Select st.St_Fname ,supervisor.*
	from Student st , Student supervisor
	where st.St_super =supervisor.St_Id

	--4.Display student with the following Format (use isNull function)
	 Select S.St_Id , ISNULL(S.st_Fname + ' '+S.St_Lname ,'no name') 'full name', isnull(D.Dept_Name,'no depart name')
	 from Student S,Department D
	 where s.Dept_Id=d.Dept_Id

	 --5.Select instructor name and his salary but if there is no salary display value ‘0000’ . “use one of Null Function” 
	  Select Ins_Name ,ISNULL(Salary,'0000')
	  from Instructor
	  --6.	Select Supervisor first name and the count of students who supervises on them
	  Select supervisor.St_Fname , COUNT(st.St_Id) AS NumberOfStudents
	  from Student st , Student supervisor
	  where st.St_super =supervisor.St_Id
	  GROUP BY  supervisor.St_Fname

	  --7.	Display max and min salary for instructors
	   Select MAX(Salary) as maxofsalary ,MIN(Salary) as minofsalary
	   from Instructor

	   --8.	Select Average Salary for instructors 
	   Select AVG(Salary) as avarageofsalary
	   from Instructor
	   
	   --9.	Display instructors who have salaries less than the average salary of all instructors.

	   select *
	   from Instructor
	   where Salary < (SELECT AVG(Salary) FROM Instructor)

	   --10.	Display the Department name that contains the instructor who receives the minimum salary

	  /* Select D.Dept_Name
	   from Department D inner join Instructor ins
	   on D.Dept_Id = ins.Dept_Id 
	   where  ins.Salary  = (SELECT MIN(ins.Salary) FROM Instructor)*/
	   -- Corrected Query
		SELECT Dept_Name
		FROM Department
		WHERE
			Dept_Id IN (SELECT Dept_Id FROM Instructor WHERE Salary = (SELECT MIN(Salary) FROM Instructor))

------------------------Part 04
use MyCompany
   ------4.1 DQL
   --1.	For each project, list the project name and the total hours per week (for all employees) spent on that project.

   Select P.Pname, WS.Hours
   from Project P ,Works_for WS
   where P.Pnumber =WS.Pno

   --2.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

   Select D.Dname , MAX(Salary) as maximumSalary,MIN(Salary) as minimumSalary ,AVG(Salary) as avarageSalary
   from Departments D inner join Employee E
   on D.Dnum =E.Dno
   GROUP BY D.Dname

   --3.	Retrieve a list of employees and the projects they are working on ordered by department and within each department, ordered alphabetically by last name, first name.
   Select E.Fname+ ' '+Lname ,P.Pname ,P.Pnumber ,Dno
   from Employee E inner join Works_for WS
   on E.SSN = WS.ESSn
   inner join Project P
   on WS.Pno =P.Pnumber
   order By Dno,E.Lname ,E.Fname
   

   --4.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 
   
   Update E
    set salary += salary *0.3
   from Employee E inner join Works_for WS
   on E.SSN = WS.ESSn
   inner join Project P
   on p.Pnumber = WS.Pno
   where p.Pname = 'Al Rabwah'

 -------4.2 DML
 --1.In the department table insert a new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'.
 INSERT INTO Departments
 values ('DEPT IT',100,112233,'1-11-2006')

 --2.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 

 --a.	First try to update her record in the department table
  Update Departments
     set  MGRSSN =102672
    where Dnum =20

 --b.	Update your record to be department 20 manager.

 Update Departments
     set  MGRSSN =102672
    where Dnum =100

--c.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
Update Employee
   set Superssn=102672
where SSN = 102660
use MyCompany

----3.	Unfortunately the company ended the contract with  Mr.Kamel Mohamed (SSN=223344) so try to delete him from your database in case you know that you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handles these cases).
--check if works on any projects
update Works_for
      set ESSn=968574
where ESSn = 223344

--checking if have dependences
Delete from Dependent
where ESSN = 223344

-----------------------------confilct
--check if manager in any departments
update Departments
     set MGRSSN = 512463
 where MGRSSN = 223344
 
 --------update superemployee
 update Employee
       set Superssn= 968574
where Superssn =223344

--delete from database
Delete from Employee
where SSN = 223344

-----------------------------------Part 05
 use MyCompany

 -----1.	Retrieve the names of all employees in department 10 who work more than or equal 10 hours per week on the "AL Rabwah" project.
	  
	  Select CONCAT_WS(' ' ,Fname ,Lname) --, p.pname
	from Employee E inner join Works_for WS
    on E.SSN = WS.ESSn
	Inner Join Project P
	on WS.Pno =P.Pnumber
	where P.Dnum =10 and (p.Pname ='AL Rabwah' and WS.Hours > =10 )

------2.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name

     Select 'name of employee' = CONCAT_WS(' ' ,Fname ,Lname) , p.pname
	from Employee E inner join Works_for WS
    on E.SSN = WS.ESSn
	Inner Join Project P
	on WS.Pno =P.Pnumber
	order By Pname

------3.For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate
 
   	Select P.Pnumber ,D.Dname ,E.Lname ,E.Address ,E.Bdate
	from Departments D inner join Project P
    on D.Dnum =P.Dnum
	Inner Join Employee E
	on E.SSN =D.MGRSSN
	where P.City ='cairo'

-------4.	Display the data of the department which has the smallest employee ID over all employees' ID

select D.*
from Departments D inner join Employee E
on  D.Dnum = E.Dno
where E.SSN = (SELECT min(Ssn) FROM Employee)

------5.	List the last name of all managers who have no dependents
 
   select distinct lname 
   from  Employee manage, Dependent D
   where manage.Superssn <> D.ESSN and Lname is not null

-----6.	For each department-- if its average salary is less than the average salary of all employees display its number, name and number of its employees.

      Select D.Dnum,D.Dname , COUNT(E.SSN) AS NumberOfEmployees
	  from Departments D inner join Employee E
	  on Dno =Dnum
	  GROUP BY D.Dnum, D.Dname
	  HAVING AVG(E.Salary) < (SELECT AVG(Salary) FROM Employee)

------7.	Try to get the max 2 salaries using subquery

	SELECT DISTINCT Salary
    FROM Employee
    WHERE Salary IN (
		SELECT DISTINCT TOP 2 Salary
		FROM Employee
		ORDER BY Salary DESC)