
-- Author: Joey Lee
-- Penn State University
-- Date: 4/14/2016
-- Purpose: Create Table

--Select the database to use

------Drop Table tblStudent and Start Fresh-----

if exists (select * from sys.objects where name = 'Posts')
BEGIN
    drop table Posts;
END

------New Table tblMenuItems to Create-----
BEGIN TRY 
CREATE TABLE Posts (
postID INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
username varchar(20) NOT NULL,
content varchar(500) NOT NULL,
date varchar(20) NOT NULL); 
PRINT 'Posts created';
END TRY
BEGIN CATCH
 PRINT 'Posts not created';
END CATCH


-------View Of Table---------
select * from Posts;