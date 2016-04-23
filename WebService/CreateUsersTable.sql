
-- Author: Joey Lee
-- Penn State University
-- Date: 4/14/2016
-- Purpose: Create Table

--Select the database to use

------Drop Table tblStudent and Start Fresh-----

if exists (select * from sys.objects where name = 'Users')
BEGIN
    drop table Users;
END

------New Table tblMenuItems to Create-----
BEGIN TRY 
CREATE TABLE Users (
userID INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
userName varchar(20) NOT NULL,
password varchar(20) NOT NULL); 
PRINT 'Users created';
END TRY
BEGIN CATCH
 PRINT 'Users Not Created';
END CATCH


-------View Of Table---------
select * from Users;