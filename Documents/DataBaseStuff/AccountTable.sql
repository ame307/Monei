CREATE TABLE Monei_Account (
  AccountId INT,
  AccountName VARCHAR2(70) NOT NULL,
  UserId INT NOT NULL,
  Amount BINARY_DOUBLE DEFAULT 0,
  Currency VARCHAR2(5) DEFAULT NULL,
  
  CONSTRAINT PK_Monei_Account 
  PRIMARY KEY(AccountId),
  
  CONSTRAINT FK_Monei_Account_UserId 
  FOREIGN KEY (UserId) 
  REFERENCES Monei_User(UserId)
  );