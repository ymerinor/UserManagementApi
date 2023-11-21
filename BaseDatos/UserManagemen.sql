CREATE DATABASE UserManagemen;
GO
USE UserManagemen;

Create table Users
(
   Id  uniqueidentifier primary key,
   Name varchar(60),
   Email varchar(50),
   Age int,
   Nationality varchar(100)
)