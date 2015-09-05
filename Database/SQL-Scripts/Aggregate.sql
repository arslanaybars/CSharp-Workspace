--Aggregate Fonksiyonlarý

--count -> Ýþlem sayýsýný verir.
--sum   -> Belirtilen kolondaki degerlerin toplamýný verir.
--avg   -> Belirtilen kolondaki degerlerin ortalamasýný verir.
--max   -> Belirtilen kolondaki degerlerin en yüksek deðeri verir.
--min   -> Belirtilen kolondaki degerlerin en düþük deðeri verir.

--Geriye tek bir deðer döndürürler.

use VideoMarket
go

select count(*) as Sayisi from Musteriler
select count(MusteriNo) as Sayisi from Musteriler

--Video Marketimizde suanda bulunan yada satýlan filmlerin sayýsý
select count(*) as FilmSayisi from Filmler where Varmi = 1

--Video Marketimizde suanda bulunan dram türündeki filmlerin sayýsýný veren sorgu
select count(*) as DramFilmiSayisi from Filmler where FilmTurNo = 3

--Bugüne kadar satýlan toplam film sayisini gösteren sorguyu yazýnýz
select sum(Adet) as ToplamSatilan from FilmSatis 

--Bugüne kadar yapýlan toplam hasilatý gösteren sorguyu yazýnýz
select sum(Adet*BirimFiyat) as ToplamHasilat from FilmSatis

--Tek seferde yapýla en büyük alýþveriþ tutarýný gösteren sorgu.
select max(Adet*BirimFiyat) as MaxAlisverisTutari from FilmSatis

--Bugüne kadar yapýlan satýþlarýn kullanýlan ortalama film satýþ fiyatýný gösteren sorguyu yazýnýz.
select avg(BirimFiyat) as Ortalama from FilmSatis

select * from FilmSatis

--Bugüne kadar 2 nolu müþterinin yaptýðý toplam alýþveriþ tutarýný gösteren sorguyu yazýnýz.
select sum(Adet*BirimFiyat) as IkiNoluMusteriToplam from FilmSatis where MusteriNo = 2

--Musterilerin yaptýklarý toplam alýsveris tutarlarýný musteri numaralarýyla birlikte listeleyen sorgu.
select sum(Adet*BirimFiyat)  as MusteriToplamAlisveris , MusteriNo from FilmSatis group by MusteriNo

--Filmlere göre toplam satis adetini film numaralarýyla birlikte gösteren sorguyu yazýnýz.
select FilmNo, sum(Adet) as ToplamAdet from FilmSatis group by FilmNo

select * from FilmSatis

insert into FilmSatis (FilmNo, MusteriNo, Adet, BirimFiyat) values(6,2,3,17)

--Her bir müþteri kaç defa alýþveriþe gelmiþtir.
Select MusteriNo, count(MusteriNo) as KacDefaGeldi from FilmSatis group by MusteriNo

--2 defadan fazla alisverise gelen musterilerin toplam alýsveris sayýsý musteri numaralarýyla listeleyen sorgu
Select MusteriNo, count(MusteriNo) as KacDefaGeldi from FilmSatis group by MusteriNo having count(MusteriNo) > 2 

--2 defadan fazla alisverise gelen musterilerin toplam alýsveris sayýsýný ve toplam alýsveris tutarlarýný musteri numaralarýyla listeleyen sorgu
Select MusteriNo, count(MusteriNo) as KacDefaGeldi, sum(Adet*BirimFiyat) as ToplamAlisveris from FilmSatis group by MusteriNo having count(MusteriNo) > 2 