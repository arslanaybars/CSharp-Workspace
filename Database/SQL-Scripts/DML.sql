DML (Data Manipulation Language) Komutlarý

--Select, Ýstenilen kayýtlarýn tablodan seçlmesini, listelenmesini saðlar.
--Insert, Tablolara yeni kayýt (satýr-row) ilave edilmesini saðlar.
--Update, Tablolardaki kayýtlar üzerinde deðiþiklik, güncelleme yapýlmasýný saðlar.
--Delete, Tablodan istenilen kayýtlarý siler.

--VideoMarket Veritananýn oluþturulmasý
use master
go
create database VideoMarket
go
use VideoMarket
go
create table FilmTurleri
(
	FilmTurNo int primary key identity(1,1) not null,
	TurAd varchar(20) not null,
	Aciklama varchar(150) 
)
go
create table Filmler
(
	FilmNo int primary key identity(1,1),
	FilmAd varchar(50) not null,
	FilmTurNo int not null,
	Yonetmen varchar(50) not null,
	Oyuncular varchar(max),
	Ozet varchar(max),
	Varmi bit default 1 not null,
)
go
create table Musteriler
(
	MusteriNo int primary key identity(1,1),
	MusteriAd varchar(20) not null,
	MusteriSoyad varchar(20) not null,
	Telefon varchar(20),
	Adres varchar(150)
)
go
--Kayýt Ekleme (Insert)

--Insert into TabloAdi(Kolon1, Kolon2, ....) values (Deger1, Deger2, ....)

Insert into FilmTurleri(TurAd, Aciklama) values('Komedi', 'Çok Komik')
Insert into FilmTurleri(TurAd, Aciklama) values('Romantik Komedi', 'Hem romantik hem komik')
Insert into FilmTurleri(TurAd) values('Dram')
Insert into FilmTurleri(TurAd) values('Savaþ')
Insert into FilmTurleri values('Action','Aksiyon')


--Secim, Listeleme Ýþlemleri (select)

--Select Kolon1, Kolon2, .... from TabloAdi Where Þartlar

Select TurAd, Aciklama from FilmTurleri
Select TurAd from FilmTurleri

Select * from FilmTurleri

Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Gladyator',4,'Ridley Scot','Russel Crove')
Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Recep Ývedik',1,'Togan Gökbakar','Þahan Gökbakar')

select * from Filmler

Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Kýþ Uykusu',3,'Nuri Bilge Ceylan','Haluk Bilginer, Demet Akbað')
Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Hükümet Kadýn',1,'Sermiyan Midyat','Sermiyan Midyat, Demet Akbað')

Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Esaretin Bedeli',3,'Frank Tarabond','Tim Robins, Morgan Freeman')
Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Forrest Gump',3,'Robert Zemeckis','Tom Hanks')
Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Yüzüklerin Efendisi',6,'Peter Jackson','Orlando Bloom')
Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Romantik Komedi',2,'ketche','Sinem Kobal')

Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Nothing Hill',2,'Roger Michell','Julia Roberts, Hugh Grant')

Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('6. His',7,'Night Shaymalan','Bruce Willis')

Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Fight Club',5,'David Fincher','Brad Pitt, Edward Norton')
Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular) values ('Truva',4,'Wolfgn Pettersen','Brad Bitt, Orlando Bloom')


Insert into FilmTurleri (TurAd) values ('Bilim Kurgu')
Insert into FilmTurleri (TurAd) values ('Korku')
Insert into FilmTurleri (TurAd) values ('Animation')
Insert into FilmTurleri (TurAd) values ('Aþk')

select * from FilmTurleri 

select * from Filmler

insert into Musteriler(MusteriAd, MusteriSoyad,Telefon,Adres) values ('Ali', 'Ucar', '5348526952', 'Sisli-Ýstanbul')
insert into Musteriler(MusteriAd, MusteriSoyad,Telefon,Adres) values ('Vedat', 'Kaya', '5678526952', 'Kadýöy-Ýstanbul')
insert into Musteriler(MusteriAd, MusteriSoyad,Telefon,Adres) values ('Oya', 'Sever', '5544526952', 'Bakýrköy-Ýstanbul')
insert into Musteriler(MusteriAd, MusteriSoyad,Telefon,Adres) values ('Ayþe', 'Koþar', '5544524353', 'Ümraniye-Ýstanbul')

select * from Musteriler

select * from Filmler -- Tüm filmleri listeler.

--5 numaralý Filmin Adý, Yönetmeni ve Oyuncularýný Listeleyen T-Sql sorgusunu yazýnýz

Select FilmAd, Yonetmen, Oyuncular from Filmler where FilmNo = 5

--Komedi - 1 türünden filmlerin listesi.
Select * from Filmler where FilmTurNo = 1

--Dram - 3 Türünden ve VideoMarketimizde bulunan filmlerin listesi
Select * from Filmler where FilmTurNo = 3 and Varmi = 1

--Kayýtlar üzerinde degisiklik (Update)

--Update TabloAdi Set KolonAdi = YeniDeger, KolonAdý = YeniDeger, ... Where Sart

--Gladyator filmini stokta kalmadý olarak iþaretleyen sorguyu yazýnýz
Update Filmler Set Varmi = 0 Where FilmAd = 'Gladyator'

select * from Filmler

--Dram - 3 Filmlerinin özet bilgisini, hüzün, gözyaþý ve mendil olarak deðiþtiren sorguyu yazýnýz
Update Filmler Set Ozet = 'hüzün, gözyaþý ve mendil' where FilmTurNo = 3

--Kayýt Silme (Delete)

--Delete from TabloAdi Where Sart
--NOT : Update ve Delete iþlemlerinde where þart mutlaka belirtilmelidir, aksi taktide tüm tablodaki kayýtlar yapýlan iþlemden etkilenecektir

--4 numaralý müþteriyi silen T-sql kodunu yazýnýz
Delete from Musteriler Where MusteriNo = 4

select * from Musteriler

insert into Musteriler(MusteriAd, MusteriSoyad,Telefon,Adres) values ('Ayþe', 'Koþar', '5544524353', 'Ümraniye-Ýstanbul')

create table FilmSatis
(
	SatisNo int primary key identity(1,1),
	Tarih datetime default getdate() not null,
	FilmNo int not null,
	MusteriNo int not null,
	Adet int not null default 1,
	BirimFiyat money not null default 0
)
go

Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (3,2,1,20)
Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (2,1,2,18)
Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (6,5,5,15)
Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (11,1,3,16)
Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (10,3,1,20)
Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (2,5,3,16)

select * from FilmSatis

Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (4,2,2,17)
Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (8,3,6,14)
Insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values (11,5,3,15)

--Birim Fiyatý 15 TL ve altýnda olan satýþlarýn listesi.
select * from FilmSatis where BirimFiyat <= 15

--Birim Fiyatý 16-20 TL. arasýnda olan satýþlarýn listesi.
select * from FilmSatis where BirimFiyat >= 16 and BirimFiyat <= 20

--2 veya 3 numaralý müþterilere yapýlan satýþlarýn listesi,
select * from FilmSatis where MusteriNo = 2 or MusteriNo = 3

--Yapýlan satýþlarý satýþ tutarlarýyla bilikte listeleyen T-sql sorgusunu yazýnýz
select FilmNo, MusteriNo, Adet, BirimFiyat , Adet * BirimFiyat as Tutar from FilmSatis