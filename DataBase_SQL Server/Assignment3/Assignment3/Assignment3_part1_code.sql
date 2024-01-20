--Create Database of Assignment3_part1_code
create Database Assignment3_part1_code
use Assignment3_part1_code


 -- create table students with attributtes

 Create Table Students 
 (
 id int primary key identity(1,1),
 Fname varchar(30) not null,
 Lname varchar(30) not null,
 Age int ,
 [Address] varchar(50),
 Dep_id int not null
 )

 -- create table departments with attributtes

 Create Table Departments
 (
 Dep_id int primary key ,
 D_name varchar(30),
 hiringDate Date ,
 ins_id int unique not null
 )
 

 -- create table instructors with attributtes

 Create Table Instructors
 (
 ins_id int primary key ,
 ins_name varchar(30)not null,
 [Address] varchar(50),
 Bouns varchar(25),
 salary int ,
 hourRate int  ,
 D_id int references Departments(Dep_id) not null
 )
 
 -- create table courses with attributtes

 Create Table Courses
 (
 C_id int primary key ,
 C_name varchar(30) not null ,
 Duration varchar(50),
 [Description] varchar(50),
 top_id int not null
 )
 
 -- create table topics with attributtes

 Create Table Topics
 (
 T_id int primary key identity(10,10),
 T_name varchar(30) not null
 )

 -- create table Stud_Course with attributtes

 Create Table Stud_Course
 (
   Stud_id int references Students(id) not null,
   course_id int references Courses(C_id) not null,
   Grade int not null,
   primary key(Stud_id,course_id)
 )
 
 -- create table Course_instructor with attributtes

 Create Table Course_instructor
 (
 Course_id int references Courses(C_id),
 inst_id int references Instructors(ins_id),
 primary key (Course_id,inst_id),
 Evaluation int not null
 )
 

 --add forgin key in table students to linked between tables Students and departments

 Alter Table Students
 add foreign key (Dep_id) references Departments(Dep_id)

 --add forgin key in table departments to linked between tables courses and departments

  Alter Table Departments
 add foreign key (ins_id) references Instructors(ins_id)

 --add forgin key in table courses to linked between tables topics and courses

  Alter Table Courses
 add foreign key (top_id) references Topics(T_id)  


 ---add two row for each table
 ---table student

 insert into Students
 values('ahmed' , 'mounir', 22,'shobra_giza',10),
      ('mostafa' ,'mohamed', 25,'zamalk_cairo' ,20)

-- table departments
insert into Departments
values(12,'computer_science','11-22-2023',30),
      (15,'Artificial_intelliegence','3-18-2020',50)

-- table instractors
insert into Instructors
values(30,'mohamad','nasr_city','25',5000,40,30),
      (10,'mayar','smart_village','75',9000,80,40)



-- table courses
insert into Courses
values(20,'algorithms','gamal_elden','improving code',10),
     (40,'Data Structure','amin_allam','building by way correctly',30)

-- table stud_course
insert into Stud_Course
values(11,20,75),
      (21,40,95)

-- table course_instractors
insert into Course_instructor
values(40,55,87),
      (50,65,84)

-- table topics
insert into Topics
values ('Machine learning'),
       ('LinkedList')




