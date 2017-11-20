--DMV table for users

CREATE TABLE dbo.Users
(
	ID			INT IDENTITY (1,1) NOT NULL,
	
	FirstName	NVARCHAR(64) NOT NULL,
	MiddleName	NVARCHAR(64),
	LastName	NVARCHAR(128) NOT NULL,
	DOB			DateTime NOT NULL,

	NAddress	NVARCHAR(128) NOT NULL,
	NCity		NVARCHAR(64) NOT NULL,
	NState		NVARCHAR(64) NOT NULL,
	NZipCode	Int NOT NULL,
	NCounty		NVARCHAR(64) NOT NULL,

	CurrDate	DateTime NOT NULL,

	CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED (ID ASC)
);

INSERT INTO dbo.Users (FirstName, MiddleName, LastName, DOB, NAddress, NCity, NState, NZipCode, NCounty, CurrDate) Values
	('Adam','J','Jones','01/01/2001','123 fucks street','Salaam','Oregon','97301','Marion','11/01/2017'),
	('Rebecca','L','Smith','09/23/1982','8671 Bonneville RD','Aurora','Oregon','97002','Marion','09/15/2017');

GO