CREATE DATABASE PCE;

USE PCE;

CREATE TABLE Wymiary(
IdWymiaru int IDENTITY(1,1) PRIMARY KEY,
Podstawa int NOT NULL,
Wysoko�� int NOT NULL
);

CREATE TABLE Kszta�tyW�osia(
IdKszta�tu int IDENTITY(1,1) PRIMARY KEY,
Opis varchar(50) NOT NULL
);

CREATE TABLE RodzajeW�osia(
IdRodzaju int IDENTITY(1,1) PRIMARY KEY,
Materia� varchar(50) NOT NULL
);

CREATE TABLE P�dzle(
IdP�dzla int IDENTITY(1,1) PRIMARY KEY,
IdKszta�tu int FOREIGN KEY REFERENCES Kszta�tyW�osia(IdKszta�tu),
IdRodzaju int FOREIGN KEY REFERENCES RodzajeW�osia(IdRodzaju),
Rozmiar int NOT NULL,
Cena money NOT NULL
);

CREATE TABLE TypyPodobrazi(
IdTypuPodobrazia int IDENTITY(1,1) PRIMARY KEY,
Nazwa varchar(50) NOT NULL
);

CREATE TABLE Podobrazia(
IdPodobrazia int IDENTITY(1,1) PRIMARY KEY,
IdTypuPodobrazie int FOREIGN KEY REFERENCES TypyPodobrazi(IdTypuPodobrazia),
Cena money NOT NULL
);

CREATE TABLE Podobrazia_Wymiary(
IdPodobrazia int FOREIGN KEY REFERENCES Podobrazia(IdPodobrazia),
IdWymiaru int FOREIGN KEY REFERENCES Wymiary(IdWymiaru),
CONSTRAINT Id PRIMARY KEY (IdPodobrazia, IdWymiaru)
);

CREATE TABLE SpoiwaFarb(
IdSpoiwa int IDENTITY(1,1) PRIMARY KEY,
Nazwa varchar(50) NOT NULL
);

CREATE TABLE Media(
IdMedium int IDENTITY(1,1) PRIMARY KEY,
IdSpoiwa int FOREIGN KEY REFERENCES SpoiwaFarb(IdSpoiwa),
Nazwa varchar(50) NOT NULL,
Cena money NOT NULL
);

CREATE TABLE Farby(
IdFarby int IDENTITY(1,1) PRIMARY KEY,
IdSpoiwa int FOREIGN KEY REFERENCES SpoiwaFarb(IdSpoiwa),
Cena money NOT NULL
);

CREATE TABLE TypyWerniks�w(
IdTypu int IDENTITY(1,1) PRIMARY KEY,
IdSpoiwa int FOREIGN KEY REFERENCES SpoiwaFarb(IdSpoiwa),
Nazwa varchar(50) NOT NULL
);

CREATE TABLE PoziomyPo�ysk�w(
IdPo�ysku int IDENTITY(1,1) PRIMARY KEY,
PoziomPo�ysku varchar(50) NOT NULL
);

CREATE TABLE Werniksy(
IdWerniksu int IDENTITY(1,1) PRIMARY KEY,
IdTypu int FOREIGN KEY REFERENCES TypyWerniks�w(IdTypu),
IdPo�ysku int FOREIGN KEY REFERENCES PoziomyPo�ysk�w(IdPo�ysku),
Cena money NOT NULL
);





