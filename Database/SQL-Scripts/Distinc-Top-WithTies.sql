--Distinct, Top, with Ties ornekleri

use VideoMarket
go

select * from Filmler

select top 5 * from Filmler

--Bir defada yapýlan en yüksek alýþveriþ tutarýný ve yapan müþteri bilgilerini gösteren sorguyu yazýnýz.
select top 1 MusteriAd + ' ' + MusteriSoyad as Musteri,Adet, BirimFiyat, Adet*BirimFiyat as tutar from FilmSatis inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo order by Adet*BirimFiyat desc

--Tek seferde en çok alýsveris yapan 3 müsteri ve alýsveris bilgileri gösteren sorgu
select Top 3 with ties MusteriAd + ' ' + MusteriSoyad as Musteri, Adet*BirimFiyat as tutar from FilmSatis inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo order by Adet*BirimFiyat desc

--with ties kullanýldýgýnda, sýralama yapýlan kolonda eþitlik durumunda, kýrýlma oluncaya kadar listelemeye devam eder.

select * from Musteriler

select MusteriAd + ' ' + MusteriSoyad as Musteri,Adet, BirimFiyat, Adet*BirimFiyat as tutar from FilmSatis inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo

--Distinct, komutu tekrar eden kayýtlardan sadece birini listeler.

--Bugune kadar alýþveriþ yapan müþteriler (her müþteri sadece bir kez görüntülensin)
select Distinct (MusteriAd + ' ' + MusteriSoyad) as FarkliMusteri from FilmSatis inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo

--Bugüne kadar alýþveriþ yapan müsteri sayýsý
select Count(Distinct (MusteriAd + ' ' + MusteriSoyad)) as FarkliMusteri from FilmSatis inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo

--Video Marketimizde kaç farklý türden film oldugunu gösteren sorgu
select count(Distinct FilmTurNo) as FarklýTur from filmler where varmi = 1

