CREATE DATABASE PCE;

USE PCE;

CREATE TABLE Wymiary(
IdWymiaru int IDENTITY(1,1) PRIMARY KEY,
Podstawa int NOT NULL,
Wysokoœæ int NOT NULL
);

CREATE TABLE Kszta³tyW³osia(
IdKszta³tu int IDENTITY(1,1) PRIMARY KEY,
Opis varchar(50) NOT NULL
);

CREATE TABLE RodzajeW³osia(
IdRodzaju int IDENTITY(1,1) PRIMARY KEY,
Materia³ varchar(50) NOT NULL
);

CREATE TABLE Pêdzle(
IdPêdzla int IDENTITY(1,1) PRIMARY KEY,
IdKszta³tu int FOREIGN KEY REFERENCES Kszta³tyW³osia(IdKszta³tu),
IdRodzaju int FOREIGN KEY REFERENCES RodzajeW³osia(IdRodzaju),
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

CREATE TABLE TypyWerniksów(
IdTypu int IDENTITY(1,1) PRIMARY KEY,
IdSpoiwa int FOREIGN KEY REFERENCES SpoiwaFarb(IdSpoiwa),
Nazwa varchar(50) NOT NULL
);

CREATE TABLE PoziomyPo³ysków(
IdPo³ysku int IDENTITY(1,1) PRIMARY KEY,
PoziomPo³ysku varchar(50) NOT NULL
);

CREATE TABLE Werniksy(
IdWerniksu int IDENTITY(1,1) PRIMARY KEY,
IdTypu int FOREIGN KEY REFERENCES TypyWerniksów(IdTypu),
IdPo³ysku int FOREIGN KEY REFERENCES PoziomyPo³ysków(IdPo³ysku),
Cena money NOT NULL
);





