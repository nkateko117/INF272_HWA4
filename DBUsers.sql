If Exists (Select * from sys.databases where name = 'DBUsers')
DROP DATABASE DBUsers
Go
Create Database DBUsers
Go

use DBUsers

Create Table Users
(
ID_Number varchar (20) primary key not null,
First_Name varchar (50) not null,
Last_Name varchar (50) not null,
User_Type varchar (10) not null,
Cellphone varchar (15) not null,
Email varchar (50) not null,
Age varchar (5) not null,
Gender varchar (10) not null,
Home_Address varchar (50) not null,
User_Password varchar (50) not null,
Application_Status varchar (10), 
)

insert into Users Values('19075716','Nkateko', 'Maluleke', 'Admin','0672472417','u19075716@tuks.co.za','21','Male','976 Park Street','12345','Approved')
Go

select * from Users