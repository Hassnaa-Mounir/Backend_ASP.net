------------------------	Assignment5 ---------
use ITI

-------Part 01
---1.Display instructors who have salaries less than the average salary of all instructors.
 Select  Ins_Id ,Ins_Name,Salary
 from Instructor
 where salary < (select AVG(salary)
                  from Instructor)

--2.Display the Department name that contains the instructor who receives the minimum salary
Select d.Dept_Name
from Department D,Instructor ins
where D.Dept_Id =ins.Dept_Id and ins.Salary in(select min(salary)
                                                  from Instructor)
------------------------------------------------------------------------------

use  MyCompany
				  
--3. Display the data of the department which has the smallest employee ID over all employees' ID.
 Select D.*
 from Employee E,Departments D
 where E.Dno =D.Dnum and SSN in(select min(SSN) from Employee)

 --4. List the last name of all managers who have no dependents

SELECT manage.Lname
FROM Employee manage LEFT JOIN Dependent D
  ON Manage.Superssn = D.ESSN
WHERE D.ESSN is NULL and lname is not null

--5. For each department-- if its average salary is less than the average salary of all employees display its number, name and number of its employees

 Select distinct D.Dnum, D.Dname 
 from Departments D , Employee E
 where D.Dnum =	E.Dno and salary < (select AVG(salary)
                                        from Employee)

--6. Try to get the max 2 salaries using subquery.
Select Salary
from  Employee
where Salary in(select top(2) Salary from Employee order by salary desc)
order By salary Desc


use ITI

--7.Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”

Select * 
from (select ins_id ,ins_name ,salary,
       ROW_NUMBER() over (partition by D.Dept_id order by salary desc ) as RN
	   from instructor INS ,Department D
	   where INS.Dept_Id =D.Dept_Id and ins.Dept_Id is not null and salary is not null) as result
where result.RN <=2

--8.Write a query to select a random student from each department. “using one of Ranking Functions”
select *
from (select std.st_id , std.Dept_Id ,
        ROW_NUMBER() over (partition by D.Dept_id order by Newid()  ) as RN
	   from Student std ,Department D
	   where std.Dept_Id =D.Dept_Id and std.Dept_Id is not null ) as result
 where RN =1


-------------------------------------Part 02
use AdventureWorks2012

--1. Display the SalesOrderID, ShipDate of the SalesOrderHearder table (Sales schema) to designate SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’

Select SalesOrderID, ShipDate -- , OrderDate
from Sales.SalesOrderHeader
where orderDate between '7/28/2002' and '7/29/2014'

--2.Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)

Select ProductID, [Name]
from Production.Product
where StandardCost < 11000

--3. Display ProductID, Name if its weight is unknown

Select ProductID, [Name]
from Production.Product
where [Weight] is null

--4. Display all Products with a Silver, Black, or Red Color

Select *
from Production.Product
where color in('silver' , 'black' , 'Red')

 --5. Display any Product with a Name starting with the letter B
 
Select *
from Production.Product
where [Name] Like 'B%'

---6. Run the following Query

UPDATE Production.ProductDescription
      SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3---7.Then write a query that displays any Product description with underscore value in its description.

Select *
from  Production.ProductDescription
where [Description] like '%_%'


---8. Display the Employees HireDate (note no repeated values are allowed)

Select distinct HireDate
from HumanResources.Employee

---9. Display the Product Name and its ListPrice within the values of  100 and 120 the list should have the following format "The [product name] is only! [List price]" (the list will be sorted according to its ListPrice value)

Select concat(Name , 'is only!' , ListPrice ) 'The [ product name ] is only! [ List price]'
from Production.Product
where ListPrice between 100 and 120
