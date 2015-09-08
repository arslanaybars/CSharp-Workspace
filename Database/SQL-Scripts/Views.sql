--View Dosyalarý

--Gerçek dosyalar degildir, Veritabanýndaki tablolar(base tables) kullanýlýr veriler bu tablolardan çekilir. Bir anlamda select (sorgu) dosyalarýdýr.

use VideoMarket
go

select * from vw_filmler

select FilmAd, TurAd from vw_Filmler

Select * from vw_DetayliSatis

create view vw_MusteriRehber
as
select MusteriAd + ' ' + MusteriSoyad as Musteri, Telefon from Musteriler
go

select * from vw_MusteriRehber

use VideoMarket
go

alter view vw_KdvliSatis
with encryption
as
select MusteriAd + ' ' + MusteriSoyad as Musteri, FilmAd, Adet, BirimFiyat, Adet*BirimFiyat as Tutar, Adet*BirimFiyat*18/100 as KDV, (Adet*BirimFiyat*18/100) + (Adet*BirimFiyat) as KDVliTutar from FilmSatis fs inner join Filmler f on fs.FilmNo = f.FilmNo inner join Musteriler m on m.MusteriNo = fs.MusteriNo
go

select * from vw_KdvliSatis

exec sp_depends vw_KdvliSatis --View'dan etkilenen tablolar ve kolonlarýný listeler

--with encryption olmadan alter ile kayýt edildiginde kaynak kodlar yeniden gorulebilecektir
exec sp_helptext 'vw_KdvliSatis' -- Dosyanýn kaynak kodlarýný gösterir

select * from vw_KdvliSatis

use VideoMarket
go

create view vw_DetayliFilmler
(FilmAdi, FilmTuru, Yapýmcý, Artisler, FilminOzeti)
as
select FilmAd, TurAd, Yonetmen, Oyuncular, Ozet from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo
go

select * from vw_DetayliFilmler

--View Dosyalarýnda deðiþiklik-silme-kayýt ekleme iþlemleri

select * from vw_DetayliSatis

insert into vw_DetayliSatis(FilmAd, Musteri, Adet, BirimFiyat) values ('6.His','Oya Koþar',2,18)

--Insert islemi birden fazla base tabloyu etkilerse hata verilir ve kayýt gerçekleþmez

select * from vw_Filmler

insert into vw_Filmler(FilmAd, TurAd) values ('Arog', 1)

insert into vw_Filmler(FilmAd) values ('Arog')

insert into vw_Filmler(TurAd) values ('Az acýlý')

select * from FilmTurleri