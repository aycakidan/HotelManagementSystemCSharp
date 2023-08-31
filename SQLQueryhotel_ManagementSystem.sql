create database hotel_ManagementSystem;

CREATE TABLE room(
room_id int IDENTITY(101,1) PRIMARY KEY,
room_No int UNIQUE,
room_Type varchar(20) not null );

select * from room

create table guest(
guest_id int IDENTITY(1,1) PRIMARY KEY,
guest_name varchar(50) not null,
guest_surname varchar(50) not null,
phone bigint not null ,
gender varchar(20) not null,
room_id int not null,
foreign key (room_id) references room(room_id) 

);

select*from guest

create table guestReservation(
res_id int IDENTITY(1,1) PRIMARY KEY,
guest_id int not null,
room_No int not null,
foreign key (guest_id) references guest(guest_id),
foreign key (room_No) references room(room_No) 

);

select*from guestReservation

create table payment(
pay_id int IDENTITY(1,1) PRIMARY KEY,
guest_id int not null,
res_id int not null,
foreign key (res_id) references guestReservation(res_id),
foreign key (guest_id) references guest(guest_id)
);

select*from payment

create table employee(
emp_id int PRIMARY KEY,
emp_name varchar(250) not null,
emp_surname varchar(250) not null,
emp_username varchar(250) not null, --- student numbers

emp_pass bigint not null
);
select*from employee

INSERT INTO employee(emp_id,emp_name,emp_surname,emp_username,emp_pass) VALUES(180444061,'Gaye', 'NECET', 's180444061@stu.thk.edu.tr',180444061)
INSERT INTO employee(emp_id,emp_name,emp_surname,emp_username,emp_pass) VALUES(180444031,'Ayça', 'KIDAN', 's180444030@stu.thk.edu.tr',180444030)
INSERT INTO employee(emp_id,emp_name,emp_surname,emp_username,emp_pass) VALUES(180444030,'Furkan', 'ILHAN', 's180444030@stu.thk.edu.tr',180444030)

DELETE FROM employee
WHERE emp_name='Ayça'

INSERT INTO employee(emp_id,emp_name,emp_surname,emp_username,emp_pass) VALUES(180444031,'Ayça', 'KIDAN', 's180444031@stu.thk.edu.tr',180444031)

ALTER TABLE guestReservation ---forgotten column is added.
ADD checkIN DATE,
checkOUT DATE

UPDATE employee
SET emp_username= 's180444061'
WHERE emp_name= 'GAYE'

select * from employee


UPDATE employee
SET emp_pass= 123
WHERE emp_name= 'GAYE'

UPDATE employee
SET emp_username= 's180444030'
WHERE emp_name= 'Furkan'

UPDATE employee
SET emp_pass= 123
WHERE emp_name= 'Furkan'

UPDATE employee
SET emp_username= 's180444031'
WHERE emp_name= 'Ayça'

select * from employee

UPDATE employee
SET emp_pass= 123
WHERE emp_name= 'Ayça'
-------------------------JOIN PART-------------------
select guest.guest_id,guest.guest_name,guest.guest_surname, room.room_id, guestreservation.res_id,payment.pay_id from guest
inner join room
on
guest.room_id= room.room_id
inner join guestReservation
on
guest.guest_id = guestreservation.guest_id
inner join payment
on
guest.guest_id = payment.guest_id

--------------------------------------------------------------------------------
ALTER TABLE guest
ALTER COLUMN phone varchar(250)
select phone from guest

UPDATE employee
SET emp_username= 'aya' ---- Changed for convenience when trying to log into the system.
WHERE emp_name= 'Ayça'


UPDATE employee
SET emp_username= '180444031'
WHERE emp_name= 'Ayça'


---------------------------Storage--------------------------

CREATE PROCEDURE guest_procedure ------ We creats storage prosedüre for guest table (select * from guest)
AS
select * from guest
GO;
EXEC guest_procedure;
USE [hotel_ManagementSystem]
GO
DECLARE @return_value int
EXEC @return_value = [dbo].[guest_procedure]
SELECT 'Return Value' = @return_value
GO

USE [hotel_ManagementSystem]
GO
/****** Object: StoredProcedure [dbo].[guest_procedure] Script Date: 29.12.2021 22:00:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[guest_procedure]
AS
select g.*, gr.checkIN, gr.checkOUT from guest g
JOIN guestReservation gr on gr.guest_id = g.guest_id
