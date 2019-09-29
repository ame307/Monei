CREATE OR REPLACE PROCEDURE 
Insert_User (
	p_Username IN monei_user.Username%TYPE,
    p_Forename IN monei_user.Forename%TYPE,
    p_Lastname IN monei_user.Lastname%TYPE,
    p_Password IN monei_user.Password%TYPE,
    p_SecurityQuestion IN monei_user.SecurityQuestion%TYPE,
    p_SecurityAnswer IN monei_user.SecurityAnswer%TYPE
	)
AS
    v_Id monei_user.UserId%TYPE;
BEGIN
    SELECT COUNT(*) INTO v_Id from monei_user;
    v_Id := v_Id + 1;
	INSERT INTO monei_user (UserId, Username, Forename, Lastname, Password, SecurityQuestion, SecurityAnswer) VALUES (v_Id, p_Username, p_Forename, p_Lastname, p_Password, p_SecurityQuestion, p_SecurityAnswer);
END;