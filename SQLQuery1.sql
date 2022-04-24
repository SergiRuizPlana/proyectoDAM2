CREATE DATABASE gestio_empreses; 

GO

USE gestio_empreses; 

GO 

CREATE TABLE categoria (
cod_categoria varchar(30) PRIMARY KEY  default NEWID(),
descripcio VARCHAR(244) NOT NULL
);

GO 

CREATE TABLE empresa (
cif VARCHAR(30) PRIMARY KEY,
nom VARCHAR(30) NOT NULL,
adreca VARCHAR(50),
telf VARCHAR(14) NOT NULL,
email VARCHAR(50), 
cod_categoria varchar(30) REFERENCES categoria(cod_categoria)
);

GO

CREATE TABLE contracte (
cod_contracte INT PRIMARY KEY,
cif VARCHAR(30) REFERENCES empresa(cif),
data_inici DATE DEFAULT GETDATE(),
tests_mensuals int
);

GO 

CREATE TABLE categoria_test (
cod_categoria varchar(30) PRIMARY KEY  default NEWID(),
descripcio VARCHAR(244) NOT NULL
); 

GO 

CREATE TABLE test (
codi_test INT PRIMARY KEY default NEWID(), 
total_preg INT NOT NULL,
cod_categoria varchar(30) REFERENCES categoria_test(cod_categoria),
preu DECIMAL(3,2) NOT NULL,
);

GO 

CREATE TABLE albara (
num_albara INT PRIMARY KEY,
cif VARCHAR(30) REFERENCES empresa(cif),
data DATE DEFAULT GETDATE()
);

CREATE TABLE albara_test (
num_albara INT REFERENCES albara(num_albara),
codi_test INT REFERENCES test(codi_test),
realitzat bit DEFAULT 0,
PRIMARY KEY(num_albara, codi_test)
);
