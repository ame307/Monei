CREATE TABLE Monei_User (
  UserId INT,
  Username VARCHAR2(35) NOT NULL,
  Forename VARCHAR2(35) NOT NULL,
  Lastname VARCHAR2(35) NOT NULL,
  Password VARCHAR2(250) NOT NULL,
  SecurityQuestion INT NOT NULL,
  SecurityAnswer VARCHAR2(100) NOT NULL,
  
  CONSTRAINT PK_Monei_User 
  PRIMARY KEY(UserId),
  
  CONSTRAINT UQ_Monei_User_Username 
  UNIQUE(Username)
  );