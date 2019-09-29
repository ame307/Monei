CREATE OR REPLACE PROCEDURE 
	Insert_Account (
		p_AccountName IN monei_account.Accountname%TYPE,
		p_Username IN monei_user.Username%TYPE,
		p_Ammount IN monei_account.Ammount%TYPE,
		p_Currency IN monei_account.Currency%TYPE
	)
AS
    v_UserId monei_user.UserId%TYPE;
	v_AccountId monei_account.AccountId%TYPE;
BEGIN
    SELECT COUNT(*) INTO v_AccountId 
	FROM monei_account;
	
    v_AccountId := v_AccountId + 1;
	
	SELECT userId 
	INTO v_UserId 
	FROM monei_user AS mu 
	WHERE userId = p_Username;
	
	INSERT INTO monei_account (AccountID, UserId, AccountName, Amount, Currency)
	VALUES (v_AccountId, p_AccountName, p_Username, p_Ammount, p_Currency);
END;