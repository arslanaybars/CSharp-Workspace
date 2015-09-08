--Ýliskilendirme (JOIN) iþlemleri

--Tablo1 innet join Tablo2 on Tablo1.OrtakKolon = Tablo2.OrtakKolon

use VideoMarket
go
select * from Filmler

select FilmAd, TurAd, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo

select Filmler.FilmAd, FilmTurleri.TurAd, Filmler.Yonetmen, Filmler.Oyuncular from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo

select FilmAd, Filmler.FilmTurNo, TurAd, Yonetmen, Oyuncular from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo

select * from FilmSatis

--Günlük Satýþ Bilgilerini Film Ýsimleriyle birikte gösteren sorgu
Select Filmler.FilmAd, FilmSatis.Adet, FilmSatis.BirimFiyat, FilmSatis.Adet*FilmSatis.BirimFiyat, FilmSatis.Tarih as Tutar From FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo

--Romantik komedi filmiyle ilgili satýþ bilgilerini gösteren sorguyu yazýnýz
Select Filmler.FilmAd, FilmSatis.Adet, FilmSatis.BirimFiyat, FilmSatis.Adet*FilmSatis.BirimFiyat as Tutar, FilmSatis.Tarih From FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo where FilmAd = 'Romantik Komedi'

select * from FilmTurleri
select * from Filmler

--Video Marketimizde bulunan komedi türündeki filmleri listeyen sorgu
Select Filmler.FilmAd, Filmler.Yonetmen, Filmler.Oyuncular, FilmTurleri.TurAd From Filmler inner join FilmTurleri on FilmTurleri.FilmTurNo = Filmler.FilmTurNo where FilmTurleri.TurAd = 'Komedi'

--FilmSatis bilgilerini müþteri adý ve soyadý ile birlikte gösteren sorguyu yazýnýz
Select FilmSatis.Tarih, Musteriler.MusteriAd + ' ' + Musteriler.MusteriSoyad as Musteri, FilmSatis.Adet, FilmSatis.BirimFiyat, FilmSatis.BirimFiyat * FilmSatis.Adet as Tutar from FilmSatis inner join Musteriler on FilmSatis.MusteriNo = Musteriler.MusteriNo

--Müþterilere göre toplam alýþveriþ tutarlarýný müþteri isim ve soyisim bilgileriyle gösteren sorguyu yazýnýz.
Select Musteriler.MusteriAd + ' ' + Musteriler.MusteriSoyad as Musteri, sum(FilmSatis.Adet * FilmSatis.BirimFiyat) as Tutar From Musteriler inner join FilmSatis on Musteriler.MusteriNo = FilmSatis.MusteriNo group by Musteriler.MusteriAd + ' ' + Musteriler.MusteriSoyad

--Satis bilgilerini Film Adý ve Müþteri bilgileriyle birlikte detaylý olarak listeleyen soruguyu yazýnýz.
Select Musteriler.MusteriAd + ' ' + Musteriler.MusteriSoyad as Musteri, Filmler.FilmAd, FilmSatis.Adet, FilmSatis.BirimFiyat From FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo inner join Musteriler on Musteriler.MusteriNo = FilmSatis.MusteriNo

--Film Turlerine göre toplam satýþ adetlerini gösteren sorguyu yazýnýz
Select FilmTurleri.TurAd, sum(FilmSatis.Adet) as TotalAdet from FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo inner join FilmTurleri on FilmTurleri.FilmTurNo = Filmler.FilmTurNo group by FilmTurleri.TurAd

--Bililm Kurgu ve Dram Turlerinden yapýlan toplam satýþ adetlerini gösteren sorguyu yazýnýz
Select FilmTurleri.TurAd, sum(FilmSatis.Adet) as TotalAdet from FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo inner join FilmTurleri on FilmTurleri.FilmTurNo = Filmler.FilmTurNo group by FilmTurleri.TurAd having FilmTurleri.TurAd = 'Bilim Kurgu' or FilmTurleri.TurAd = 'Dram'

--Where daha hýzlý calýsýr direk odaklý ama having önce hepsini gruplar sonra isteni gösrerir
Select FilmTurleri.TurAd, sum(FilmSatis.Adet) as TotalAdet from FilmSatis inner join Filmler on FilmSatis.FilmNo = Filmler.FilmNo inner join FilmTurleri on FilmTurleri.FilmTurNo = Filmler.FilmTurNo where FilmTurleri.TurAd = 'Bilim Kurgu' or FilmTurleri.TurAd = 'Dram' group by FilmTurleri.TurAd