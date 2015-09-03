--T-Sql(Transact SQL) Komutlarý

--DDL (Data Definition Language) Komutlarý

--Create, Alter ve Drop
--Create nesnetürü nesneadý -> ismi belirtilen neseneyi olusturur.
--create database yeni -> yeni isminde database olusturur.
-- * yeni bir veritabaný tanýmlamak için master system database'i aktif olmalýdýr.
use master
use okul
--alter table tabloadi -> ismi belirtilen tablo üzerinde deðiþiklik yapýlacaðý anlamýna gelir.

--drop database veritabaniadi -> ismi belirtilen database'yi siler

use master
go
create database YeniData on Primary
(Name = YeniData, FileName = 'c:\Server\d\YeniData.mdf',
Size = 5, MaxSize = 50, FileGrowth = 20%),
FileGroup Secondary
(Name = YeniData2, FileName = 'c:\server\e\YeniData2.ndf',
Size = 5, FileGrowth = 2)
Log on (Name = YeniData_log, FileName = 'c:\Server\d\YeniDataLog.ldf',
Size = 1, FileGrowth = 1)
Collate Turkish_100_CI_AS
go
--Veritabaný üzerinde deðiþiklik
alter database YeniData
add filegroup Third
go

alter database YeniData
add file (Name = YeniData3, FileName = 'c:\server\f\YeniData3.ndf',
Size = 5, FileGrowth = 2) to filegroup Third
go

--Tablo Oluþturma
use YeniData
go
create table Tablo1
(
	ID int primary key identity(1,1) not null,
	Ad varchar(20) not null,
	Soyad varchar(20) not null,
	DogumTarihi datetime default getdate() not null
)
go