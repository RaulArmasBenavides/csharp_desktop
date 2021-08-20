--create database hospitalManagementSystem;
--RMAB realicé modificaciones 19/08/2021
use hospitalManagementSystem

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Inpatient') 
drop table Inpatient;


IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'admin_ID') 
drop table admin_ID;
create table admin_ID
(
ID varchar(10) primary key,
password varchar(10)
);

insert into admin_ID values('13142103',' ');
IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'administration') 
drop table administration;
create table administration
(
ID varchar(10) primary key,
password varchar(10)
);

insert into administration values('1314210',' ');



IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'room') 
 drop table room
create table room
(
w_no varchar(20) not null ,
room_no numeric(5,0) not null primary key,
room_type varchar(10) not null,
capacity numeric(20),
charge numeric(10,0)not null
foreign key (w_no) references word
);

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'AddBed') 
drop table AddBed;


create table AddBed
(
bed_no numeric(5,0) ,
room_no numeric(5,0) not null ,
);

insert into AddBed values ('1','301');
insert into AddBed values ('2','301');


IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Bed') 
drop table Bed;




create table register
(
	Category varchar(50) not null,
	Id varchar(10) not null,
	First_name varchar(50) not null,
	Last_name varchar(50) not null,
	Email varchar(50) not null,
	username varchar(50) Primary key,
	passward varchar(50) not null
);

insert into register values ('123','123','RAUL','ARMAS','raul.armas@unmsm.edu.pe','rarmas','123');

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'doctor') 
Drop table doctor;

create table doctor(

d_id char(6) not null primary key,
d_name varchar(50) not null,
d_gender varchar(50) not null,
d_age varchar(50) not null,
qualification  varchar(50) not null,
Speciality varchar(50),
salary numeric(10,0)not null,
d_mobile varchar(20)not null,
d_address varchar(100)not null,
w_no varchar(20) not null,
d_password varchar(20),

foreign key(w_no) references word

);

insert into doctor values('123456','DR. Musa','Male','35','MBBS','50000','01879675432','Dhaka','ACC');

Drop table nourse;

create table nourse(

n_id char(6) not null primary key,
n_name varchar(50) not null,
FathersName varchar(50),
MothersName varchar(50),
BloodGroup varchar(20),
PresentAddress varchar(100) not null,
permanentAddress varchar(200) not null,
n_age varchar(50) not null,
salary numeric(10,0),
n_mobile varchar(20),
n_password varchar(20),
w_no varchar(20) not null,
foreign key(w_no) references word
);


drop table stuffs;

create table stuffs
(
	
	StuffTitle varchar(50) not null,
	Stuff_Id varchar(10) not null primary key,
	Stuff_name varchar(50) not null,
	Gender varchar(50) not null,
	NID varchar(50) not null,
	Stuff_PresentAddress Varchar(10) not null,
	Stuff_ParmanentAddress Varchar(10) not null,
	Stuff_mobile varchar(20) not null,
	Stuff_password varchar(10),
	Blood_group varchar(6),
	w_no varchar(20) not null,
foreign key(w_no) references word

);

drop table Schedule;

create table Schedule
(

 catagory varchar(50),
 id varchar(20),
 buildig varchar(50),
 w_no varchar(20),
 workingHour numeric(5,0),
 DaysperWeek numeric(5,0),
 startTime numeric(5,0),
 endTime numeric(5,0),
 BreakTime numeric(5,0),

);


create table Inpatient
 (
p_id char(6) not null primary key,
p_name varchar(50) not null,
p_gender varchar(50) not null,
p_age varchar(50) not null,
BoodGroup varchar(20),
city  varchar(50) not null,
country varchar(20) not null,
p_mobile varchar(20),
GurdianName varchar(20),
Relation varchar(20),
G_mobile varchar(20),

w_no varchar(20) not null,
admit_date varchar(50) not null,

room_no numeric(5,0) not null,

foreign key(w_no) references word,

);

Create table DoctorRoom
(
d_id char(6) primary key,
room_no numeric(5,0),

foreign key (d_id) references doctor,
foreign key (room_no) references room
); 

drop table doctorCheckPatient;

create table doctorCheckPatient
(
p_id char(6) primary key,
d_id char(6),
discharge_date varchar(50)


);


create table Bed
(
	room_no numeric(5,0) not null,
	p_id char(6) not null primary key,
	bed_no numeric(5,0),
	
	foreign key (p_id) references Inpatient
	
	
);

drop table treat;

create table treat
(
p_id char(6),
n_id char(6),

);

drop table PatientsPrescribtion;

create table PatientsPrescribtion
(
	p_id char(6),
	medicineName varchar(200),
	MedicenTime varchar(20),

);

create table Inpatientbill
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
foreign key(p_id) references Inpatient
);

drop table appoinment;
create table appoinment
(
	tokenNo varchar(10) primary key,
	d_id char(6) not null,
	p_id char(6)not null,
	AppoinmentDate varchar(50),
	roomNo varchar(10)
);

create table Outpatient
 (
p_id char(6) not null primary key,
p_name varchar(50) not null,
p_gender varchar(50) not null,
p_age varchar(50) not null,
appoinment_no char(6),
city  varchar(50) not null,
country varchar(20) not null,
p_mobile varchar(20),

room_no numeric(5,0) not null,


);

create table Outpatientbill
(
Bill_no	numeric	(20,0) primary key,      
bDate varchar (50),
p_id char(6)not null,	
p_name varchar(50) not null,
p_age varchar(50) not null,
p_gender varchar(50) not null,	
Doctor_Fees	Varchar	(50)not null,
Miscellaneous	Varchar	(50) not null,
Total_Amount	Varchar	(100) not null,	
foreign key(p_id) references Outpatient

);


insert into bill values('1','14-12','000001','Anupam','23','Male','December 12 2016','December 14 2016','1000','3000','1000','2000','7000');








select*from attendance;
create table attendance
(
 category varchar(50) not null,
 ID varchar(20),
 LogInDate varchar(50),
 LogInTime varchar(20),
 LogOutTime varchar(20),
);

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'word') 
drop table word
create table word(

w_no varchar(20) not null primary key,
category varchar(50) not null,
buildig varchar(50) not null,

);