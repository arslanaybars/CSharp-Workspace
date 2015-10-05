use FilmReplikleri
go

select * from FilmReplikleri

select max(ID) as ReplikSayisi from FilmReplikleri

select count(ID) as ReplikSayisi from FilmReplikleri

select ID from FilmReplikleri

select Replik From FilmReplikleri

select ID ,Replik, Sahibi From FilmReplikleri where ID = 7

SELECT TOP 1 ID ,Replik, Sahibi, Fav FROM FilmReplikleri
ORDER BY NEWID()

SELECT TOP 1 ID ,Replik, Sahibi FROM FilmReplikleri where fav = 1
ORDER BY NEWID()

select * from FilmReplikleri where fav = 1

Update FilmReplikleri set fav = 1 where ID=6

select fav from FilmReplikleri where ID = 5