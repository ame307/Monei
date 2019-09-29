CREATE TABLE Monei_Acces (
  AccesId INT,
  UserId INT NOT NULL,
  AccountId INT NOT NULL,
  AccesLevel INT DEFAULT 0,
  
  CONSTRAINT PK_Monei_Acces
  PRIMARY KEY(AccesId),
  
  CONSTRAINT FK_Monei_Acces_UserId
  FOREIGN KEY (UserId) 
  REFERENCES Monei_User(UserId),
  
  CONSTRAINT FK_Monei_Acces_AccountId 
  FOREIGN KEY (AccountId) 
  REFERENCES Monei_Account(AccountId)
  );