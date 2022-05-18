
USE gestioEmpresa; 


CREATE TABLE usrs(
nif VARCHAR(15) PRIMARY KEY ,
userName varchar(30) not null unique,
fname VARCHAR(25) NOT NULL,
lname VARCHAR(50) NOT NULL, 
address VARCHAR(60),
city VARCHAR(30), 
zip VARCHAR(12),
phone INT,
email varchar(50),
psswd VARCHAR(20) NOT NULL,
role VARCHAR(30) check(role in ('ADMIN','TEACHER','STUDENT'))
); 

go

CREATE TABLE topics (
id_topic uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
description VARCHAR(30) NOT NULL
); 

go

CREATE TABLE questions(
id_question  uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
question VARCHAR(244) not NULL,
answer1 VARCHAR(100) not NULL,
answer2 VARCHAR(100) not NULL,
answer3 VARCHAR(100),
answer4 VARCHAR(100), 
correctanswer INT not NULL,
id_topic  uniqueidentifier REFERENCES topics(id_topic) ON DELETE CASCADE
); 


 
go
 

CREATE TABLE statsExams(
id_statExam  uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
hits INT default 0,
misses INT default 0,
blank INT default 0, 
nif VARCHAR(15) REFERENCES usrs(nif) ON DELETE CASCADE, 
stat_date DATE DEFAULT GETDATE(),
id_topic uniqueidentifier REFERENCES topics(id_topic) ON DELETE CASCADE
)

go


CREATE TABLE statsQuestions(
id_statQuestion  uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
total_hits INT default 0,
nif VARCHAR(15) REFERENCES usrs(nif) ON DELETE CASCADE,
total_misses INT default 0,
total_blank INT default 0,
id_question  uniqueidentifier REFERENCES questions(id_question) ON DELETE CASCADE
);

insert into usrs(nif,userName,psswd,fname,lname,role) values('c121212','admin','admin','admin','admin','TEACHER'); 
insert into topics(description) values('matematicas')

