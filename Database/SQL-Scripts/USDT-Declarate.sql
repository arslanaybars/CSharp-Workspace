--Kullanýcý Tanýmlý Veri TÜrleri (User Defined Data Types)

--Sql'de mevcut veri türleri kullanýlarak veritabaný üzerine yeni veri türleri eklenebilir (istenilirse model sistem veritabanýna kaydedilerek tüm tablolarda kullanýlmasý saðlanabilir).

--Kullanýcý tanýmlý veri türleri sp_addtype sistem stored procedure'ü ile oluþturulur.

use VideoMarket
go
Exec sp_addtype adres, 'varchar(150)', null
Exec sp_addtype mass, 'money'
Exec sp_addtype maas, 'money'

Exec sp_droptype mass

--Local Degiskenler Tanýmlama
--Declare @degiskenadi verituru

Declare @sayi int
set @sayi = 5
select @sayi as Sayi


Declare @ad varchar(20) = 'Mehmet'
select @ad as isim


Declare @sayi1 int = 5
Declare @sayi2 int = 3
Declare @top int = @sayi1 + @sayi2
select @top as Toplam

Declare @sayi3 int = 5
Declare @sayi4 int = 10
if (@sayi3 > @sayi4)
begin
	select @sayi3 / @sayi4 as Sonuc
end
if (@sayi4 > @sayi3)
begin
	select @sayi4 / @sayi3 as Sonuc
end
else
begin
	select 1 as sonuc
end

select * from FilmSatis

Declare @EnYuksekFiyat money
select @EnYuksekFiyat= max(BirimFiyat) from FilmSatis
select @EnYuksekFiyat as MaxBirimFiyat 