CREATE TABLE Monei_Log (
  LogId INT,
  UserId INT DEFAULT NULL,
  Action VARCHAR(500) NOT NULL,
  ActionDate DATE DEFAULT SYSDATE,
  
  CONSTRAINT PK_Monei_Log
  PRIMARY KEY(LogId),
  
  CONSTRAINT FK_Monei_Log_UserId 
  FOREIGN KEY (UserId) 
  REFERENCES Monei_User(UserId)
  );