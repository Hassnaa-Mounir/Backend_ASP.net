-----------------Assignment8-----------------------
use iti
go
---•Create a trigger to prevent anyone from inserting a new record in the Department table ( Display a message for user to tell him that he can’t insert a new record in that table )
CREATE TRIGGER PreventInsertDepartment
ON Department
INSTEAD OF INSERT
AS
   select 'Insert operation not allowed on the Department table.'

   ---for test 
   insert into Department (Dept_Id,Dept_Name)
   values(122 ,'Angular')

   ---•Create a table named “StudentAudit”. Its Columns are (Server User Name , Date, Note) 
   CREATE TABLE StudentAudit (
    ServerUserName NVARCHAR(255),
    [Date] DATETIME,
    Note NVARCHAR(MAX)
            );

  go----
  
CREATE TRIGGER AfterInsertStudentAudit
ON Student
AFTER INSERT
AS

    INSERT INTO StudentAudit (ServerUserName, [Date], Note)
    SELECT 
        SYSTEM_USER AS ServerUserName,
        GETDATE() AS [Date],
        '[' + SYSTEM_USER + '] Inserted New Row with Key = ' + CAST(St_Id AS NVARCHAR(50)) + ' in table [Student]' AS Note
    FROM INSERTED

	go
	-----



CREATE TRIGGER InsteadOfDeleteStudentAudit
ON Student
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @DeletedRows TABLE (
        StudentId INT
    );

    INSERT INTO @DeletedRows (StudentId)
    SELECT St_Id
    FROM DELETED;

    INSERT INTO StudentAudit (ServerUserName, [Date], Note)
    SELECT 
        SYSTEM_USER AS ServerUserName,
        GETDATE() AS [Date],
        'Attempted to delete Row with id = ' + CAST(StudentId AS NVARCHAR(50)) AS Note
    FROM @DeletedRows;
END

go
------

use MyCompany
go
----
CREATE TRIGGER PreventInsertMarchEmployee
ON Employee
INSTEAD OF INSERT
AS
BEGIN
    IF (SELECT COUNT(*) FROM INSERTED WHERE MONTH(Bdate) = 3) > 0
    BEGIN
        select 'Insert operation not allowed for Employee records in March.'
    END
    ELSE
    BEGIN
        INSERT INTO Employee
        SELECT *
        FROM INSERTED;
    END
END

go
-----




-- Create the Audit tableCREATE TABLE Audit (    ProjectNo NVARCHAR(50),    UserName NVARCHAR(50),    ModifiedDate DATETIME,    Budget_Old INT,    Budget_New INT);gouse [SD32-Company]go-- Create the triggerCREATE TRIGGER HR.BudgetUpdateAuditON HR.ProjectAFTER UPDATEASBEGIN    IF UPDATE(Budget)    BEGIN        INSERT INTO Audit (ProjectNo, UserName, ModifiedDate, Budget_Old, Budget_New)        SELECT d.ProjectNo,SYSTEM_USER,GETDATE(),d.Budget,i.Budget        FROM            inserted i            INNER JOIN deleted d ON i.ProjectNo = d.ProjectNo            WHERE i.Budget <> d.Budget;    ENDEND;


go
---------------------part-3-------------------------

   use iti
   go
   ---•	Create an index on column (Hiredate) that allows you to cluster the data in table Department. What will happen?
   -----you will  create nonclustered index because department table is have primary key dept_id that clustered index you can''t make another clustered index

   Create nonclustered index IX_HiringDate
   on Department(Manager_hiredate)

   select * from  Department where Manager_hiredate='2000-01-01'


   -----•Create an index that allows you to enter unique ages in the student table. What will happen?
   ---------you will create 
   CREATE UNIQUE INDEX IX_UniqueAge_Student
   ON Student (St_Age)

  -- If you try to insert a new row with an age that already exists in the table, the database will raise a unique constraint violation error, and the insert operation will be rejected.
		
  -- Create Login
CREATE LOGIN RouteStudent WITH PASSWORD = 'YourPassword';

-- Use ITI Database
USE ITI

-- Create User for the Login in the ITI Database
CREATE USER RouteStudentUser FOR LOGIN RouteStudent

-- Grant SELECT and INSERT permissions on student and Course tables
GRANT SELECT, INSERT ON student TO RouteStudentUser
GRANT SELECT, INSERT ON Course TO RouteStudentUser

-- Deny DELETE and UPDATE permissions on student and Course tables
DENY DELETE, UPDATE ON student TO RouteStudentUser
DENY DELETE, UPDATE ON Course TO RouteStudentUser

go
-----------------------part-4---------------------------------------------

-- Create the ReturnedBooks table
CREATE TABLE ReturnedBooks (
    UserSSN INT,
    BookId INT,
    DueDate DATE,
    ReturnDate DATE,
	AmountPaid DECIMAL(10, 2),
    Fees DECIMAL(10, 2)
);
go

-- Create the trigger
CREATE TRIGGER InsteadOfInsertReturnedBooks
ON ReturnedBooks
INSTEAD OF INSERT
AS
BEGIN
    IF (SELECT COUNT(*) FROM INSERTED WHERE ReturnDate <> DueDate) > 0
    BEGIN
        UPDATE ReturnedBooks
        SET Fees =ReturnedBooks.AmountPaid * 0.2
        FROM INSERTED
        WHERE ReturnedBooks.UserSSN = INSERTED.UserSSN
            AND ReturnedBooks.BookId = INSERTED.BookId;

        INSERT INTO ReturnedBooks (UserSSN, BookId, DueDate, ReturnDate, Fees)
        SELECT UserSSN, BookId, DueDate, ReturnDate, Fees
        FROM INSERTED;
    END
    ELSE
    BEGIN
        INSERT INTO ReturnedBooks (UserSSN, BookId, DueDate, ReturnDate, Fees)
        SELECT UserSSN, BookId, DueDate, ReturnDate, 0
        FROM INSERTED;
    END
END;
go
-----------------------------------------------------
-- Preventing actions on the Employee table

use MyCompany
go

CREATE TRIGGER PreventActionsOnEmployee
ON Employee
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
     select 'You are not allowed to modify or delete or insert into the Employee table.'
END;

------------------------------------------------------------
--Testing Referential Integrity , Mention What Will Happen When: 
--Create an index on column (Salary) that allows you to cluster the data in table Employee
go
create nonclustered index IX_salary on Employee
-- we can't make clustered index on employee table, because employee table has clustered index (primary key)
-- you made nonclustered index on salary column might affect referential integrity.

------------------------------------------------------------
use Library

-- Create a login

CREATE LOGIN hassnaa WITH PASSWORD = '20190180';

-- Create a user for the login
CREATE USER YourNameUser FOR LOGIN hassnaa;

-- Grant SELECT and INSERT permissions on Employee and Floor tables
GRANT SELECT, INSERT ON Employee TO YourNameUser;
GRANT SELECT, INSERT ON Floor TO YourNameUser;

-- Deny DELETE and UPDATE permissions on Employee and Floor tables
DENY DELETE, UPDATE ON Employee TO YourNameUser;
DENY DELETE, UPDATE ON Floor TO YourNameUser;



--------------------------


