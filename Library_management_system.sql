create database LMS
use LMS

create table Student (
id int primary key identity,
fname varchar(30),
lname varchar(30),
userName varchar(30),
passwords varchar(30),
age int,
email varchar(40),
phone_no int
)


create table Librarian (
id int primary key identity,
fname varchar(30),
lname varchar(30),
userName varchar(30),
passwords varchar(30),
age int,
email varchar(40),
phone_no int
)



create table Book (
isbn_no int primary key,
title varchar(30),
author varchar(30),
book_quantity int,
publicationYear int
)



--PROCEDURES
go
create proc sp_insertStudent 
@fname varchar(30),
@lname varchar(30),
@userName varchar(30),
@age int,
@email varchar(40),
@phone_no int,
@password varchar(30)
as
begin
insert into Student(fname,lname,userName,age,email,phone_no,passwords) values (@fname,@lname,@userName,@age,@email,@phone_no,@password)
end


go
create proc sp_insertLibrarian 
@fname varchar(30),
@lname varchar(30),
@userName varchar(30),
@age int,
@email varchar(40),
@phone_no int,
@password varchar(30)
as
begin
insert into Librarian(fname,lname,userName,age,email,phone_no,passwords) values (@fname,@lname,@userName,@age,@email,@phone_no,@password)
end

--inserting Books for the save button
go
create proc sp_insertBooks 
@isbn_no int,
@title varchar(30),
@author varchar(30),
@book_quantity int,
@publication_Year int
as
begin
insert into Book(isbn_no,title,author,book_quantity,publicationYear) values (@isbn_no,@title,@author,
@book_quantity,@publication_Year)
end

-- This is for the update Button
go
create proc sp_updateBooks 
@isbn_no int,
@title varchar(30),
@author varchar(30),
@book_quantity int,
@publication_Year int
as
begin
update Book
set title=@title, author=@author, book_quantity=@book_quantity, publicationYear=@publication_Year
where isbn_no=@isbn_no
--insert into Book(isbn_no,title,author,book_quantity,publicationYear) values (@isbn_no,@title,@author,
--@book_quantity,@publication_Year)
end



select * from Librarian
select * from Student

select * from Book

select isbn_no, title,author,book_quantity from Book

