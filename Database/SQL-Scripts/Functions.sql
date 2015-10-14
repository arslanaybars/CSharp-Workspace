--FUNCTIONS

--UDF (User Defined Functions) : Geriye tek bir deðer döndüren (scalar) yada tablo döndüren fonksiyonlar yazabiliriz.

-- Create Function FonksiyonIsmi
-- (Parametreler)
-- Returns DondurecegiVeriTuru
-- as
-- begin
-- T-Sql komutlarý
-- T-Sql komutlarý
-- Return GeriDonusDegeri
-- End

-- Fonksiyonlar sorgu cümlelerinde kullanýlabilirler.

use VideoMarket
go

create Function NullKontrol
(@Alan varchar(20))
Returns varchar(20)
as
begin
if(@Alan is null)
	begin
		set @Alan = 'Bilgi Girilmemis'

	end
Return @Alan
end

-- Fonksiyonlar cagýrýlýrken basýna dbo eklenir

select filmAd, Yonetmen, Oyuncular, dbo.NullKontrol(Ozet)
as FilmOzeti from Filmler where Varmi = 1

select * from Filmler

update Filmler set Ozet = dbo.NullKontrol(Ozet)

create Function StokKontrol
(@Varmi varchar(20))
Returns varchar(20)
as
begin
	if(@Varmi = 0)
		begin
			set @Varmi = 'Stokta Mevcut Degil'
		end
	else
		begin
			set @Varmi = 'Stokta Mevcut'
		end
Return @Varmi
end

select * from Filmler

select filmAd, Yonetmen, Oyuncular, dbo.StokKontrol(Varmi)
as Varmiymis from Filmler

select * from musteriler

create Function AdSoyadGetir
(@MusteriNo int)
Returns varchar(20)
as
begin
Return (select MusteriAd + ' ' + MusteriSoyad from Musteriler where MusteriNo = @MusteriNo)
end

select dbo.AdSoyadGetir(MusteriNo) as Musteri, Adet, BirimFiyat, Adet * BirimFiyat as Tutar from FilmSatis