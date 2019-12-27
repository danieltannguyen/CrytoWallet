CREATE PROC UserAdd
@ID int,
@Username varchar(50),
@Password varchar(50),
@Email varchar(50)
AS
	INSERT INTO Account(ID, Username,Password,Email)
	VALUES (@ID,@Username,@Password,@Email)