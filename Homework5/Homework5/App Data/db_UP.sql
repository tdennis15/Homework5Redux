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
	('Steve','A','Lewis','07/11/1989','47 Dearborne Ave.','Independence','Oregon','97351','Polk','11/03/2017'),
	('Seymore','H','Butts','05/22/1992','9045 Sierra Dr.','Monmouth','Oregon','97361','Polk','11/05/2017'),
	('Ben','A','Dover','03/08/1996','21 Jump St.','Scio','Oregon','97374','Linn','10/25/2017'),
	('Rebecca','L','Smith','09/23/1982','8671 Bonneville RD','Aurora','Oregon','97002','Marion','09/15/2017');

GO