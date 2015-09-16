use VideoMarket
go

select * from Musteriler

select * from Musteriler where silindi = 0

select * from musteriler where Telefon = Telefon and silindi = 0

Insert into Musteriler(MusteriAd, MusteriSoyad, Telefon, Adres) values ('Aybars', 'Arslan', '532337520', 'Finike-Antalya')

Update Musteriler Set MusteriAd, MusteriSoyad, Telefon, Adres Where MusteriNo = MusteriNo

select * from FilmTurleri

select FilmTurNo from FilmTurleri where turAd = 'Savaþ'

select * from filmler
select * from FilmTurleri

Select FilmAd from Filmler

Select Filmler.FilmNo, Filmler.FilmAd, FilmTurleri.TurAd, Filmler.FilmTurNo, Filmler.Yonetmen, Filmler.Oyuncular, Filmler.Ozet, Filmler.Miktar from Filmler inner join FilmTurleri on filmler.FilmTurNo = FilmTurleri.FilmTurNo

select Filmler.FilmNo, Filmler.FilmAd, FilmTurleri.TurAd, Filmler.Yonetmen, Filmler.Oyuncular, Filmler.Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo

Insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular, Ozet, Miktar) values (FilmAd, FilmTurNo, Yonetmen, Oyuncular, Ozet, Miktar)

select * from FilmTurleri

Select TurAd from FilmTurleri where FilmTurNo = 6 and silindi = 0

Update Filmler set Ozet='Ödülünü hakeden film', Miktar=4 where FilmNo=3

Delete from Musteriler Where MusteriNo = 100