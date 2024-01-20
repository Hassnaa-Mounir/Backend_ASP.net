--------------------------------Assignment7--------------------------
-------------------- Part 04
 ----create DB named RouteCompany
 use RouteCompany
 Create Table Department 
 (
  DeptNo int primary key,
  DeptName varchar(max),
  [Location] varchar(max)
 )
 insert into Department
 values(1,'Research', 'NY'),
 (2,'Accounting', 'DS'),(3,'Marketing','KW')
 Create Table Employee
 (
  EmpNo int primary key,
  EmpFname varchar(max) not null,
  EmpLname varchar(max) not null,
  DeptNo  int references Department(DeptNo) ,
  salary int unique
 )
 ---insert data to employee by waizard
insert into Works_on(EmpNo)
values(11111)
---having error because ProjectNO donot accept null must give value for projectNo
update Works_on
 set EmpNo = 11111
 where EmpNo =10102
 ----happen confilct because empNo has aforeign key from table employee must  can solve this by change updateRule to cascade 
 ---update employee.empNo the first

 -------------modification
 Alter Table employee
 add phone varchar(max)

 Alter Table employee
 drop column phone

 -----------2.Create the following schema and transfer the following tables to it 
 ---a
 go
 Create schema Company
 go
 alter schema Company
 Transfer dbo.Department

 alter schema Company
 Transfer dbo.Project

 ----b
 go
 Create schema HumanResourses
 go
 alter schema HumanResourses
 Transfer dbo.employee

 ----3. Increase the budget of the project where the manager number is 10102 by 10%.
 update Company.Project
   set budget += budget *.1
   where projectNo in( select ProjectNo
                        from dbo.Works_on ws
                         where EmpNo = 10102 )
----4. Change the name of the department for which the employee named 
--James works.The new department name is Sales.

update company.Department
  set DeptName ='sales'
where DeptNo in( select DeptNo
                from HumanResourses.Employee
				where EmpFname ='James')

-----5. Change the enter date for the projects for those employees who work in project p1 and belong to department ‘Sales’. The new date is 12.12.2007.

update dbo.Works_on
   set Enter_Date ='12.12.2007'
   where ProjectNo=1 and EmpNo in (select EmpNo from HumanResourses.Employee E,Company.Department D
                                   where d.DeptNo =e.DeptNo and DeptName='sales')

----6. Delete the information in the works_on table for all employees who work for the department located in KW.delete  from dbo.Works_onwhere EmpNo in (select EmpNo from HumanResourses.Employee E,Company.Department D
                                   where d.DeptNo =e.DeptNo and Location='KW')