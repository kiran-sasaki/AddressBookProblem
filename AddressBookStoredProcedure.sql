create Procedure spGetPerson
As begin
try
select * from AddressBook
End try
Begin Catch
SELECT
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH


Exec spGetPerson

Create Procedure spUpdatePerson(@ID bigint,@Address varchar(max),@Phonenumber bigint)
As begin
try
Update AddressBook set Phonenumber=@Phonenumber,Address=@Address where ID=@ID
End try
Begin Catch
SELECT
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH

Exec spUpdatePerson


Create Procedure spGetPersonDate(@DateAdded varchar(max))
As begin
try
select * from AddressBook where DateAdded=@DateAdded
End try
Begin Catch
SELECT
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH

Exec spGetPersonDate

Create Procedure spGetPersonCity(@City varchar(max))
As begin
try
select * from AddressBook where City=@City
End try
Begin Catch
SELECT
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH

Exec spGetPersonCity

create Procedure spAddPerson(@ID Bigint,@FirstName varchar(max),@LastName varchar(max),@Address varchar(max),@PhoneNumber bigint,@EmailAddress varchar(max),@City varchar(max),@State varchar(max),@Zipcode bigint,@DateAdded varchar(max))
As begin
try
insert into AddressBook values(@FirstName,@LastName,@Address,@PhoneNumber,@EmailAddress,@City,@State,@Zipcode,@DateAdded)
End try
Begin Catch
SELECT
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH


Exec spGetPerson