create database movieNxt

use  movieNxt

create table AdminInfo(userName varchar(50) primary key not null,
firstName varchar(50) not null,
lastName varchar(50) not null,
Email varchar(50) unique not null,
PhoneNo bigint unique not null
)
create table usersInfo(NameUser varchar(50) primary key not null,
FullName varchar(50) not null,
Email varchar(50) not null,
mobileNo bigint unique not null
)

alter table adminInfo ADD password varchar(50) unique not null
select * from AdminInfo
select * from usersInfo

alter table usersInfo ADD password varchar(50) unique not null