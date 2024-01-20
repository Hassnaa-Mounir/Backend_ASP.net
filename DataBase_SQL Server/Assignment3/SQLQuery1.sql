-- single line 



/*
....
....
....
.....
*/


--------------------------- Data Types ----------------------------
------------------- 1.Numeric Data Types
bit         -- Boolean Value 0[false]  : 1[true] 
tinyint		-- 1 Byte => -128:127		| 0:255 [Unsigned(Positive)]
smallint	-- 2 Byte => -32768:32767	| 0:65555 [Unsigned] 
int			-- 4 Byte 
bigint		-- 8 Byte

------------------- 2.Fractions Data Types
smallmoney	4B.0000            -- 4 Numbers After Point
money		8B.0000            -- 4 Numbers After Point 
real		  .0000000         -- 7 Numbers After Point
float		  .000000000000000 -- 15 Numbers After Point
dec			-- Datatype and Make Valiadtion at The Same Time => Recommended
dec(5, 2) 124.22	18.1	12.2212 XXX 2.1234

------------------- 3.String Data Types 
char(10)		[Fixed Length Character]	Ahmed 10	Ali 10	
varchar(10)		[Variable Length Character]	Ahmed 5		Ali 3
nchar(10)		[like char(), But With UniCode] على ???
nvarchar(50)	[like varchar(), But With UniCode] على
nvarchar(max)	[Up to 2GB]
varchar(max)

------------------- 4.DateTime Data Types
Date			MM/dd/yyyy
Time			hh:mm:ss.123 --Defualt=> Time(3)
Time(4)			hh:mm:ss.1234
smalldatetime	MM/dd/yyyy hh:mm:00
datetime		MM/dd/yyyy hh:mm:ss.123
datetime2(4)	MM/dd/yyyy hh:mm:ss.1234
datetimeoffset	11/23/2020 10:30 +2:00 Timezone

------------------- 5. Binary Data Types
binary 01110011 11110000
image

------------------- 6. Other Data Types
Xml
sql_variant -- Like Var In Javascript



==================================================================
--------------------------- Variables ----------------------------

---global variables 

Select @@ServerName 

select @@Version 


---Local variables 


declare @Number int = 20 

print @Number 

set @Number = 80 
 print @Number 

 
--DDL Data Definition Language 
--Create  

Create Database Cycle41G01

use Cycle41G01


Create table Employees
(
	id int primary key identity(1,1),
	FName varchar(10) not null ,
	LName varchar, 
	BirthDate date ,
	Gender char(1) , 
	Address  varchar(50) , 
	salary  money  default  5000,
	SuperId int references Employees(id),
	DeptId int


)


Create Table Departments 
(
	Number int primary key identity(100,100),
	Name varchar(20) not null ,
	HiringDate date ,
	MGId int references Employees(id)
)

Create Table Locations 
(
	Location varchar(50),
	DeptNum int references Departments(Number)
	primary key (Location  , DeptNum)
)

-- Alter 

alter table  Employees 
add foreign key (DeptId) references Departments(Number)



alter Table Employees
alter column LName varchar(20) Not null 



alter Table Employees
drop column BirthDate


drop table Locations 


drop table departments 



alter Table Employees
drop constraint [FK__Employees__DeptI__412EB0B6]