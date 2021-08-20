create database hospital;

create table register
(
	First_name varchar(50) not null,
	Last_name varchar(50) not null,
	Email varchar(50) not null,
	username varchar(50) not null,
	passward varchar(50) not null
);
drop table login;
create table room
(
room_no numeric(5,0) not null primary key,
room_type varchar(10) not null,
charge numeric(10,0)not null
);

insert into room values('101','AC','1000');

create table word(

w_no varchar(20) not null primary key,
category varchar(50) not null,
buildig varchar(50) not null,
room_no numeric(5,0) not null,
foreign key (room_no) references room
);
insert into word values('ACC','Accident','Watson','101');

create table doctor(

d_id char(6) not null primary key,
d_name varchar(50) not null,
d_gender varchar(50) not null,
d_age varchar(50) not null,
qualification  varchar(50) not null,
salary numeric(10,0)not null,
d_mobile varchar(20)not null,
d_address varchar(100)not null,
w_no varchar(20) not null,
foreign key(w_no) references word
);
insert into doctor values('123456','DR. Musa','Male','35','MBBS','50000','01879675432','Dhaka','ACC');

create table nourse(

n_id char(6) not null primary key,
n_name varchar(50) not null,
n_age varchar(50) not null,
salary numeric(10,0),
d_mobile varchar(20),
w_no varchar(20) not null,
foreign key(w_no) references word
);
insert into nourse values('123800','Ms. Shanu','25','15000','01879675454','ACC');
insert into nourse values('123801','Ms. Parvina','24','15000','01879455656','ACC');

create table patient
 (
p_id char(6) not null primary key,
p_name varchar(50) not null,
p_gender varchar(50) not null,
p_age varchar(50) not null,
city  varchar(50) not null,
country varchar(20) not null,
p_mobile varchar(20),
w_no varchar(20) not null,
d_id char(6) not null,
admit_date varchar(50) not null,
room_no numeric(5,0) not null,
foreign key (room_no) references room,
foreign key(w_no) references word,
foreign key(d_id) references doctor
);
insert into patient values('000001','Anupam','Male','23','Dhaka','Bangladesh','01845591641','ACC','123456','December 12 2016 ','101');

create table treat
(
p_id char(6) not null,
n_id char(6) not null,
foreign key(p_id) references patient,
foreign key(n_id) references nourse
);

insert into treat values('000001','123800');
insert into treat values('000001','123801');

create table bill
(
Bill_no	numeric	(20,0) primary key,      
bDate varchar (50),
p_id char(6)not null,	
p_name varchar(50) not null,
p_age varchar(50) not null,
p_gender varchar(50) not null,
admit_date varchar(50) not null,
Discharge_date varchar(50) not null,
Room_Charges	Varchar	(50) not null,	
Pathology_fees	Varchar	(50) not null,
Doctor_Fees	Varchar	(50)not null,
Miscellaneous	Varchar	(50) not null,
Total_Amount	Varchar	(100) not null,	
foreign key(p_id) references patient
);

insert into bill values('1','14-12','000001','Anupam','23','Male','December 12 2016','December 14 2016','1000','3000','1000','2000','7000');


create table treate 
(
p_id char(6) not null,
d_id char(6) not null,
n_id char(6) not null,
discharge_date varchar(20),

);

create table treate 
(
p_id char(6) not null,
d_id char(6) not null,
n_id char(6) not null,
discharge_date varchar(20),

);