
CREATE DATABASE academy;

USE gestioEmpresa; 

CREATE TABLE usr(
nif VARCHAR(15) PRIMARY KEY ,
fname VARCHAR(25) NOT NULL,
lname VARCHAR(50) NOT NULL, 
address VARCHAR(60),
city VARCHAR(30), 
zip VARCHAR(12),
phone INT, 
psswd VARCHAR(20) NOT NULL,
role VARCHAR(30) check(role in ('ADMIN','TEACHER','STUDENT'))
); 

go

CREATE TABLE topic (
id_topic VARCHAR(30) PRIMARY KEY DEFAULT NEWID(),
description VARCHAR(30) NOT NULL
); 

go

CREATE TABLE question(
id_question  VARCHAR(30) PRIMARY KEY DEFAULT NEWID(),
question VARCHAR(244) not NULL,
answer1 VARCHAR(100) not NULL,
answer2 VARCHAR(100) not NULL,
answer3 VARCHAR(100),
answer4 VARCHAR(100), 
correctanswer INT not NULL,
id_topic  VARCHAR(30) REFERENCES topic(id_topic)
); 

CREATE TABLE exam(
id_exam  VARCHAR(30) PRIMARY KEY DEFAULT NEWID(),
id_topic  VARCHAR(30) REFERENCES topic(id_topic),
description VARCHAR(30) NOT NULL,
n_questions INT 
); 

go

CREATE TABLE statexam(
hits INT,
misses INT,
blank INT, 
nif VARCHAR(15) REFERENCES usr(nif),
id_exam  VARCHAR(30) REFERENCES exam(id_exam),
stat_date DATE DEFAULT GETDATE(),
PRIMARY KEY(nif, id_exam)
);

go

CREATE TABLE statquestions(
stat_date DATE DEFAULT GETDATE(),
total_hits INT, 
total_misses INT,
total_blank INT,
id_question  VARCHAR(30)  REFERENCES question(id_question),
PRIMARY KEY (id_question)
);

go

CREATE TABLE exam_question(
id_exam  VARCHAR(30) REFERENCES exam(id_exam),
id_question  VARCHAR(30) REFERENCES question(id_question)
);