
Create Table Users(
ID int  primary key identity(1,1),
TcKimlik nvarchar(11) unique not null,
Password nvarchar(50) not null,
AD nvarchar(50) not null,
SoyAd nvarchar(50) not null,
DogumTarihi nvarchar(50) not null,
StatuID int not null,
FirstActivation int,
KangrubuID int,
KanGrubu nvarchar(50),
foreign key (StatuID) references Statu(StatuID),
foreign key (KanGrubuID) references KanGrup(KangrubuID)
);
Create table Statu
(
StatuID  int identity(0,1) primary key not null,
StatuName nvarchar(50)  not null,

);
create table Aylar
(
AyID int  primary key identity(1,1),
Aylar nvarchar(50) not null,
);

create table Doctor
(
TcKimlikno nvarchar(11) not null unique,
DoktorKullanýcý nvarchar(50) not null,
Password int not null,
ID int identity (1,1) primary key,
Adý nvarchar(50) not null,
Soyadý nvarchar(50) not null,
BolumID int not null,
Bolumler nvarchar(50) not null,
foreign key (BolumID) references Bolumler (BolumID),

);

create table Bolumler
(
BolumID int primary key identity(1,1),
Bolumler nvarchar(50) not null,
);
ALTER TABLE Users
ADD Adress nvarchar(100);
ALTER TABLE Users
ADD Eposta nvarchar(100);
ALTER TABLE Users
ADD Telefon varchar(100);

ALTER TABLE Users
ADD Picture nvarchar(100);
ALTER TABLE Users
ADD  BolumID int 

ALTER TABLE Users
ADD FOREIGN KEY (BolumID) REFERENCES Bolumler(BolumID);
create table Kangrup(

KangrubuID int identity(1,1) primary key,
KanGrubu nvarchar(50) not null,
)

create table Durumu
(
DurumID int  identity(1,1) primary key,
MedeniDurum nvarchar(50) not null,
)
create table DoctorStatu(
DStatu int identity(1,1) primary key,
DStatuName nvarchar(50) not null,
);
create table Vezne(
ID int  primary key identity(1,1),
VezKullanýcý nvarchar(11) unique not null,
Password nvarchar(50) not null,
StatuID int not null,
FirstActivation int,
);
create table Randevu
(
ýd int primary key identity(1,1),
TcKimlik nvarchar(11) not null,
RandevuTarihi datetime,
RandevuSaati nvarchar(50),
randevuID int not null,
BolumID int not null,
StatuID int not null,
);



select count(TcKimlik) from Randevu where TcKimlik=4 and randevuID=1


INSERT INTO  dbo.Bolumler VALUES('Acil Týp');
INSERT INTO  dbo.Bolumler VALUES('Adli Týp');
INSERT INTO  dbo.Bolumler VALUES('Cocuk Ruh Saglýgý');
INSERT INTO  dbo.Bolumler VALUES('Cocuk Saglýgý ve Hastalýklarý');
INSERT INTO  dbo.Bolumler VALUES('Dermatoloji');
INSERT INTO  dbo.Bolumler VALUES('Enfeksiyon Hastalýklarý');
INSERT INTO  dbo.Bolumler VALUES('Fiziksel Týp ve Rehabilitasyon');
INSERT INTO  dbo.Bolumler VALUES('Göðüs Hastalýklarý');
INSERT INTO  dbo.Bolumler VALUES('Halk Saðlýðý');
INSERT INTO  dbo.Bolumler VALUES('Ýç Hastalýklarý');
INSERT INTO  dbo.Bolumler VALUES('Kardiyoloji');
INSERT INTO  dbo.Bolumler VALUES('Nöroloji');
INSERT INTO  dbo.Bolumler VALUES('Nükleer Týp');
INSERT INTO  dbo.Bolumler VALUES('Radyasyon Onkolojisi');
INSERT INTO  dbo.Bolumler VALUES('Radyoloji');
INSERT INTO  dbo.Bolumler VALUES('Psikiyatri');
INSERT INTO  dbo.Bolumler VALUES('Týbbý Farmakoloji');
INSERT INTO  dbo.Bolumler VALUES('Týbbý Genetik');
INSERT INTO  dbo.Bolumler VALUES('Anestezi ve Reanimasyon');
INSERT INTO  dbo.Bolumler VALUES('Beyin ve Sinir Cerrahisi');
INSERT INTO  dbo.Bolumler VALUES('Çocuk Cerrahisi');
INSERT INTO  dbo.Bolumler VALUES('Genel Cerrahi');
INSERT INTO  dbo.Bolumler VALUES('Kalp ve Damar Cerrahisi');
INSERT INTO  dbo.Bolumler VALUES('Göðüs Cerrahisi');
INSERT INTO  dbo.Bolumler VALUES('Göz Hastalýklarý');
INSERT INTO  dbo.Bolumler VALUES('Kadýn Hastalýklarý ve Doðum');
INSERT INTO  dbo.Bolumler VALUES('Kulak Burun Boðaz');
INSERT INTO  dbo.Bolumler VALUES('Ortopedi ve Travmatoloji');
INSERT INTO  dbo.Bolumler VALUES('Týbbi Patoloji');
INSERT INTO  dbo.Bolumler VALUES('Üroloji');
INSERT INTO  dbo.Bolumler VALUES('Plastik Rekonstrüktif ve Estetik Cerrahi');

INSERT INTO  dbo.DoctorStatu VALUES('Pratisyen Doktor');
INSERT INTO  dbo.DoctorStatu VALUES('Uzman Doktor');
INSERT INTO  dbo.DoctorStatu VALUES('Operatör Doktor');
INSERT INTO  dbo.DoctorStatu VALUES('Yardýmcý doçent');
INSERT INTO  dbo.DoctorStatu VALUES('Doçent');
INSERT INTO  dbo.DoctorStatu VALUES('Profesör');
INSERT INTO  dbo.DoctorStatu VALUES('Ordinaryüs');
INSERT INTO  dbo.Kangrup VALUES('A-');
INSERT INTO  dbo.Kangrup VALUES('B-');
INSERT INTO  dbo.Kangrup VALUES('A+');
INSERT INTO  dbo.Kangrup VALUES('B+');
INSERT INTO  dbo.Kangrup VALUES('AB+');
INSERT INTO  dbo.Kangrup VALUES('AB-');
INSERT INTO  dbo.Kangrup VALUES('0-');
INSERT INTO  dbo.Kangrup VALUES('0+');
insert into Statu values ('Vezne')

create table  Randevu
(
randevuID int identity(1,1) primary key,
RandevuDurumu nvarchar(20),
);


INSERT INTO Randevu VALUES('onaylandý')
INSERT INTO Randevu VALUES('Ýptal Edildi')


	

Select * from Users where TcKimlik='1'





alter table Doctor Alter Column Password nvarchar(50) not null





alter table Users add Picture image 



alter table Users drop Column Picture image  null


Select * from Users  where TcKimlik like '1%'
Select * from Users where StatuID='2'


select email from Users where TcKimlik=1
ALTER TABLE Users
DROP COLUMN email