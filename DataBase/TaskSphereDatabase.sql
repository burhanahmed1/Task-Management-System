create database TaskSphere1
use tasksphere1
create table userlist
(
id int not null identity(1,1) primary key,
username varchar(200),
password varchar(200)
)
create table projects(
id int not null identity(1,1) primary key,
name varchar(100),
description varchar(100)
)

create table completed(
id int not null identity(1,1) primary key,
name varchar(100),
description varchar(100)
)

create table inprogress(
id int not null identity(1,1) primary key,
name varchar(100),
description varchar(100)
)

create table starred(
id int not null identity(1,1) primary key,
name varchar(100),
description varchar(100)
)

create table todolist(
id int not null identity(1,1) primary key,
name varchar(100),
description varchar(100)
)



drop table completed
drop table inprogress
drop table todolist
drop table projects

select * from userlist
select * from projects
select * from completed
select* from inprogress
select* from todolist
select* from starred

insert into todolist(name,description)
values('COAL','Snake and Apple game')
;


delete from todolist where name in ('TaskSphere','ML Model')
