sp_helptext spAddEmployee

Create procedure spSaveEmployee
@Id int,
@Name nvarchar(50),
@Gender nvarchar(10),
@City varchar(50),
@DateOfBirth DateTime
as
Begin
	Update tblEmployeeBS Set Name = @Name, Gender = @Gender, City = @City, DateOfBirth = @DateOfBirth
	where Id = @Id
End