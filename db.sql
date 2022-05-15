
CREATE DATABASE academy;

USE gestioEmpresa; 


CREATE TABLE usr(
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

CREATE TABLE topic (
id_topic uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
description VARCHAR(30) NOT NULL
); 

go

CREATE TABLE question(
id_question  uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
question VARCHAR(244) not NULL,
answer1 VARCHAR(100) not NULL,
answer2 VARCHAR(100) not NULL,
answer3 VARCHAR(100),
answer4 VARCHAR(100), 
correctanswer INT not NULL,
id_topic  uniqueidentifier REFERENCES topic(id_topic) ON DELETE CASCADE
); 



go
 

CREATE TABLE statExam(
id_statExam  uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
hits INT default 0,
misses INT default 0,
blank INT default 0, 
nif VARCHAR(15) REFERENCES usr(nif) ON DELETE CASCADE, 
stat_date DATE DEFAULT GETDATE(),
id_topic uniqueidentifier REFERENCES topic(id_topic) ON DELETE CASCADE
)

go


CREATE TABLE statQuestion(
id_statQuestion  uniqueidentifier PRIMARY KEY DEFAULT NEWID(),
total_hits INT default 0,
nif VARCHAR(15) REFERENCES usr(nif) ON DELETE CASCADE,
total_misses INT default 0,
total_blank INT default 0,
id_question  uniqueidentifier REFERENCES question(id_question) ON DELETE CASCADE
);



