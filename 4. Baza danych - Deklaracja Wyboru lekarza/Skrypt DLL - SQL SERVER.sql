begin transaction
create table Lekarze(
ID_LEKARZA integer Identity(1,1) unique not null,
IMIE varchar (30) not null,
NAZWISKO varchar(30) not null,
SPECJALIZACJA varchar(20) not null,
ID_ADRESU integer not null
);
alter table Lekarze add constraint Lekarze_PK primary key (ID_LEKARZA);

create table Adresy(
ID_ADRESU integer Identity(1,1) unique not null,
ULICA varchar(40),
NR_DOMU numeric(10) constraint NR_DOMU_CHECK check(NR_DOMU>0),
NR_MIESZKANIA numeric(10) constraint NR_MIESZKANIA_CHECK check(NR_MIESZKANIA>0),
KOD_POCZTOWY numeric(5) not null  constraint KOD_POCZTOWY_CHECK check (KOD_POCZTOWY>10000),
MIEJSCOWOSC varchar(45) not null
);
alter table Adresy add constraint Adresy_PK primary key (ID_ADRESU);

create table Swiadczenia(
NR_SWIADCZENIA int unique not null constraint NR_SWIADCZENIA_CHECK check(NR_SWIADCZENIA>100),
ID_LEKARZA int not null,
ID_SWIADCZENIOBIORCY numeric(11) not null,
DATA_SWIADCZENIA datetime not null default sysdatetime(),
NAZWA_ODDZIALU varchar(20) not null default 'G³owny',
);
alter table Swiadczenia add constraint Swiadczenia_PK primary key(NR_SWIADCZENIA);

create table Swiadczeniobiorcy(
PESEL numeric(11) not null constraint PESEL_CHECK check(PESEL>10000000000),
IMIE varchar (30) not null,
NAZWISKO varchar(30) not null,
NAZWISKO_RODOWE varchar(30) null,
DATA_UR smalldatetime not null,
NR_TELEFONU numeric(9) null constraint NR_TELEFONU_CHECK check(NR_TELEFONU>100000000),
PLEC bit not null,
NR_KARTY_NFZ numeric(12) not null constraint NR_KARTY_NFZ check(NR_KARTY_NFZ>100000000000),
KOD_NFZ numeric(2) not null constraint KOD_NFZ_CHECK check(KOD_NFZ>1),
ID_ADRESU int not null,
MIEJSCE_NAUKI varchar(40) null
);
alter table Swiadczeniobiorcy add constraint Swiadczeniobiorcy_PK primary key(PESEL);



ALTER TABLE Lekarze 
ADD CONSTRAINT FK_LEKARZE_ADRESY
FOREIGN KEY(ID_ADRESU)REFERENCES Adresy(ID_ADRESU);

ALTER TABLE Swiadczeniobiorcy 
ADD CONSTRAINT FK_SWIADCZENIOBIORCY_ADRESY
FOREIGN KEY(ID_ADRESU)REFERENCES Adresy(ID_ADRESU);

alter table Swiadczenia
add constraint FK_SWIADCZENIA_LEKARZ
FOREIGN KEY (ID_LEKARZA) REFERENCES Lekarze(ID_LEKARZA);

alter table Swiadczenia
add constraint FK_SWIADCZENIA_SWIADCZENIOBIORCA
foreign key(ID_SWIADCZENIOBIORCY) references Swiadczeniobiorcy(PESEL);

commit;
