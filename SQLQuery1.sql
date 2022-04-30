


create database gestio_empre1222ses;
go
USE gestio_empre1222ses; 

GO 

CREATE TABLE categoria (
cod_categoria uniqueidentifier PRIMARY KEY  default NEWID(),
descripcio VARCHAR(244) NOT NULL
);

GO 

CREATE TABLE empresa (
cif varchar(15) PRIMARY KEY,
nom VARCHAR(30) NOT NULL,
adreca VARCHAR(50),
telf VARCHAR(14) NOT NULL,
email VARCHAR(50), 
cod_categoria uniqueidentifier REFERENCES categoria(cod_categoria),
fecha_ultima_modificaio date default  GETDATE()
);


GO

CREATE TABLE contracte (
cod_contracte INT PRIMARY KEY,
cif varchar(15) REFERENCES empresa(cif),
data_inici DATE DEFAULT GETDATE(),
tests_mensuals int,
fecha_ultima_modificaio date default  GETDATE()
);

GO 

CREATE TABLE categoria_test (
cod_categoria uniqueidentifier PRIMARY KEY  default NEWID(),
descripcio VARCHAR(244) NOT NULL
); 

GO 

CREATE TABLE test (
codi_test uniqueidentifier PRIMARY KEY default NEWID(), 
total_preg INT NOT NULL,
cod_categoria uniqueidentifier  REFERENCES categoria_test(cod_categoria),
preu DECIMAL(3,2) NOT NULL,
);

GO 

CREATE TABLE albara (
num_albara varchar(30) PRIMARY KEY,
cif VARCHAR(15) REFERENCES empresa(cif),
data DATE DEFAULT GETDATE(),
fecha_ultima_modificaio date default  GETDATE()
);

CREATE TABLE albara_test (
num_albara varchar(30) REFERENCES albara(num_albara),
codi_test uniqueidentifier REFERENCES test(codi_test),
realitzat bit DEFAULT 0,
PRIMARY KEY(num_albara, codi_test)
);
