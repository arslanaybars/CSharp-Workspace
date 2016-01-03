select * from tblEmployeeBS

Create procedure spAddEmployee
@Name nvarchar(50),
@Gender nvarchar(10),
@City varchar(50),
@DateOfBirth DateTime
as
Begin
	Insert into	tblEmployeeBS (Name, Gender, City, DateOfBirth)
	values (@Name, @Gender, @City, @DateOfBirth)
End