use PsCafe
go

select * from GenelAyarlar

select MasaSayisi from GenelAyarlar

Update GenelAyarlar Set MasaSayisi = 8 Where GenelID = 1

select * from Ucretler

select Ucret, Yuvarlama, AcKapa from Ucretler

use PsCafe
go

select * from Log inner join Ucretler on Log.UcretID = Ucretler.UcretID

select * from Log

Insert into Log (Baslangic, Bitis, GecenSure, LogDurumu, ToplamUcret, Adisyon, MasaID, UcretID) values(CONVERT(Time,GETDATE(),108) as a, CONVERT(Time,'02:57:12',108) as b, CONVERT(VARCHAR(8),(b - a), 108), 'DENEME', 10, 11, 1, 4)

select getdate()

SELECT CONVERT(VARCHAR(8),GETDATE(),108) AS HourMinuteSecond

select CONVERT(Time,'02:57:12',108)

select CONVERT(VARCHAR(8),(CONVERT(Time,GETDATE(),108) - CONVERT(Time,GetDate(),108)), 108)


Select (DATEDIFF (hour, CONVERT(Time,GETDATE(),108), CONVERT(Time,'04:57:12',108 )) + ':' + DATEDIFF (minute, CONVERT(Time,GETDATE(),108), CONVERT(Time,'04:57:12',108 )) + ':' + DATEDIFF (second, CONVERT(Time,GETDATE(),108), CONVERT(Time,'04:57:12',108 ))) as saniye 

Insert into Log (MasaID) values(@MasaID)

select * from log

select * from GenelAyarlar

select YoneticiSifre from GenelAyarlar

Update GenelAyarlar set YoneticiSifre = '123456' where GenelID = 1

select * from Uyelik

Select * from Uyelik where UyeAdi = 'Ozgur' and UyeSoyadi = 'Aslan' and Telefon = '05348256971' and silindi = 0