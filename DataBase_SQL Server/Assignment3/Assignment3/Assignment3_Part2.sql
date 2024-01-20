--create Queries on DataBase Mycompany 
use MyCompany

             ----Part2  1.Try to create the following Queries:--------

----1.Display all the employees Data.

 select *
  from Employee

-----2.Display the employee First name, last name, Salary and Department number

  select Fname,Lname ,Salary ,Dno 
  From Employee
  
  --2.a ->Display all the projects names, locations and the department which is responsible for it.
  select Dnum ,Pname ,Plocation
  From Project
   
----3.Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
    select fullname= Fname +' '+ Lname ,Annual_Salary = Salary *12 *0.1
	From Employee
  
 ---4.Display the employees Id, name who earns more than 1000 LE monthly.
    select SSN ,fullname= Fname +' '+ Lname 
	From Employee
	where Salary >1000

----5.Display the employees Id, name who earns more than 10000 LE annually.
   select SSN ,fullname= Fname +' '+ Lname --,Annual_Salary = Salary *12 
	From Employee
	where Salary*12 >10000
	
----6.Display the names and salaries of the female employees 
    select fullname= Fname +' '+ Lname ,Salary
	From Employee
	where Sex='f'

----7.Display each department id, name which is managed by a manager with id equals 968574.
    select Dnum ,Dname --,MGRSSN
    From Departments
	where MGRSSN = 968574

----8.Display the ids, names and locations of  the projects which are controlled with department 10. 
    select Pnumber,Pname ,Plocation  --,Dnum
	From Project
	where Dnum =10

	---------------Part2  2.2.	Data Manipulation Language:


-----1. insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.

      insert Employee
	  values(null,null,102672,null,null,null,3000,112233,30)
-----another way
      insert Employee(Dno,SSN,Superssn,Salary)
	  values(30,102672,112233,3000)

-----2.Insert another employee with your friend's personal data as a new employee in department number 30, SSN = 102660, but don’t enter any value for salary or manager number to him.

      insert Employee(Dno,SSN)
	  values(30,102660)
-----another way
        insert Employee
	  values(null,null,102660,null,null,null,30)


----3.Upgrade your salary by 20 % of its last valu
    
	update Employee
	set Salary += Salary*0.2

