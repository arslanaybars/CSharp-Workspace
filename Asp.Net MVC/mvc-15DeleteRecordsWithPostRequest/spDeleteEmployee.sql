use Sample
go

Create Procedure spDeleteEmployee
@Id int
as
Begin
	Delete from tblEmployeeBS
	where Id = @Id
End