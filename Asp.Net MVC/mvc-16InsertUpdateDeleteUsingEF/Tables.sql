Create Table tblDepartment
(
	Id int primary key identity,
	Name nvarchar(50)
)

Insert into tblDepartment values('IT')
Insert into tblDepartment values('HR')
Insert into tblDepartment values('Payroll')

Create Table tblEmployee
(
	EmployeeId int primary key identity(1,1),
	Name nvarchar(50),
	Gender nvarchar(50),
	City nvarchar(50),
	DepartmentId int
)

Alter Table tblEmployee
add foreign key (DepartmentId)
references tblDepartment(Id)

Insert into tblEmployee values('Mark','Male','London',1)
Insert into tblEmployee values('John','Male','Chennai',3)
Insert into tblEmployee values('Marry','Female','New York',3)
Insert into tblEmployee values('Mike','Male','Sydney',2)
Insert into tblEmployee values('Scott','Male','London',1)
Insert into tblEmployee values('Pam','Female','Falls Cruch',2)
Insert into tblEmployee values('Todd','Male','Sydney',1)
Insert into tblEmployee values('Sara','Female','New Delhi',2)
Insert into tblEmployee values('Ben','Male','London',1)

select * from tblDepartment

select * from tblEmployee