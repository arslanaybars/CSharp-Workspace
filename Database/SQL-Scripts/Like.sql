--DML Komutlarý Like Kullanýmý

--KolonAdi Like 'A%' -> A ile baþlayýp herhangi bir karakter yada karakter grubuyla biten.
--KolonAdi Like '%A' -> Her türlü karakter yada karakter grubuyla baþlayýp A ile biten
--KolonAdi Like '%A%' -> Ýçinde A harfi geçen tüm ifadeler

use VideoMarket
go

Select * from Musteriler

--Ýsmi A ile baþlayan müþterilerin listesi
Select * from Musteriler Where MusteriAd like 'A%'
Select * from Musteriler Where MusteriAd like '[A]%'

--Soyadý AR ile biten müþterilerin listesi
Select * from Musteriler where MusteriSoyad like  '%AR'

--Köyde oturan müþterilerin lisetesi
Select * from Musteriler where Adres like '%köy%'

--Brad Pitt'in oynadýðý fimlerin Adý, Yönetmeni ve Oyuncu bilgilerini listeleyen sorgu.
Select FilmAd, Yonetmen, Oyuncular from Filmler where Oyuncular like '%Brad Pitt%'

--Ismi A ile P harfi arasýndaki harflerle baþlayan müþterilerin listesi
Select * from Musteriler Where MusteriAd like '[A-P]%'

--Ismi A harfi ile baþlamayan müþterilerin listesi
Select * from Musteriler Where MusteriAd like '[^A]%'

--Ýsmi A ile Baþlayýp 3 karakterden oluþan müþterilerin listesi
Select * from Musteriler Where MusteriAd like 'A__'

