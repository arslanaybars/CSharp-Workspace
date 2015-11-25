--TRIGERS
--Triggerlar, tablo üzerine kaydedilirler. Doðrudan çalýþtýrýlamazlar.
--Insert, Update, Delete iþlmemleri sýrasýnda otomatik olarak tetiklenir.
--Tabloya kayýt eklediðimizde inserted tablosu, kayýt silindiðinde deleted tablosu oluþturulur.
--Update iþlemi sýrasýnda ise hem inerted hem de deleted tablolarý oluþturulur. Silinen orginal bilgiler deleted tablosuna yeni girilen bilgiler ise inserted tablosuna kayýt edilir.
--Trgglerlar transaction yapýsýna sahiptir, herhangi bir aþamada rollback ile tüm iþlemleri geri alabiliriz.
--For Triggers and Instead Of Trigger olmak üzere 2 cesit trigger tanýmlanabilir.
--For Triggerlarýnda, öncelikle iþlem (insert, update, yada delete) gerçekleþtirilir ve trigger sonrasýnda devreye girer.
--Instead of triggerlar ise, olay gerçekleþmeden o iþlemin yerine yapýlmasý gerekenleri tanýmlar

use VideoMarket
go
create trigger tg_KayitSilinmesin on Filmler
for delete
as
if(select count(*) from deleted ) > 1
begin
	print 'Birden fazla kayýt silemezsiniz...'
	Rollback
	return
end
go

select * from Filmler
delete from Filmler where FilmNo > 15

exec sp_helptext tg_KayitSilinmesin

alter table Filmler
disable trigger tg_KayitSilinmesin --Trigger'ý devre dýþý býrakýlýr

alter table Filmler
enable trigger tg_KayitSilinmesin --Trigger devreye girer

create trigger tg_FilmSatildi on FilmSatis
for insert
as
Declare @FilmNo int
Declare @Adet int
select @FilmNo = FilmNo, @Adet=Adet from inserted
update Filmler set Miktar = Miktar - @Adet where FilmNo = @FilmNo
go

insert into FilmSatis(FilmNo,MusteriNo,Adet,BirimFiyat) values(2,1,3,15)

--Instead of Triggers
--Constraints (kýsýtlayýcýlar) gibi çalýþýyor, yani iþlem gerçekleþmeden önce evreye girer ve onun yerine çalýþýr

create trigger tg_SilmeYerine on Musteriler
instead of delete
as
update Musteriler set silindi = '1' from Musteriler inner join deleted on deleted.MusteriNo = Musteriler.MusteriNo
go

select * from Musteriler
delete from Musteriler where MusteriNo = 12