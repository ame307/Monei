CREATE TABLE Monei_Transaction (
  TransactionId INT,
  AccountId INT NOT NULL,
  UserId INT NOT NULL,
  TransactionName VARCHAR(50) NOT NULL,
  Usernote VARCHAR(500),
  TransactionDate DATE DEFAULT SYSDATE,
  Crediting BINARY_DOUBLE NOT NULL,
  
  CONSTRAINT PK_Monei_Transaction
  PRIMARY KEY(TransactionId),
  
  CONSTRAINT FK_Monei_Transaction_UserId 
  FOREIGN KEY (UserId) 
  REFERENCES Monei_User(UserId),
  
  CONSTRAINT FK_Monei_Transaction_AccountId 
  FOREIGN KEY (AccountId) 
  REFERENCES Monei_Account(AccountId)
  );